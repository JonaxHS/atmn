using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace SistemaSeguridad
{
    public partial class eliminar : Form
    {
        BindingSource bs = new BindingSource();
        public eliminar()
        {
            InitializeComponent();
        }


        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from visitaproveedor");
            DataView view = ds.Tables[0].DefaultView;//Ordena registros
            view.Sort = "FECHA DESC, HORA ENTRADA DESC";
            dataGridView2.DataSource = view;//Termina ordenar
            bs.DataSource = ds.Tables[0];
            dataGridView2.DataSource = bs;
            this.dataGridView2.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();

            
                DataSet ds = bus.recibir("select * from visitaproveedor where " + "FECHA" + "='" + dateTimePicker1.Text + "'  ");
                cargardatos();
                bs.DataSource = ds.Tables[0];
                dataGridView2.DataSource = bs;
            
            
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
           cargardatos();


           txtBorrar.DataBindings.Add("Text", bs, "FOLIO");
           dateTimePicker1.DataBindings.Add("Text", bs, "FECHA");

        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                buscardatos();
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


        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                BasedeDatos x = new BasedeDatos();

                x.enviar("delete from visitaproveedor where " + "FOLIO" + "='" + txtBorrar.Text + "'");
                lbagregado.Visible = true;
                cargardatos();
                timer1.Start();

            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
        }
        //Exportar en excel
        public void exportaraexcel()
        {

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }
        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.Red;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportaraexcel();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
