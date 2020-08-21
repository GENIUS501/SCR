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
    public partial class Visor_Sessiones_Fechas : Form
    {
        public string Usuario { get; set; }
        public DateTime Fecha_Ini { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public Visor_Sessiones_Fechas()
        {
            InitializeComponent();
        }

        private void Visor_Sessiones_Fechas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SCRDataSet.Ingresos_Salidas' Puede moverla o quitarla según sea necesario.
                this.Ingresos_SalidasTableAdapter.Fill(this.SCRDataSet.Ingresos_Salidas);
                ReportParameter[] parameters = new ReportParameter[3];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Fecha_Ini", Fecha_Ini.ToString());
                parameters[2] = new ReportParameter("Fecha_Fin", Fecha_Fin.ToString());
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
