using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.PanelsMain.AdminForms.RolesPermisos
{
    public partial class formUsuarios : Form
    {

        private Usuario _usuario;

        public formUsuarios()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';
            txtContra.ReadOnly = false;
        }


        private void ListarRoles()
        {
            List<Familia> roles = FamiliaRepository.Current.GetAll();
            cmbTipoRol.DataSource = null;
            cmbTipoRol.DataSource = roles;  
            cmbTipoRol.ValueMember = "IdFamilia";
            cmbTipoRol.DisplayMember = "NombreFamilia";

        }

        private void ListarUsuarios()
        {
            List<Usuario> usuarios = UsuarioRepository.Current.GetAll();
            dgvUsuarios.DataSource = null;

            var usuariosList = from u in usuarios
                               select new
                               {
                                   IdUsuario = u.IdUsuario,
                                   UserName = u.UserName,
                               };

            dgvUsuarios.DataSource = usuariosList.ToList();


            dgvUsuarios.Columns["IdUsuario"].Visible = false;

            dgvUsuarios.Columns["UserName"].HeaderText = "Usuario";

            ConfigurarDataGridView(dgvUsuarios);    
        }



        private void ListarPermisos()
        {
            List<Patente> permisos = PatenteRepository.Current.GetAll();
            dgvPermisos.DataSource = null;

            var permisosList = from p in permisos
                               select new
                               {
                                   idPatente = p.idPatente,
                                   NombreAcceso = p.Nombre,
                                   DataKey = p.DataKey
                               };

            dgvPermisos.DataSource = permisosList.ToList();

            dgvPermisos.Columns["idPatente"].Visible = false;
            dgvPermisos.Columns["NombreAcceso"].HeaderText = "Nombre del Permiso";
            dgvPermisos.Columns["DataKey"].HeaderText = "Referencia de permiso";

            if (dgvPermisos.Columns["Seleccionar"] == null) 
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Seleccionar";
                checkBoxColumn.Name = "Seleccionar";
                checkBoxColumn.Width = 50;
                dgvPermisos.Columns.Insert(0, checkBoxColumn); 
            }

            ConfigurarDataGridView(dgvPermisos);
        }


        private void formUsuarios_Load(object sender, EventArgs e)
        {
            ListarRoles();
            ListarUsuarios();
            ListarPermisos();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(button5.Text == "Guardar")
                {

                    Usuario usuario = new Usuario();
                    usuario.UserName = txtUser.Text;
                    usuario.Password = txtContra.Text;


                    UsuarioRepository.Current.Add(usuario);


                    List<Patente> patentes = new List<Patente>();

                    foreach (DataGridViewRow row in dgvPermisos.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                        if (chk.Value != null && (bool)chk.Value)
                        {
                            patentes.Add(PatenteRepository.Current.GetById(Guid.Parse(row.Cells["idPatente"].Value.ToString())));
                        }
                    }
                     
                    Familia familia = FamiliaRepository.Current.GetById(Guid.Parse(cmbTipoRol.SelectedValue.ToString()));

                    UsuarioFamiliaRepository.Current.Add(new UsuarioFamilia() { idUsuario = usuario.IdUsuario, idFamilia = familia.IdFamilia });


                    foreach (var item in patentes)
                    {
                        UsuarioPatenteRepository.Current.Add(new UsuarioPatente() { idUsuario = usuario.IdUsuario, idPatente = item.idPatente });
                    }


                    ListarUsuarios();
                    LimpiarTodo();

                    MessageBox.Show("Usuario creado correctamente");
                }
                else
                {
                    Usuario usuario = _usuario;



                    List<Patente> patentes = new List<Patente>();

                    foreach (DataGridViewRow row in dgvPermisos.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                        if (chk.Value != null && (bool)chk.Value)
                        {
                            patentes.Add(PatenteRepository.Current.GetById(Guid.Parse(row.Cells["idPatente"].Value.ToString())));
                        }
                    }


                    UsuarioRepository.Current.Update(usuario);

                    foreach (var item in patentes)
                    {
                        UsuarioPatenteRepository.Current.Add(new UsuarioPatente() { idUsuario = usuario.IdUsuario, idPatente = item.idPatente });
                    }




                    ListarUsuarios();
                    LimpiarTodo();

                    MessageBox.Show("Usuario actualizado correctamente");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void LimpiarTodo()
        {
            txtUser.Text = "";
            txtContra.Text = "";
            cmbTipoRol.SelectedIndex = 0;

            txtContra.ReadOnly = false;

            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                chk.Value = false;
            }

            button5.Text = "Guardar";
        }

            private void ListarPermisosDeUsuario()
        {

            txtContra.ReadOnly = true;
            foreach (var permiso in _usuario.GetAllPatentes())
            {
                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    if (permiso.idPatente == Guid.Parse(row.Cells["idPatente"].Value.ToString()))
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                        chk.Value = true;
                    }
                }

            }
        }














        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(45, 45, 48);
            dataGridView.ForeColor = Color.White;
            dataGridView.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                button5.Text = "Actualizar";
                Guid idUsuario = Guid.Parse(dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString());
                Usuario usuario = UsuarioRepository.Current.GetById(idUsuario);

                _usuario = usuario;
                txtUser.Text = usuario.UserName;
                txtContra.Text = usuario.Password;



                cmbTipoRol.SelectedValue = usuario.GetFamilias().FirstOrDefault().IdFamilia;





                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                    chk.Value = false;
                }

                foreach (var item in usuario.GetAllPatentes())
                {
                    foreach (DataGridViewRow row in dgvPermisos.Rows)
                    {
                        if (item.idPatente == Guid.Parse(row.Cells["idPatente"].Value.ToString()))
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                            chk.Value = true;
                        }
                    }
                }

                ListarPermisosDeUsuario();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }
    }
}
