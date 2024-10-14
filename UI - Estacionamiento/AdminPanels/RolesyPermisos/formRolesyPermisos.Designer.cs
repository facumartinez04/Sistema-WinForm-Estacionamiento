namespace UI___Estacionamiento.AdminPanels.RolesyPermisos
{
    partial class formRolesyPermisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.button2btnFiltroRol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.LOGIN = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridPermisos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFiltroPerm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor1.Location = new System.Drawing.Point(951, 0);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(281, 589);
            this.panelContenedor1.TabIndex = 0;
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(161)))));
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.ForeColor = System.Drawing.Color.White;
            this.btnPermisos.Location = new System.Drawing.Point(233, 492);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(167, 40);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "AGREGAR PERMISO";
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(161)))));
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.Color.White;
            this.btnRol.Location = new System.Drawing.Point(237, 492);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(152, 40);
            this.btnRol.TabIndex = 6;
            this.btnRol.Text = "AGREGAR ROL";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // button2btnFiltroRol
            // 
            this.button2btnFiltroRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(161)))));
            this.button2btnFiltroRol.FlatAppearance.BorderSize = 0;
            this.button2btnFiltroRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2btnFiltroRol.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2btnFiltroRol.ForeColor = System.Drawing.Color.White;
            this.button2btnFiltroRol.Location = new System.Drawing.Point(259, 71);
            this.button2btnFiltroRol.Name = "button2btnFiltroRol";
            this.button2btnFiltroRol.Size = new System.Drawing.Size(130, 33);
            this.button2btnFiltroRol.TabIndex = 8;
            this.button2btnFiltroRol.Text = "FILTRAR";
            this.button2btnFiltroRol.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 33);
            this.textBox1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridRoles);
            this.panel2.Controls.Add(this.LOGIN);
            this.panel2.Controls.Add(this.btnRol);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button2btnFiltroRol);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 565);
            this.panel2.TabIndex = 10;
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRoles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRoles.Location = new System.Drawing.Point(19, 131);
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.Size = new System.Drawing.Size(370, 291);
            this.dataGridRoles.TabIndex = 11;
            this.dataGridRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoles_CellContentClick);
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.White;
            this.LOGIN.Location = new System.Drawing.Point(12, 14);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(90, 40);
            this.LOGIN.TabIndex = 10;
            this.LOGIN.Text = "Roles";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridPermisos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.btnPermisos);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.btnFiltroPerm);
            this.panel3.Location = new System.Drawing.Point(472, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 565);
            this.panel3.TabIndex = 11;
            // 
            // dataGridPermisos
            // 
            this.dataGridPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPermisos.Location = new System.Drawing.Point(30, 131);
            this.dataGridPermisos.Name = "dataGridPermisos";
            this.dataGridPermisos.ReadOnly = true;
            this.dataGridPermisos.Size = new System.Drawing.Size(370, 291);
            this.dataGridPermisos.TabIndex = 12;
            this.dataGridPermisos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPermisos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Permisos";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-441, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 33);
            this.textBox3.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(161)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-201, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "FILTRAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 33);
            this.textBox2.TabIndex = 9;
            // 
            // btnFiltroPerm
            // 
            this.btnFiltroPerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(161)))));
            this.btnFiltroPerm.FlatAppearance.BorderSize = 0;
            this.btnFiltroPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroPerm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroPerm.ForeColor = System.Drawing.Color.White;
            this.btnFiltroPerm.Location = new System.Drawing.Point(270, 71);
            this.btnFiltroPerm.Name = "btnFiltroPerm";
            this.btnFiltroPerm.Size = new System.Drawing.Size(130, 33);
            this.btnFiltroPerm.TabIndex = 8;
            this.btnFiltroPerm.Text = "FILTRAR";
            this.btnFiltroPerm.UseVisualStyleBackColor = false;
            // 
            // formRolesyPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(13)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1231, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContenedor1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRolesyPermisos";
            this.Text = "formRolesyPermisos";
            this.Load += new System.EventHandler(this.formRolesyPermisos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button button2btnFiltroRol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnFiltroPerm;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.DataGridView dataGridPermisos;
    }
}