using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgramacion2Unidad2
{
    public partial class Form2 : Form
    {
        private List<List<object>> _lista_alumnos;

        public Form2(List<List<object>> lista_alumnos)
        {
            InitializeComponent();
            _lista_alumnos = lista_alumnos;
            foreach (var alumno in lista_alumnos)
            {
                MessageBox.Show(
                    $"ID: {alumno[0]}\n" +
                    $"Nombre: {alumno[1]}\n" +
                    $"Apellido: {alumno[2]}\n" +
                    $"Correo: {alumno[3]}\n" +
                    $"Teléfono: {alumno[4]}"

                );
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
