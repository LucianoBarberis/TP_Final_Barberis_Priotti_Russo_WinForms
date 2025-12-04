namespace RussoBarberisPriotti_GestorArchivos.src.GeneradorDeReportes
{
    partial class FormGeneradorDeReportes
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
            lblSelectFile = new Label();
            lbFiles = new ListBox();
            btnGenerate = new Button();
            btnSave = new Button();
            btnReturn = new Button();
            tbReport = new TextBox();
            SuspendLayout();
            // 
            // lblSelectFile
            // 
            lblSelectFile.AutoSize = true;
            lblSelectFile.Location = new Point(16, 14);
            lblSelectFile.Margin = new Padding(4, 0, 4, 0);
            lblSelectFile.Name = "lblSelectFile";
            lblSelectFile.Size = new Size(142, 20);
            lblSelectFile.TabIndex = 0;
            lblSelectFile.Text = "Seleccionar Archivo:";
            // 
            // lbFiles
            // 
            lbFiles.FormattingEnabled = true;
            lbFiles.Location = new Point(20, 38);
            lbFiles.Margin = new Padding(4, 5, 4, 5);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(279, 344);
            lbFiles.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(20, 389);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(279, 49);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generar Reporte";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(20, 448);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 49);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar Reporte";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(161, 448);
            btnReturn.Margin = new Padding(4, 5, 4, 5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(138, 49);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Volver";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // tbReport
            // 
            tbReport.BorderStyle = BorderStyle.FixedSingle;
            tbReport.Location = new Point(306, 38);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.ReadOnly = true;
            tbReport.ScrollBars = ScrollBars.Vertical;
            tbReport.Size = new Size(441, 459);
            tbReport.TabIndex = 6;
            // 
            // FormGeneradorDeReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 512);
            Controls.Add(tbReport);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(btnGenerate);
            Controls.Add(lbFiles);
            Controls.Add(lblSelectFile);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGeneradorDeReportes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Generador de Reportes";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private TextBox tbReport;
    }
}