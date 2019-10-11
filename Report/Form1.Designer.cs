namespace Report
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MT_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mushtaqdbDataSet = new Report.mushtaqdbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MT_ReportTableAdapter = new Report.mushtaqdbDataSetTableAdapters.MT_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MT_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushtaqdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MT_ReportBindingSource
            // 
            this.MT_ReportBindingSource.DataMember = "MT_Report";
            this.MT_ReportBindingSource.DataSource = this.mushtaqdbDataSet;
            // 
            // mushtaqdbDataSet
            // 
            this.mushtaqdbDataSet.DataSetName = "mushtaqdbDataSet";
            this.mushtaqdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.MT_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(925, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // MT_ReportTableAdapter
            // 
            this.MT_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 590);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MT_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushtaqdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MT_ReportBindingSource;
        private mushtaqdbDataSet mushtaqdbDataSet;
        private mushtaqdbDataSetTableAdapters.MT_ReportTableAdapter MT_ReportTableAdapter;
    }
}

