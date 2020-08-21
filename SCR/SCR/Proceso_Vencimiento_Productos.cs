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
    public partial class Proceso_Vencimiento_Productos : Form
    {
        Gestor Negocios;
        Vencimiento_Productos Vencido;
        public string Usuario { get; set; }
        public Proceso_Vencimiento_Productos()
        {
            InitializeComponent();
        }

        private void txt_tiempo_reaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_unidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Proceso_Vencimiento_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Zonas' Puede moverla o quitarla según sea necesario.
                this.zonasTableAdapter.Fill(this.sCRDataSet.Zonas);
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Punto_Venta_Cliente' Puede moverla o quitarla según sea necesario.
                this.punto_Venta_ClienteTableAdapter.Fill(this.sCRDataSet.Punto_Venta_Cliente);
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Supervisores' Puede moverla o quitarla según sea necesario.
                this.supervisoresTableAdapter.Fill(this.sCRDataSet.Supervisores);
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

                if (this.txt_codigo.Text!=""&&this.txt_unidades.Text!=""&&this.txt_tiempo_reaccion.Text!=""&&this.txt_descripcion.Text!="")
                {
                    Negocios = new Gestor();
                    string S3 = "N";
                    string S5 = "N";
                    if(this.chb_3_meses.Checked==true)
                    {
                        S3 = "S";
                    }
                    if(this.chb_5_meses.Checked==true)
                    {
                        S5 = "S";
                    }
                    Vencido = new Vencimiento_Productos();
                    Vencido.Cedula_Supervisor = int.Parse(this.cbo_supervisor.SelectedValue.ToString());
                    Vencido.tiempo_reaccion = int.Parse(this.txt_tiempo_reaccion.Text);
                    Vencido.Cliente = int.Parse(this.cbo_cliente.SelectedValue.ToString());
                    Vencido.Descripcion_SKU = this.txt_descripcion.Text;
                    Vencido.Fecha_reporte_vencimiento = DateTime.Now;
                    Vencido.Fecha_vencimiento_producto = Convert.ToDateTime(this.txt_fecha_vencimiento.Text);
                    Vencido.Observaciones = this.txt_observaciones.Text;
                    Vencido.Seguimiento_3_meses = S3;
                    Vencido.Seguimiento_5_meses = S5;
                    Vencido.UnidadesxSKU = int.Parse(this.txt_unidades.Text);
                    Vencido.Zona = int.Parse(this.cbo_zona.SelectedValue.ToString());
                    Vencido.Usuario = Usuario;
                    Int32 FilasAfectadas = 0;
                    FilasAfectadas = Negocios.AgregarVencimiento(Vencido,Usuario);
                    if(FilasAfectadas>0)
                    {
                        MessageBox.Show("Vencimiento generado exitosamente!!!","exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Visor_Vencimiento frm = new Visor_Vencimiento();
                        frm.Usuario = Usuario;
                        frm.Id = FilasAfectadas;
                        frm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
