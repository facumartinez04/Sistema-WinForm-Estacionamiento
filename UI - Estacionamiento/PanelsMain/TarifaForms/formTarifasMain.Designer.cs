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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEditTarifa = new System.Windows.Forms.Button();
            this.txtNombreTarifa = new System.Windows.Forms.TextBox();
            this.txtMontoTarifa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBTarifasList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBTarifasList
            // 
            this.DBTarifasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBTarifasList.Location = new System.Drawing.Point(22, 190);
            this.DBTarifasList.Name = "DBTarifasList";
            this.DBTarifasList.Size = new System.Drawing.Size(360, 232);
            this.DBTarifasList.TabIndex = 0;
            this.DBTarifasList.DoubleClick += new System.EventHandler(this.DBTarifasList_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMontoTarifa);
            this.groupBox1.Controls.Add(this.txtNombreTarifa);
            this.groupBox1.Controls.Add(this.btnAddEditTarifa);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarifas";
            // 
            // btnAddEditTarifa
            // 
            this.btnAddEditTarifa.Location = new System.Drawing.Point(267, 108);
            this.btnAddEditTarifa.Name = "btnAddEditTarifa";
            this.btnAddEditTarifa.Size = new System.Drawing.Size(81, 34);
            this.btnAddEditTarifa.TabIndex = 0;
            this.btnAddEditTarifa.Text = "Agregar";
            this.btnAddEditTarifa.UseVisualStyleBackColor = true;
            this.btnAddEditTarifa.Click += new System.EventHandler(this.btnAddEditTarifa_Click);
            // 
            // txtNombreTarifa
            // 
            this.txtNombreTarifa.Location = new System.Drawing.Point(6, 43);
            this.txtNombreTarifa.Name = "txtNombreTarifa";
            this.txtNombreTarifa.Size = new System.Drawing.Size(125, 20);
            this.txtNombreTarifa.TabIndex = 1;
            // 
            // txtMontoTarifa
            // 
            this.txtMontoTarifa.Location = new System.Drawing.Point(223, 43);
            this.txtMontoTarifa.Name = "txtMontoTarifa";
            this.txtMontoTarifa.Size = new System.Drawing.Size(125, 20);
            this.txtMontoTarifa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto por Hora";
            // 
            // formTarifasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DBTarifasList);
            this.Name = "formTarifasMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTarifasMain";
            this.Load += new System.EventHandler(this.formTarifasMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBTarifasList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBTarifasList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoTarifa;
        private System.Windows.Forms.TextBox txtNombreTarifa;
        private System.Windows.Forms.Button btnAddEditTarifa;
    }
}