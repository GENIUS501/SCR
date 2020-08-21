using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCR
{
    public partial class Mantenimiento_Supervisores : Form
    {
        public string Accion { get; set; }
        public int Cedula { get; set; }
        public string Usuario { get; set; }
        Gestor Negocios;
        Supervisores Sup;
        public Mantenimiento_Supervisores()
        {
            InitializeComponent();
        }

        private void llenar()
        {
            Negocios = new Gestor();
            Sup = new Supervisores(Negocios.Mostrar_Supervisores_Unico(Cedula));
            this.txt_apellido1.Text = Sup.Primer_Apellido;
            this.txt_apellido2.Text = Sup.Segundo_Apellido;
            this.txt_cedula.Text = Sup.Cedula.ToString();
            this.txt_correo.Text = Sup.Correo;
            this.txt_nombre.Text = Sup.Nombre;
            this.txt_telefono.Text = Sup.Telefono.ToString();
        }

        private void Mantenimiento_Supervisores_Load(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="M"|| Accion == "E" || Accion == "C")
                {
                    llenar();
                    this.txt_cedula.Enabled = false;
                    if(Accion=="E" ||Accion=="C")
                    {
                        this.grb_contacto.Enabled = false;
                        this.grb_personales.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_apellido1.Text!=""&&this.txt_apellido2.Text!=""&&this.txt_cedula.Text!=""&&this.txt_correo.Text!=""&&this.txt_nombre.Text!=""&&this.txt_telefono.Text!="")
                {
                    if(this.txt_cedula.Text.Length>8&&this.txt_cedula.Text.Length<10)
                    {
                        if (this.txt_correo.Text.Contains("@") && this.txt_correo.Text.Contains(".com"))
                        {
                            if(this.txt_telefono.Text.Length==8)
                            {
                                #region lo de adentro
                                if (Accion == "A" || Accion == "M" || Accion == "E")
                                {
                                    Sup = new Supervisores(int.Parse(this.txt_cedula.Text), this.txt_nombre.Text, this.txt_apellido1.Text, this.txt_apellido2.Text, this.txt_correo.Text, int.Parse(this.txt_telefono.Text));
                                    Int32 FilasAfectadas = 0;
                                    Negocios = new Gestor();
                                    #region Agregar
                                    if (Accion == "A")
                                    {
                                        FilasAfectadas = Negocios.AgregarSupervisor(Sup, Usuario);
                                        if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Supervisor agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (FilasAfectadas == -1)
                                            {
                                                MessageBox.Show("Supervisor agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al agregar el supervisor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Modificar
                                    if (Accion == "M")
                                    {
                                        FilasAfectadas = Negocios.Modificar_Supervisores(Sup, Usuario);
                                        if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Supervisor actualizado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (FilasAfectadas == -1)
                                            {
                                                MessageBox.Show("Supervisor actualizado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al actualizar el Supervisor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Eliminar
                                    if (Accion == "E")
                                    {
                                        DialogResult dr = MessageBox.Show("Realmente desea eliminar Supervisor?", "Eliminar el Supervisor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                        if (dr == DialogResult.Yes)
                                        {
                                            FilasAfectadas = Negocios.Eliminar_Supervisor(Sup.Cedula, Usuario);
                                            if (FilasAfectadas > 0)
                                            {
                                                MessageBox.Show("Supervisor eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                if (FilasAfectadas == -1)
                                                {
                                                    MessageBox.Show("Supervisor eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al eliminar el Supervisor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            this.Close();
                                        }
                                    }
                                    #endregion

                                }
                                if (Accion == "C")
                                {
                                    this.Close();
                                }
                                #endregion
                            }else
                            {
                                MessageBox.Show("Formato de telefono invalido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Formato de correo invalido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de cedula incorrecto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha llenado uno o varios campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
