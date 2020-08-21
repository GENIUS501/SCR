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
    public partial class Mantenimiento_Usuarios : Form
    {
        Gestor Negocios;
        Usuarios Usu;
        public string Accion { get; set; }
        private string contrasena = "";
        public string Nombre_Usuario { get; set; }
        public string User { get; set; }
        public Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }
        private void Llenar_cbo_genero()
        {
            try
            {
                this.cbo_genero.DisplayMember = "Text";
                this.cbo_genero.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Masculino", Value = "M" },
                                    new { Text = "Femenino", Value = "F" },
                                    };
                this.cbo_genero.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }

        private void llenar_usuario()
        {
            Negocios = new Gestor();
            Usu = new Usuarios();
            Usu = Negocios.Mostrar_Usuario_Unico(Nombre_Usuario);
            this.txt_cclave.Visible = false;
            this.lbl_cclave.Visible = false;
            this.txt_apellido1.Text = Usu.Primer_Apellido;
            this.txt_apellido2.Text = Usu.Segundo_Apellido;
            this.txt_cedula.Text = Usu.Cedula.ToString();
            this.txt_clave.Text = Usu.Clave;
            contrasena = Usu.Clave;
            this.txt_nombre.Text = Usu.Nombre;
            this.txt_nombre_usuario.Text = Usu.Nombre_Usuario;
            this.cbo_genero.SelectedValue = Usu.Sexo;
            this.cbo_rol.SelectedValue = Usu.Id_Rol;
        }

        private void Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Llenar_cbo_genero();
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Roles' Puede moverla o quitarla según sea necesario.
                this.rolesTableAdapter.Fill(this.sCRDataSet.Roles);
                if(Accion=="M"|| Accion == "C" || Accion == "E" )
                {
                    this.txt_cedula.Enabled = false;
                    this.txt_nombre_usuario.Enabled = false;
                    llenar_usuario();
                    if(Accion == "C" || Accion == "E")
                    {
                        this.txt_nombre.Enabled = false;
                        this.txt_apellido1.Enabled = false;
                        this.txt_apellido2.Enabled = false;
                        this.txt_clave.Enabled = false;
                        this.cbo_genero.Enabled = false;
                        this.cbo_rol.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="A"||Accion=="E" || Accion == "M")
                {
                    if (this.txt_cedula.Text != "" && this.txt_nombre.Text != "" && this.txt_apellido1.Text != "" && this.txt_apellido2.Text != "" && this.txt_nombre_usuario.Text!=""&&this.txt_clave.Text!="")
                    {
                        if (this.txt_cedula.Text.Length > 8 & this.txt_cedula.Text.Length < 11)
                        {
                            if (this.txt_cclave.Text == this.txt_clave.Text || Accion!="A" )
                            {
                                Usu = new Usuarios(int.Parse(this.txt_cedula.Text), this.txt_nombre_usuario.Text, this.txt_nombre.Text, this.txt_apellido1.Text, this.txt_apellido2.Text, Helper.EncodePassword(string.Concat(this.txt_nombre_usuario.Text.ToString(), this.txt_clave.ToString())), this.cbo_genero.SelectedValue.ToString(), int.Parse(this.cbo_rol.SelectedValue.ToString()));
                                Negocios = new Gestor();
                                Int32 FilasAfectadas = 0;
                                #region Agregar
                                if (Accion == "A")
                                {
                                    FilasAfectadas = Negocios.AgregarUsuarios(Usu,User);
                                    if(FilasAfectadas>0)
                                    {
                                        MessageBox.Show("Usuario Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (FilasAfectadas == -1)
                                        {
                                            MessageBox.Show("Usuario Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
#endregion

                                #region Modificar
                                if (Accion=="M")
                                {
                                    if (contrasena == this.txt_clave.Text)
                                        {
                                            FilasAfectadas = Negocios.Modificar_Usuario(Usu, User);
                                        }
                                    else
                                        {
                                            Usu.Clave = Helper.EncodePassword(string.Concat(this.txt_nombre_usuario.Text.ToString(), this.txt_clave.ToString()));
                                            FilasAfectadas = Negocios.Modificar_Usuario_pass(Usu, User);
                                        }
                                    if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Usuario modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                    else
                                        {
                                        if (FilasAfectadas == -1)
                                        {
                                            MessageBox.Show("Usuario modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                #endregion

                                #region Eliminar
                                if (Accion == "E")
                                {
                                    DialogResult dr = MessageBox.Show("Realmente desea eliminar el Usuario?", "Eliminar el Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (dr == DialogResult.Yes)
                                    {
                                        FilasAfectadas = Negocios.Eliminar_Usuario(Usu.Nombre_Usuario, "User");
                                        if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Usuario Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (FilasAfectadas == -1)
                                            {
                                                MessageBox.Show("El usuario se ha eliminado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                this.Close();
                                            }
                                            else
                                            {
                                                if (FilasAfectadas == -1)
                                                {
                                                    MessageBox.Show("Usuario eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
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
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en el formato de la cedula!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha llenado uno o varios campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #region Consultar
                if (Accion == "C")
                {
                    this.Close();
                }
                #endregion
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
