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
    public partial class Reporte_Vencimiento_producto : Form
    {
        public string Usuario { get; set; }
        Gestor Negocios;
        public Reporte_Vencimiento_producto()
        {
            InitializeComponent();
        }

        private void Reporte_Vencimiento_producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Supervisores' Puede moverla o quitarla según sea necesario.
            this.supervisoresTableAdapter.Fill(this.sCRDataSet.Supervisores);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Vencimiento_Productos' Puede moverla o quitarla según sea necesario.
                this.vencimiento_ProductosTableAdapter.Fill(this.sCRDataSet.Vencimiento_Productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_vencimiento_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_vencimiento.DataSource = Negocios.llenar_Vencimiento(Convert.ToDateTime(this.txt_vencimiento_producto.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_reporte_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_vencimiento.DataSource = Negocios.llenar_Vencimientov(Convert.ToDateTime(this.txt_reporte.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_supervision_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_vencimiento.DataSource = Negocios.llenar_Vencimiento(int.Parse(this.cbo_supervisor.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_vencimiento_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Vencimieto_fecha_vencimiento frm = new Visor_Vencimieto_fecha_vencimiento();
                frm.Usuario = Usuario;
                frm.Fecha = Convert.ToDateTime(this.txt_vencimiento_producto.Text);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_reporte_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Vencimientos_Reporte frm = new Visor_Vencimientos_Reporte();
                frm.Usuario = Usuario;
                frm.Fecha = Convert.ToDateTime(this.txt_reporte.Text);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_supervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Vencimiento_Supervisor frm = new Visor_Vencimiento_Supervisor();
                frm.Usuario = Usuario;
                frm.Cedula = int.Parse(this.cbo_supervisor.SelectedValue.ToString());
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
