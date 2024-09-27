namespace UI___Estacionamiento.Auth
{
    partial class formAuth
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
            this.btnreg = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 10);
            this.panel1.TabIndex = 0;
            // 
            // btnreg
            // 
            this.btnreg.FlatAppearance.BorderSize = 0;
            this.btnreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.ForeColor = System.Drawing.Color.White;
            this.btnreg.Location = new System.Drawing.Point(220, 0);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(228, 62);
            this.btnreg.TabIndex = 1;
            this.btnreg.Text = "Registrarse";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btniniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.White;
            this.btniniciar.Location = new System.Drawing.Point(-1, 0);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(215, 62);
            this.btniniciar.TabIndex = 2;
            this.btniniciar.Text = "Iniciar Sesion";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(-1, 75);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(449, 429);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "EstacionAR";
            // 
            // formAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(446, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.panel1);
            this.Name = "formAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAuth";
            this.Load += new System.EventHandler(this.formAuth_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
    }
}