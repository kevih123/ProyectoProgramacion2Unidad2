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
            lblTitulo.Size = new Size(1046, 87);
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
            panel1.Location = new Point(95, 107);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 601);
            panel1.TabIndex = 7;
            // 
            // lblSemestre
            // 
            lblSemestre.BackColor = SystemColors.Menu;
            lblSemestre.Location = new Point(120, 447);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(608, 40);
            lblSemestre.TabIndex = 14;
            lblSemestre.Text = "Semestre";
            // 
            // lblCarrera
            // 
            lblCarrera.BackColor = SystemColors.Menu;
            lblCarrera.Location = new Point(120, 389);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(608, 40);
            lblCarrera.TabIndex = 13;
            lblCarrera.Text = "Carrera";
            // 
            // lblTelefono
            // 
            lblTelefono.BackColor = SystemColors.Menu;
            lblTelefono.Location = new Point(120, 332);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(608, 40);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            lblCorreo.BackColor = SystemColors.Menu;
            lblCorreo.Location = new Point(122, 275);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(608, 40);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // lblApellido
            // 
            lblApellido.BackColor = SystemColors.Menu;
            lblApellido.Location = new Point(122, 217);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(608, 40);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = SystemColors.Menu;
            lblNombre.Location = new Point(122, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(608, 40);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.BackColor = SystemColors.Menu;
            lblID.Location = new Point(122, 104);
            lblID.Name = "lblID";
            lblID.Size = new Size(608, 40);
            lblID.TabIndex = 8;
            lblID.Text = "ID";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 122, 0);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(557, 515);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(174, 74);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(255, 122, 0);
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(342, 515);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(174, 74);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblFecha
            // 
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(474, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(346, 32);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopRight;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(255, 122, 0);
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(120, 515);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(187, 74);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbID
            // 
            cmbID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbID.FlatStyle = FlatStyle.Popup;
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(225, 12);
            cmbID.Margin = new Padding(3, 4, 3, 4);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(210, 40);
            cmbID.TabIndex = 1;
            // 
            // lblSelID
            // 
            lblSelID.AutoSize = true;
            lblSelID.ForeColor = Color.White;
            lblSelID.Location = new Point(16, 12);
            lblSelID.Name = "lblSelID";
            lblSelID.Size = new Size(194, 32);
            lblSelID.TabIndex = 0;
            lblSelID.Text = "Selecciona un ID";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(959, 0);
            picFoto.Margin = new Padding(3, 4, 3, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(87, 87);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 5;
            picFoto.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 711);
            Controls.Add(picFoto);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
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