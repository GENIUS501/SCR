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
    public partial class Reporte_Faltante_Productos : Form
    {
        Gestor Negocios;
        public string Usuario { get; set; }
        public Reporte_Faltante_Productos()
        {
            InitializeComponent();
        }

        private void btn_buscar_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_fecha_mes.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_faltante.DataSource = Negocios.llenar_Faltante(this.txt_fecha_mes.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_punto_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_faltante.DataSource = Negocios.llenar_Faltantev(int.Parse(this.cbo_punto.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_codigo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_codigo.Text != "")
                {
                    Negocios = new Gestor();
                    this.dat_faltante.DataSource = Negocios.llenar_Faltante(int.Parse(this.txt_codigo.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Reporte_Faltante_Productos_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Punto_Venta_Cliente' Puede moverla o quitarla según sea necesario.
                this.punto_Venta_ClienteTableAdapter.Fill(this.sCRDataSet.Punto_Venta_Cliente);
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Faltantes' Puede moverla o quitarla según sea necesario.
                this.faltantesTableAdapter.Fill(this.sCRDataSet.Faltantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_fecha_mes.Text!= "")
                {
                    Visor_faltantes_fecha frm = new Visor_faltantes_fecha();
                    frm.Usuario = Usuario;
                    frm.Fecha = this.txt_fecha_mes.Text;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_punto_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Faltantes_Cedula frm = new Visor_Faltantes_Cedula();
                frm.Usuario = Usuario;
                frm.Cedula = int.Parse(this.cbo_punto.SelectedValue.ToString());
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_codigo_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_codigo.Text!="")
                {
                    Visor_Faltantes_Codigo frm = new Visor_Faltantes_Codigo();
                    frm.Usuario = Usuario;
                    frm.Codigo = int.Parse(this.txt_codigo.Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
