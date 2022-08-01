using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUTRICIÓN
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            Caracterizacion caracterizacion = new Caracterizacion();
            caracterizacion.Show();
            this.Close();
        }
    }
}
