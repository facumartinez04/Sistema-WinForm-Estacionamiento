namespace UI___Estacionamiento.PanelsMain.MetodoPagoForms
{
    partial class formMetodoPagoMain
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
            this.DBMetodosPago = new System.Windows.Forms.DataGridView();
            this.groupBx1 = new System.Windows.Forms.GroupBox();
            this.lblnombremetodopago = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.btnEditarAddMP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmetodospago = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBMetodosPago)).BeginInit();
            this.groupBx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBMetodosPago
            // 
            this.DBMetodosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBMetodosPago.Location = new System.Drawing.Point(396, 81);
            this.DBMetodosPago.Name = "DBMetodosPago";
            this.DBMetodosPago.Size = new System.Drawing.Size(268, 222);
            this.DBMetodosPago.TabIndex = 0;
            this.DBMetodosPago.DoubleClick += new System.EventHandler(this.DBMetodosPago_DoubleClick);
            // 
            // groupBx1
            // 
            this.groupBx1.Controls.Add(this.lblnombremetodopago);
            this.groupBx1.Controls.Add(this.txtMetodoPago);
            this.groupBx1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBx1.Location = new System.Drawing.Point(12, 43);
            this.groupBx1.Name = "groupBx1";
            this.groupBx1.Size = new System.Drawing.Size(378, 119);
            this.groupBx1.TabIndex = 1;
            this.groupBx1.TabStop = false;
            this.groupBx1.Text = "Metodo de pago";
            // 
            // lblnombremetodopago
            // 
            this.lblnombremetodopago.AutoSize = true;
            this.lblnombremetodopago.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombremetodopago.ForeColor = System.Drawing.Color.Black;
            this.lblnombremetodopago.Location = new System.Drawing.Point(6, 37);
            this.lblnombremetodopago.Name = "lblnombremetodopago";
            this.lblnombremetodopago.Size = new System.Drawing.Size(244, 20);
            this.lblnombremetodopago.TabIndex = 10;
            this.lblnombremetodopago.Text = "NOMBRE DEL METODO DE PAGO:";
            this.lblnombremetodopago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMetodoPago.Location = new System.Drawing.Point(6, 60);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(244, 20);
            this.txtMetodoPago.TabIndex = 1;
            // 
            // btnEditarAddMP
            // 
            this.btnEditarAddMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnEditarAddMP.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditarAddMP.ForeColor = System.Drawing.Color.White;
            this.btnEditarAddMP.Location = new System.Drawing.Point(12, 247);
            this.btnEditarAddMP.Name = "btnEditarAddMP";
            this.btnEditarAddMP.Size = new System.Drawing.Size(358, 56);
            this.btnEditarAddMP.TabIndex = 0;
            this.btnEditarAddMP.Text = "Agregar";
            this.btnEditarAddMP.UseVisualStyleBackColor = false;
            this.btnEditarAddMP.Click += new System.EventHandler(this.btnEditarAddMP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lblmetodospago);
            this.panel1.Location = new System.Drawing.Point(396, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 38);
            this.panel1.TabIndex = 8;
            // 
            // lblmetodospago
            // 
            this.lblmetodospago.AutoSize = true;
            this.lblmetodospago.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmetodospago.ForeColor = System.Drawing.Color.White;
            this.lblmetodospago.Location = new System.Drawing.Point(11, 9);
            this.lblmetodospago.Name = "lblmetodospago";
            this.lblmetodospago.Size = new System.Drawing.Size(131, 20);
            this.lblmetodospago.TabIndex = 0;
            this.lblmetodospago.Text = "Metodos de pago";
            this.lblmetodospago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(396, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15);
            this.btnClose.Size = new System.Drawing.Size(268, 52);
            this.btnClose.TabIndex = 17;
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
            this.panel2.Size = new System.Drawing.Size(686, 30);
            this.panel2.TabIndex = 18;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMetodoPagoMain_MouseDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(658, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // formMetodoPagoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(684, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBx1);
            this.Controls.Add(this.DBMetodosPago);
            this.Controls.Add(this.btnEditarAddMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMetodoPagoMain";
            this.Text = "formMetodoPagoMain";
            this.Load += new System.EventHandler(this.formMetodoPagoMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMetodoPagoMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DBMetodosPago)).EndInit();
            this.groupBx1.ResumeLayout(false);
            this.groupBx1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBMetodosPago;
        private System.Windows.Forms.GroupBox groupBx1;
        private System.Windows.Forms.Button btnEditarAddMP;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label lblnombremetodopago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmetodospago;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
    }
}