namespace Coacching_Center_V1
{
    partial class Student_Result
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
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportData = new Coacching_Center_V1.ReportData();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet7 = new Coacching_Center_V1.CCDataSet7();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.resultTableAdapter = new Coacching_Center_V1.CCDataSet7TableAdapters.ResultTableAdapter();
            this.resultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Coacching_Center_V1.CCDataSet7TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new Coacching_Center_V1.ReportDataTableAdapters.ReportTableAdapter();
            this.report1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report1TableAdapter = new Coacching_Center_V1.ReportDataTableAdapters.Report1TableAdapter();
            this.report1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Coacching_Center_V1.CCDataSet10TableAdapters.TableAdapterManager();
            this.report1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.reportData;
            // 
            // reportData
            // 
            this.reportData.DataSetName = "ReportData";
            this.reportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.cCDataSet7BindingSource;
            // 
            // cCDataSet7BindingSource
            // 
            this.cCDataSet7BindingSource.DataSource = this.cCDataSet7;
            this.cCDataSet7BindingSource.Position = 0;
            // 
            // cCDataSet7
            // 
            this.cCDataSet7.DataSetName = "CCDataSet7";
            this.cCDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "VariableResult";
            reportDataSource1.Value = this.reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Coacching_Center_V1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // resultBindingSource1
            // 
            this.resultBindingSource1.DataMember = "Result";
            this.resultBindingSource1.DataSource = this.cCDataSet7;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResultTableAdapter = this.resultTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coacching_Center_V1.CCDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam code :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportBindingSource1
            // 
            this.reportBindingSource1.DataMember = "Report";
            this.reportBindingSource1.DataSource = this.reportData;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // report1BindingSource
            // 
            this.report1BindingSource.DataMember = "Report1";
            this.report1BindingSource.DataSource = this.reportData;
            // 
            // report1TableAdapter
            // 
            this.report1TableAdapter.ClearBeforeFill = true;
            // 
            // report1BindingSource1
            // 
            this.report1BindingSource1.DataMember = "Report1";
            this.report1BindingSource1.DataSource = this.reportData;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.examTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Coacching_Center_V1.CCDataSet10TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // report1BindingSource2
            // 
            this.report1BindingSource2.DataMember = "Report1";
            this.report1BindingSource2.DataSource = this.reportData;
            // 
            // Student_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(724, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Student_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Result";
            this.Load += new System.EventHandler(this.Student_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CCDataSet7 cCDataSet7;
        private System.Windows.Forms.BindingSource cCDataSet7BindingSource;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private CCDataSet7TableAdapters.ResultTableAdapter resultTableAdapter;
        private System.Windows.Forms.BindingSource resultBindingSource1;
        private CCDataSet7TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ReportData reportData;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private ReportDataTableAdapters.ReportTableAdapter reportTableAdapter;
        private System.Windows.Forms.BindingSource report1BindingSource;
        private ReportDataTableAdapters.Report1TableAdapter report1TableAdapter;
        private System.Windows.Forms.BindingSource report1BindingSource1;
        private System.Windows.Forms.BindingSource reportBindingSource1;
        private CCDataSet10TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource report1BindingSource2;
    }
}