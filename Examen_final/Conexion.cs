using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    public class Conexion
    {
        public Conexion()
        {

        }

        public string cadena()
        {

            string conectar = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\TOFI\\DESKTOP\\EXAMEN_FINAL\\EXAMEN_FINAL.MDF;Integrated Security=True";
            return conectar;

        }
    }
}
