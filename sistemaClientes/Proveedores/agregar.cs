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
    
    public partial class agregar : Form
	{
        String bandera = "";
        BindingSource bs = new BindingSource();
       

        public agregar()
		{
			InitializeComponent();
		}

        public agregar(string text)
        {
            InitializeComponent();
            txtguardia.Text = text;
        }

        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from datosproveedores");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
            Random rnd = new Random();

            txtfolio.Text = "PV-" + Convert.ToString(rnd.Next(0, 10000000)) + "";
        }
        

        private void Agregar_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtfolio.Text = "PV-" + Convert.ToString(rnd.Next(0, 10000000)) +"";
            cargardatos();
            dataGridView1.Visible = false;
            bandera = "NUEVO";
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txthoraentrada.Text = DateTime.Now.ToString("hh:mm:ss");
            txthorasalida.Text = "";
            txtempresa.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                BasedeDatos x = new BasedeDatos();
                String Folio = txtfolio.Text;
                String Fecha = txtfecha.Text;
                String horaentrada = txthoraentrada.Text;
                String horasalida = txthorasalida.Text;
                String Empresa = txtempresa.Text;
                String rfc = txtrfc.Text;
                String Nombrevis = txtnombrevisi.Text;
                String Pvisita = txtpvista.Text;
                String area = txtarea.Text;
                String guardia = txtguardia.Text;

                if (bandera == "NUEVO")
                {
                    x.enviar("insert into visitaproveedor values ('" +
                        Folio + "','" + Fecha + "','" + horaentrada + "','" + horasalida + "','" + Empresa + "','" + rfc + "','" + Nombrevis + "','" + Pvisita + "','" + area + "','" + guardia + "')");
                    lbagregado.Visible = true;
                    timer1.Start();
                }
                   
            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
            cargardatos();
        }

      

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbtimer.Text += 1;
            if (lbtimer.Text == "01111111111111111111111111")
            {
                lbagregado.Visible = false;
                
                timer1.Stop();
                lbtimer.Text = "0";
               
            }
        }

        

        private void Timer2_Tick(object sender, EventArgs e)
        {
            lbtimer2.Text += 1;

            if (lbtimer2.Text == "0111111111111111111111111")
            {

                lberror.Visible = false;
                timer2.Stop();
                lbtimer2.Text = "0";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btlista.Visible = false;
            dataGridView1.Visible = true;
            txtempresa.DataBindings.Add("Text", bs, "EMPRESA");
            txtrfc.DataBindings.Add("Text", bs, "RFC");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
