namespace ProyectoProgramacion2Unidad2
{
    partial class Form2
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
            lblTitulo = new Label();
            panel1 = new Panel();
            lblSemestre = new Label();
            lblCarrera = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblID = new Label();
            btnCerrar = new Button();
            btnRegresar = new Button();
            lblFecha = new Label();
            btnGenerar = new Button();
            cmbID = new ComboBox();
            lblSelID = new Label();
            picFoto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(33, 78, 176);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(915, 65);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Reporte de Alumno";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 27, 60);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblSemestre);
            panel1.Controls.Add(lblCarrera);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(cmbID);
            panel1.Controls.Add(lblSelID);
            panel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(83, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 441);
            panel1.TabIndex = 7;
            // 
            // lblSemestre
            // 
            lblSemestre.BackColor = SystemColors.Menu;
            lblSemestre.Location = new Point(105, 335);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(532, 30);
            lblSemestre.TabIndex = 14;
            lblSemestre.Text = "Semestre";
            // 
            // lblCarrera
            // 
            lblCarrera.BackColor = SystemColors.Menu;
            lblCarrera.Location = new Point(105, 292);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(532, 30);
            lblCarrera.TabIndex = 13;
            lblCarrera.Text = "Carrera";
            // 
            // lblTelefono
            // 
            lblTelefono.BackColor = SystemColors.Menu;
            lblTelefono.Location = new Point(105, 249);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(532, 30);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            lblCorreo.BackColor = SystemColors.Menu;
            lblCorreo.Location = new Point(107, 206);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(532, 30);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // lblApellido
            // 
            lblApellido.BackColor = SystemColors.Menu;
            lblApellido.Location = new Point(107, 163);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(532, 30);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = SystemColors.Menu;
            lblNombre.Location = new Point(107, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(532, 30);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.BackColor = SystemColors.Menu;
            lblID.Location = new Point(107, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(532, 30);
            lblID.TabIndex = 8;
            lblID.Text = "ID";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 122, 0);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(487, 386);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(152, 44);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(255, 122, 0);
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(299, 386);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(152, 44);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(636, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 25);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(255, 122, 0);
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(107, 386);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(152, 44);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // cmbID
            // 
            cmbID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbID.FlatStyle = FlatStyle.Popup;
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(174, 9);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(184, 33);
            cmbID.TabIndex = 1;
            // 
            // lblSelID
            // 
            lblSelID.AutoSize = true;
            lblSelID.ForeColor = Color.White;
            lblSelID.Location = new Point(14, 9);
            lblSelID.Name = "lblSelID";
            lblSelID.Size = new Size(154, 25);
            lblSelID.TabIndex = 0;
            lblSelID.Text = "Selecciona un ID";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(833, 1);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(80, 80);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 5;
            picFoto.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 533);
            Controls.Add(picFoto);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ComboBox cmbID;
        private Label lblSelID;
        private Button btnGenerar;
        private PictureBox picFoto;
        private Label lblFecha;
        private Label lblID;
        private Button btnCerrar;
        private Button btnRegresar;
        private Label lblSemestre;
        private Label lblCarrera;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblApellido;
        private Label lblNombre;
    }
}