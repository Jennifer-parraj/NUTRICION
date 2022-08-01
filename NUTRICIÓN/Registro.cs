using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace NUTRICIÓN
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\Servidor;database=nutricion;integrated security = true");

        private void registrar_Click(object sender, EventArgs e)
        {
            String txtNombre = nombre.Text;
            String txtCorreo = correo.Text;
            String txtUsuario = usuario.Text;
            String txtPassword = password.Text;
            String txtRepPassword = reppassword.Text;

            // && = and
            // || = or
            if (!String.IsNullOrEmpty(txtNombre) || !String.IsNullOrEmpty(txtCorreo) || !String.IsNullOrEmpty(txtUsuario) || !String.IsNullOrEmpty(txtPassword) || !String.IsNullOrEmpty(txtRepPassword))
            {
                if (IsValidEmail(txtCorreo))
                {
                    if (IsValidPassword(txtPassword, txtRepPassword))
                    {
                        if (registrarUsuario(txtNombre, txtCorreo, txtUsuario, txtPassword))
                        {
                            Login login = new Login();

                            if (login.LoginValidate(txtUsuario, txtPassword))
                            {
                                Inicio inicio = new Inicio();
                                inicio.Show();
                                this.Hide();
                            }
                        }
                        else
                            MessageBox.Show("Error al insertar el usuario");
                    }
                    else
                        MessageBox.Show("La contraseña no pasó las validaciones");
                }
                else
                    MessageBox.Show("El correo no es valido");
            }
            else
                MessageBox.Show("Todos los campos son obligatorios");
        }

        private Boolean IsValidPassword(String password, String rep_passqord)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-Z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            if (!letras.IsMatch(password))
                return false;

            if (!numeros.IsMatch(password))
                return false;

            if (!caracEsp.IsMatch(password))
                return false;

            if (password.Length < 8)
                return false;

            if (!password.Equals(rep_passqord))
                return false;

            return true;
        }

        private Boolean IsValidEmail(String email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            } catch (Exception ex)
            {
                return false;
            }
        }

        private Boolean registrarUsuario(String nombre, String correo, String usuario, String password)
        {
            conexion.Open();

            SqlCommand comm = new SqlCommand("INSERT INTO Usuarios(nombre_completo, correo, usuario, password) VALUES(@nombre, @correo, @usuario, @password)", conexion);
            comm.Parameters.AddWithValue("@nombre", nombre);
            comm.Parameters.AddWithValue("@correo", correo);
            comm.Parameters.AddWithValue("@usuario", usuario);
            comm.Parameters.AddWithValue("@password", password);

            try
            {
                comm.ExecuteNonQuery();
                return true;
            } catch
            {
                return false;
            }

            conexion.Close();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
