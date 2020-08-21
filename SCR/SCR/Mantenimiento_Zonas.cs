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
    public partial class Mantenimiento_Zonas : Form
    {
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        Gestor Negocios;
        Zonas Zona;
        public Mantenimiento_Zonas()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Zonas_Load(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="A")
                {
                    this.txt_Id.Visible = false;
                    this.label1.Visible = false;
                }
                if(Accion=="M"||Accion == "E" ||Accion=="C")
                {
                    Negocios = new Gestor();
                    Zona = new Zonas();
                    Zona = Negocios.Mostrar_Zonas_Unico(Id);
                    this.txt_Id.Text = Zona.Id_Zona.ToString();
                    this.txt_Id.Enabled = false;
                    this.txt_nombre.Text = Zona.Nombre_Zona;
                    if(Accion == "E" || Accion == "C")
                    {
                        this.txt_nombre.Enabled = false;
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
                if(Accion=="A"||Accion=="M" || Accion=="E")
                {
                    if(this.txt_nombre.Text !="")
                    {
                        Negocios = new Gestor();
                        Int32 FilasAfectadas;
                        #region Agregar
                        if (Accion == "A")
                        {
                            Zona = new Zonas(0, this.txt_nombre.Text);
                            FilasAfectadas = Negocios.AgregarZona(Zona, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Zona agregada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Zona agregada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar la Zona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            Zona = new Zonas(int.Parse(this.txt_Id.Text), this.txt_nombre.Text);
                            FilasAfectadas = Negocios.Modificar_Zonas(Zona, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Zona modificada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Zona modificada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar la Zona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Eliminar
                        if (Accion == "E")
                        {
                            Zona = new Zonas(int.Parse(this.txt_Id.Text), this.txt_nombre.Text);
                            DialogResult dr = MessageBox.Show("Realmente desea eliminar la Zona?", "Eliminar la Zona", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                FilasAfectadas = Negocios.Eliminar_Zona(Zona.Id_Zona, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Zona Eliminada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("Zona eliminada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MessageBox.Show("Error al registra la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar la zona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    else
                    {
                        MessageBox.Show("No se ha llenado el nombre!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                if(Accion=="c")
                {
                    this.Close();
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
    }
}
