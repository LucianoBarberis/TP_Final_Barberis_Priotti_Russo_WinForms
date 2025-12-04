using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using RussoBarberisPriotti_GestorArchivos.src.Models;

namespace RussoBarberisPriotti_GestorArchivos.src.ReadFile
{
    public partial class FormReadFile : Form
    {
        private string FolderPath = Path.Combine(Application.StartupPath, "Archivos");

        public FormReadFile()
        {
            InitializeComponent();
            LoadFileList();
        }

        private void LoadFileList()
        {
            if (Directory.Exists(FolderPath))
            {
                string[] files = Directory.GetFiles(FolderPath);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".txt" || extension == ".csv" || extension == ".json" || extension == ".xml")
                    {
                        lbFiles.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            else
            {
                MessageBox.Show("La carpeta de archivos no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = lbFiles.SelectedItem!.ToString()!;
            string filePath = Path.Combine(FolderPath, fileName);
            LoadFile(filePath);
        }

        private void LoadFile(string filePath)
        {
            List<Alumno> alumnoList = new List<Alumno>();

            try
            {
                if (filePath.EndsWith(".txt"))
                {
                    string[] lineas = File.ReadAllLines(filePath);
                    foreach (string linea in lineas)
                    {
                        if (string.IsNullOrEmpty(linea)) continue;
                        Alumno? alumno = Alumno.FromTxtToObj(linea);
                        if (alumno != null)
                        {
                            alumnoList.Add(alumno);
                        }
                    }
                }
                else if (filePath.EndsWith(".csv"))
                {
                    string[] lineas = File.ReadAllLines(filePath);
                    foreach (string linea in lineas.Skip(1))
                    {
                        if (string.IsNullOrEmpty(linea)) continue;
                        Alumno? alumno = Alumno.FromCsvToObj(linea);
                        if (alumno != null)
                        {
                            alumnoList.Add(alumno);
                        }
                    }
                }
                else if (filePath.EndsWith(".json"))
                {
                    string json = File.ReadAllText(filePath);
                    alumnoList = JsonSerializer.Deserialize<List<Alumno>>(json) ?? new List<Alumno>();
                }
                else if (filePath.EndsWith(".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        List<Alumno>? result = (List<Alumno>?)serializer.Deserialize(reader);
                        if (result != null)
                        {
                            alumnoList = result;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato de archivo no soportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DisplayData(alumnoList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData(List<Alumno> alumnos)
        {
            dgvAlumnos.Rows.Clear();
            foreach (var alumno in alumnos)
            {
                dgvAlumnos.Rows.Add(alumno.Legajo, alumno.Apellido, alumno.Nombre, alumno.Dni, alumno.Email, alumno.Telefono);
            }

            if (alumnos.Count == 0)
            {
                MessageBox.Show("No se encontraron alumnos en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
