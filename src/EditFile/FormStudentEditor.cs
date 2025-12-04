using System;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;

namespace RussoBarberisPriotti_GestorArchivos.src.EditFile
{
    public partial class FormStudentEditor : Form
    {
        public Alumno? StudentResult { get; private set; }

        public FormStudentEditor()
        {
            InitializeComponent();
            this.Text = "Agregar Alumno";
            btnSave.Text = "Agregar";
        }

        public FormStudentEditor(Alumno alumno)
        {
            InitializeComponent();
            this.Text = "Modificar Alumno";
            btnSave.Text = "Guardar Cambios";
            
            txtLegajo.Text = alumno.Legajo;
            txtApellido.Text = alumno.Apellido;
            txtNombre.Text = alumno.Nombre;
            txtDni.Text = alumno.Dni;
            txtEmail.Text = alumno.Email;
            txtTelefono.Text = alumno.Telefono;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string legajo = txtLegajo.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;
            string email = txtEmail.Text;
            string tel = txtTelefono.Text;

            if (Alumno.ValidarAlumno(legajo, apellido, nombre, dni, email, tel))
            {
                StudentResult = new Alumno(legajo, apellido, nombre, dni, email, tel);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos inválidos. Por favor verifique los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
