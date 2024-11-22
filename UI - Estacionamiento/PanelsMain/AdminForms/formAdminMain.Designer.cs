namespace UI___Estacionamiento.PanelsMain.AdminForms
{
    partial class formAdminMain
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
            this.label4 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnBackups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 30);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "PANEL DE ADMINISTRADOR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrar.Image = global::UI___Estacionamiento.Properties.Resources.close__1_;
            this.cerrar.Location = new System.Drawing.Point(1142, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(29, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBackups);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnLogs);
            this.panel2.Controls.Add(this.btnBitacora);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 51);
            this.panel2.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(332, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(184, 51);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(166, 0);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(166, 51);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBitacora.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Location = new System.Drawing.Point(0, 0);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(166, 51);
            this.btnBitacora.TabIndex = 0;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(0, 76);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1171, 566);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnBackups
            // 
            this.btnBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnBackups.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackups.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackups.ForeColor = System.Drawing.Color.White;
            this.btnBackups.Location = new System.Drawing.Point(516, 0);
            this.btnBackups.Name = "btnBackups";
            this.btnBackups.Size = new System.Drawing.Size(184, 51);
            this.btnBackups.TabIndex = 4;
            this.btnBackups.Text = "Backups";
            this.btnBackups.UseVisualStyleBackColor = false;
            this.btnBackups.Click += new System.EventHandler(this.btnBackups_Click);
            // 
            // formAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1171, 641);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdminMain";
            this.Text = "formAdminMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnBackups;
    }
}