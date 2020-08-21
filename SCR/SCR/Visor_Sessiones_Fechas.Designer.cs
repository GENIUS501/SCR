namespace SCR
{
    partial class Visor_Sessiones_Fechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_Sessiones_Fechas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SCRDataSet = new SCR.SCRDataSet();
            this.Ingresos_SalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ingresos_SalidasTableAdapter = new SCR.SCRDataSetTableAdapters.Ingresos_SalidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos_SalidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Ingresos_SalidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCR.Rpt_Sessiones_Fechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 335);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCRDataSet
            // 
            this.SCRDataSet.DataSetName = "SCRDataSet";
            this.SCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ingresos_SalidasBindingSource
            // 
            this.Ingresos_SalidasBindingSource.DataMember = "Ingresos_Salidas";
            this.Ingresos_SalidasBindingSource.DataSource = this.SCRDataSet;
            // 
            // Ingresos_SalidasTableAdapter
            // 
            this.Ingresos_SalidasTableAdapter.ClearBeforeFill = true;
            // 
            // Visor_Sessiones_Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 335);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor_Sessiones_Fechas";
            this.Text = "Sessiones Fechas";
            this.Load += new System.EventHandler(this.Visor_Sessiones_Fechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos_SalidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Ingresos_SalidasBindingSource;
        private SCRDataSet SCRDataSet;
        private SCRDataSetTableAdapters.Ingresos_SalidasTableAdapter Ingresos_SalidasTableAdapter;
    }
}