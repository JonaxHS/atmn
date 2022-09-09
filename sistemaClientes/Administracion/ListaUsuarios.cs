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
    public partial class ListaUsuarios : Form
    {
        BindingSource bs = new BindingSource();
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from usuarios");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }
    }
}
