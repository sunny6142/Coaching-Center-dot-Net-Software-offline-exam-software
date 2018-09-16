namespace Coacching_Center_V1
{
    partial class set
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.examcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optioncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctoptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negmarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet4 = new Coacching_Center_V1.CCDataSet4();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet5 = new Coacching_Center_V1.CCDataSet5();
            this.examTableAdapter = new Coacching_Center_V1.CCDataSet5TableAdapters.examTableAdapter();
            this.cCDataSet8 = new Coacching_Center_V1.CCDataSet8();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new Coacching_Center_V1.CCDataSet8TableAdapters.StudentDataTableAdapter();
            this.tableAdapterManager1 = new Coacching_Center_V1.CCDataSet8TableAdapters.TableAdapterManager();
            this.ccDataSet81 = new Coacching_Center_V1.CCDataSet8();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.examTableAdapter1 = new Coacching_Center_V1.CCDataSet4TableAdapters.examTableAdapter();
            this.tableAdapterManager = new Coacching_Center_V1.CCDataSet4TableAdapters.TableAdapterManager();
            this.ccDataSet41 = new Coacching_Center_V1.CCDataSet4();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccDataSet101 = new Coacching_Center_V1.CCDataSet10();
            this.examBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examcodeDataGridViewTextBoxColumn,
            this.qnoDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.optionaDataGridViewTextBoxColumn,
            this.optionbDataGridViewTextBoxColumn,
            this.optioncDataGridViewTextBoxColumn,
            this.optiondDataGridViewTextBoxColumn,
            this.correctoptionDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn,
            this.negmarks});
            this.dataGridView1.DataSource = this.examBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 615);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // examcodeDataGridViewTextBoxColumn
            // 
            this.examcodeDataGridViewTextBoxColumn.DataPropertyName = "examcode";
            this.examcodeDataGridViewTextBoxColumn.FillWeight = 60F;
            this.examcodeDataGridViewTextBoxColumn.HeaderText = "examcode";
            this.examcodeDataGridViewTextBoxColumn.Name = "examcodeDataGridViewTextBoxColumn";
            this.examcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.examcodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // qnoDataGridViewTextBoxColumn
            // 
            this.qnoDataGridViewTextBoxColumn.DataPropertyName = "qno";
            this.qnoDataGridViewTextBoxColumn.FillWeight = 60F;
            this.qnoDataGridViewTextBoxColumn.HeaderText = "Ques no";
            this.qnoDataGridViewTextBoxColumn.Name = "qnoDataGridViewTextBoxColumn";
            this.qnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.qnoDataGridViewTextBoxColumn.Width = 70;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionDataGridViewTextBoxColumn.Width = 500;
            // 
            // optionaDataGridViewTextBoxColumn
            // 
            this.optionaDataGridViewTextBoxColumn.DataPropertyName = "optiona";
            this.optionaDataGridViewTextBoxColumn.HeaderText = "optiona";
            this.optionaDataGridViewTextBoxColumn.Name = "optionaDataGridViewTextBoxColumn";
            this.optionaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionbDataGridViewTextBoxColumn
            // 
            this.optionbDataGridViewTextBoxColumn.DataPropertyName = "optionb";
            this.optionbDataGridViewTextBoxColumn.HeaderText = "optionb";
            this.optionbDataGridViewTextBoxColumn.Name = "optionbDataGridViewTextBoxColumn";
            this.optionbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optioncDataGridViewTextBoxColumn
            // 
            this.optioncDataGridViewTextBoxColumn.DataPropertyName = "optionc";
            this.optioncDataGridViewTextBoxColumn.HeaderText = "optionc";
            this.optioncDataGridViewTextBoxColumn.Name = "optioncDataGridViewTextBoxColumn";
            this.optioncDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optiondDataGridViewTextBoxColumn
            // 
            this.optiondDataGridViewTextBoxColumn.DataPropertyName = "optiond";
            this.optiondDataGridViewTextBoxColumn.HeaderText = "optiond";
            this.optiondDataGridViewTextBoxColumn.Name = "optiondDataGridViewTextBoxColumn";
            this.optiondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctoptionDataGridViewTextBoxColumn
            // 
            this.correctoptionDataGridViewTextBoxColumn.DataPropertyName = "correctoption";
            this.correctoptionDataGridViewTextBoxColumn.HeaderText = "correctoption";
            this.correctoptionDataGridViewTextBoxColumn.Name = "correctoptionDataGridViewTextBoxColumn";
            this.correctoptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "marks";
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            this.marksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // negmarks
            // 
            this.negmarks.DataPropertyName = "negmarks";
            this.negmarks.HeaderText = "negmarks";
            this.negmarks.Name = "negmarks";
            this.negmarks.ReadOnly = true;
            // 
            // examBindingSource1
            // 
            this.examBindingSource1.DataMember = "exam";
            this.examBindingSource1.DataSource = this.cCDataSet4;
            // 
            // cCDataSet4
            // 
            this.cCDataSet4.DataSetName = "CCDataSet4";
            this.cCDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add Question";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(419, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "exam";
            this.examBindingSource.DataSource = this.cCDataSet5;
            // 
            // cCDataSet5
            // 
            this.cCDataSet5.DataSetName = "CCDataSet5";
            this.cCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // cCDataSet8
            // 
            this.cCDataSet8.DataSetName = "CCDataSet8";
            this.cCDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "StudentData";
            this.studentDataBindingSource.DataSource = this.cCDataSet8;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StudentDataTableAdapter = this.studentDataTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Coacching_Center_V1.CCDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ccDataSet81
            // 
            this.ccDataSet81.DataSetName = "CCDataSet8";
            this.ccDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(529, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Go to";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(747, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // examTableAdapter1
            // 
            this.examTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.examTableAdapter = this.examTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Coacching_Center_V1.CCDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ccDataSet41
            // 
            this.ccDataSet41.DataSetName = "CCDataSet4";
            this.ccDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(874, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Tag = "";
            this.button8.Text = "Delete All";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exam code :";
            // 
            // ccDataSet101
            // 
            this.ccDataSet101.DataSetName = "CCDataSet10";
            this.ccDataSet101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource2
            // 
            this.examBindingSource2.DataMember = "exam";
            this.examBindingSource2.DataSource = this.cCDataSet5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(336, 187);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Conduct Exam";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "set";
            this.Text = "Set Question Paper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataSet101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private CCDataSet5 cCDataSet5;
        private System.Windows.Forms.BindingSource examBindingSource;
        private CCDataSet5TableAdapters.examTableAdapter examTableAdapter;
        private CCDataSet4 cCDataSet4;
        private System.Windows.Forms.BindingSource examBindingSource1;
        private CCDataSet4TableAdapters.examTableAdapter examTableAdapter1;
        private CCDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private CCDataSet8 cCDataSet8;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private CCDataSet8TableAdapters.StudentDataTableAdapter studentDataTableAdapter;
        private CCDataSet8TableAdapters.TableAdapterManager tableAdapterManager1;
        private CCDataSet8 ccDataSet81;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private CCDataSet4 ccDataSet41;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CCDataSet10 ccDataSet101;
        private System.Windows.Forms.DataGridViewTextBoxColumn examcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optioncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctoptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negmarks;
        private System.Windows.Forms.BindingSource examBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button7;
    }
}