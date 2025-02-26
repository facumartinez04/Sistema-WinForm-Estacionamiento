namespace UI___Estacionamiento.PanelsMain.TarifaForms
{
    partial class formTarifasMain
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
            this.DBTarifasList = new System.Windows.Forms.DataGridView();
            this.gbTarifa = new System.Windows.Forms.GroupBox();
            this.lblanametarifa = new System.Windows.Forms.Label();
            this.txtNombreTarifa = new System.Windows.Forms.TextBox();
            this.btnAddEditTarifa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltarifas = new System.Windows.Forms.Label();
            this.txtMontoTarifa = new System.Windows.Forms.TextBox();
            this.gbMonto = new System.Windows.Forms.GroupBox();
            this.lblmontohora = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBTarifasList)).BeginInit();
            this.gbTarifa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbMonto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBTarifasList
            // 
            this.DBTarifasList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBTarifasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBTarifasList.Location = new System.Drawing.Point(424, 94);
            this.DBTarifasList.Name = "DBTarifasList";
            this.DBTarifasList.Size = new System.Drawing.Size(258, 304);
            this.DBTarifasList.TabIndex = 0;
            this.DBTarifasList.DoubleClick += new System.EventHandler(this.DBTarifasList_DoubleClick);
            // 
            // gbTarifa
            // 
            this.gbTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTarifa.Controls.Add(this.lblanametarifa);
            this.gbTarifa.Controls.Add(this.txtNombreTarifa);
            this.gbTarifa.Location = new System.Drawing.Point(22, 38);
            this.gbTarifa.Name = "gbTarifa";
            this.gbTarifa.Size = new System.Drawing.Size(261, 83);
            this.gbTarifa.TabIndex = 1;
            this.gbTarifa.TabStop = false;
            this.gbTarifa.Text = "Tarifa";
            // 
            // lblanametarifa
            // 
            this.lblanametarifa.AutoSize = true;
            this.lblanametarifa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanametarifa.ForeColor = System.Drawing.Color.Black;
            this.lblanametarifa.Location = new System.Drawing.Point(6, 20);
            this.lblanametarifa.Name = "lblanametarifa";
            this.lblanametarifa.Size = new System.Drawing.Size(180, 20);
            this.lblanametarifa.TabIndex = 10;
            this.lblanametarifa.Text = "NOMBRE DE LA TARIFA:";
            this.lblanametarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreTarifa
            // 
            this.txtNombreTarifa.Location = new System.Drawing.Point(6, 43);
            this.txtNombreTarifa.Name = "txtNombreTarifa";
            this.txtNombreTarifa.Size = new System.Drawing.Size(180, 20);
            this.txtNombreTarifa.TabIndex = 1;
            // 
            // btnAddEditTarifa
            // 
            this.btnAddEditTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnAddEditTarifa.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddEditTarifa.ForeColor = System.Drawing.Color.White;
            this.btnAddEditTarifa.Location = new System.Drawing.Point(22, 331);
            this.btnAddEditTarifa.Name = "btnAddEditTarifa";
            this.btnAddEditTarifa.Size = new System.Drawing.Size(373, 67);
            this.btnAddEditTarifa.TabIndex = 0;
            this.btnAddEditTarifa.Text = "Agregar";
            this.btnAddEditTarifa.UseVisualStyleBackColor = false;
            this.btnAddEditTarifa.Click += new System.EventHandler(this.btnAddEditTarifa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lbltarifas);
            this.panel1.Location = new System.Drawing.Point(424, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 38);
            this.panel1.TabIndex = 8;
            // 
            // lbltarifas
            // 
            this.lbltarifas.AutoSize = true;
            this.lbltarifas.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarifas.ForeColor = System.Drawing.Color.White;
            this.lbltarifas.Location = new System.Drawing.Point(11, 9);
            this.lbltarifas.Name = "lbltarifas";
            this.lbltarifas.Size = new System.Drawing.Size(55, 20);
            this.lbltarifas.TabIndex = 0;
            this.lbltarifas.Text = "Tarifas";
            this.lbltarifas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMontoTarifa
            // 
            this.txtMontoTarifa.Location = new System.Drawing.Point(10, 48);
            this.txtMontoTarifa.Name = "txtMontoTarifa";
            this.txtMontoTarifa.Size = new System.Drawing.Size(163, 20);
            this.txtMontoTarifa.TabIndex = 9;
            this.txtMontoTarifa.TextChanged += new System.EventHandler(this.txtMontoTarifa_TextChanged_1);
            // 
            // gbMonto
            // 
            this.gbMonto.Controls.Add(this.lblmontohora);
            this.gbMonto.Controls.Add(this.txtMontoTarifa);
            this.gbMonto.Location = new System.Drawing.Point(22, 149);
            this.gbMonto.Name = "gbMonto";
            this.gbMonto.Size = new System.Drawing.Size(261, 91);
            this.gbMonto.TabIndex = 11;
            this.gbMonto.TabStop = false;
            this.gbMonto.Text = "Monto";
            // 
            // lblmontohora
            // 
            this.lblmontohora.AutoSize = true;
            this.lblmontohora.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontohora.ForeColor = System.Drawing.Color.Black;
            this.lblmontohora.Location = new System.Drawing.Point(6, 25);
            this.lblmontohora.Name = "lblmontohora";
            this.lblmontohora.Size = new System.Drawing.Size(146, 20);
            this.lblmontohora.TabIndex = 11;
            this.lblmontohora.Text = "MONTO POR HORA";
            this.lblmontohora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(424, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15);
            this.btnClose.Size = new System.Drawing.Size(258, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 30);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formTarifasMain_MouseDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(686, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // formTarifasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(712, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbMonto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTarifa);
            this.Controls.Add(this.DBTarifasList);
            this.Controls.Add(this.btnAddEditTarifa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTarifasMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTarifasMain";
            this.Load += new System.EventHandler(this.formTarifasMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formTarifasMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DBTarifasList)).EndInit();
            this.gbTarifa.ResumeLayout(false);
            this.gbTarifa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMonto.ResumeLayout(false);
            this.gbMonto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBTarifasList;
        private System.Windows.Forms.GroupBox gbTarifa;
        private System.Windows.Forms.TextBox txtNombreTarifa;
        private System.Windows.Forms.Button btnAddEditTarifa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltarifas;
        private System.Windows.Forms.TextBox txtMontoTarifa;
        private System.Windows.Forms.Label lblanametarifa;
        private System.Windows.Forms.GroupBox gbMonto;
        private System.Windows.Forms.Label lblmontohora;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
    }
}