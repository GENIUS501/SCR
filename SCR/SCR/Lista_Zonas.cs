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
    public partial class Lista_Zonas : Form
    {
        public string Usuario { get; set; }
        Gestor Negocios;
        int valorcelda = -1;
        public Lista_Zonas()
        {
            InitializeComponent();
        }

        private void Renderizar(string Accion)
        {
            try
            {
                if (Accion != "A" && Accion == "M" && valorcelda != -1 || Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
                {
                    Mantenimiento_Zonas frm = new Mantenimiento_Zonas();
                    frm.Accion = Accion;
                    frm.Id = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    Lista_Zonas_Load(null, null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        Mantenimiento_Zonas frm = new Mantenimiento_Zonas();
                        frm.Accion = Accion;
                        frm.Id = valorcelda;
                        frm.Usuario = Usuario;
                        frm.ShowDialog();
                        valorcelda = -1;
                        Lista_Zonas_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una zona!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_zonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_zonas.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    Lista_Zonas_Load(null, null);
                }
                else
                {
                    valorcelda = Convert.ToInt32(this.dat_zonas.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void Lista_Zonas_Load(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_zonas.DataSource = Negocios.llenar_Zonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
