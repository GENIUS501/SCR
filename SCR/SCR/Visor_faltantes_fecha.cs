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
    public partial class Visor_faltantes_fecha : Form
    {
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public Visor_faltantes_fecha()
        {
            InitializeComponent();
        }

        private void Visor_faltantes_fecha_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SCRDataSet.Faltantes' Puede moverla o quitarla según sea necesario.
                this.FaltantesTableAdapter.Fill(this.SCRDataSet.Faltantes);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Fecha", Fecha.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
