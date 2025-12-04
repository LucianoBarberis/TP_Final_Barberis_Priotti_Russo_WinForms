using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;
using RussoBarberisPriotti_GestorArchivos.src.Utilities;

namespace RussoBarberisPriotti_GestorArchivos.src.GeneradorDeReportes
{
    public partial class FormGeneradorDeReportes : Form
    {
        private string FolderPath = Path.Combine(Application.StartupPath, "Archivos");

        public FormGeneradorDeReportes()
        {
            InitializeComponent();
            LoadFileList();
        }

        private void LoadFileList()
        {
            lbFiles.Items.Clear();
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = lbFiles.SelectedItem.ToString();
            string filePath = Path.Combine(FolderPath, fileName);

            try
            {
                List<Alumno> alumnos = FileHelper.ReadFile(filePath);

                if (alumnos == null || alumnos.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar alumnos o el archivo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ordenar por apellido
                List<Alumno> alumnosOrdenados = alumnos.OrderBy(a => a.Apellido).ToList();

                // Generar reporte
                string reporte = GenerarReporteString(alumnosOrdenados);
                tbReport.Text = reporte;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarReporteString(List<Alumno> alumnos)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===============================");
            sb.AppendLine("REPORTE DE ALUMNOS POR APELLIDO");
            sb.AppendLine($"Fecha/Hora: {DateTime.Now}");
            sb.AppendLine("===============================");

            if (alumnos == null || alumnos.Count == 0)
            {
                sb.AppendLine("No hay alumnos para mostrar.");
                return sb.ToString();
            }

            string apellidoActual = "";
            int cantidadPorApellido = 0;
            bool esPrimerGrupo = true;

            foreach (var alumno in alumnos)
            {
                // Normalizamos comparaciones de strings para evitar problemas de mayúsculas/minúsculas
                string apellidoAlumno = alumno.Apellido ?? ""; 

                if (apellidoAlumno.ToUpper() != apellidoActual.ToUpper())
                {
                    if (!esPrimerGrupo)
                    {
                        sb.AppendLine($"-> Subtotal {apellidoActual.ToUpper()}: {cantidadPorApellido} alumno(s)");
                        sb.AppendLine("-------------------------------");
                    }

                    apellidoActual = apellidoAlumno;
                    cantidadPorApellido = 0;
                    esPrimerGrupo = false;

                    sb.AppendLine($"\nApellido: {apellidoActual.ToUpper()}");
                }

                sb.AppendLine($"Legajo: {alumno.Legajo}");
                sb.AppendLine($"Nombre: {alumno.Nombre}");
                sb.AppendLine($"Documento: {alumno.Dni}");
                sb.AppendLine($"Email: {alumno.Email}");
                sb.AppendLine($"Telefono: {alumno.Telefono}");
                sb.AppendLine("");
                cantidadPorApellido++;
            }

            if (!esPrimerGrupo)
            {
                sb.AppendLine($"-> Subtotal {apellidoActual.ToUpper()}: {cantidadPorApellido} alumno(s)");
                sb.AppendLine("-------------------------------");
            }

            sb.AppendLine("\n===============================");
            sb.AppendLine("        RESUMEN GENERAL        ");
            sb.AppendLine("===============================");
            int totalAlumnos = alumnos.Count;
            int cantidadApellidosDiferentes = alumnos.Select(a => a.Apellido.ToUpper()).Distinct().Count();
            sb.AppendLine($"Cantidad total de alumnos: {totalAlumnos}");
            sb.AppendLine($"Cantidad de apellidos diferentes: {cantidadApellidosDiferentes}");
            sb.AppendLine("===============================");

            return sb.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbReport.Text))
            {
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar Reporte";
            saveFileDialog.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HH-mm}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, tbReport.Text);
                    MessageBox.Show("Reporte guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}