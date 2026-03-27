using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoProgramacion2Unidad2
{
    public partial class Form2 : Form
    {
        // Instanciamos la variable local _lista_alumnos
        private List<List<object>> _alumnos;

        public Form2(List<List<object>> lista_alumnos) // El constructor recibe _alumnos del Form1
        {
            InitializeComponent();
            _alumnos = lista_alumnos; // A nuestra variable instanciada le asignamos la lista que se pasó
            CargarCmbID();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            picFoto.Image = Image.FromFile("../../../res/logo.png");
        }

        private void CargarCmbID()
        {
            foreach (var datos_alumno in _alumnos)
            {
                if (datos_alumno.Count == 0)
                {
                    cmbID.Items.Add("Sin alumnos registrados");
                }
                else if (datos_alumno.Count >= 1)
                {
                    cmbID.Items.Add(datos_alumno[0].ToString());
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Actualizar la fecha
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (cmbID.SelectedItem != null)
            {
                string idSeleccionado = cmbID.SelectedItem.ToString();

                foreach (var alumno in _alumnos)
                {
                    if (alumno[0] == idSeleccionado && idSeleccionado != null)
                    {
                        // Mostrar los valores en labels
                        lblID.Text = alumno[0]?.ToString();
                        lblNombre.Text = alumno[1]?.ToString();
                        lblApellido.Text = alumno[2]?.ToString();
                        lblCorreo.Text = alumno[3]?.ToString();
                        lblTelefono.Text = alumno[4]?.ToString();
                        lblCarrera.Text = alumno[5]?.ToString();
                        lblSemestre.Text = alumno[6]?.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ID para generar el reporte.", "ID no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estas seguro que deseas cerrar?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
    }
