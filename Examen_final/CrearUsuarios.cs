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
    public partial class CrearUsuarios : Form
    {
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadUsuarios usuario= new EntidadUsuarios();
            QuerysUsuarios cusuario = new QuerysUsuarios();
            usuario.Usuario=textBox1.Text;
            usuario.Nombre=textBox2.Text;
            cusuario.insertarUser(usuario);
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Usuario Agregado", "Cuadro Informativo");
        }
    }
}
