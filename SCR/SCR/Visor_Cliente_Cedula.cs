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
    public partial class Visor_Cliente_Cedula : Form
    {
        public string Usuario { get; set; }
        public int Cedula { get; set; }
        public Visor_Cliente_Cedula()
        {
            InitializeComponent();
        }

        private void Visor_Cliente_Cedula_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SCRDataSet.Punto_Venta_Cliente' Puede moverla o quitarla según sea necesario.
                this.Punto_Venta_ClienteTableAdapter.Fill(this.SCRDataSet.Punto_Venta_Cliente);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Cedula", Cedula.ToString());
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
