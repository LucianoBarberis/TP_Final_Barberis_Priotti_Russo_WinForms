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

namespace RussoBarberisPriotti_GestorArchivos.src.NewFile
{
    public partial class FormAddAlumno : Form
    {
        public int CantidadDeAlumnos { get; set; }
        public List<Alumno> AlumnosACargar { get; set; }
        private int CurrentStudentIndex { get; set; }

        public FormAddAlumno(int cantidad)
        {
            InitializeComponent();
            CantidadDeAlumnos = cantidad;
            AlumnosACargar = new List<Alumno>();
            CurrentStudentIndex = 1;
            ActualizarLabel();
        }

        public FormAddAlumno()
        {
            InitializeComponent();
            AlumnosACargar = new List<Alumno>();
        }

        private void ActualizarLabel()
        {
            lblProgress.Text = $"Alumno {CurrentStudentIndex} de {CantidadDeAlumnos}";
            if (CurrentStudentIndex == CantidadDeAlumnos)
            {
                btnGuardar.Text = "Terminar Carga";
            }
            else
            {
                btnGuardar.Text = "Siguiente >";
            }
        }

        private void ClearFields()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtLegajo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string legajo = txtLegajo.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;
            string email = txtEmail.Text;
            string tel = txtTelefono.Text;

            if (Alumno.ValidarAlumno(legajo, apellido, nombre, dni, email, tel))
            {
                Alumno alumno = new Alumno(legajo, apellido, nombre, dni, email, tel);
                AlumnosACargar.Add(alumno);

                if (CurrentStudentIndex >= CantidadDeAlumnos)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    CurrentStudentIndex++;
                    ClearFields();
                    ActualizarLabel();
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos. Por favor verifique los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}