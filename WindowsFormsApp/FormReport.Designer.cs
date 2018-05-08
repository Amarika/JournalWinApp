namespace WindowsFormsApp
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.GetRecordsFromDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JournalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetRecordsFromDateTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.GetRecordsFromDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetRecordsFromDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GetRecordsFromDateBindingSource
            // 
            this.GetRecordsFromDateBindingSource.DataMember = "GetRecordsFromDate";
            this.GetRecordsFromDateBindingSource.DataSource = this.JournalDBDataSet;
            // 
            // JournalDBDataSet
            // 
            this.JournalDBDataSet.DataSetName = "JournalDBDataSet";
            this.JournalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetRecordsFromDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(583, 296);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // GetRecordsFromDateTableAdapter
            // 
            this.GetRecordsFromDateTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 296);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetRecordsFromDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetRecordsFromDateBindingSource;
        private JournalDBDataSet JournalDBDataSet;
        private JournalDBDataSetTableAdapters.GetRecordsFromDateTableAdapter GetRecordsFromDateTableAdapter;
    }
}