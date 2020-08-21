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
    public partial class Visor_Vencimientos_Reporte : Form
    {
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Visor_Vencimientos_Reporte()
        {
            InitializeComponent();
        }

        private void Visor_Vencimientos_Reporte_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha_ini = Fecha;
                DateTime fecha_fin = Fecha.AddHours(23).AddMinutes(59);
                // TODO: esta línea de código carga datos en la tabla 'Vencimiento.DataTable1' Puede moverla o quitarla según sea necesario.
                this.DataTable1TableAdapter.Fill(this.Vencimiento.DataTable1);
                ReportParameter[] parameters = new ReportParameter[3];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("fecha_ini", fecha_ini.ToString());
                parameters[2] = new ReportParameter("fecha_fin", fecha_fin.ToString());
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
