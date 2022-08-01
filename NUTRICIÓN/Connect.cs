using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NUTRICIÓN
{
    internal static class Connect
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static Object Conexion()
        {
            SqlConnection conn = new SqlConnection(@"server=(localdb)\Servidor;database=nutricion;integrated security = true");
            return conn;
        }
    }
}
