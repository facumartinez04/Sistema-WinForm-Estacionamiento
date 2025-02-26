namespace UI___Estacionamiento.PanelsMain.VehiculoForms
{
    partial class formVehiculoMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.DBVehiculosList = new System.Windows.Forms.DataGridView();
            this.btnAddEditVehiculo = new System.Windows.Forms.Button();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gbPatente = new System.Windows.Forms.GroupBox();
            this.lblanamepatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBVehiculosList)).BeginInit();
            this.gbMarca.SuspendLayout();
            this.gbPatente.SuspendLayout();
            this.gbModelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 30);
            this.panel2.TabIndex = 18;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(416, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15);
            this.btnClose.Size = new System.Drawing.Size(373, 52);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lblVehiculos);
            this.panel1.Location = new System.Drawing.Point(416, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 38);
            this.panel1.TabIndex = 20;
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.Color.White;
            this.lblVehiculos.Location = new System.Drawing.Point(11, 9);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(75, 20);
            this.lblVehiculos.TabIndex = 0;
            this.lblVehiculos.Text = "Vehiculos";
            this.lblVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBVehiculosList
            // 
            this.DBVehiculosList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBVehiculosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBVehiculosList.Location = new System.Drawing.Point(416, 96);
            this.DBVehiculosList.Name = "DBVehiculosList";
            this.DBVehiculosList.Size = new System.Drawing.Size(373, 304);
            this.DBVehiculosList.TabIndex = 19;
            this.DBVehiculosList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBVehiculosList_CellContentClick);
            this.DBVehiculosList.DoubleClick += new System.EventHandler(this.DBVehiculosList_DoubleClick);
            // 
            // btnAddEditVehiculo
            // 
            this.btnAddEditVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnAddEditVehiculo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddEditVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAddEditVehiculo.Location = new System.Drawing.Point(12, 383);
            this.btnAddEditVehiculo.Name = "btnAddEditVehiculo";
            this.btnAddEditVehiculo.Size = new System.Drawing.Size(373, 67);
            this.btnAddEditVehiculo.TabIndex = 22;
            this.btnAddEditVehiculo.Text = "Agregar";
            this.btnAddEditVehiculo.UseVisualStyleBackColor = false;
            this.btnAddEditVehiculo.Click += new System.EventHandler(this.btnAddEditVehiculo_Click);
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.lblmarca);
            this.gbMarca.Controls.Add(this.txtMarca);
            this.gbMarca.Location = new System.Drawing.Point(12, 159);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(261, 91);
            this.gbMarca.TabIndex = 24;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.Color.Black;
            this.lblmarca.Location = new System.Drawing.Point(6, 25);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(68, 20);
            this.lblmarca.TabIndex = 11;
            this.lblmarca.Text = "MARCA:";
            this.lblmarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(10, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(163, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // gbPatente
            // 
            this.gbPatente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPatente.Controls.Add(this.lblanamepatente);
            this.gbPatente.Controls.Add(this.txtPatente);
            this.gbPatente.Location = new System.Drawing.Point(12, 59);
            this.gbPatente.Name = "gbPatente";
            this.gbPatente.Size = new System.Drawing.Size(261, 83);
            this.gbPatente.TabIndex = 23;
            this.gbPatente.TabStop = false;
            this.gbPatente.Text = "Patente";
            // 
            // lblanamepatente
            // 
            this.lblanamepatente.AutoSize = true;
            this.lblanamepatente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanamepatente.ForeColor = System.Drawing.Color.Black;
            this.lblanamepatente.Location = new System.Drawing.Point(6, 20);
            this.lblanamepatente.Name = "lblanamepatente";
            this.lblanamepatente.Size = new System.Drawing.Size(193, 20);
            this.lblanamepatente.TabIndex = 10;
            this.lblanamepatente.Text = "NUMERO DE LA PATENTE:";
            this.lblanamepatente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(10, 43);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(180, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.lblmodelo);
            this.gbModelo.Controls.Add(this.txtModelo);
            this.gbModelo.Location = new System.Drawing.Point(12, 269);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(261, 91);
            this.gbModelo.TabIndex = 25;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Modelo";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.ForeColor = System.Drawing.Color.Black;
            this.lblmodelo.Location = new System.Drawing.Point(6, 25);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(75, 20);
            this.lblmodelo.TabIndex = 11;
            this.lblmodelo.Text = "MODELO:";
            this.lblmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(10, 48);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(163, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(787, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // formVehiculoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbPatente);
            this.Controls.Add(this.btnAddEditVehiculo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DBVehiculosList);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVehiculoMain";
            this.Text = "formVehiculoMain";
            this.Load += new System.EventHandler(this.formVehiculoMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBVehiculosList)).EndInit();
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.gbPatente.ResumeLayout(false);
            this.gbPatente.PerformLayout();
            this.gbModelo.ResumeLayout(false);
            this.gbModelo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.DataGridView DBVehiculosList;
        private System.Windows.Forms.Button btnAddEditVehiculo;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox gbPatente;
        private System.Windows.Forms.Label lblanamepatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.TextBox txtModelo;
    }
}