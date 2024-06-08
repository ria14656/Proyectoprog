using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
            QuerysProductos Producto = new QuerysProductos();
            if (Producto.Productos().Rows.Count == 0)
            {
                MessageBox.Show("No se tiene registro de Productos Inserte uno", "Cuadro Informativo");
                dataGridView1.DataSource = Producto.Productos();
            }
            else
                dataGridView1.DataSource = Producto.Productos();
        }
    }
}
