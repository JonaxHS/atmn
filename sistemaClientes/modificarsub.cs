using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaClientes
{
    public partial class modificarsub : Form
    {
        modificar mod = new modificar();
        BindingSource bs = new BindingSource();
        public modificarsub()
        {
            InitializeComponent();
        }

        private void Txtapellidom_TextChanged(object sender, EventArgs e)
        {

        }

        
        public void cargardatos()
        {
            
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from empleados");
            bs.DataSource = ds.Tables[0];
            
        }
        modificar visualizar = new modificar();
        private void Modificarsub_Load(object sender, EventArgs e)
        {
            cargardatos();
            
            txtci.Enabled = false;
            
        }

        private void Txtci_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {

           
            BasedeDatos x = new BasedeDatos();
            String ci = txtci.Text;
            String nombres = txtnombres.Text;
            String apellidop = txtapellidop.Text;
            String apellidom = txtapellidom.Text;
            String cel = txtcel.Text;
            
            x.enviar("update empleados set NOMBRES='" + nombres + "', [APELLIDO PATERNO]='" + apellidop + "', [APELLIDO MATERNO]='" + apellidom + "', CELULAR='" + cel + "' where ci='" + ci + "'");
            MessageBox.Show("El cliente se edito correctamente", "Mensaje");
            
           
            
        }

       
    }
}
