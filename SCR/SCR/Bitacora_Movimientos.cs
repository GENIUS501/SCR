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
    public partial class Bitacora_Movimientos : Form
    {
        Gestor Negocios;
        public string Usuario { get; set; }
        public Bitacora_Movimientos()
        {
            InitializeComponent();
        }

        private void Bitacora_Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Acciones_Realizadas' Puede moverla o quitarla según sea necesario.
                this.acciones_RealizadasTableAdapter.Fill(this.sCRDataSet.Acciones_Realizadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Usuario_Click(object sender, EventArgs e)
        {

            try
            {
                if(this.txt_usuario.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_sesiones.DataSource = Negocios.llenar_Bitacora_Movimientos(this.txt_usuario.Text);
                }else
                {
                    Bitacora_Movimientos_Load(null,null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_fechas_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_sesiones.DataSource = Negocios.llenar_Bitacora_Movimientos(Convert.ToDateTime(this.txt_fecha_ini.Text),Convert.ToDateTime(this.txt_fecha_fin.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_movimientos_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_sesiones.DataSource = Negocios.llenar_Bitacora_Movimientosv(this.cbo_movimiento.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    Visor_Movimientos_Usuario frm = new Visor_Movimientos_Usuario();
                    frm.Usuario = Usuario;
                    frm.Nombre_Usuario = this.txt_usuario.Text;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_fechas_Click(object sender, EventArgs e)
        {
            try
            {
                    Visor_Movimientos_Fechas frm = new Visor_Movimientos_Fechas();
                    frm.Usuario = Usuario;
                    frm.Fecha_Ini = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    frm.Fecha_Fin = Convert.ToDateTime(this.txt_fecha_fin.Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_movimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_movimiento.SelectedItem != null)
                {
                    Visor_Movimientos_Accion frm = new Visor_Movimientos_Accion();
                    frm.Usuario = Usuario;
                    frm.Accion = this.cbo_movimiento.SelectedItem.ToString();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
