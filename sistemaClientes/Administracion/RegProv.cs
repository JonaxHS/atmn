using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SistemaSeguridad
{
    public partial class RegProv : Form
    {
        String bandera = "";
        BindingSource bs = new BindingSource();
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion
        public RegProv()
        {
            InitializeComponent();
        }
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from datosproveedores");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }

        private void AgProvedores_Load(object sender, EventArgs e)
        {
            bandera = "NUEVO";
            cargardatos();
            txtrfc.DataBindings.Add("Text", bs, "RFC");
            txtempresa.DataBindings.Add("Text", bs, "EMPRESA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BasedeDatos x = new BasedeDatos();
                String EMPRESA = txtempresa.Text;
                String RFC = txtrfc.Text;

                if (bandera == "NUEVO")
                {
                    x.enviar("insert into datosproveedores values ('" + EMPRESA + "','" + RFC + "')");
                    lbagregado.Visible = true;
                    timer1.Start();
                    cargardatos();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BasedeDatos x = new BasedeDatos();

                x.enviar("delete from datosproveedores where " + "RFC" + "='" + txtrfc.Text + "'");
                lbagregado.Visible = true;
                timer1.Start();
                cargardatos();

            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
        }
        //Exportar en excel
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtempresa.Text = "";
            txtrfc.Text = "";
        }
    }
    }
