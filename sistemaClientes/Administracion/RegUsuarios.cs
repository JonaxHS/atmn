using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSeguridad.Properties;

namespace SistemaSeguridad
{
    public partial class RegUsuarios : Form
    {
        String bandera = "";
        BindingSource bs = new BindingSource();
        public RegUsuarios()
        {
            InitializeComponent();
        }

        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from usuarios");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }

        private void RegUsuarios_Load(object sender, EventArgs e)
        {
            bandera = "NUEVO";
            cargardatos();
            txtNombre.DataBindings.Add("Text", bs, "usuario");
            txtContraseña.DataBindings.Add("Text", bs, "contraseña");
            txtFolio.DataBindings.Add("Text", bs, "Folio");
            ptbImagen.DataBindings.Add("Image", bs, "Imagen", true);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de guardar los datos?, verifica que el folio sea correcto, no se puede cambiar después.", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (bandera == "NUEVO")

                    BasedeDatos.EjecutarQuery("insert into usuarios (usuario,contraseña,Folio, Imagen)values('" + txtNombre.Text + "','" + txtContraseña.Text + "','" + txtFolio.Text + "',@Imagen)", ptbImagen.Image);
                cargardatos();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort)
            {
                return;
            }
            if (r == DialogResult.Cancel)
            {
                return;
            }

            ptbImagen.Image = Image.FromFile(examinar.FileName);
        }

        private void editar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de guardar los datos?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String Usuario = txtNombre.Text;
                String Contraseña = txtContraseña.Text;
                String Folio = txtFolio.Text;
                BasedeDatos.EjecutarQuery("update USUARIOS set contraseña='" + Contraseña + "', " +
                    "usuario='" + Usuario + "'," +
                    " Folio='" + Folio + "', " +
                    "Imagen= @Imagen " +
                    "where Folio='" + Folio + "'", ptbImagen.Image);
                cargardatos();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void txtBorrar_Click(object sender, EventArgs e)
        {
            BasedeDatos x = new BasedeDatos();

            x.enviar("delete from usuarios where " + "FOLIO" + "='" + txtFolio.Text + "'");
            cargardatos();
        }
        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();


            DataSet ds = bus.recibir("select * from usuarios where " + "Folio" + "='" + txtFolio.Text + "'  ");
            cargardatos();
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;


        }
        private void txtBuscar_Click(object sender, EventArgs e)
        {
            buscardatos();
        }

        private void AbrirLista_Click(object sender, EventArgs e)
        {
            ListaUsuarios Lista = new ListaUsuarios();
            Lista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtFolio.Text = "";
            ptbImagen.Image = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      

      

        private void btnMostrarpass_Click_1(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnMostrarpass.Visible = false;
            btnOcultarpass.Visible = true;
        }

        private void btnOcultarpass_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnMostrarpass.Visible = true;
            btnOcultarpass.Visible = false;

        }
    }
}
