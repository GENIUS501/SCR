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
    public partial class Visor_Movimientos_Accion : Form
    {
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public Visor_Movimientos_Accion()
        {
            InitializeComponent();
        }

        private void Visor_Movimientos_Accion_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SCRDataSet.Acciones_Realizadas' Puede moverla o quitarla según sea necesario.
                this.Acciones_RealizadasTableAdapter.Fill(this.SCRDataSet.Acciones_Realizadas);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Accion", Accion.ToString());
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
