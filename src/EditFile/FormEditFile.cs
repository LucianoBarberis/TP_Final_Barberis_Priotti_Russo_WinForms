using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;
using RussoBarberisPriotti_GestorArchivos.src.Utilities;

namespace RussoBarberisPriotti_GestorArchivos.src.EditFile
{
    public partial class FormEditFile : Form
    {
        private string FolderPath = Path.Combine(Application.StartupPath, "Archivos");

        public FormEditFile()
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = lbFiles.SelectedItem.ToString()!;
            string filePath = Path.Combine(FolderPath, fileName);

            try
            {
                List<Alumno> alumnos = FileHelper.ReadFile(filePath);
                FormEditorWorkspace workspace = new FormEditorWorkspace(filePath, alumnos);
                workspace.ShowDialog();
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}