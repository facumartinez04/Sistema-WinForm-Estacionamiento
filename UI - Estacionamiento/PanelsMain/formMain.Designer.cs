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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horarioDia = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSelectIdioma = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.EngLeng = new System.Windows.Forms.PictureBox();
            this.spainLeng = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.btnTarifa = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EngLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spainLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnMetodoPago);
            this.panel1.Controls.Add(this.btnTarifa);
            this.panel1.Controls.Add(this.btnHistorial);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 1011);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHorario);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 889);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 43);
            this.panel2.TabIndex = 4;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(2, 17);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(123, 25);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "23:29:00 PM";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(139, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "11/11/2024";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 100);
            this.panel3.TabIndex = 13;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(4, 48);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Bienvenido";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // horarioDia
            // 
            this.horarioDia.Tick += new System.EventHandler(this.horarioDia_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.EngLeng);
            this.panel4.Controls.Add(this.spainLeng);
            this.panel4.Controls.Add(this.lblSelectIdioma);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 804);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 85);
            this.panel4.TabIndex = 16;
            // 
            // lblSelectIdioma
            // 
            this.lblSelectIdioma.AutoSize = true;
            this.lblSelectIdioma.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSelectIdioma.ForeColor = System.Drawing.Color.White;
            this.lblSelectIdioma.Location = new System.Drawing.Point(4, 11);
            this.lblSelectIdioma.Name = "lblSelectIdioma";
            this.lblSelectIdioma.Size = new System.Drawing.Size(148, 17);
            this.lblSelectIdioma.TabIndex = 0;
            this.lblSelectIdioma.Text = "Seleccionar un idioma:";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackgroundImage = global::UI___Estacionamiento.Properties.Resources.Estacionamiento_cubierto_Aeropuerto_Ezeiza_7_min_2;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(217, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(781, 1011);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // EngLeng
            // 
            this.EngLeng.Image = global::UI___Estacionamiento.Properties.Resources.united_kingdom;
            this.EngLeng.Location = new System.Drawing.Point(81, 45);
            this.EngLeng.Name = "EngLeng";
            this.EngLeng.Size = new System.Drawing.Size(58, 34);
            this.EngLeng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EngLeng.TabIndex = 2;
            this.EngLeng.TabStop = false;
            this.EngLeng.Click += new System.EventHandler(this.EngLeng_Click);
            // 
            // spainLeng
            // 
            this.spainLeng.Image = global::UI___Estacionamiento.Properties.Resources.spain;
            this.spainLeng.Location = new System.Drawing.Point(7, 45);
            this.spainLeng.Name = "spainLeng";
            this.spainLeng.Size = new System.Drawing.Size(58, 34);
            this.spainLeng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spainLeng.TabIndex = 1;
            this.spainLeng.TabStop = false;
            this.spainLeng.Click += new System.EventHandler(this.spainLeng_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::UI___Estacionamiento.Properties.Resources.logout;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 646);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10);
            this.btnCerrar.Size = new System.Drawing.Size(216, 78);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::UI___Estacionamiento.Properties.Resources.admin_con_ruedas_dentadas;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 568);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(216, 78);
            this.button3.TabIndex = 15;
            this.button3.Text = "Administrador";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMetodoPago
            // 
            this.btnMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnMetodoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodoPago.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoPago.ForeColor = System.Drawing.Color.White;
            this.btnMetodoPago.Image = global::UI___Estacionamiento.Properties.Resources.payment_method;
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodoPago.Location = new System.Drawing.Point(0, 490);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Padding = new System.Windows.Forms.Padding(10);
            this.btnMetodoPago.Size = new System.Drawing.Size(216, 78);
            this.btnMetodoPago.TabIndex = 11;
            this.btnMetodoPago.Text = "Metodos \r\nde pago";
            this.btnMetodoPago.UseVisualStyleBackColor = false;
            this.btnMetodoPago.Click += new System.EventHandler(this.btnMetodoPago_Click);
            // 
            // btnTarifa
            // 
            this.btnTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnTarifa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifa.ForeColor = System.Drawing.Color.White;
            this.btnTarifa.Image = global::UI___Estacionamiento.Properties.Resources.receipt;
            this.btnTarifa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifa.Location = new System.Drawing.Point(0, 412);
            this.btnTarifa.Name = "btnTarifa";
            this.btnTarifa.Padding = new System.Windows.Forms.Padding(10);
            this.btnTarifa.Size = new System.Drawing.Size(216, 78);
            this.btnTarifa.TabIndex = 10;
            this.btnTarifa.Text = "Tarifas";
            this.btnTarifa.UseVisualStyleBackColor = false;
            this.btnTarifa.Click += new System.EventHandler(this.btnTarifa_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = global::UI___Estacionamiento.Properties.Resources.history;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 334);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(10);
            this.btnHistorial.Size = new System.Drawing.Size(216, 78);
            this.btnHistorial.TabIndex = 9;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::UI___Estacionamiento.Properties.Resources.bill;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 256);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(216, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Facturacion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::UI___Estacionamiento.Properties.Resources.a7046d_8db80e67a33e4216bab447550167cb43_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 932);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::UI___Estacionamiento.Properties.Resources.coche;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 178);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(216, 78);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salidas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::UI___Estacionamiento.Properties.Resources.car__3_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 100);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(216, 78);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ingresos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 1011);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "formMain";
            this.Text = "formMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.Click += new System.EventHandler(this.formMain_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EngLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spainLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer horarioDia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMetodoPago;
        private System.Windows.Forms.Button btnTarifa;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSelectIdioma;
        private System.Windows.Forms.PictureBox spainLeng;
        private System.Windows.Forms.PictureBox EngLeng;
    }
}