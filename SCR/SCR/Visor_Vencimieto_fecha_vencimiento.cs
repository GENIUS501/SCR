using Microsoft.Reporting.WinForms;
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
    public partial class Visor_Vencimieto_fecha_vencimiento : Form
    {
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Visor_Vencimieto_fecha_vencimiento()
        {
            InitializeComponent();
        }

        private void Visor_Vencimieto_fecha_vencimiento_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'Vencimiento.DataTable1' Puede moverla o quitarla según sea necesario.
                this.DataTable1TableAdapter.Fill(this.Vencimiento.DataTable1);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Fecha", Fecha.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
