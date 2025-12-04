namespace RussoBarberisPriotti_GestorArchivos.src.EditFile
{
    partial class FormStudentEditor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancel = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtLegajo = new TextBox();
            lblLegajo = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(264, 239);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 53);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(104, 239);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 53);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(274, 192);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 25;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(274, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(274, 52);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(200, 27);
            txtDni.TabIndex = 21;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(274, 27);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 20;
            lblDni.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(274, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(274, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(34, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 27);
            txtApellido.TabIndex = 17;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 97);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 16;
            lblApellido.Text = "Apellido:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(34, 52);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(200, 27);
            txtLegajo.TabIndex = 15;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(34, 27);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(57, 20);
            lblLegajo.TabIndex = 14;
            lblLegajo.Text = "Legajo:";
            // 
            // FormStudentEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 317);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStudentEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Alumno";
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtLegajo;
        private Label lblLegajo;
    }
}
