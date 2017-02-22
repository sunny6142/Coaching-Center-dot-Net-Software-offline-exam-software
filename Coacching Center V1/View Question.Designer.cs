namespace Coacching_Center_V1
{
    partial class View_Question
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
            this.examDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet10 = new Coacching_Center_V1.CCDataSet10();
            this.examTableAdapter = new Coacching_Center_V1.CCDataSet10TableAdapters.examTableAdapter();
            this.tableAdapterManager = new Coacching_Center_V1.CCDataSet10TableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.examDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // examDataGridView
            // 
            this.examDataGridView.AllowUserToAddRows = false;
            this.examDataGridView.AllowUserToDeleteRows = false;
            this.examDataGridView.AutoGenerateColumns = false;
            this.examDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.examDataGridView.DataSource = this.examBindingSource;
            this.examDataGridView.Location = new System.Drawing.Point(23, 63);
            this.examDataGridView.Name = "examDataGridView";
            this.examDataGridView.ReadOnly = true;
            this.examDataGridView.Size = new System.Drawing.Size(843, 438);
            this.examDataGridView.TabIndex = 1;
            this.examDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qno";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ques no.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "question";
            this.dataGridViewTextBoxColumn5.HeaderText = "Question";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "optiona";
            this.dataGridViewTextBoxColumn6.HeaderText = "option A";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "optionb";
            this.dataGridViewTextBoxColumn7.HeaderText = "option B";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "optionc";
            this.dataGridViewTextBoxColumn8.HeaderText = "option C";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "optiond";
            this.dataGridViewTextBoxColumn9.HeaderText = "option D";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "correctoption";
            this.dataGridViewTextBoxColumn10.HeaderText = "Correctoption";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "marks";
            this.dataGridViewTextBoxColumn11.HeaderText = "Marks";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "exam";
            this.examBindingSource.DataSource = this.cCDataSet10;
            // 
            // cCDataSet10
            // 
            this.cCDataSet10.DataSetName = "CCDataSet10";
            this.cCDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.examTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coacching_Center_V1.CCDataSet10TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // View_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 518);
            this.Controls.Add(this.examDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Question";
            this.Resizable = false;
            this.Text = "View Question";
            this.Load += new System.EventHandler(this.View_Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCDataSet10 cCDataSet10;
        private System.Windows.Forms.BindingSource examBindingSource;
        private CCDataSet10TableAdapters.examTableAdapter examTableAdapter;
        private CCDataSet10TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView examDataGridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}