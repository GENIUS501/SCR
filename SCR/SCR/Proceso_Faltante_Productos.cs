using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace SCR
{
    public partial class Proceso_Faltante_Productos : Form
    {
        Productos prod;
        Gestor Negocios;
        Faltantes Falta;
        public string Usuario { get; set; }
        public Proceso_Faltante_Productos()
        {
            InitializeComponent();
        }

        private void Proceso_Faltante_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Punto_Venta_Cliente' Puede moverla o quitarla según sea necesario.
                this.punto_Venta_ClienteTableAdapter.Fill(this.sCRDataSet.Punto_Venta_Cliente);
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Zonas' Puede moverla o quitarla según sea necesario.
                this.zonasTableAdapter.Fill(this.sCRDataSet.Zonas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Buscar()
        {
            prod = new Productos();
            Negocios = new Gestor();
            prod = Negocios.Mostrar_Productos_Unico(int.Parse(this.txt_codigo.Text));
            if (prod.Codigo_Producto == 0)
            {
                MessageBox.Show("El producto no existe!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            else
            {
                this.txt_descripcion.Text = prod.Descripcion;
                this.txt_nombre.Text = prod.Nombre;
                this.txt_marca.Text = prod.Marca;
                return 0; 
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                    if (e.KeyChar == (char)Keys.Enter||e.KeyChar == 13)
                    {
                    // MessageBox.Show("Enter key pressed");
                    Buscar();
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
                if(this.txt_fecha_mes.Text!=""||this.txt_codigo.Text!="" ||this.txt_cantidad.Text!="")
                {
                   int proceder = Buscar();
                    if(proceder==0)
                    {
                        string Sugeridos = "N";
                        if (this.chb_sugerido.Checked == true)
                        {
                            Sugeridos = "S";
                        }
                        Falta = new Faltantes(0, int.Parse(this.txt_codigo.Text), int.Parse(this.cbo_punto_venta.SelectedValue.ToString()), Sugeridos, this.txt_fecha_mes.Text, int.Parse(this.txt_cantidad.Text), Usuario);
                        Int32 FilasAfectadas = 0;
                        Negocios = new Gestor();
                        FilasAfectadas = Negocios.AgregarFaltante(Falta,Usuario);
                        if(FilasAfectadas>0)
                        {
                            MessageBox.Show("Faltante de producto generado exitosamente!!!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Visor_Faltantes frm = new Visor_Faltantes();
                            frm.Usuario = Usuario;
                            frm.id = FilasAfectadas;
                            //frm.MdiParent = this.MdiParent;
                            frm.ShowDialog();
                            this.Close();
                        }else
                        {
                            MessageBox.Show("Se ha producido un error al generar el faltante!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }else
                {
                    MessageBox.Show("No se ha llenado uno o varios campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
