using System.Windows.Forms;

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
                dvgAlumnos.Rows[i].Cells["id_alumno"].Value = (i+1).ToString("D3");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estas seguro que deseas cerrar?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) { 
                this.Close();
            }
        }

        private void dvgAlumnos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dvgAlumnos.Columns[e.ColumnIndex].Name == "telefono")
            {
                //if (dvgAlumnos.Rows[e.RowIndex].IsNewRow) return;

                int resultado;
                string valor = e.FormattedValue.ToString();
                
                if (!int.TryParse(valor, out resultado) || resultado < 0)
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
    }
}
