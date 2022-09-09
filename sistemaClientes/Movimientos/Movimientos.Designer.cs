namespace SistemaSeguridad
{
    partial class Movimientos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimientos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btactualizar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btinsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userlogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(215, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 43);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bitacora de movimientos.";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.dataGridView1);
            this.panelContenedor.Location = new System.Drawing.Point(9, 44);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1091, 442);
            this.panelContenedor.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1500;
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.Transparent;
            this.btactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btactualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Image = global::SistemaSeguridad.Properties.Resources.recargar;
            this.btactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btactualizar.Location = new System.Drawing.Point(564, 509);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(204, 79);
            this.btactualizar.TabIndex = 5;
            this.btactualizar.Text = "Recargar";
            this.btactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btactualizar, "Muestra los datos actualizados.");
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.Button6_Click_1);
            this.btactualizar.MouseEnter += new System.EventHandler(this.Button6_MouseEnter);
            this.btactualizar.MouseLeave += new System.EventHandler(this.Button6_MouseLeave);
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmodificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.Color.White;
            this.btmodificar.Image = global::SistemaSeguridad.Properties.Resources.editar;
            this.btmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmodificar.Location = new System.Drawing.Point(360, 509);
            this.btmodificar.Margin = new System.Windows.Forms.Padding(0);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(204, 79);
            this.btmodificar.TabIndex = 4;
            this.btmodificar.Text = "Editar Movimiento";
            this.btmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btmodificar, "Modifica los Movimientos.");
            this.btmodificar.UseVisualStyleBackColor = false;
            this.btmodificar.Click += new System.EventHandler(this.Button5_Click_1);
            this.btmodificar.MouseEnter += new System.EventHandler(this.Button5_MouseEnter);
            this.btmodificar.MouseLeave += new System.EventHandler(this.Button5_MouseLeave);
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.Red;
            this.bteliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bteliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bteliminar.FlatAppearance.BorderSize = 0;
            this.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Image = global::SistemaSeguridad.Properties.Resources.basura;
            this.bteliminar.Location = new System.Drawing.Point(156, 509);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(0);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(204, 79);
            this.bteliminar.TabIndex = 3;
            this.bteliminar.Text = "Eliminar Movimientos";
            this.bteliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bteliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bteliminar, "Elimina a un Movimiento seleccionado.");
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.Button4_Click_1);
            this.bteliminar.MouseEnter += new System.EventHandler(this.Button4_MouseEnter);
            this.bteliminar.MouseLeave += new System.EventHandler(this.Button4_MouseLeave);
            // 
            // btinsertar
            // 
            this.btinsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btinsertar.BackColor = System.Drawing.Color.Transparent;
            this.btinsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btinsertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btinsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinsertar.ForeColor = System.Drawing.Color.White;
            this.btinsertar.Image = global::SistemaSeguridad.Properties.Resources.add_location;
            this.btinsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btinsertar.Location = new System.Drawing.Point(768, 509);
            this.btinsertar.Margin = new System.Windows.Forms.Padding(0);
            this.btinsertar.Name = "btinsertar";
            this.btinsertar.Size = new System.Drawing.Size(204, 79);
            this.btinsertar.TabIndex = 2;
            this.btinsertar.Text = "Agregar Movimiento";
            this.btinsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btinsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btinsertar, "Agrega un Movimiento nuevo.");
            this.btinsertar.UseVisualStyleBackColor = false;
            this.btinsertar.Click += new System.EventHandler(this.Button3_Click);
            this.btinsertar.MouseEnter += new System.EventHandler(this.Button3_MouseEnter);
            this.btinsertar.MouseLeave += new System.EventHandler(this.Button3_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SistemaSeguridad.Properties.Resources.policeman;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::SistemaSeguridad.Properties.Resources.z;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(1020, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 42);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::SistemaSeguridad.Properties.Resources.ex;
            this.button1.Location = new System.Drawing.Point(1058, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            // 
            // userlogin
            // 
            this.userlogin.AutoSize = true;
            this.userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlogin.ForeColor = System.Drawing.Color.Red;
            this.userlogin.Location = new System.Drawing.Point(12, 546);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(0, 24);
            this.userlogin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Logeado como: ";
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.userlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btinsertar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora de Movimientos.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btinsertar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label userlogin;
        private System.Windows.Forms.Label label2;
    }
}

