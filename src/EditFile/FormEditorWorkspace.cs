using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;
using RussoBarberisPriotti_GestorArchivos.src.Utilities;

namespace RussoBarberisPriotti_GestorArchivos.src.EditFile
{
    public partial class FormEditorWorkspace : Form
    {
        private string FilePath;
        private List<Alumno> AlumnoList;

        public FormEditorWorkspace(string filePath, List<Alumno> alumnos)
        {
            InitializeComponent();
            FilePath = filePath;
            AlumnoList = alumnos;
            DisplayData();
            this.Text = $"Editando: {Path.GetFileName(FilePath)}";
        }

        private void DisplayData()
        {
            dgvAlumnos.Rows.Clear();
            foreach (var alumno in AlumnoList)
            {
                dgvAlumnos.Rows.Add(alumno.Legajo, alumno.Apellido, alumno.Nombre, alumno.Dni, alumno.Email, alumno.Telefono);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStudentEditor editor = new FormStudentEditor();
            if (editor.ShowDialog() == DialogResult.OK)
            {
                Alumno newStudent = editor.StudentResult!;
                
                if (AlumnoList.Exists(a => a.Legajo == newStudent.Legajo))
                {
                    MessageBox.Show("El legajo ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AlumnoList.Add(newStudent);
                DisplayData();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string legajo = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString()!;
            if (string.IsNullOrEmpty(legajo))
            {
                MessageBox.Show("No se pudo obtener el Legajo del alumno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Alumno? target = AlumnoList.Find(a => a.Legajo == legajo);
            if (target == null)
            {
                // This case should ideally not happen if legajo is correctly obtained from dgvAlumnos and AlumnoList is in sync.
                MessageBox.Show("Alumno no encontrado en la lista en memoria.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormStudentEditor editor = new FormStudentEditor(target);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                int index = AlumnoList.IndexOf(target);
                // The editor returns a new Alumno object, so we replace the old one in the list.
                // We also need to check if the legajo changed and if the new legajo already exists.
                Alumno updatedStudent = editor.StudentResult!;
                if (updatedStudent.Legajo != target.Legajo && AlumnoList.Exists(a => a.Legajo == updatedStudent.Legajo))
                {
                    MessageBox.Show("El nuevo legajo ya existe para otro alumno. No se pudo modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                AlumnoList[index] = updatedStudent;
                DisplayData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string legajo = dgvAlumnos.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(legajo))
            {
                MessageBox.Show("No se pudo obtener el Legajo del alumno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Alumno? target = AlumnoList.Find(a => a.Legajo == legajo);
            if (target == null)
            {
                // This case should ideally not happen if legajo is correctly obtained from dgvAlumnos and AlumnoList is in sync.
                MessageBox.Show("Alumno no encontrado en la lista en memoria.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = $"¿Está seguro que desea eliminar a:\n{target.Apellido}, {target.Nombre} (Legajo: {target.Legajo})?";
            if (MessageBox.Show(msg, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AlumnoList.Remove(target);
                DisplayData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Create Backup
                string backupPath = FilePath + ".bak";
                if (File.Exists(backupPath)) File.Delete(backupPath);
                File.Move(FilePath, backupPath);

                // Save New File
                string extension = Path.GetExtension(FilePath).ToLower();
                switch (extension)
                {
                    case ".txt":
                        SaveFile.saveInTxt(AlumnoList, FilePath.Replace(extension, "")); // SaveFile appends extension
                        break;
                    case ".csv":
                        SaveFile.saveInCsv(AlumnoList, FilePath.Replace(extension, ""));
                        break;
                    case ".json":
                        SaveFile.saveInJson(AlumnoList, FilePath.Replace(extension, ""));
                        break;
                    case ".xml":
                        SaveFile.saveInXml(AlumnoList, FilePath.Replace(extension, ""));
                        break;
                }
                
                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Restore backup if move happened but save failed? 
                // For simplicity, we leave .bak there. User can recover manually if needed.
            }
        }

                private void btnCancel_Click(object sender, EventArgs e)
                {
                    if (MessageBox.Show("¿Desea salir sin guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
        }
