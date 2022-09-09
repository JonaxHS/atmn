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
    public partial class mostrarMov : Form
    {

        BindingSource bs = new BindingSource();
        public mostrarMov()
        {
            InitializeComponent();
        }
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from movimientos");
            bs.DataSource = ds.Tables[0];
            DataView view = ds.Tables[0].DefaultView;//Ordena registros
            view.Sort = "FECHA DESC";
            dataGridView1.DataSource = view;//Termina ordenar
            dataGridView1.DataSource = bs;
            this.dataGridView1.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
