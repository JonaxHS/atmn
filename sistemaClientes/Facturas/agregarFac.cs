using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSeguridad
{
    
    public partial class agregarFac : Form
	{
        String bandera = "";
        BindingSource bs = new BindingSource();
       

        public agregarFac()
		{
			InitializeComponent();
		}

        public agregarFac(string text)
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
        }
        private void Recargar()
        {
            Random rnd = new Random();
            txtfolio.Text = "FA-" + Convert.ToString(rnd.Next(0, 10000000)) + "";
            bandera = "NUEVO";
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtfactura.Text = "";
            txtempresa.Text = "";
            txtrfc.Text = "";
            


        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtfolio.Text = "FA-" + Convert.ToString(rnd.Next(0, 10000000)) + "";
            cargardatos();
            dataGridView1.Visible = false;
            bandera = "NUEVO";
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtfactura.Text = "";
            txtempresa.Text = "";
            txtrfc.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                BasedeDatos x = new BasedeDatos();
                String FOLIO = txtfolio.Text;
                String FACTURA = txtfactura.Text;
                String FECHA = txtfecha.Text;
                String EMPRESA = txtempresa.Text;
                String RFC = txtrfc.Text;
                String GUARDIA = txtguardia.Text;
                


                if (bandera == "NUEVO")
                {
                    x.enviar("insert into facturas values ('" +
                        FOLIO + "','" + FACTURA + "','" + FECHA + "','" + EMPRESA + "','" + RFC + "','" + GUARDIA + "')");
                    lbagregado.Visible = true;
                    timer1.Start();
                    Recargar();
                }
                   
            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
