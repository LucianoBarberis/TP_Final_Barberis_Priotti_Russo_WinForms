namespace RussoBarberisPriotti_GestorArchivos.src
{
    partial class FormNewFile
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
            inpFileName = new TextBox();
            label1 = new Label();
            gbFileFormat = new GroupBox();
            rbXml = new RadioButton();
            rbJson = new RadioButton();
            rbCsv = new RadioButton();
            rbTxt = new RadioButton();
            nudCantidadAlu = new NumericUpDown();
            label2 = new Label();
            btnAddAlumnos = new Button();
            gbFileFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadAlu).BeginInit();
            SuspendLayout();
            // 
            // inpFileName
            // 
            inpFileName.Location = new Point(20, 45);
            inpFileName.Name = "inpFileName";
            inpFileName.Size = new Size(290, 27);
            inpFileName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del archivo";
            // 
            // gbFileFormat
            // 
            gbFileFormat.Controls.Add(rbXml);
            gbFileFormat.Controls.Add(rbJson);
            gbFileFormat.Controls.Add(rbCsv);
            gbFileFormat.Controls.Add(rbTxt);
            gbFileFormat.Location = new Point(20, 90);
            gbFileFormat.Name = "gbFileFormat";
            gbFileFormat.Size = new Size(290, 73);
            gbFileFormat.TabIndex = 2;
            gbFileFormat.TabStop = false;
            gbFileFormat.Text = "Formato del archivo";
            // 
            // rbXml
            // 
            rbXml.AutoSize = true;
            rbXml.Location = new Point(214, 33);
            rbXml.Name = "rbXml";
            rbXml.Size = new Size(57, 24);
            rbXml.TabIndex = 3;
            rbXml.TabStop = true;
            rbXml.Text = ".xml";
            rbXml.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Location = new Point(139, 33);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(60, 24);
            rbJson.TabIndex = 2;
            rbJson.TabStop = true;
            rbJson.Text = ".json";
            rbJson.UseVisualStyleBackColor = true;
            // 
            // rbCsv
            // 
            rbCsv.AutoSize = true;
            rbCsv.Location = new Point(75, 33);
            rbCsv.Name = "rbCsv";
            rbCsv.Size = new Size(53, 24);
            rbCsv.TabIndex = 1;
            rbCsv.TabStop = true;
            rbCsv.Text = ".csv";
            rbCsv.UseVisualStyleBackColor = true;
            // 
            // rbTxt
            // 
            rbTxt.AutoSize = true;
            rbTxt.Location = new Point(15, 33);
            rbTxt.Name = "rbTxt";
            rbTxt.Size = new Size(50, 24);
            rbTxt.TabIndex = 0;
            rbTxt.TabStop = true;
            rbTxt.Text = ".txt";
            rbTxt.UseVisualStyleBackColor = true;
            // 
            // nudCantidadAlu
            // 
            nudCantidadAlu.Location = new Point(20, 205);
            nudCantidadAlu.Name = "nudCantidadAlu";
            nudCantidadAlu.Size = new Size(290, 27);
            nudCantidadAlu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 180);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de alumnos a cargar";
            // 
            // btnAddAlumnos
            // 
            btnAddAlumnos.Location = new Point(20, 270);
            btnAddAlumnos.Name = "btnAddAlumnos";
            btnAddAlumnos.Size = new Size(290, 45);
            btnAddAlumnos.TabIndex = 5;
            btnAddAlumnos.Text = "Cargar Alumnos";
            btnAddAlumnos.UseVisualStyleBackColor = true;
            btnAddAlumnos.Click += btnAddAlumnos_Click;
            // 
            // FormNewFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 350);
            Controls.Add(btnAddAlumnos);
            Controls.Add(label2);
            Controls.Add(nudCantidadAlu);
            Controls.Add(gbFileFormat);
            Controls.Add(label1);
            Controls.Add(inpFileName);
            Name = "FormNewFile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear Nuevo Archivo";
            gbFileFormat.ResumeLayout(false);
            gbFileFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadAlu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inpFileName;
        private Label label1;
        private GroupBox gbFileFormat;
        private RadioButton rbJson;
        private RadioButton rbCsv;
        private RadioButton rbTxt;
        private RadioButton rbXml;
        private NumericUpDown nudCantidadAlu;
        private Label label2;
        private Button btnAddAlumnos;
    }
}