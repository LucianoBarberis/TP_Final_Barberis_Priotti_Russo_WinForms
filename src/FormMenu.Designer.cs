namespace RussoBarberisPriotti_GestorArchivos
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewFile = new Button();
            btnReadFile = new Button();
            btnEditFile = new Button();
            btnDeleteFile = new Button();
            ConvertFile = new Button();
            NewReport = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNewFile
            // 
            btnNewFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewFile.Location = new Point(215, 58);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(180, 40);
            btnNewFile.TabIndex = 0;
            btnNewFile.Text = "Crear Nuevo Archivo";
            btnNewFile.UseVisualStyleBackColor = true;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReadFile.Location = new Point(215, 108);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(180, 40);
            btnReadFile.TabIndex = 2;
            btnReadFile.Text = "Leer Archivo";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnEditFile
            // 
            btnEditFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditFile.Location = new Point(215, 158);
            btnEditFile.Name = "btnEditFile";
            btnEditFile.Size = new Size(180, 40);
            btnEditFile.TabIndex = 3;
            btnEditFile.Text = "Editar Archivo";
            btnEditFile.UseVisualStyleBackColor = true;
            btnEditFile.Click += btnEditFile_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteFile.Location = new Point(215, 208);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(180, 40);
            btnDeleteFile.TabIndex = 4;
            btnDeleteFile.Text = "Eliminar Archivo";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // ConvertFile
            // 
            ConvertFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ConvertFile.Location = new Point(215, 258);
            ConvertFile.Name = "ConvertFile";
            ConvertFile.Size = new Size(180, 40);
            ConvertFile.TabIndex = 5;
            ConvertFile.Text = "Convertir Archivo";
            ConvertFile.UseVisualStyleBackColor = true;
            ConvertFile.Click += ConvertFile_Click;
            // 
            // NewReport
            // 
            NewReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewReport.Location = new Point(215, 308);
            NewReport.Name = "NewReport";
            NewReport.Size = new Size(180, 40);
            NewReport.TabIndex = 6;
            NewReport.Text = "Crear Reporte";
            NewReport.UseVisualStyleBackColor = true;
            NewReport.Click += NewReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 7;
            label1.Text = "Gestor de Archivos";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 364);
            Controls.Add(label1);
            Controls.Add(NewReport);
            Controls.Add(ConvertFile);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnEditFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnNewFile);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor De Archivos | Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewFile;
        private Button btnReadFile;
        private Button btnEditFile;
        private Button btnDeleteFile;
        private Button ConvertFile;
        private Button NewReport;
        private Label label1;
    }
}
