namespace UI___Estacionamiento.PanelsMain.HistorialForms
{
    partial class formHistorialMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbseachpatente = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnBuscarPatente = new System.Windows.Forms.Button();
            this.gbsearchfechas = new System.Windows.Forms.GroupBox();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.lblhasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lbldesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPatente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbseachpatente.SuspendLayout();
            this.gbsearchfechas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbseachpatente
            // 
            this.gbseachpatente.Controls.Add(this.lblPatente);
            this.gbseachpatente.Controls.Add(this.txtPatente);
            this.gbseachpatente.Controls.Add(this.btnBuscarPatente);
            this.gbseachpatente.Location = new System.Drawing.Point(13, 50);
            this.gbseachpatente.Name = "gbseachpatente";
            this.gbseachpatente.Size = new System.Drawing.Size(316, 127);
            this.gbseachpatente.TabIndex = 1;
            this.gbseachpatente.TabStop = false;
            this.gbseachpatente.Text = "Buscar por patente";
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
            // gbsearchfechas
            // 
            this.gbsearchfechas.Controls.Add(this.btnBuscarFecha);
            this.gbsearchfechas.Controls.Add(this.lblhasta);
            this.gbsearchfechas.Controls.Add(this.dtpHasta);
            this.gbsearchfechas.Controls.Add(this.lbldesde);
            this.gbsearchfechas.Controls.Add(this.dtpDesde);
            this.gbsearchfechas.Location = new System.Drawing.Point(345, 50);
            this.gbsearchfechas.Name = "gbsearchfechas";
            this.gbsearchfechas.Size = new System.Drawing.Size(403, 127);
            this.gbsearchfechas.TabIndex = 2;
            this.gbsearchfechas.TabStop = false;
            this.gbsearchfechas.Text = "Buscar por fechas";
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
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesde.ForeColor = System.Drawing.Color.Black;
            this.lbldesde.Location = new System.Drawing.Point(6, 33);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(59, 20);
            this.lbldesde.TabIndex = 11;
            this.lbldesde.Text = "DESDE:";
            this.lbldesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            this.dtpDesde.Location = new System.Drawing.Point(6, 56);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(131, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 30);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formHistorialMain_MouseDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(1006, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(394, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15);
            this.btnClose.Size = new System.Drawing.Size(182, 52);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(2, 33);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(59, 20);
            this.lblPatente.TabIndex = 14;
            this.lblPatente.Text = "DESDE:";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHistorialMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1034, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbsearchfechas);
            this.Controls.Add(this.gbseachpatente);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHistorialMain";
            this.Text = "formHistorialMain";
            this.Load += new System.EventHandler(this.formHistorialMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formHistorialMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbseachpatente.ResumeLayout(false);
            this.gbseachpatente.PerformLayout();
            this.gbsearchfechas.ResumeLayout(false);
            this.gbsearchfechas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbseachpatente;
        private System.Windows.Forms.GroupBox gbsearchfechas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBuscarPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatente;
    }
}