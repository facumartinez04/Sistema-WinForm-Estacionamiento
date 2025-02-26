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
            this.lblrealizarcobro = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.gbtiempotrans = new System.Windows.Forms.GroupBox();
            this.lblsegundosTranscurridos = new System.Windows.Forms.Label();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.lblMinutosTranscurridos = new System.Windows.Forms.Label();
            this.lblminutos = new System.Windows.Forms.Label();
            this.lblHorasTranscurridas = new System.Windows.Forms.Label();
            this.lblhoras = new System.Windows.Forms.Label();
            this.lblDiaTranscurrido = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiaSalida = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblfechahorasalida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiaIngreso = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblfechahoraingreso = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.gbTarifa = new System.Windows.Forms.GroupBox();
            this.txtMontoHora = new System.Windows.Forms.TextBox();
            this.lblMontoHora = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblTipoTarifa = new System.Windows.Forms.Label();
            this.lblTotalaCobrar = new System.Windows.Forms.Label();
            this.txtCobro = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.tiempos = new System.Windows.Forms.Timer(this.components);
            this.gbmetodopago = new System.Windows.Forms.GroupBox();
            this.cmbmetodoPago = new System.Windows.Forms.ComboBox();
            this.lblelegirmetodo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gbtiempotrans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTarifa.SuspendLayout();
            this.gbmetodopago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.lblrealizarcobro);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 30);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClose_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblrealizarcobro
            // 
            this.lblrealizarcobro.AutoSize = true;
            this.lblrealizarcobro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrealizarcobro.ForeColor = System.Drawing.Color.White;
            this.lblrealizarcobro.Location = new System.Drawing.Point(3, 5);
            this.lblrealizarcobro.Name = "lblrealizarcobro";
            this.lblrealizarcobro.Size = new System.Drawing.Size(332, 20);
            this.lblrealizarcobro.TabIndex = 11;
            this.lblrealizarcobro.Text = "REALIZAR EL COBRO DEL ESTACIONAMIENTO";
            this.lblrealizarcobro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // gbtiempotrans
            // 
            this.gbtiempotrans.Controls.Add(this.lblsegundosTranscurridos);
            this.gbtiempotrans.Controls.Add(this.lblsegundos);
            this.gbtiempotrans.Controls.Add(this.lblMinutosTranscurridos);
            this.gbtiempotrans.Controls.Add(this.lblminutos);
            this.gbtiempotrans.Controls.Add(this.lblHorasTranscurridas);
            this.gbtiempotrans.Controls.Add(this.lblhoras);
            this.gbtiempotrans.Controls.Add(this.lblDiaTranscurrido);
            this.gbtiempotrans.Controls.Add(this.lbldias);
            this.gbtiempotrans.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtiempotrans.Location = new System.Drawing.Point(385, 255);
            this.gbtiempotrans.Name = "gbtiempotrans";
            this.gbtiempotrans.Size = new System.Drawing.Size(401, 136);
            this.gbtiempotrans.TabIndex = 28;
            this.gbtiempotrans.TabStop = false;
            this.gbtiempotrans.Text = "TIEMPO TRANSCURRIDO";
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
            // lblsegundos
            // 
            this.lblsegundos.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundos.ForeColor = System.Drawing.Color.Black;
            this.lblsegundos.Location = new System.Drawing.Point(268, 23);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(97, 24);
            this.lblsegundos.TabIndex = 31;
            this.lblsegundos.Text = "SEGUNDOS";
            this.lblsegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblminutos
            // 
            this.lblminutos.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutos.ForeColor = System.Drawing.Color.Black;
            this.lblminutos.Location = new System.Drawing.Point(173, 23);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(89, 24);
            this.lblminutos.TabIndex = 29;
            this.lblminutos.Text = "MINUTOS";
            this.lblminutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblhoras
            // 
            this.lblhoras.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoras.ForeColor = System.Drawing.Color.Black;
            this.lblhoras.Location = new System.Drawing.Point(92, 23);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(75, 24);
            this.lblhoras.TabIndex = 27;
            this.lblhoras.Text = "HORAS";
            this.lblhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lbldias
            // 
            this.lbldias.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.ForeColor = System.Drawing.Color.Black;
            this.lbldias.Location = new System.Drawing.Point(16, 23);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(80, 24);
            this.lbldias.TabIndex = 25;
            this.lbldias.Text = "DIAS";
            this.lbldias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiaSalida);
            this.groupBox2.Controls.Add(this.lblHoraSalida);
            this.groupBox2.Controls.Add(this.lblfechahorasalida);
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
            // lblfechahorasalida
            // 
            this.lblfechahorasalida.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechahorasalida.ForeColor = System.Drawing.Color.Black;
            this.lblfechahorasalida.Location = new System.Drawing.Point(4, 0);
            this.lblfechahorasalida.Name = "lblfechahorasalida";
            this.lblfechahorasalida.Size = new System.Drawing.Size(185, 39);
            this.lblfechahorasalida.TabIndex = 22;
            this.lblfechahorasalida.Text = "FECHA Y HORA DE SALIDA:";
            this.lblfechahorasalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiaIngreso);
            this.groupBox1.Controls.Add(this.lblHoraIngreso);
            this.groupBox1.Controls.Add(this.lblfechahoraingreso);
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
            // lblfechahoraingreso
            // 
            this.lblfechahoraingreso.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechahoraingreso.ForeColor = System.Drawing.Color.Black;
            this.lblfechahoraingreso.Location = new System.Drawing.Point(6, 0);
            this.lblfechahoraingreso.Name = "lblfechahoraingreso";
            this.lblfechahoraingreso.Size = new System.Drawing.Size(183, 39);
            this.lblfechahoraingreso.TabIndex = 22;
            this.lblfechahoraingreso.Text = "FECHA Y HORA DE INGRESO";
            this.lblfechahoraingreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(6, 75);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.ReadOnly = true;
            this.txtPatente.Size = new System.Drawing.Size(373, 77);
            this.txtPatente.TabIndex = 35;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatente
            // 
            this.lblPatente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(2, 36);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(84, 36);
            this.lblPatente.TabIndex = 25;
            this.lblPatente.Text = "PATENTE:";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbTarifa
            // 
            this.gbTarifa.Controls.Add(this.txtMontoHora);
            this.gbTarifa.Controls.Add(this.lblMontoHora);
            this.gbTarifa.Controls.Add(this.txtTarifa);
            this.gbTarifa.Controls.Add(this.lblTipoTarifa);
            this.gbTarifa.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarifa.Location = new System.Drawing.Point(6, 172);
            this.gbTarifa.Name = "gbTarifa";
            this.gbTarifa.Size = new System.Drawing.Size(373, 100);
            this.gbTarifa.TabIndex = 36;
            this.gbTarifa.TabStop = false;
            this.gbTarifa.Text = "Tarifa";
            // 
            // txtMontoHora
            // 
            this.txtMontoHora.Location = new System.Drawing.Point(190, 53);
            this.txtMontoHora.Name = "txtMontoHora";
            this.txtMontoHora.ReadOnly = true;
            this.txtMontoHora.Size = new System.Drawing.Size(155, 29);
            this.txtMontoHora.TabIndex = 28;
            // 
            // lblMontoHora
            // 
            this.lblMontoHora.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoHora.ForeColor = System.Drawing.Color.Black;
            this.lblMontoHora.Location = new System.Drawing.Point(187, 25);
            this.lblMontoHora.Name = "lblMontoHora";
            this.lblMontoHora.Size = new System.Drawing.Size(158, 22);
            this.lblMontoHora.TabIndex = 27;
            this.lblMontoHora.Text = "MONTO POR HORA:";
            this.lblMontoHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(9, 53);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.ReadOnly = true;
            this.txtTarifa.Size = new System.Drawing.Size(155, 29);
            this.txtTarifa.TabIndex = 26;
            // 
            // lblTipoTarifa
            // 
            this.lblTipoTarifa.AutoSize = true;
            this.lblTipoTarifa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTarifa.ForeColor = System.Drawing.Color.Black;
            this.lblTipoTarifa.Location = new System.Drawing.Point(6, 25);
            this.lblTipoTarifa.Name = "lblTipoTarifa";
            this.lblTipoTarifa.Size = new System.Drawing.Size(134, 17);
            this.lblTipoTarifa.TabIndex = 25;
            this.lblTipoTarifa.Text = "TIPO  DE LA TARIFA:";
            this.lblTipoTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalaCobrar
            // 
            this.lblTotalaCobrar.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalaCobrar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalaCobrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalaCobrar.Location = new System.Drawing.Point(7, 275);
            this.lblTotalaCobrar.Name = "lblTotalaCobrar";
            this.lblTotalaCobrar.Size = new System.Drawing.Size(372, 36);
            this.lblTotalaCobrar.TabIndex = 37;
            this.lblTotalaCobrar.Text = "TOTAL A COBRAR";
            this.lblTotalaCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCobro
            // 
            this.txtCobro.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobro.Location = new System.Drawing.Point(6, 328);
            this.txtCobro.Multiline = true;
            this.txtCobro.Name = "txtCobro";
            this.txtCobro.ReadOnly = true;
            this.txtCobro.Size = new System.Drawing.Size(373, 51);
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
            this.btnCobrar.Location = new System.Drawing.Point(6, 454);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Padding = new System.Windows.Forms.Padding(15);
            this.btnCobrar.Size = new System.Drawing.Size(373, 66);
            this.btnCobrar.TabIndex = 39;
            this.btnCobrar.Text = "Cobrar Ahora";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // tiempos
            // 
            this.tiempos.Tick += new System.EventHandler(this.tiempos_Tick_1);
            // 
            // gbmetodopago
            // 
            this.gbmetodopago.Controls.Add(this.cmbmetodoPago);
            this.gbmetodopago.Controls.Add(this.lblelegirmetodo);
            this.gbmetodopago.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbmetodopago.Location = new System.Drawing.Point(385, 398);
            this.gbmetodopago.Name = "gbmetodopago";
            this.gbmetodopago.Size = new System.Drawing.Size(395, 122);
            this.gbmetodopago.TabIndex = 40;
            this.gbmetodopago.TabStop = false;
            this.gbmetodopago.Text = "METODOS DE PAGO";
            // 
            // cmbmetodoPago
            // 
            this.cmbmetodoPago.FormattingEnabled = true;
            this.cmbmetodoPago.Location = new System.Drawing.Point(11, 56);
            this.cmbmetodoPago.Name = "cmbmetodoPago";
            this.cmbmetodoPago.Size = new System.Drawing.Size(178, 29);
            this.cmbmetodoPago.TabIndex = 30;
            // 
            // lblelegirmetodo
            // 
            this.lblelegirmetodo.AutoSize = true;
            this.lblelegirmetodo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelegirmetodo.ForeColor = System.Drawing.Color.Black;
            this.lblelegirmetodo.Location = new System.Drawing.Point(8, 36);
            this.lblelegirmetodo.Name = "lblelegirmetodo";
            this.lblelegirmetodo.Size = new System.Drawing.Size(153, 17);
            this.lblelegirmetodo.TabIndex = 29;
            this.lblelegirmetodo.Text = "Elegir metodo de pago:";
            this.lblelegirmetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formFacturacionPago
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(794, 532);
            this.Controls.Add(this.gbmetodopago);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotalaCobrar);
            this.Controls.Add(this.txtCobro);
            this.Controls.Add(this.gbTarifa);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbtiempotrans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formFacturacionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formFacturacionPago_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClose_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbtiempotrans.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbTarifa.ResumeLayout(false);
            this.gbTarifa.PerformLayout();
            this.gbmetodopago.ResumeLayout(false);
            this.gbmetodopago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblrealizarcobro;
        private System.Windows.Forms.GroupBox gbtiempotrans;
        private System.Windows.Forms.Label lblsegundosTranscurridos;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Label lblMinutosTranscurridos;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Label lblHorasTranscurridas;
        private System.Windows.Forms.Label lblhoras;
        private System.Windows.Forms.Label lblDiaTranscurrido;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDiaSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblfechahorasalida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiaIngreso;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label lblfechahoraingreso;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.GroupBox gbTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblTipoTarifa;
        private System.Windows.Forms.Label lblTotalaCobrar;
        private System.Windows.Forms.TextBox txtCobro;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Timer tiempos;
        private System.Windows.Forms.TextBox txtMontoHora;
        private System.Windows.Forms.Label lblMontoHora;
        private System.Windows.Forms.GroupBox gbmetodopago;
        private System.Windows.Forms.ComboBox cmbmetodoPago;
        private System.Windows.Forms.Label lblelegirmetodo;
    }
}