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
    public partial class modificarMov : Form
    {
        
        BindingSource bs = new BindingSource();
        public modificarMov()
        {
            InitializeComponent();
        }
        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();
            DataSet ds = bus.recibir("select * from movimientos where " + "Fecha" + "='" + dateTimePicker1.Text + "'");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
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
        
        private void Modificar_Load(object sender, EventArgs e)
        {
            

            cargardatos();
            txtci.DataBindings.Add("Text", bs, "FECHA", true, DataSourceUpdateMode.OnPropertyChanged, null, "yyyy-MM-dd");
            txtnombres.DataBindings.Add("Text", bs, "Hora");
            txtapellidop.DataBindings.Add("Text", bs, "Descripcion");
            txtfolio.DataBindings.Add("Text", bs, "Folio");


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
                String fecha = txtci.Text;
                String hora = txtnombres.Text;
                String Descripcion = txtapellidop.Text;
                String Folio = txtfolio.Text;


                x.enviar("update movimientos set Descripcion='" + Descripcion + "', Fecha='" + fecha + "', Hora='" + hora + "' where Folio='" + Folio + "'");
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

    

        private void modificarMov_Load(object sender, EventArgs e)
        {

        }
    }
}
