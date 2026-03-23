namespace ProyectoProgramacion2Unidad2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            id_alumno = new DataGridViewTextBoxColumn();
            nombre_alumn = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_alumno, nombre_alumn, apellido, correo, telefono });
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(509, 200);
            dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(48, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(64, 167);
            button1.Name = "button1";
            button1.Size = new Size(104, 33);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(64, 105);
            button2.Name = "button2";
            button2.Size = new Size(104, 36);
            button2.TabIndex = 3;
            button2.Text = "Reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 27, 60);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(538, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 244);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de alumnos: ";
            // 
            // id_alumno
            // 
            id_alumno.HeaderText = "ID";
            id_alumno.Name = "id_alumno";
            id_alumno.ReadOnly = true;
            // 
            // nombre_alumn
            // 
            nombre_alumn.HeaderText = "Nombre";
            nombre_alumn.Name = "nombre_alumn";
            nombre_alumn.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(33, 78, 176);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 45);
            label2.TabIndex = 5;
            label2.Text = "Proyecto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 191, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private DataGridViewTextBoxColumn id_alumno;
        private DataGridViewTextBoxColumn nombre_alumn;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private Label label1;
        private Label label2;
    }
}
