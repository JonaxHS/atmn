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
using System.IO;

namespace SistemaSeguridad
{
	public partial class Facturas : Form
	{
        
        String bandera="";
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

        public Facturas()
		{
			InitializeComponent();
			
		}
        public Facturas(string text)
        {
            InitializeComponent();
            userlogin.Text = text;
        }
        
        private void Form1_Load(object sender, EventArgs e)
		{
            
            cargardatos();
            
        }
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from facturas");
            bs.DataSource = ds.Tables[0];
            DataView view = ds.Tables[0].DefaultView;//Ordena registros
            view.Sort = "FECHA DESC";
            dataGridView1.DataSource = view;//Termina ordenar
            dataGridView1.DataSource = bs;
            this.dataGridView1.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
           
            


        }

        private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			
			Color red1 = Color.FromArgb(128, 0, 0);
			button1.BackColor = red1;
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			button1.BackColor = Color.Transparent;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Button2_MouseEnter(object sender, EventArgs e)
		{
			Color white1 = Color.FromArgb(240, 255, 255);
			button2.BackColor = white1;
		}

		private void Button2_MouseLeave(object sender, EventArgs e)
		{
			button2.BackColor = Color.Transparent;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
            string user = userlogin.Text;
            agregarFac fact = new agregarFac(user);
            bandera = "agregar";
            bteliminar.BackColor = Color.Transparent;
            btmodificar.BackColor = Color.Transparent;
            btactualizar.BackColor = Color.Transparent;
            abrirformhijo(new agregarFac(user));
            
            
        }

		private void Button3_MouseEnter(object sender, EventArgs e)
		{
			Color purple1 = Color.FromArgb(24, 113, 14);
			btinsertar.BackColor = purple1;
		}

		private void Button3_MouseLeave(object sender, EventArgs e)
		{
           if(bandera!="agregar")
			btinsertar.BackColor = Color.Transparent;
            
        }

		private void Button4_MouseEnter(object sender, EventArgs e)
		{
			Color purple1 = Color.FromArgb(24, 113, 14);
			bteliminar.BackColor = purple1;
		}

		private void Button4_MouseLeave(object sender, EventArgs e)
		{
            if(bandera!="eliminar")
            bteliminar.BackColor = Color.Transparent;
		}

		private void Button5_MouseEnter(object sender, EventArgs e)
		{
			Color purple1 = Color.FromArgb(24, 113, 14);
			btmodificar.BackColor = purple1;
		}

		private void Button5_MouseLeave(object sender, EventArgs e)
		{
            if (bandera != "modificar")
                btmodificar.BackColor = Color.Transparent;
		}

		private void Button6_MouseEnter(object sender, EventArgs e)
		{
			Color purple1 = Color.FromArgb(24, 113, 14);
			btactualizar.BackColor = purple1;

		}

		private void Button6_MouseLeave(object sender, EventArgs e)
		{
            if(bandera!="actualizar")
			btactualizar.BackColor = Color.Transparent;
		}

        
        
        private void MenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado Por Jonathan Vieras Camacho","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        

        private void abrirformhijo(object formhijo)
        {
            if(this.panelContenedor.Controls.Count>0)
            this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

       

        private void Button6_Click_1(object sender, EventArgs e)
        {
            bandera = "actualizar";
            btinsertar.BackColor = Color.Transparent;
            bteliminar.BackColor = Color.Transparent;
            btmodificar.BackColor = Color.Transparent;
            abrirformhijo(new mostrarFac());
           
        }

     

        private void Button4_Click_1(object sender, EventArgs e)
        {
            bandera = "eliminar";
            btinsertar.BackColor = Color.Transparent;
           
            btmodificar.BackColor = Color.Transparent;
            btactualizar.BackColor = Color.Transparent;
            
            
            abrirformhijo(new eliminarFac());
           
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            bandera = "modificar";
            btinsertar.BackColor = Color.Transparent;
            bteliminar.BackColor = Color.Transparent;
           
            btactualizar.BackColor = Color.Transparent;
            
            abrirformhijo(new modificarFac());
           
        }


    }
}
