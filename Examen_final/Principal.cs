using Examen_final.Properties;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProducto cproducto = new CrearProducto();
            panel1.Controls.Clear();
            cproducto.TopLevel = false;
            panel1.Controls.Add(cproducto);
            cproducto.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_y_borrar acproducto = new Actualizar_y_borrar();
            panel1.Controls.Clear();
            acproducto.TopLevel = false;
            panel1.Controls.Add(acproducto);
            acproducto.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProducto coproducto = new ConsultarProducto();
            panel1.Controls.Clear();
            coproducto.TopLevel = false;
            panel1.Controls.Add(coproducto);
            coproducto.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearUsuarios cusuario = new CrearUsuarios();
            panel1.Controls.Clear();
            cusuario.TopLevel = false;
            panel1.Controls.Add(cusuario);
            cusuario.Show();
        }
    }
}
