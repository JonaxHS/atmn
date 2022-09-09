using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSeguridad
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegProv Provedores = new RegProv();
            Provedores.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegUsuarios Usuarios = new RegUsuarios();
            Usuarios.Show();
        }
    }
}
