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
    public partial class Mantenimiento_Productos : Form
    {
        public string Accion { get; set; }
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        Gestor Negocios;
        Productos Prod;
        public Mantenimiento_Productos()
        {
            InitializeComponent();
        }
        private void llenar()
        {
            Negocios = new Gestor();
            Prod = new Productos();
            Prod = Negocios.Mostrar_Productos_Unico(Codigo);
            this.txt_codigo.Text = Prod.Codigo_Producto.ToString();
            this.txt_marca.Text = Prod.Marca;
            this.txt_nombre.Text = Prod.Nombre;
            this.txt_descripcion.Text = Prod.Descripcion;
        }
        private void Mantenimiento_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="M"|| Accion == "E" || Accion == "C")
                {
                    llenar();
                    this.txt_codigo.Enabled = false;
                    if(Accion == "E" || Accion == "C")
                    {
                        this.txt_descripcion.Enabled = false;
                        this.txt_marca.Enabled = false;
                        this.txt_nombre.Enabled = false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_codigo.Text!=""&&this.txt_nombre.Text!=""&&this.txt_marca.Text!=""&&this.txt_descripcion.Text!="")
                {
                    if(Accion=="A"|| Accion == "M" || Accion == "E" )
                    {
                        Prod = new Productos(int.Parse(this.txt_codigo.Text),this.txt_nombre.Text,this.txt_descripcion.Text,this.txt_marca.Text);
                        Int32 FilasAfectadas = 0;
                        Negocios = new Gestor();

                        #region Agregar
                        if(Accion=="A")
                        {
                            FilasAfectadas = Negocios.AgregarProducto(Prod,Usuario);
                            if(FilasAfectadas>0)
                            {
                                MessageBox.Show("Producto agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Producto agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            FilasAfectadas = Negocios.Modificar_Productos(Prod, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Producto modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Producto modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Eliminar
                        if (Accion == "E")
                        {
                            DialogResult dr = MessageBox.Show("Realmente desea eliminar producto?", "Eliminar el producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                FilasAfectadas = Negocios.Eliminar_Producto(Prod.Codigo_Producto, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Producto Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("Producto Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        #endregion

                   }
                    if(Accion=="C")
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha llenado uno o varios campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
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
