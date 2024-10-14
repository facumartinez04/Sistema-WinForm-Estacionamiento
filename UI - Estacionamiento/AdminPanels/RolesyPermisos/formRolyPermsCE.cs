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

namespace UI___Estacionamiento.AdminPanels.RolesyPermisos
{
    public partial class formRolyPermsCE : Form
    {
        private string _tipo;
        private Guid _id;

        private formRolesyPermisos formPrincipal;

        public formRolyPermsCE()
        {
            InitializeComponent();
        }

        public formRolyPermsCE(string tipo,Guid id, formRolesyPermisos form)
        {
            InitializeComponent();
            formPrincipal = form;
            this._id = id;
            this._tipo = tipo;
            if (tipo == "Permiso")
            {
                if(id == Guid.Empty) {
                    AgregarPermiso();
                }
                else
                {
                    ModificarPermiso(id);
                }
            }
            else if (tipo == "Rol")
            {
                if (id == Guid.Empty)
                {
                    AgregarRol();
                }
                else
                {
                    ModificarRol(id);
                }
            }
}
        private void formRolyPermsCE_Load(object sender, EventArgs e)
        {

        }


        private void AgregarPermiso()
        {
            titulo.Text = "Agregar Permiso";
            btnAccion.Text = "Agregar";
            lbl1.Text = "Nombre del Permiso";
            lbl2.Text = "Data Key";
            txt1.Text = "";
            txt2.Text = "";
            pan3.Visible = false;
        }

        private void ModificarPermiso(Guid id)
        {

            Patente patente = PatenteRepository.Current.GetById(id);
            txt1.Text = patente.Nombre;
            txt2.Text = patente.DataKey;
            txt3.Text = patente.idPatente.ToString();
            titulo.Text = "Modificar Permiso";
            btnAccion.Text = "Modificar";
            lbl1.Text = "Nombre del Permiso";
            lbl2.Text = "Data Key";
            pan3.Visible = false;
        }

        private void ModificarRol(Guid id)
        {
            Familia familia = FamiliaRepository.Current.GetById(id);
            txt1.Text = familia.Nombre;
            titulo.Text = "Modificar Rol";
            btnAccion.Text = "Modificar";
            lbl1.Text = "Nombre del Rol";
            lbl2.Text = "";
            txt1.Text = "";
            pan2.Visible = false;
            pan3.Visible = false;
        }

        private void AgregarRol()
        {
            titulo.Text = "Agregar Rol";
            btnAccion.Text = "Agregar";
            lbl1.Text = "Nombre del Rol";
            lbl2.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            pan2.Visible = false;
            pan3.Visible = false;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (titulo.Text.Contains("Permiso"))
                {

                    if(titulo.Text == "Modificar Permiso")
                    {
                        PatenteRepository.Current.Update(new Patente()
                        {
                            idPatente = Guid.Parse(txt3.Text),
                            Nombre = txt1.Text,
                            DataKey = txt2.Text
                        });

                        this.Close();
                        formPrincipal.CargarPermisos();
                    }else if (titulo.Text == "Agregar Permiso")
                    {
                        PatenteRepository.Current.Add(new Patente()
                        {
                            Nombre = txt1.Text,
                            DataKey = txt2.Text
                        });

                        this.Close();
                        formPrincipal.CargarPermisos();
                    }

                }
                else if (titulo.Text == "Agregar Rol")
                {
                    FamiliaRepository.Current.Add(new Familia()
                    {
                        Nombre = txt1.Text
                    });

                    this.Close();
                    formPrincipal.CargarRoles();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txt3.Text == "") return;
            if (_tipo == "Permiso")
            {
                if (!PatenteRepository.Current.Remove(Guid.Parse(txt3.Text)))
                {
                    MessageBox.Show("No se pudo eliminar el permiso");

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Permiso eliminado correctamente");
                }

                    this.Close();
                formPrincipal.CargarPermisos();
            }
            else if (_tipo == "Rol")
            {
                if (FamiliaRepository.Current.Remove(Guid.Parse(txt3.Text)))
                {
                    MessageBox.Show("No se pudo eliminar el rol");

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Rol eliminado correctamente");
                }
                this.Close();
                formPrincipal.CargarRoles();
            }


        }
    }
}
