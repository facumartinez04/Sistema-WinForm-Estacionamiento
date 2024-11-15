namespace UI___Estacionamiento.PanelsMain.FacturacionForms
{
    partial class formFacturacionPago
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsegundosTranscurridos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinutosTranscurridos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHorasTranscurridas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDiaTranscurrido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiaSalida = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiaIngreso = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMontoHora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCobro = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.tiempos = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 30);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClose_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "REALIZAR EL COBRO DEL ESTACIONAMIENTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(766, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsegundosTranscurridos);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblMinutosTranscurridos);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblHorasTranscurridas);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblDiaTranscurrido);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(385, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 136);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIEMPO TRANSCURRIDO";
            // 
            // lblsegundosTranscurridos
            // 
            this.lblsegundosTranscurridos.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundosTranscurridos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblsegundosTranscurridos.Location = new System.Drawing.Point(268, 62);
            this.lblsegundosTranscurridos.Name = "lblsegundosTranscurridos";
            this.lblsegundosTranscurridos.Size = new System.Drawing.Size(97, 62);
            this.lblsegundosTranscurridos.TabIndex = 32;
            this.lblsegundosTranscurridos.Text = "00";
            this.lblsegundosTranscurridos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "SEGUNDOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutosTranscurridos
            // 
            this.lblMinutosTranscurridos.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosTranscurridos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblMinutosTranscurridos.Location = new System.Drawing.Point(173, 62);
            this.lblMinutosTranscurridos.Name = "lblMinutosTranscurridos";
            this.lblMinutosTranscurridos.Size = new System.Drawing.Size(89, 62);
            this.lblMinutosTranscurridos.TabIndex = 30;
            this.lblMinutosTranscurridos.Text = "00";
            this.lblMinutosTranscurridos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(173, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "MINUTOS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorasTranscurridas
            // 
            this.lblHorasTranscurridas.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTranscurridas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHorasTranscurridas.Location = new System.Drawing.Point(92, 62);
            this.lblHorasTranscurridas.Name = "lblHorasTranscurridas";
            this.lblHorasTranscurridas.Size = new System.Drawing.Size(75, 62);
            this.lblHorasTranscurridas.TabIndex = 28;
            this.lblHorasTranscurridas.Text = "00";
            this.lblHorasTranscurridas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(92, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "HORAS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaTranscurrido
            // 
            this.lblDiaTranscurrido.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaTranscurrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblDiaTranscurrido.Location = new System.Drawing.Point(16, 62);
            this.lblDiaTranscurrido.Name = "lblDiaTranscurrido";
            this.lblDiaTranscurrido.Size = new System.Drawing.Size(80, 62);
            this.lblDiaTranscurrido.TabIndex = 26;
            this.lblDiaTranscurrido.Text = "000";
            this.lblDiaTranscurrido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "DIAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiaSalida);
            this.groupBox2.Controls.Add(this.lblHoraSalida);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(591, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 183);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // lblDiaSalida
            // 
            this.lblDiaSalida.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.lblDiaSalida.Location = new System.Drawing.Point(4, 116);
            this.lblDiaSalida.Name = "lblDiaSalida";
            this.lblDiaSalida.Size = new System.Drawing.Size(185, 39);
            this.lblDiaSalida.TabIndex = 24;
            this.lblDiaSalida.Text = "00/00/0000";
            this.lblDiaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHoraSalida.Location = new System.Drawing.Point(6, 39);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(183, 77);
            this.lblHoraSalida.TabIndex = 23;
            this.lblHoraSalida.Text = "00:00:00";
            this.lblHoraSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 39);
            this.label8.TabIndex = 22;
            this.label8.Text = "FECHA Y HORA DE SALIDA:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiaIngreso);
            this.groupBox1.Controls.Add(this.lblHoraIngreso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(385, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 183);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // lblDiaIngreso
            // 
            this.lblDiaIngreso.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.lblDiaIngreso.Location = new System.Drawing.Point(6, 116);
            this.lblDiaIngreso.Name = "lblDiaIngreso";
            this.lblDiaIngreso.Size = new System.Drawing.Size(183, 39);
            this.lblDiaIngreso.TabIndex = 24;
            this.lblDiaIngreso.Text = "00/00/0000";
            this.lblDiaIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHoraIngreso.Location = new System.Drawing.Point(6, 39);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(183, 77);
            this.lblHoraIngreso.TabIndex = 23;
            this.lblHoraIngreso.Text = "00:00:00";
            this.lblHoraIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "FECHA Y HORA DE INGRESO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(6, 75);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(373, 77);
            this.txtPatente.TabIndex = 35;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "PATENTE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMontoHora);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTarifa);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 100);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarifa";
            // 
            // txtMontoHora
            // 
            this.txtMontoHora.Location = new System.Drawing.Point(190, 53);
            this.txtMontoHora.Name = "txtMontoHora";
            this.txtMontoHora.ReadOnly = true;
            this.txtMontoHora.Size = new System.Drawing.Size(155, 29);
            this.txtMontoHora.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(187, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "MONTO POR HORA:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(9, 53);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.ReadOnly = true;
            this.txtTarifa.Size = new System.Drawing.Size(155, 29);
            this.txtTarifa.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "TIPO  DE LA TARIFA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(87, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "TOTAL A COBRAR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCobro
            // 
            this.txtCobro.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobro.Location = new System.Drawing.Point(6, 314);
            this.txtCobro.Multiline = true;
            this.txtCobro.Name = "txtCobro";
            this.txtCobro.Size = new System.Drawing.Size(373, 77);
            this.txtCobro.TabIndex = 38;
            this.txtCobro.Text = "ASD123ASD";
            this.txtCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnCobrar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(6, 397);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Padding = new System.Windows.Forms.Padding(15);
            this.btnCobrar.Size = new System.Drawing.Size(373, 52);
            this.btnCobrar.TabIndex = 39;
            this.btnCobrar.Text = "Cobrar Ahora";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // tiempos
            // 
            this.tiempos.Tick += new System.EventHandler(this.tiempos_Tick_1);
            // 
            // formFacturacionPago
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(794, 484);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCobro);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formFacturacionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formFacturacionPago_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClose_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblsegundosTranscurridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinutosTranscurridos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHorasTranscurridas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDiaTranscurrido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDiaSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiaIngreso;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCobro;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Timer tiempos;
        private System.Windows.Forms.TextBox txtMontoHora;
        private System.Windows.Forms.Label label7;
    }
}