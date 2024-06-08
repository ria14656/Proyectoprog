using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final.Properties
{
    public partial class Actualizar_y_borrar : Form
    {
        public Actualizar_y_borrar()
        {
            InitializeComponent();
            Actualizartabla();

        }

        public void Actualizartabla()
        {
            QuerysProductos Producto = new QuerysProductos();
            if (Producto.Productos().Rows.Count == 0)
            {
                MessageBox.Show("No se tiene registro de Productos Inserte uno", "Cuadro Informativo");
                dataGridView1.DataSource = Producto.Productos();
            }
            else
                dataGridView1.DataSource=Producto.Productos();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Se emplea el begininvoke para que no haya un siclo infinito..
            this.BeginInvoke(new MethodInvoker(() =>
            {
                QuerysProductos qproductos = new QuerysProductos();
                EntidadProductos eproducto = new EntidadProductos();
                eproducto.Codigo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                eproducto.Nombre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                eproducto.Precio = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                eproducto.Existencia = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                MessageBox.Show(qproductos.UpdateProducto(eproducto)+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "Cuadro Informativo");
                
                Actualizartabla();
            }));
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                QuerysProductos qproductos = new QuerysProductos();
                EntidadProductos eproducto = new EntidadProductos();
                eproducto.Codigo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                qproductos.deleteProductos(eproducto);
                MessageBox.Show("Producto Eliminado", "Cuadro Informativo");
                Actualizartabla();
            }
        }
    }
}
