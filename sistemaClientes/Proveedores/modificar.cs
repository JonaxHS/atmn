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
    public partial class modificar : Form
    {
        
        BindingSource bs = new BindingSource();
        public modificar()
        {
            InitializeComponent();
        }
        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();
            DataSet ds = bus.recibir("select * from visitaproveedor where " + "FECHA" + "='" + dateTimePicker1.Text + "'");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
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
            this.dataGridView1.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }
        
        private void Modificar_Load(object sender, EventArgs e)
        {

            
            cargardatos();
            txtfolio.DataBindings.Add("Text", bs, "FOLIO");
            txtfecha.DataBindings.Add("Text", bs, "FECHA", true, DataSourceUpdateMode.OnPropertyChanged, null, "yyyy-MM-dd");
            txthoraentrada.DataBindings.Add("Text", bs, "HORA ENTRADA");
            txthorasalida.DataBindings.Add("Text", bs, "HORA SALIDA");
            txtempresa.DataBindings.Add("Text", bs, "EMPRESA");
            txtrfc.DataBindings.Add("Text", bs, "RFC");
            txtnombrevisi.DataBindings.Add("Text", bs, "NOMBRE DEL VISITANTE");
            txtpvista.DataBindings.Add("Text", bs, "PERSONA QUE VISITA");
            txtarea.DataBindings.Add("Text", bs, "AREA");


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            buscardatos();
                
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


                x.enviar("update visitaproveedor set [HORA ENTRADA]='" + horaentrada + "',FECHA='" + Fecha + "', [HORA SALIDA]='" + horasalida + "', EMPRESA='" + Empresa + "', RFC='" + rfc + "', [NOMBRE DEL VISITANTE]='" + Nombrevis + "', [PERSONA QUE VISITA]='" + Pvisita + "', AREA='" + area + "' where FOLIO='" + Folio + "'");
                cargardatos();
                lbagregado.Visible = true;
                timer1.Start();
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

        private void txtci_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthorasalida.Text = DateTime.Now.ToString("hh:mm:ss");
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


                x.enviar("update visitaproveedor set [HORA ENTRADA]='" + horaentrada + "',FECHA='" + Fecha + "', [HORA SALIDA]='" + horasalida + "', EMPRESA='" + Empresa + "', RFC='" + rfc + "', [NOMBRE DEL VISITANTE]='" + Nombrevis + "', [PERSONA QUE VISITA]='" + Pvisita + "', AREA='" + area + "' where FOLIO='" + Folio + "'");
                cargardatos();
                lbagregado.Visible = true;
                timer1.Start();
            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
        }
    }
}
