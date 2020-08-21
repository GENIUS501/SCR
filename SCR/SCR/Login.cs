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
    public partial class Login : Form
    {
        Gestor Negocios;
        Ingresos_Salidas ses;
        Usuarios usu;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                usu = new Usuarios();
                int Id_Session = 0;
                string pass = Helper.EncodePassword(string.Concat(this.txt_Usuario.Text.ToString(), this.txt_contrasena.ToString()));
                usu = Negocios.Login(this.txt_Usuario.Text, pass);
                if (usu.Cedula != 0)
                {
                    ses = new Ingresos_Salidas();
                    ses.Fecha_Hora_Ingreso = DateTime.Now;
                    ses.Nombre_Usuario = this.txt_Usuario.Text;
                    Id_Session = Negocios.Ingreso(ses);
                    if (Id_Session > 0)
                    {
                        this.Hide();
                        Menu form = new Menu();
                        form.Id_Rol = usu.Id_Rol;
                        form.id_sesion = Id_Session;
                        form.Usuario = usu.Nombre_Usuario;
                        MessageBox.Show("Bienvenido: " + usu.Nombre_Usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error usuario o contraseña invalido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
