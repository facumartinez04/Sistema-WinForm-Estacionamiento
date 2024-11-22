namespace UI___Estacionamiento.PanelsMain.SalidaForms
{
    partial class formSalidaMain
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
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.lblIngresados = new System.Windows.Forms.Label();
            this.DBIngresosList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.searchPatente = new System.Windows.Forms.PictureBox();
            this.lblfechahorarioIngreso = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblDiaIngreso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiaSalida = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label8lblfechahorarioSalida = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsegundosTranscurridos = new System.Windows.Forms.Label();
            this.lblseconds = new System.Windows.Forms.Label();
            this.lblMinutosTranscurridos = new System.Windows.Forms.Label();
            this.lblminutes = new System.Windows.Forms.Label();
            this.lblHorasTranscurridas = new System.Windows.Forms.Label();
            this.lblhours = new System.Windows.Forms.Label();
            this.lblDiaTranscurrido = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.tiempos = new System.Windows.Forms.Timer(this.components);
            this.ClearTodo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBIngresosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 30);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formSalidaMain_MouseDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.button6.Location = new System.Drawing.Point(1118, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(750, 610);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15);
            this.button4.Size = new System.Drawing.Size(383, 52);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.lblIngresados);
            this.panel1.Location = new System.Drawing.Point(750, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 38);
            this.panel1.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::UI___Estacionamiento.Properties.Resources.reload;
            this.button7.Location = new System.Drawing.Point(342, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 38);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblIngresados
            // 
            this.lblIngresados.AutoSize = true;
            this.lblIngresados.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresados.ForeColor = System.Drawing.Color.White;
            this.lblIngresados.Location = new System.Drawing.Point(11, 9);
            this.lblIngresados.Name = "lblIngresados";
            this.lblIngresados.Size = new System.Drawing.Size(156, 20);
            this.lblIngresados.TabIndex = 0;
            this.lblIngresados.Text = "Vehiculos Ingresados";
            this.lblIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBIngresosList
            // 
            this.DBIngresosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBIngresosList.Location = new System.Drawing.Point(750, 85);
            this.DBIngresosList.Name = "DBIngresosList";
            this.DBIngresosList.ReadOnly = true;
            this.DBIngresosList.Size = new System.Drawing.Size(383, 519);
            this.DBIngresosList.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "PATENTE:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Nirmala UI", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(36, 78);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(463, 101);
            this.txtPatente.TabIndex = 19;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
            // 
            // searchPatente
            // 
            this.searchPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.searchPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatente.Image = global::UI___Estacionamiento.Properties.Resources.magnifying_glass;
            this.searchPatente.Location = new System.Drawing.Point(505, 78);
            this.searchPatente.Name = "searchPatente";
            this.searchPatente.Padding = new System.Windows.Forms.Padding(15);
            this.searchPatente.Size = new System.Drawing.Size(103, 101);
            this.searchPatente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPatente.TabIndex = 21;
            this.searchPatente.TabStop = false;
            this.searchPatente.Click += new System.EventHandler(this.searchPatente_Click);
            // 
            // lblfechahorarioIngreso
            // 
            this.lblfechahorarioIngreso.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechahorarioIngreso.ForeColor = System.Drawing.Color.Black;
            this.lblfechahorarioIngreso.Location = new System.Drawing.Point(-1, 0);
            this.lblfechahorarioIngreso.Name = "lblfechahorarioIngreso";
            this.lblfechahorarioIngreso.Size = new System.Drawing.Size(269, 39);
            this.lblfechahorarioIngreso.TabIndex = 22;
            this.lblfechahorarioIngreso.Text = "FECHA Y HORA DE INGRESO";
            this.lblfechahorarioIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHoraIngreso.Location = new System.Drawing.Point(-1, 39);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(269, 77);
            this.lblHoraIngreso.TabIndex = 23;
            this.lblHoraIngreso.Text = "00:00:00";
            this.lblHoraIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaIngreso
            // 
            this.lblDiaIngreso.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.lblDiaIngreso.Location = new System.Drawing.Point(-1, 116);
            this.lblDiaIngreso.Name = "lblDiaIngreso";
            this.lblDiaIngreso.Size = new System.Drawing.Size(269, 39);
            this.lblDiaIngreso.TabIndex = 24;
            this.lblDiaIngreso.Text = "00/00/0000";
            this.lblDiaIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiaIngreso);
            this.groupBox1.Controls.Add(this.lblHoraIngreso);
            this.groupBox1.Controls.Add(this.lblfechahorarioIngreso);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(37, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 183);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiaSalida);
            this.groupBox2.Controls.Add(this.lblHoraSalida);
            this.groupBox2.Controls.Add(this.label8lblfechahorarioSalida);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(340, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 183);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // lblDiaSalida
            // 
            this.lblDiaSalida.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.lblDiaSalida.Location = new System.Drawing.Point(-1, 116);
            this.lblDiaSalida.Name = "lblDiaSalida";
            this.lblDiaSalida.Size = new System.Drawing.Size(269, 39);
            this.lblDiaSalida.TabIndex = 24;
            this.lblDiaSalida.Text = "00/00/0000";
            this.lblDiaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHoraSalida.Location = new System.Drawing.Point(-1, 39);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(269, 77);
            this.lblHoraSalida.TabIndex = 23;
            this.lblHoraSalida.Text = "00:00:00";
            this.lblHoraSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8lblfechahorarioSalida
            // 
            this.label8lblfechahorarioSalida.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8lblfechahorarioSalida.ForeColor = System.Drawing.Color.Black;
            this.label8lblfechahorarioSalida.Location = new System.Drawing.Point(-1, 0);
            this.label8lblfechahorarioSalida.Name = "label8lblfechahorarioSalida";
            this.label8lblfechahorarioSalida.Size = new System.Drawing.Size(269, 39);
            this.label8lblfechahorarioSalida.TabIndex = 22;
            this.label8lblfechahorarioSalida.Text = "FECHA Y HORA DE SALIDA:";
            this.label8lblfechahorarioSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(36, 513);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Padding = new System.Windows.Forms.Padding(15);
            this.btnPagar.Size = new System.Drawing.Size(572, 91);
            this.btnPagar.TabIndex = 26;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsegundosTranscurridos);
            this.groupBox3.Controls.Add(this.lblseconds);
            this.groupBox3.Controls.Add(this.lblMinutosTranscurridos);
            this.groupBox3.Controls.Add(this.lblminutes);
            this.groupBox3.Controls.Add(this.lblHorasTranscurridas);
            this.groupBox3.Controls.Add(this.lblhours);
            this.groupBox3.Controls.Add(this.lblDiaTranscurrido);
            this.groupBox3.Controls.Add(this.lblday);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(36, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 120);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIEMPO TRANSCURRIDO";
            // 
            // lblsegundosTranscurridos
            // 
            this.lblsegundosTranscurridos.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundosTranscurridos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblsegundosTranscurridos.Location = new System.Drawing.Point(455, 51);
            this.lblsegundosTranscurridos.Name = "lblsegundosTranscurridos";
            this.lblsegundosTranscurridos.Size = new System.Drawing.Size(97, 62);
            this.lblsegundosTranscurridos.TabIndex = 32;
            this.lblsegundosTranscurridos.Text = "00";
            this.lblsegundosTranscurridos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblseconds
            // 
            this.lblseconds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseconds.ForeColor = System.Drawing.Color.Black;
            this.lblseconds.Location = new System.Drawing.Point(455, 12);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(97, 24);
            this.lblseconds.TabIndex = 31;
            this.lblseconds.Text = "SEGUNDOS";
            this.lblseconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutosTranscurridos
            // 
            this.lblMinutosTranscurridos.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosTranscurridos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblMinutosTranscurridos.Location = new System.Drawing.Point(360, 51);
            this.lblMinutosTranscurridos.Name = "lblMinutosTranscurridos";
            this.lblMinutosTranscurridos.Size = new System.Drawing.Size(89, 62);
            this.lblMinutosTranscurridos.TabIndex = 30;
            this.lblMinutosTranscurridos.Text = "00";
            this.lblMinutosTranscurridos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblminutes
            // 
            this.lblminutes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutes.ForeColor = System.Drawing.Color.Black;
            this.lblminutes.Location = new System.Drawing.Point(360, 12);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(89, 24);
            this.lblminutes.TabIndex = 29;
            this.lblminutes.Text = "MINUTOS";
            this.lblminutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorasTranscurridas
            // 
            this.lblHorasTranscurridas.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTranscurridas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblHorasTranscurridas.Location = new System.Drawing.Point(279, 51);
            this.lblHorasTranscurridas.Name = "lblHorasTranscurridas";
            this.lblHorasTranscurridas.Size = new System.Drawing.Size(75, 62);
            this.lblHorasTranscurridas.TabIndex = 28;
            this.lblHorasTranscurridas.Text = "00";
            this.lblHorasTranscurridas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhours
            // 
            this.lblhours.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.ForeColor = System.Drawing.Color.Black;
            this.lblhours.Location = new System.Drawing.Point(279, 12);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(75, 24);
            this.lblhours.TabIndex = 27;
            this.lblhours.Text = "HORAS";
            this.lblhours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaTranscurrido
            // 
            this.lblDiaTranscurrido.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaTranscurrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblDiaTranscurrido.Location = new System.Drawing.Point(203, 51);
            this.lblDiaTranscurrido.Name = "lblDiaTranscurrido";
            this.lblDiaTranscurrido.Size = new System.Drawing.Size(80, 62);
            this.lblDiaTranscurrido.TabIndex = 26;
            this.lblDiaTranscurrido.Text = "000";
            this.lblDiaTranscurrido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblday
            // 
            this.lblday.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.Black;
            this.lblday.Location = new System.Drawing.Point(203, 12);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(80, 24);
            this.lblday.TabIndex = 25;
            this.lblday.Text = "DIAS";
            this.lblday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tiempos
            // 
            this.tiempos.Tick += new System.EventHandler(this.tiempos_Tick);
            // 
            // ClearTodo
            // 
            this.ClearTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.ClearTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearTodo.Image = global::UI___Estacionamiento.Properties.Resources.remove;
            this.ClearTodo.Location = new System.Drawing.Point(614, 78);
            this.ClearTodo.Name = "ClearTodo";
            this.ClearTodo.Padding = new System.Windows.Forms.Padding(15);
            this.ClearTodo.Size = new System.Drawing.Size(103, 101);
            this.ClearTodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearTodo.TabIndex = 28;
            this.ClearTodo.TabStop = false;
            this.ClearTodo.Click += new System.EventHandler(this.ClearTodo_Click);
            // 
            // formSalidaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1145, 667);
            this.Controls.Add(this.ClearTodo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchPatente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBIngresosList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSalidaMain";
            this.Text = "formSalidaMain";
            this.Load += new System.EventHandler(this.formSalidaMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBIngresosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClearTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblIngresados;
        private System.Windows.Forms.DataGridView DBIngresosList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.PictureBox searchPatente;
        private System.Windows.Forms.Label lblfechahorarioIngreso;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label lblDiaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDiaSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label label8lblfechahorarioSalida;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMinutosTranscurridos;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.Label lblHorasTranscurridas;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label lblDiaTranscurrido;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Timer tiempos;
        private System.Windows.Forms.Label lblsegundosTranscurridos;
        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.PictureBox ClearTodo;
    }
}