using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;
using RussoBarberisPriotti_GestorArchivos.src.Utilities;

namespace RussoBarberisPriotti_GestorArchivos.src
{
    public partial class FormNewFile : Form
    {
        public int CantidadDeAlumnos = 0;
        public FormNewFile()
        {
            InitializeComponent();
            rbTxt.Checked = true;
        }

        private void btnAddAlumnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpFileName.Text) || !Program.EsNombreDeArchivoValido(inpFileName.Text))
            {
                MessageBox.Show("El nombre del archivo no es valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudCantidadAlu.Value == 0)
            {
                MessageBox.Show("Debe haber mas de 1 alumno", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string format = "txt";
            if (rbCsv.Checked) { format = "csv"; }
            else if (rbJson.Checked) { format = "json"; }
            else if (rbXml.Checked) { format = "xml"; }
            
            string folderPath = Path.Combine(Application.StartupPath, "Archivos");
            string fullPath = Path.Combine(folderPath, inpFileName.Text + "." + format);

            if (File.Exists(fullPath))
            {
                DialogResult result = MessageBox.Show($"El archivo {inpFileName.Text}.{format} ya existe. ¿Desea sobrescribirlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            CantidadDeAlumnos = Convert.ToInt32(nudCantidadAlu.Value);
            NewFile.FormAddAlumno formAddAlumno = new NewFile.FormAddAlumno(CantidadDeAlumnos);
            
            if (formAddAlumno.ShowDialog() == DialogResult.OK)
            {
                List<Alumno> alumnos = formAddAlumno.AlumnosACargar;
                
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                
                string pathForSave = Path.Combine(folderPath, inpFileName.Text);

                try
                {
                    switch (format)
                    {
                        case "txt":
                            SaveFile.saveInTxt(alumnos, pathForSave);
                            break;
                        case "csv":
                            SaveFile.saveInCsv(alumnos, pathForSave);
                            break;
                        case "json":
                            SaveFile.saveInJson(alumnos, pathForSave);
                            break;
                        case "xml":
                            SaveFile.saveInXml(alumnos, pathForSave);
                            break;
                    }
                    MessageBox.Show("Archivo creado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}