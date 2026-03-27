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
            dvgAlumnos = new DataGridView();
            id_alumno = new DataGridViewTextBoxColumn();
            nombre_alumn = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            nudFilas = new NumericUpDown();
            btnCerrar = new Button();
            btnReporte = new Button();
            panel1 = new Panel();
            btnCrear = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            carrera = new DataGridViewTextBoxColumn();
            semestre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFilas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgAlumnos
            // 
            dvgAlumnos.AllowUserToAddRows = false;
            dvgAlumnos.AllowUserToDeleteRows = false;
            dvgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgAlumnos.BackgroundColor = SystemColors.ScrollBar;
            dvgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAlumnos.Columns.AddRange(new DataGridViewColumn[] { id_alumno, nombre_alumn, apellido, correo, telefono, carrera, semestre });
            dvgAlumnos.Location = new Point(14, 97);
            dvgAlumnos.Margin = new Padding(3, 4, 3, 4);
            dvgAlumnos.Name = "dvgAlumnos";
            dvgAlumnos.RowHeadersWidth = 51;
            dvgAlumnos.Size = new Size(1018, 391);
            dvgAlumnos.TabIndex = 0;
            // 
            // id_alumno
            // 
            id_alumno.HeaderText = "ID";
            id_alumno.MinimumWidth = 6;
            id_alumno.Name = "id_alumno";
            // 
            // nombre_alumn
            // 
            nombre_alumn.HeaderText = "Nombre";
            nombre_alumn.MinimumWidth = 6;
            nombre_alumn.Name = "nombre_alumn";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            // 
            // nudFilas
            // 
            nudFilas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudFilas.Location = new Point(321, 76);
            nudFilas.Margin = new Padding(3, 4, 3, 4);
            nudFilas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudFilas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFilas.Name = "nudFilas";
            nudFilas.Size = new Size(387, 34);
            nudFilas.TabIndex = 1;
            nudFilas.Tag = "";
            nudFilas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 122, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(610, 139);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(125, 48);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(255, 122, 0);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(448, 139);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(125, 48);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Ver Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 27, 60);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nudFilas);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnReporte);
            panel1.Location = new Point(14, 496);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 204);
            panel1.TabIndex = 4;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(255, 122, 0);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(288, 139);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(125, 48);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear Tabla";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 13);
            label1.Name = "label1";
            label1.Size = new Size(316, 41);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de alumnos\r\n";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(33, 78, 176);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1046, 75);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Práctica 3 -Registro de Alumnos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // carrera
            // 
            carrera.HeaderText = "Carrera";
            carrera.MinimumWidth = 6;
            carrera.Name = "carrera";
            // 
            // semestre
            // 
            semestre.HeaderText = "Semestre";
            semestre.MinimumWidth = 6;
            semestre.Name = "semestre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 711);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Controls.Add(dvgAlumnos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFilas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgAlumnos;
        private NumericUpDown nudFilas;
        private Button btnCerrar;
        private Button btnReporte;
        private Panel panel1;
        private DataGridViewTextBoxColumn id_alumno;
        private DataGridViewTextBoxColumn nombre_alumn;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private Label label1;
        private Label lblTitulo;
        private Button btnCrear;
        private DataGridViewTextBoxColumn carrera;
        private DataGridViewTextBoxColumn semestre;
    }
}
