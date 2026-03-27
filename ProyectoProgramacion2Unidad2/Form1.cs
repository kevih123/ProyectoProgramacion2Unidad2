namespace ProyectoProgramacion2Unidad2
{
    public partial class Form1 : Form
    {
        int filas = 0;
        public Form1()
        {
            InitializeComponent();
            //Conectar el evento cell validating y sobreescribir
            dvgAlumnos.CellValidating += dvgAlumnos_CellValidating;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            filas = (int)nudFilas.Value;
            dvgAlumnos.Rows.Clear();
            dvgAlumnos.ReadOnly = false;
            dvgAlumnos.AllowUserToAddRows = false;
            dvgAlumnos.AllowUserToDeleteRows = false;
            dvgAlumnos.AllowUserToResizeRows = false;
            dvgAlumnos.AllowUserToOrderColumns = false;
            dvgAlumnos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dvgAlumnos.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dvgAlumnos.Columns["id_alumno"].ReadOnly = true; //Restriccion para no modificar id 

            //Creacion de las filas
            for (int i = 0; i < filas; i++)
            {
                dvgAlumnos.Rows.Add();
                dvgAlumnos.Rows[i].Cells["id_alumno"].Value = (i + 1).ToString("D3");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estas seguro que deseas cerrar?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dvgAlumnos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dvgAlumnos.Columns[e.ColumnIndex].Name == "telefono")
            {
                //if (dvgAlumnos.Rows[e.RowIndex].IsNewRow) return;

                long resultado;
                string valor = e.FormattedValue.ToString();

                if (!long.TryParse(valor, out resultado) || resultado < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Solo se permite números enteros.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dvgAlumnos.Rows[e.RowIndex].ErrorText = String.Empty;
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // crear una lista para almacenar a todos los alumnos
            List<List<object>> lista_alumnos = new List<List<object>>();

            foreach (DataGridViewRow fila in dvgAlumnos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // crear una lista para almacenar los datos de los alumnos
                    List<object> datos_alumno = new List<object>();

                    //agregar los datos del alumno a la lista de datos_alumno
                    datos_alumno.Add(fila.Cells["id_alumno"].Value);
                    datos_alumno.Add(fila.Cells["nombre_alumn"].Value);
                    datos_alumno.Add(fila.Cells["apellido"].Value);
                    datos_alumno.Add(fila.Cells["correo"].Value);
                    datos_alumno.Add(fila.Cells["telefono"].Value);
                    datos_alumno.Add(fila.Cells["carrera"].Value);
                    datos_alumno.Add(fila.Cells["semestre"].Value);


                    // agregar la lista de datos_alumno a la lista de alumnos
                    lista_alumnos.Add(datos_alumno);

                }
            }

            Form2 form2 = new Form2(lista_alumnos);
            form2.ShowDialog(); // ShowDialog = modal (bloquea Form1 mientras está abierto)
        }
    }
}
