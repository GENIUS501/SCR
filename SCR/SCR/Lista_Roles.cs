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
    public partial class Lista_Roles : Form
    {
        Gestor Negocios;
        Accesos Permi;
        int valorcelda = -1;
        int numero_modulo = 1;
        public int Id_Rol { get; set; }
        public string Usuario { get; set; }
        public Lista_Roles()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_buscar.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_rol.DataSource = Negocios.llenar_Roles(this.txt_buscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Renderizar(string Accion)
        {
            if(Accion!="A"&&Accion=="M" && valorcelda!=-1|| Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
            {
                Mantenimiento_Roles frm = new Mantenimiento_Roles();
                frm.Accion = Accion;
                frm.Id_Rol = valorcelda;
                frm.Usuario = Usuario;
                frm.ShowDialog();
                valorcelda = -1;
                Lista_Roles_Load(null, null);
            }
            else
            {
                if(Accion=="A")
                {
                    Mantenimiento_Roles frm = new Mantenimiento_Roles();
                    frm.Accion = Accion;
                    frm.Id_Rol = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    Lista_Roles_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("M");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("E");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista_Roles_Load(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                Permi = new Accesos();
                //Agregar
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Agregar");
                if (Permi.Modulo > 0)
                {
                    this.btn_agregar.Enabled = true;
                }
                //Modificar
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                if (Permi.Modulo > 0)
                {
                    this.btn_modificar.Enabled = true;
                }
                //Consultar
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                if (Permi.Modulo > 0)
                {
                    this.btn_consultar.Enabled = true;
                }
                //Eliminar
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                if (Permi.Modulo > 0)
                {
                    this.btn_eliminar.Enabled = true;
                }
                this.dat_rol.DataSource=Negocios.llenar_Roles();
                valorcelda = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_rol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_rol.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    Lista_Roles_Load(null, null);
                }
                else
                {
                    valorcelda = Convert.ToInt32(this.dat_rol.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
