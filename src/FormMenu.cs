using RussoBarberisPriotti_GestorArchivos.src;
using RussoBarberisPriotti_GestorArchivos.src.DeleteFile;
using RussoBarberisPriotti_GestorArchivos.src.ReadFile;
using RussoBarberisPriotti_GestorArchivos.src.EditFile;
using RussoBarberisPriotti_GestorArchivos.src.Conversor;
using RussoBarberisPriotti_GestorArchivos.src.GeneradorDeReportes;

namespace RussoBarberisPriotti_GestorArchivos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            FormNewFile formNewFile = new FormNewFile();
            formNewFile.ShowDialog();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            FormReadFile formReadFile = new FormReadFile();
            formReadFile.ShowDialog();
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            FormEditFile formEditFile = new FormEditFile();
            formEditFile.ShowDialog();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            FormDeleteFile formDeleteFile = new FormDeleteFile();
            formDeleteFile.ShowDialog();
        }

        private void ConvertFile_Click(object sender, EventArgs e)
        {
            FormConversor formConversor = new FormConversor();
            formConversor.ShowDialog();
        }

        private void NewReport_Click(object sender, EventArgs e)
        {
            FormGeneradorDeReportes formGeneradorDeReportes = new FormGeneradorDeReportes();
            formGeneradorDeReportes.ShowDialog();
        }
    }
}
