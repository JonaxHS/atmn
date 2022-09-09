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
    
    public partial class agregarMov : Form
	{
        String bandera = "";
        BindingSource bs = new BindingSource();
        public agregarMov()
		{
			InitializeComponent();
		}
        public agregarMov(string text)
        {
            InitializeComponent();
            txtguardia.Text = text;
        }

        private void Recargar()
        {
            Random rnd = new Random();

            txtfolio.Text = "MV-" + Convert.ToString(rnd.Next(0, 10000000)) + "";
            bandera = "NUEVO";
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txthora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtdescripcion.Text = "";
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtfolio.Text = "MV-" + Convert.ToString(rnd.Next(0, 10000000)) + "";
            bandera = "NUEVO";
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txthora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtdescripcion.Text = "";
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                BasedeDatos x = new BasedeDatos();
                String FOLIO = txtfolio.Text;
                String FECHA = txtfecha.Text;
                String HORA = txthora.Text;
                String DESCRIPCION = txtdescripcion.Text;
                String GUARDIA = txtguardia.Text;

                if (bandera == "NUEVO")
                {
                    x.enviar("insert into movimientos values ('" +
                        FOLIO + "','" + FECHA + "','" + HORA + "','" + DESCRIPCION + "','" + GUARDIA + "')");
                    lbagregado.Visible = true;
                    timer1.Start();
                }
                   
            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
            Recargar();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txthora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtdescripcion.Text = "";
           
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

        private void txthora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
