namespace SCR
{
    partial class Visor_Vencimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_Vencimiento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vencimiento = new SCR.Vencimiento();
            this.vencimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new SCR.VencimientoTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vencimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCR.Rpt_Vencimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(655, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // vencimiento
            // 
            this.vencimiento.DataSetName = "Vencimiento";
            this.vencimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vencimientoBindingSource
            // 
            this.vencimientoBindingSource.DataSource = this.vencimiento;
            this.vencimientoBindingSource.Position = 0;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.vencimiento;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Visor_Vencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 446);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor_Vencimiento";
            this.Text = "Visor Vencimientos";
            this.Load += new System.EventHandler(this.Visor_Vencimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vencimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vencimientoBindingSource;
        private Vencimiento vencimiento;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private VencimientoTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}