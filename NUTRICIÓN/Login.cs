using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using SqlClient para conexión a base de datos (paquete)
using System.Data.SqlClient;

namespace NUTRICIÓN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /*
            Creamos un objeto de tipo SqlConnection y a la Clase SqlConnection le pasamos el string 
        */
        SqlConnection conexion = new SqlConnection(@"server=(localdb)\Servidor;database=nutricion;integrated security = true");

        private void ingresar_Click(object sender, EventArgs e)
        {
            // Abrir conexión a base de datos
            conexion.Open();

            try
            {
                SqlCommand com = new SqlCommand("SELECT password FROM usuarios WHERE usuario = @usuario AND estado = @estado", conexion);
                com.Parameters.AddWithValue("usuario", usuario.Text);
                com.Parameters.AddWithValue("estado", 1);
                SqlDataReader response = com.ExecuteReader();

                if (response.Read())
                {
                    if (password.Text.Equals(response["password"]))
                    {
                        Inicio view = new Inicio();
                        view.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Contraseña incorrectos");
                    }
                } else
                {
                    MessageBox.Show("Usuario incorrectos");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error en la base de datos");
            }

            // Cerrar conexión a base de datos
            conexion.Close();
            
        }

        public Boolean LoginValidate(String usuario, String password)
        {
            conexion.Open();

            try
            {
                SqlCommand com = new SqlCommand("SELECT password FROM usuarios WHERE usuario = @usuario AND estado = @estado", conexion);
                com.Parameters.AddWithValue("usuario", usuario);
                com.Parameters.AddWithValue("estado", 1);
                SqlDataReader response = com.ExecuteReader();

                if (response.Read())
                {
                    if (password.Equals(response["password"]))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

            // Cerrar conexión a base de datos
            conexion.Close();
            return false;

        }
    }
}
