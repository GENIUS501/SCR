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
    public partial class Lista_Punto_Venta_Cliente : Form
    {
        int valorcelda = -1;
        int numero_modulo =4;
        public string Usuario { get; set; }
        public int Id_Rol { get; set; }
        Gestor Negocios;
        Accesos Permi;
        public Lista_Punto_Venta_Cliente()
        {
            InitializeComponent();
        }

        private void Lista_Punto_Venta_Cliente_Load(object sender, EventArgs e)
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
                this.dat_Cliente.DataSource = Negocios.llenar_Puntos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_buscar_cedula.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_Cliente.DataSource = Negocios.llenar_Puntos(int.Parse(this.txt_buscar_cedula.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar.Text != "")
                {
                    Negocios = new Gestor();
                    this.dat_Cliente.DataSource = Negocios.llenar_Puntos(this.txt_buscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Renderizar(string Accion)
        {
            try
            {
                if (Accion != "A" && Accion == "M" && valorcelda != -1 || Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
                {
                    Mantenimiento_Punto_Venta_Cliente frm = new Mantenimiento_Punto_Venta_Cliente();
                    frm.Accion = Accion;
                    frm.Usuario = Usuario;
                    frm.Cedula = valorcelda;
                    frm.ShowDialog();
                    valorcelda = -1;
                    Lista_Punto_Venta_Cliente_Load(null,null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        Mantenimiento_Punto_Venta_Cliente frm = new Mantenimiento_Punto_Venta_Cliente();
                        frm.Accion = Accion;
                        frm.Usuario = Usuario;
                        frm.Cedula = valorcelda;
                        frm.ShowDialog();
                        valorcelda = -1;
                        Lista_Punto_Venta_Cliente_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un punto de venta cliente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_Cliente.Rows[e.RowIndex].Cells[4].Value.ToString() == "")
                {
                    Lista_Punto_Venta_Cliente_Load(null, null);
                }
                else
                {
                    valorcelda = Convert.ToInt32(this.dat_Cliente.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
