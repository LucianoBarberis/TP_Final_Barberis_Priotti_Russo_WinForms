namespace RussoBarberisPriotti_GestorArchivos.src.Conversor
{
    partial class FormConversor
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
            lblSource = new Label();
            lbFiles = new ListBox();
            lblFormat = new Label();
            cmbDestFormat = new ComboBox();
            btnConvert = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(13, 9);
            lblSource.Margin = new Padding(4, 0, 4, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(137, 20);
            lblSource.TabIndex = 0;
            lblSource.Text = "Seleccione Archivo:";
            // 
            // lbFiles
            // 
            lbFiles.FormattingEnabled = true;
            lbFiles.Location = new Point(13, 36);
            lbFiles.Margin = new Padding(4, 5, 4, 5);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(240, 404);
            lbFiles.TabIndex = 1;
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(261, 11);
            lblFormat.Margin = new Padding(4, 0, 4, 0);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(123, 20);
            lblFormat.TabIndex = 2;
            lblFormat.Text = "Formato Destino:";
            // 
            // cmbDestFormat
            // 
            cmbDestFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestFormat.FormattingEnabled = true;
            cmbDestFormat.Items.AddRange(new object[] { ".txt", ".csv", ".json", ".xml" });
            cmbDestFormat.Location = new Point(261, 36);
            cmbDestFormat.Margin = new Padding(4, 5, 4, 5);
            cmbDestFormat.Name = "cmbDestFormat";
            cmbDestFormat.Size = new Size(160, 28);
            cmbDestFormat.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(261, 74);
            btnConvert.Margin = new Padding(4, 5, 4, 5);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(160, 49);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convertir";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(261, 133);
            btnReturn.Margin = new Padding(4, 5, 4, 5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(160, 49);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Volver";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FormConversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 462);
            Controls.Add(btnReturn);
            Controls.Add(btnConvert);
            Controls.Add(cmbDestFormat);
            Controls.Add(lblFormat);
            Controls.Add(lbFiles);
            Controls.Add(lblSource);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConversor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Conversor de Archivos";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cmbDestFormat;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReturn;
    }
}