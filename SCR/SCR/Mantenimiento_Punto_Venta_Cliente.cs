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
    public partial class Mantenimiento_Punto_Venta_Cliente : Form
    {
        public int Cedula { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        Gestor Negocios;
        Punto_Venta_Cliente Pun;
        public Mantenimiento_Punto_Venta_Cliente()
        {
            InitializeComponent();
        }
        private void llenar()
        {
            Negocios = new Gestor();
            Pun = new Punto_Venta_Cliente();
            Pun = Negocios.Mostrar_Puntos_Unico(Cedula);
            this.txt_cedula.Text = Pun.Cedula_juridica_fisica.ToString();
            this.txt_correo.Text = Pun.CorreoElectronico;
            this.txt_direccion.Text = Pun.Direccion;
            this.txt_nombre.Text = Pun.Nombre.ToString();
            this.txt_telefono.Text = Pun.Telefono.ToString();
        }
        private void Mantenimiento_Punto_Venta_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "C" || Accion == "E" || Accion == "M")
                {
                    llenar();
                    this.txt_cedula.Enabled = false;
                    if(Accion == "C" || Accion == "E")
                    {
                        this.txt_correo.Enabled = false;
                        this.txt_direccion.Enabled = false;
                        this.txt_nombre.Enabled = false;
                        this.txt_telefono.Enabled = false;
                    }
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
                if(this.txt_cedula.Text!=""||this.txt_correo.Text !="" ||this.txt_direccion.Text!="" ||this.txt_nombre.Text!="" ||this.txt_telefono.Text!="")
                {
                    if (this.txt_telefono.Text.Length == 8)
                    {
                        if(this.txt_correo.Text.Contains("@") && this.txt_correo.Text.Contains(".com"))
                        {
                            if (this.txt_cedula.Text.Length > 8)
                            {
                                #region lo de adentro
                                if (Accion == "A" || Accion == "M" || Accion == "E")
                                {
                                    Pun = new Punto_Venta_Cliente(this.txt_nombre.Text, this.txt_direccion.Text, int.Parse(this.txt_telefono.Text), this.txt_correo.Text, int.Parse(this.txt_cedula.Text));
                                    Int32 FilasAfectadas = 0;
                                    Negocios = new Gestor();
                                    #region Agregar
                                    if (Accion == "A")
                                    {
                                        FilasAfectadas = Negocios.AgregarPunto(Pun, Usuario);
                                        if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Punto de venta de cliente agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (FilasAfectadas == -1)
                                            {
                                                MessageBox.Show("Punto de venta de cliente agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al agregar el punto de venta cliente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Modificar
                                    if (Accion == "M")
                                    {
                                        FilasAfectadas = Negocios.Modificar_Punto(Pun, Usuario);
                                        if (FilasAfectadas > 0)
                                        {
                                            MessageBox.Show("Punto de venta de cliente actualizado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (FilasAfectadas == -1)
                                            {
                                                MessageBox.Show("Punto de venta de cliente actualizado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al actualizar el punto de venta cliente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Eliminar
                                    if (Accion == "E")
                                    {
                                        DialogResult dr = MessageBox.Show("Realmente desea eliminar punto de venta cliente?", "Eliminar el punto de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                        if (dr == DialogResult.Yes)
                                        {
                                            FilasAfectadas = Negocios.Eliminar_Punto(Pun.Cedula_juridica_fisica, Usuario);
                                            if (FilasAfectadas > 0)
                                            {
                                                MessageBox.Show("Punto de venta de cliente eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                if (FilasAfectadas == -1)
                                                {
                                                    MessageBox.Show("Punto de venta de cliente eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al eliminar el punto de venta cliente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (Accion == "C")
                                {
                                    this.Close();
                                }
                                #endregion
                            }
                            else
                            {
                                MessageBox.Show("Formato de cedula invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Formato de correo invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Formato de telefono invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
