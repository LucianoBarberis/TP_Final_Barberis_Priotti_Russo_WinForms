namespace RussoBarberisPriotti_GestorArchivos.src.DeleteFile
{
    partial class FormDeleteFile
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
            btnDeleteFile = new Button();
            SuspendLayout();
            // 
            // lbFiles
            // 
            lbFiles.FormattingEnabled = true;
            lbFiles.Location = new Point(12, 12);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(306, 344);
            lbFiles.TabIndex = 0;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(12, 362);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(306, 60);
            btnDeleteFile.TabIndex = 1;
            btnDeleteFile.Text = "Borrar Archivo";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // FormDeleteFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 434);
            Controls.Add(btnDeleteFile);
            Controls.Add(lbFiles);
            Name = "FormDeleteFile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestor de Archivos | Borrar Archivo";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbFiles;
        private Button btnDeleteFile;
    }
}