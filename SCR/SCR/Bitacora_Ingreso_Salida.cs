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
    public partial class Bitacora_Ingreso_Salida : Form
    {
        Gestor Negocios;
        public string Usuario { get; set; }
        public Bitacora_Ingreso_Salida()
        {
            InitializeComponent();
        }

        private void Bitacora_Ingreso_Salida_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sCRDataSet.Ingresos_Salidas' Puede moverla o quitarla según sea necesario.
                this.ingresos_SalidasTableAdapter.Fill(this.sCRDataSet.Ingresos_Salidas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_usuario.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_sesiones.DataSource = Negocios.llenar_Bitacora_Sesiones(this.txt_usuario.Text);
                }else
                {
                    Bitacora_Ingreso_Salida_Load(null,null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Sessiones_Usuario frm = new Visor_Sessiones_Usuario();
                frm.Usuario = Usuario;
                frm.Nombre_Usuario = this.txt_usuario.Text;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_sesiones.DataSource = Negocios.llenar_Bitacora_Sesiones(Convert.ToDateTime(this.txt_fecha_ini.Text),Convert.ToDateTime(this.txt_fecha_fin.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Sessiones_Fechas frm = new Visor_Sessiones_Fechas();
                frm.Usuario = Usuario;
                frm.Fecha_Ini = Convert.ToDateTime(this.txt_fecha_ini.Text);
                frm.Fecha_Fin = Convert.ToDateTime(this.txt_fecha_fin.Text);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
