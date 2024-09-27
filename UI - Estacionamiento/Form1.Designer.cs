namespace UI___Estacionamiento
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnTarifas = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panelContenedor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 675);
            this.panel1.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(242, 57);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1071, 612);
            this.panelContenedor.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1313, 55);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnMetodosPago);
            this.panel2.Controls.Add(this.btnFacturacion);
            this.panel2.Controls.Add(this.btnTarifas);
            this.panel2.Controls.Add(this.btnSalidas);
            this.panel2.Controls.Add(this.btnIngresos);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 668);
            this.panel2.TabIndex = 0;
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.FlatAppearance.BorderSize = 0;
            this.btnMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.btnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodosPago.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodosPago.ForeColor = System.Drawing.Color.White;
            this.btnMetodosPago.Location = new System.Drawing.Point(3, 293);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(239, 54);
            this.btnMetodosPago.TabIndex = 5;
            this.btnMetodosPago.Text = "METODOS DE PAGO";
            this.btnMetodosPago.UseVisualStyleBackColor = true;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Location = new System.Drawing.Point(3, 173);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(239, 54);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnTarifas
            // 
            this.btnTarifas.FlatAppearance.BorderSize = 0;
            this.btnTarifas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.btnTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifas.ForeColor = System.Drawing.Color.White;
            this.btnTarifas.Location = new System.Drawing.Point(3, 233);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(239, 54);
            this.btnTarifas.TabIndex = 3;
            this.btnTarifas.Text = "TARIFAS";
            this.btnTarifas.UseVisualStyleBackColor = true;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.Color.White;
            this.btnSalidas.Location = new System.Drawing.Point(3, 113);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(239, 54);
            this.btnSalidas.TabIndex = 2;
            this.btnSalidas.Text = "SALIDAS";
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Location = new System.Drawing.Point(3, 53);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(239, 54);
            this.btnIngresos.TabIndex = 1;
            this.btnIngresos.Text = "INGRESOS";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 664);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnTarifas;
    }
}

