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
    public partial class mostrar : Form
    {

        BindingSource bs = new BindingSource();
        public mostrar()
        {
            InitializeComponent();
        }
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from visitaproveedor");
            DataView view = ds.Tables[0].DefaultView;//Ordena registros
            view.Sort = "FECHA DESC, HORA ENTRADA DESC";
            dataGridView1.DataSource = view;//Termina ordenar
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";





        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

     

        private void mostrar_Load_1(object sender, EventArgs e)
        {

        }

       

        private void mostrar_Load_2(object sender, EventArgs e)
        {

        }
    }
}
