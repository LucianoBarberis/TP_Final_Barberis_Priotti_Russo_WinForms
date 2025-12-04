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

namespace RussoBarberisPriotti_GestorArchivos.src.Conversor
{
    public partial class FormConversor : Form
    {
        private string FolderPath = Path.Combine(Application.StartupPath, "Archivos");

        public FormConversor()
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de origen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDestFormat.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un formato de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = lbFiles.SelectedItem!.ToString()!;
            string sourcePath = Path.Combine(FolderPath, fileName);
            string destFormat = cmbDestFormat.SelectedItem!.ToString()!;
            string currentExtension = Path.GetExtension(sourcePath).ToLower();

            if (destFormat == currentExtension)
            {
                MessageBox.Show("El formato de destino es igual al de origen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Alumno> alumnos = FileHelper.ReadFile(sourcePath);

                if (alumnos == null || alumnos.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar alumnos o el archivo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                string destPathWithoutExt = Path.Combine(FolderPath, nameWithoutExt);

                switch (destFormat)
                {
                    case ".txt":
                        SaveFile.saveInTxt(alumnos, destPathWithoutExt);
                        break;
                    case ".csv":
                        SaveFile.saveInCsv(alumnos, destPathWithoutExt);
                        break;
                    case ".json":
                        SaveFile.saveInJson(alumnos, destPathWithoutExt);
                        break;
                    case ".xml":
                        SaveFile.saveInXml(alumnos, destPathWithoutExt);
                        break;
                }

                MessageBox.Show("Conversión finalizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFileList(); // Refresh list to show potentially new file (though likely overwrites or same name different ext)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error durante la conversión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}