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
    public partial class Reporte_Punto_Venta_Cliente : Form
    {
        public string Usuario { get; set; }
        Gestor Negocios;
        public Reporte_Punto_Venta_Cliente()
        {
            InitializeComponent();
        }

        private void btn_buscar_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar_cedula.Text != "")
                {
                    Negocios = new Gestor();
                    this.dat_reporte.DataSource = Negocios.llenar_Puntos(int.Parse(this.txt_buscar_cedula.Text));
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
                    this.dat_reporte.DataSource = Negocios.llenar_Puntos(this.txt_buscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reporte_Punto_Venta_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Punto_Venta_Cliente' Puede moverla o quitarla según sea necesario.
                this.punto_Venta_ClienteTableAdapter.Fill(this.sCRDataSet.Punto_Venta_Cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar_cedula.Text != "")
                {
                    Visor_Cliente_Cedula frm = new Visor_Cliente_Cedula();
                    frm.Usuario = Usuario;
                    frm.Cedula = int.Parse(this.txt_buscar_cedula.Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar.Text != "")
                {
                    Visor_Cliente_Nombre frm = new Visor_Cliente_Nombre();
                    frm.Usuario = Usuario;
                    frm.Nombre = this.txt_buscar.Text;
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
