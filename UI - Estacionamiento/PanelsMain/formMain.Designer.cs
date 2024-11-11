namespace UI___Estacionamiento.PanelsMain
{
    partial class formMain
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
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnTarifas = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMetodosPago);
            this.panel1.Controls.Add(this.btnTarifas);
            this.panel1.Controls.Add(this.btnFacturacion);
            this.panel1.Controls.Add(this.btnIngresos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetodosPago.Location = new System.Drawing.Point(0, 201);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(216, 67);
            this.btnMetodosPago.TabIndex = 3;
            this.btnMetodosPago.Text = "Metodos de Pago";
            this.btnMetodosPago.UseVisualStyleBackColor = true;
            // 
            // btnTarifas
            // 
            this.btnTarifas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarifas.Location = new System.Drawing.Point(0, 134);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(216, 67);
            this.btnTarifas.TabIndex = 2;
            this.btnTarifas.Text = "Tarifas";
            this.btnTarifas.UseVisualStyleBackColor = true;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 67);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(216, 67);
            this.btnFacturacion.TabIndex = 1;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            this.btnIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresos.Location = new System.Drawing.Point(0, 0);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(216, 67);
            this.btnIngresos.TabIndex = 0;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.panel1);
            this.Name = "formMain";
            this.Text = "formMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnTarifas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnIngresos;
    }
}