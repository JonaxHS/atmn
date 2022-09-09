using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SistemaSeguridad

{
    public partial class Inicio : Form
    {

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
        public Inicio()
        {
            InitializeComponent();

        }
        public Inicio(string text)
        {
            InitializeComponent();
            userlogin.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userlogin.Text;
            Form1 fac = new Form1(user);
            fac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = userlogin.Text;
            Movimientos mov = new Movimientos(user);
            mov.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = userlogin.Text;
            Facturas fac = new Facturas(user);
            fac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginAdmin adm = new LoginAdmin();
            adm.Show();
           
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           label3.Text = DateTime.Now.ToLongDateString();
           label4.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InicioSesion cambiar = new InicioSesion();
            cambiar.Show();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego " + userlogin.Text + "");
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
