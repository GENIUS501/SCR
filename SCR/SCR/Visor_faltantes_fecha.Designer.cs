namespace SCR
{
    partial class Visor_faltantes_fecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_faltantes_fecha));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SCRDataSet = new SCR.SCRDataSet();
            this.FaltantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FaltantesTableAdapter = new SCR.SCRDataSetTableAdapters.FaltantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaltantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FaltantesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCR.Rpt_faltantes_fecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1031, 439);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCRDataSet
            // 
            this.SCRDataSet.DataSetName = "SCRDataSet";
            this.SCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FaltantesBindingSource
            // 
            this.FaltantesBindingSource.DataMember = "Faltantes";
            this.FaltantesBindingSource.DataSource = this.SCRDataSet;
            // 
            // FaltantesTableAdapter
            // 
            this.FaltantesTableAdapter.ClearBeforeFill = true;
            // 
            // Visor_faltantes_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 439);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor_faltantes_fecha";
            this.Text = "Reporte Faltantes";
            this.Load += new System.EventHandler(this.Visor_faltantes_fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaltantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FaltantesBindingSource;
        private SCRDataSet SCRDataSet;
        private SCRDataSetTableAdapters.FaltantesTableAdapter FaltantesTableAdapter;
    }
}