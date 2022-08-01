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

namespace NUTRICIÓN
{
    public partial class Caracterizacion : Form
    {
        /*
           Creamos un objeto de tipo SqlConnection y a la Clase SqlConnection le pasamos el string 
       */
        SqlConnection conexion = new SqlConnection(@"server=(localdb)\Servidor;database=nutricion;integrated security = true");

        public Caracterizacion()
        {
            InitializeComponent();
        }

 

        private void caracterizacion_Load(object sender, EventArgs e)
        {

        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombres_Completos = txtBxNombreCompleto.Text;
            string Tipo_Identificacion = cmbBxTipoidentificacion.Text;
            string Numero_Identificacion = txtBxNumeroIdentificacion.Text.Trim();
            string Pais_Origen = cmbBxPPaisOrigen.Text;
            int Tiempo_Permanencia_meses = int.Parse(txtBxPermanencia.Text);
            string Genero = cmbBxGenero.Text;
            string Fecha_Nacimiento = dtTmPckrFechaNacimiento.Value.ToString();
            int Edad = int.Parse(txtBxEdad.Text);
            string Estado_Civil = cmbBxEstadoCivil.Text;
            int Numero_Hijos = int.Parse(txtBxNumeroHijos.Text);
            string Direccion_Residencia = txtBxDireccion.Text;
            string Barrio_Residencia = txtBxBarrio.Text;
            int Telefono_Contacto = int.Parse(txtBxTelefono.Text);
            string Ocupacion = cmbBxOcupacion.Text;
            string Nivel_escolaridad = cmbBxNivelEscolaridad.Text;
            string EPS = txtBxEps.Text;
            string Regimen = cmbBxRegimen.Text;
            string Email = txtBxEmail.Text;
            int Contacto_emergencia = int.Parse(txtBxContactoEmergencia.Text);
            string Antecedentes_Medicos = null;
            string Convenio = cmbBxConvenio.Text;
        }
        private Boolean registrarUsuario(String txtBxNombreCompleto, String cmbBxTipoidentificacion, String txtBxNumeroIdentificacion, String cmbBxPPaisOrigen, String txtBxPermanencia, String cmbBxGenero, String dtTmPckrFechaNacimiento, String txtBxEdad, String cmbBxEstadoCivil, String txtBxNumeroHijos, String txtBxDireccion, String txtBxBarrio, String txtBxTelefono, String cmbBxOcupacion, String cmbBxNivelEscolaridad, String txtBxEps, String cmbBxRegimen, String txtBxEmail, String txtBxContactoEmergencia, String cmbBxConvenio)
        {//Falta antecedentes medicos
            conexion.Open();

            SqlCommand comm = new SqlCommand("INSERT INTO afiliados(txtBxNombreCompleto, cmbBxTipoidentificacion, txtBxNumeroIdentificacion, cmbBxPPaisOrigen, txtBxPermanencia, cmbBxGenero, dtTmPckrFechaNacimiento, txtBxEdad, cmbBxEstadoCivil, txtBxNumeroHijos, txtBxDireccion, txtBxBarrio, txtBxTelefono, cmbBxOcupacion, cmbBxNivelEscolaridad, txtBxEps, cmbBxRegimen, txtBxEmail, txtBxContactoEmergencia, cmbBxConvenio) VALUES(@nombre_completo, @tipo_identificacion, @numero_identificacion, @pais_origen, @tiempo_permanencia, @genero, @fecha_nacimiento, @edad, @estado_civil, @numero_hijos, @direccion_residencia, @barrio_residencia, @telefono_contacto, @ocupacion, @nivel_escolaridad, @eps, @regimen, @email, @contacto_emergencia, @convenio)", conexion);
            comm.Parameters.AddWithValue("@nombre_completo", txtBxNombreCompleto);
            comm.Parameters.AddWithValue("@tipo_identificacion", cmbBxTipoidentificacion);
            comm.Parameters.AddWithValue("@numero_identificacion", txtBxNumeroIdentificacion);
            comm.Parameters.AddWithValue("@pais_origen", cmbBxPPaisOrigen);
            comm.Parameters.AddWithValue("@tiempo_permanencia", txtBxPermanencia);
            comm.Parameters.AddWithValue("@genero", cmbBxGenero);
            comm.Parameters.AddWithValue("@fecha_nacimiento", dtTmPckrFechaNacimiento);
            comm.Parameters.AddWithValue("@edad", txtBxEdad);
            comm.Parameters.AddWithValue("@estado_civil",cmbBxEstadoCivil);
            comm.Parameters.AddWithValue("@numero_hijos", txtBxNumeroHijos);
            comm.Parameters.AddWithValue("@direccion_residencia", txtBxDireccion);
            comm.Parameters.AddWithValue("@barrio_residencia", txtBxBarrio);
            comm.Parameters.AddWithValue("@telefono_contacto", txtBxTelefono);
            comm.Parameters.AddWithValue("@ocupacion", cmbBxOcupacion);
            comm.Parameters.AddWithValue("@nivel_escolaridad", cmbBxNivelEscolaridad);
            comm.Parameters.AddWithValue("@eps", txtBxEps);
            comm.Parameters.AddWithValue("@regimen", cmbBxRegimen);
            comm.Parameters.AddWithValue("@email", txtBxEmail);
            comm.Parameters.AddWithValue("@contacto_emergencia", txtBxContactoEmergencia);
            comm.Parameters.AddWithValue("@convenio", cmbBxConvenio);
       

            try
            {
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

            conexion.Close();
        }
    }
}
