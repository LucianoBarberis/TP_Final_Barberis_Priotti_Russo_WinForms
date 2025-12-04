using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussoBarberisPriotti_GestorArchivos.src.DeleteFile
{
    public partial class FormDeleteFile : Form
    {
        private string FolderPath = Path.Combine(Application.StartupPath, "Archivos");
        public FormDeleteFile()
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
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName = lbFiles.SelectedItem.ToString();
            string filePath = Path.Combine(FolderPath, fileName);
            DeleteFile(filePath);
        }
        private void DeleteFile(string filePath)
        {
            try
            {
                FileInfo infoArchivo = new FileInfo(filePath);
                if (MessageBox.Show($"Desea eliminar el archivo, esta accion es irreversible \nNombre: {infoArchivo.Name}\nPeso: Tamaño: {infoArchivo.Length / 1024.0:F2} KB\nFecha de creación: {infoArchivo.CreationTime}\nÚltima modificación: {infoArchivo.LastWriteTime}", "Borrar archivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    File.Delete(filePath);
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbFiles.Items.Clear();
            LoadFileList();
        }
    }
}
