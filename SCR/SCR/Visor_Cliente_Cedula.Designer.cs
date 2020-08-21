namespace SCR
{
    partial class Visor_Cliente_Cedula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_Cliente_Cedula));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SCRDataSet = new SCR.SCRDataSet();
            this.Punto_Venta_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Punto_Venta_ClienteTableAdapter = new SCR.SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Punto_Venta_ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Punto_Venta_ClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCR.Rpt_Cliente_Cedula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCRDataSet
            // 
            this.SCRDataSet.DataSetName = "SCRDataSet";
            this.SCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Punto_Venta_ClienteBindingSource
            // 
            this.Punto_Venta_ClienteBindingSource.DataMember = "Punto_Venta_Cliente";
            this.Punto_Venta_ClienteBindingSource.DataSource = this.SCRDataSet;
            // 
            // Punto_Venta_ClienteTableAdapter
            // 
            this.Punto_Venta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Visor_Cliente_Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 371);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor_Cliente_Cedula";
            this.Text = "Reporte de punto de venta o cliente";
            this.Load += new System.EventHandler(this.Visor_Cliente_Cedula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Punto_Venta_ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Punto_Venta_ClienteBindingSource;
        private SCRDataSet SCRDataSet;
        private SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter Punto_Venta_ClienteTableAdapter;
    }
}