namespace lab11
{
    partial class frmRapPar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dSRaport = new lab11.DSRaport();
            this.dSRaportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRapPar = new lab11.DSRapPar();
            this.dSRapParBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSRaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRapPar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRapParBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet98";
            reportDataSource3.Value = this.dSRapParBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab11.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 225);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 182);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(204, 30);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dati sxul pacientilor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afisare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inchidere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // dSRapPar
            // 
            this.dSRapPar.DataSetName = "DSRapPar";
            this.dSRapPar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSRapParBindingSource
            // 
            this.dSRapParBindingSource.DataSource = this.dSRapPar;
            this.dSRapParBindingSource.Position = 0;
            // 
            // frmRapPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRapPar";
            this.Text = "frmRapPar";
            this.Load += new System.EventHandler(this.frmRapPar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRapPar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRapParBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dSRapParBindingSource;
        private DSRapPar dSRapPar;
        private DSRaport dSRaport;
        private System.Windows.Forms.BindingSource dSRaportBindingSource;
    }
}