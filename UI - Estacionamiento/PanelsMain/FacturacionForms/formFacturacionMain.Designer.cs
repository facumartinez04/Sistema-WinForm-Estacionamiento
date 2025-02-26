namespace UI___Estacionamiento.PanelsMain.FacturacionForms
{
    partial class formFacturacionMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.gboxdate = new System.Windows.Forms.GroupBox();
            this.lbldesde = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.lblhasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gboxpatente = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblIngresarPatente = new System.Windows.Forms.Label();
            this.btnBuscarPatente = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.gboxdate.SuspendLayout();
            this.gboxpatente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrar.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.cerrar.Location = new System.Drawing.Point(837, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(29, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 188);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(842, 347);
            this.dgvFacturas.TabIndex = 1;
            // 
            // gboxdate
            // 
            this.gboxdate.Controls.Add(this.lbldesde);
            this.gboxdate.Controls.Add(this.btnBuscarFecha);
            this.gboxdate.Controls.Add(this.lblhasta);
            this.gboxdate.Controls.Add(this.dtpHasta);
            this.gboxdate.Controls.Add(this.dtpDesde);
            this.gboxdate.Location = new System.Drawing.Point(344, 55);
            this.gboxdate.Name = "gboxdate";
            this.gboxdate.Size = new System.Drawing.Size(403, 127);
            this.gboxdate.TabIndex = 4;
            this.gboxdate.TabStop = false;
            this.gboxdate.Text = "Buscar por fechas";
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesde.ForeColor = System.Drawing.Color.Black;
            this.lbldesde.Location = new System.Drawing.Point(2, 33);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(59, 20);
            this.lbldesde.TabIndex = 14;
            this.lbldesde.Text = "DESDE:";
            this.lbldesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Location = new System.Drawing.Point(293, 45);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(86, 31);
            this.btnBuscarFecha.TabIndex = 3;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhasta.ForeColor = System.Drawing.Color.Black;
            this.lblhasta.Location = new System.Drawing.Point(156, 33);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(62, 20);
            this.lblhasta.TabIndex = 13;
            this.lblhasta.Text = "HASTA:";
            this.lblhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            this.dtpHasta.Location = new System.Drawing.Point(156, 56);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(131, 20);
            this.dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            this.dtpDesde.Location = new System.Drawing.Point(6, 56);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(131, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // gboxpatente
            // 
            this.gboxpatente.Controls.Add(this.txtPatente);
            this.gboxpatente.Controls.Add(this.lblIngresarPatente);
            this.gboxpatente.Controls.Add(this.btnBuscarPatente);
            this.gboxpatente.Location = new System.Drawing.Point(12, 55);
            this.gboxpatente.Name = "gboxpatente";
            this.gboxpatente.Size = new System.Drawing.Size(316, 127);
            this.gboxpatente.TabIndex = 3;
            this.gboxpatente.TabStop = false;
            this.gboxpatente.Text = "Buscar por patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPatente.Location = new System.Drawing.Point(6, 56);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(177, 29);
            this.txtPatente.TabIndex = 2;
            // 
            // lblIngresarPatente
            // 
            this.lblIngresarPatente.AutoSize = true;
            this.lblIngresarPatente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarPatente.ForeColor = System.Drawing.Color.Black;
            this.lblIngresarPatente.Location = new System.Drawing.Point(6, 33);
            this.lblIngresarPatente.Name = "lblIngresarPatente";
            this.lblIngresarPatente.Size = new System.Drawing.Size(169, 20);
            this.lblIngresarPatente.TabIndex = 14;
            this.lblIngresarPatente.Text = "INGRESA LA PATENTE:";
            this.lblIngresarPatente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarPatente
            // 
            this.btnBuscarPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnBuscarPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPatente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPatente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPatente.Location = new System.Drawing.Point(189, 56);
            this.btnBuscarPatente.Name = "btnBuscarPatente";
            this.btnBuscarPatente.Size = new System.Drawing.Size(86, 29);
            this.btnBuscarPatente.TabIndex = 1;
            this.btnBuscarPatente.Text = "Buscar";
            this.btnBuscarPatente.UseVisualStyleBackColor = false;
            this.btnBuscarPatente.Click += new System.EventHandler(this.btnBuscarPatente_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(323, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15);
            this.btnClose.Size = new System.Drawing.Size(208, 52);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // formFacturacionMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(866, 612);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxdate);
            this.Controls.Add(this.gboxpatente);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formFacturacionMain";
            this.Load += new System.EventHandler(this.formFacturacionMain_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.gboxdate.ResumeLayout(false);
            this.gboxdate.PerformLayout();
            this.gboxpatente.ResumeLayout(false);
            this.gboxpatente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ingresadoHace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.GroupBox gboxdate;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gboxpatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblIngresarPatente;
        private System.Windows.Forms.Button btnBuscarPatente;
        private System.Windows.Forms.Button btnClose;
    }
}