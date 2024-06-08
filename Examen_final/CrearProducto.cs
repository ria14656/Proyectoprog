using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen_final
{
    public partial class CrearProducto : Form
    {
        public CrearProducto()
        {
            InitializeComponent();
            Cargar_Tabla();
        }

        public void Cargar_Tabla()
        {
            QuerysUsuarios QUsuarios = new QuerysUsuarios();
            comboBox1.DataSource = QUsuarios.Usuarios();
            comboBox1.DisplayMember = "Usuario";
            comboBox1.ValueMember = "Codigo_Usuario";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadProductos Producto = new EntidadProductos();
            Producto.Nombre = textBox1.Text;
            Producto.Precio = decimal.Parse(textBox2.Text);
            Producto.Existencia = int.Parse(textBox3.Text);
            Producto.Codigo_Usuario = int.Parse(comboBox1.SelectedValue.ToString());
            QuerysProductos qproducto =new QuerysProductos();
            qproducto.insertarProducto(Producto);
            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = 0;
            MessageBox.Show("Producto Agregado, Consulte", "Cuadro Informativo");
        }
    }
}
