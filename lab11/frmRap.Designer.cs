namespace lab11
{
    partial class frmRap
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSRaport = new lab11.DSRaport();
            this.dSRaportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programariDataSet = new lab11.ProgramariDataSet();
            this.programariDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSRaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programariDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet99";
            reportDataSource1.Value = this.dSRaportBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab11.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(86, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(627, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRaport
            // 
            this.dSRaport.DataSetName = "DSRaport";
            this.dSRaport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSRaportBindingSource
            // 
            this.dSRaportBindingSource.DataSource = this.dSRaport;
            this.dSRaportBindingSource.Position = 0;
            // 
            // programariDataSet
            // 
            this.programariDataSet.DataSetName = "ProgramariDataSet";
            this.programariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programariDataSetBindingSource
            // 
            this.programariDataSetBindingSource.DataSource = this.programariDataSet;
            this.programariDataSetBindingSource.Position = 0;
            // 
            // dSRaportBindingSource1
            // 
            this.dSRaportBindingSource1.DataSource = this.dSRaport;
            this.dSRaportBindingSource1.Position = 0;
            // 
            // frmRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRap";
            this.Text = "frmRap";
            this.Load += new System.EventHandler(this.frmRap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programariDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSRaportBindingSource;
        private DSRaport dSRaport;
        private System.Windows.Forms.BindingSource programariDataSetBindingSource;
        private ProgramariDataSet programariDataSet;
        private System.Windows.Forms.BindingSource dSRaportBindingSource1;
    }
}