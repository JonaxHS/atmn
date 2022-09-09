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
using System.Configuration;
using System.Data.SqlClient;
using SistemaSeguridad.Properties;

namespace SistemaSeguridad
{
    public partial class InicioSesion : Form
    {
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
        public InicioSesion()
        {
            InitializeComponent();
        }
        public static string obtener()
        {
            return Settings.Default.ATMICHConnectionString;
        }
        
        public void logins()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(obtener());
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios WHERE Usuario='" + txtuser.Text + "' AND Contraseña='" + txtpass.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            int x = 0;
                            progressBar1.Visible = true;
                            progressBar1.Minimum = 1;
                            progressBar1.Maximum = 1000000;
                            progressBar1.Value = 1;
                            progressBar1.Step = 1;
                            for (x = 1; x <= 1000000; x++)
                            {
                                progressBar1.PerformStep();
                            }
                            MessageBox.Show("Bienvenido " + txtuser.Text + "");
                            /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                            string user = txtuser.Text;
                            Inicio userlogin = new Inicio(user);
                            userlogin.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario " + txtuser.Text + " o contraseña no validos","Credenciales no validas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            logins();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

       

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado Por Jonathan Vieras Camacho", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
