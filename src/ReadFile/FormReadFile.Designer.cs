namespace RussoBarberisPriotti_GestorArchivos.src.ReadFile
{
    partial class FormReadFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFiles = new ListBox();
            btnLoadFile = new Button();
            dgvAlumnos = new DataGridView();
            colLegajo = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // lbFiles
            // 
            lbFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbFiles.FormattingEnabled = true;
            lbFiles.Location = new Point(13, 16);
            lbFiles.Margin = new Padding(3, 4, 3, 4);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(228, 444);
            lbFiles.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadFile.Location = new Point(13, 478);
            btnLoadFile.Margin = new Padding(3, 4, 3, 4);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(229, 51);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Cargar Archivo";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colApellido, colNombre, colDni, colEmail, colTelefono });
            dgvAlumnos.Location = new Point(251, 16);
            dgvAlumnos.Margin = new Padding(3, 4, 3, 4);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(826, 571);
            dgvAlumnos.TabIndex = 1;
            // 
            // colLegajo
            // 
            colLegajo.HeaderText = "Legajo";
            colLegajo.MinimumWidth = 6;
            colLegajo.Name = "colLegajo";
            colLegajo.ReadOnly = true;
            colLegajo.Width = 125;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            colApellido.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.MinimumWidth = 6;
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            colDni.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 150;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(14, 536);
            button1.Name = "button1";
            button1.Size = new Size(228, 51);
            button1.TabIndex = 3;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormReadFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 600);
            Controls.Add(button1);
            Controls.Add(btnLoadFile);
            Controls.Add(lbFiles);
            Controls.Add(dgvAlumnos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReadFile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Leer Archivo";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private Button button1;
    }
}
