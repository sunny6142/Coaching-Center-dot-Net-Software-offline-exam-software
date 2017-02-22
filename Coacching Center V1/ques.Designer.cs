using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coacching_Center_V1
{
    partial class ques
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.examBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet = new Coacching_Center_V1.CCDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.exam1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cCoption = new Coacching_Center_V1.CCoption();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.exam4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.exam3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.exam2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exam1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cCDataSet9 = new Coacching_Center_V1.CCDataSet9();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new Coacching_Center_V1.CCDataSet9TableAdapters.StudentDataTableAdapter();
            this.tableAdapterManager1 = new Coacching_Center_V1.CCDataSet9TableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cCDataSet1 = new Coacching_Center_V1.CCDataSet1();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTableAdapter = new Coacching_Center_V1.CCDataSet1TableAdapters.ResultTableAdapter();
            this.tableAdapterManager2 = new Coacching_Center_V1.CCDataSet1TableAdapters.TableAdapterManager();
            this.cCDataSet8 = new Coacching_Center_V1.CCDataSet8();
            this.studentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter1 = new Coacching_Center_V1.CCDataSet8TableAdapters.StudentDataTableAdapter();
            this.tableAdapterManager3 = new Coacching_Center_V1.CCDataSet8TableAdapters.TableAdapterManager();
            this.cCoption1 = new Coacching_Center_V1.CCoption();
            this.exam1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.exam1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.exam1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exam1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter1 = new Coacching_Center_V1.CCoptionTableAdapters.examTableAdapter();
            this.examBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.exam1TableAdapter = new Coacching_Center_V1.CCoptionTableAdapters.exam1TableAdapter();
            this.cCoption2 = new Coacching_Center_V1.CCoption();
            this.examBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.examBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentResultTableAdapter = new Coacching_Center_V1.CCoptionTableAdapters.StudentResultTableAdapter();
            this.tableAdapterManager = new Coacching_Center_V1.CCoptionTableAdapters.TableAdapterManager();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new Coacching_Center_V1.CCDataSetTableAdapters.examTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examtile = new Coacching_Center_V1.examtile();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTableAdapter = new Coacching_Center_V1.examtileTableAdapters.titleTableAdapter();
            this.tableAdapterManager4 = new Coacching_Center_V1.examtileTableAdapters.TableAdapterManager();
            this.exam1TableAdapter1 = new Coacching_Center_V1.CCoptionTableAdapters.exam1TableAdapter();
            this.exam2TableAdapter1 = new Coacching_Center_V1.CCoptionTableAdapters.exam2TableAdapter();
            this.exam3TableAdapter1 = new Coacching_Center_V1.CCoptionTableAdapters.exam3TableAdapter();
            this.exam4TableAdapter1 = new Coacching_Center_V1.CCoptionTableAdapters.exam4TableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examtile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exam1BindingSource4, "optiond", true));
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 519);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(739, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(853, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(853, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(800, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Marks :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(766, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Neg_marks :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(52, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource5, "question", true));
            this.richTextBox1.Location = new System.Drawing.Point(17, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(945, 157);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // examBindingSource5
            // 
            this.examBindingSource5.DataMember = "exam";
            this.examBindingSource5.DataSource = this.cCDataSet;
            // 
            // cCDataSet
            // 
            this.cCDataSet.DataSetName = "CCDataSet";
            this.cCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(392, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save and Next";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(563, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "Mark as Review";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(222, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exam1BindingSource5, "optiond", true));
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(56, 358);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 24);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // exam1BindingSource5
            // 
            this.exam1BindingSource5.DataMember = "exam1";
            this.exam1BindingSource5.DataSource = this.cCoption;
            // 
            // cCoption
            // 
            this.cCoption.DataSetName = "CCoption";
            this.cCoption.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exam4BindingSource, "optionc", true));
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(56, 319);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // exam4BindingSource
            // 
            this.exam4BindingSource.DataMember = "exam4";
            this.exam4BindingSource.DataSource = this.cCoption;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exam3BindingSource, "optionb", true));
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(56, 276);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 24);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // exam3BindingSource
            // 
            this.exam3BindingSource.DataMember = "exam3";
            this.exam3BindingSource.DataSource = this.cCoption;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exam2BindingSource, "optiona", true));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(56, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // exam2BindingSource
            // 
            this.exam2BindingSource.DataMember = "exam2";
            this.exam2BindingSource.DataSource = this.cCoption;
            // 
            // exam1BindingSource4
            // 
            this.exam1BindingSource4.DataMember = "exam1";
            this.exam1BindingSource4.DataSource = this.cCoption;
            // 
            // cCDataSet9
            // 
            this.cCDataSet9.DataSetName = "CCDataSet9";
            this.cCDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "StudentData";
            this.studentDataBindingSource.DataSource = this.cCDataSet9;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StudentDataTableAdapter = this.studentDataTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Coacching_Center_V1.CCDataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1169, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1210, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1226, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1267, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1283, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1029, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Time Remain :";
            // 
            // cCDataSet1
            // 
            this.cCDataSet1.DataSetName = "CCDataSet1";
            this.cCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.cCDataSet1;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ResultTableAdapter = this.resultTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Coacching_Center_V1.CCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cCDataSet8
            // 
            this.cCDataSet8.DataSetName = "CCDataSet8";
            this.cCDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource1
            // 
            this.studentDataBindingSource1.DataMember = "StudentData";
            this.studentDataBindingSource1.DataSource = this.cCDataSet8;
            // 
            // studentDataTableAdapter1
            // 
            this.studentDataTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.StudentDataTableAdapter = this.studentDataTableAdapter1;
            this.tableAdapterManager3.UpdateOrder = Coacching_Center_V1.CCDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cCoption1
            // 
            this.cCoption1.DataSetName = "CCoption";
            this.cCoption1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exam1BindingSource2
            // 
            this.exam1BindingSource2.DataMember = "exam1";
            this.exam1BindingSource2.DataSource = this.cCoption;
            // 
            // exam1BindingSource3
            // 
            this.exam1BindingSource3.DataMember = "exam1";
            this.exam1BindingSource3.DataSource = this.cCoption;
            // 
            // exam1BindingSource1
            // 
            this.exam1BindingSource1.DataMember = "exam1";
            this.exam1BindingSource1.DataSource = this.cCoption;
            // 
            // exam1BindingSource
            // 
            this.exam1BindingSource.DataMember = "exam1";
            this.exam1BindingSource.DataSource = this.cCoption;
            // 
            // examBindingSource1
            // 
            this.examBindingSource1.DataMember = "exam";
            this.examBindingSource1.DataSource = this.cCoption;
            // 
            // examTableAdapter1
            // 
            this.examTableAdapter1.ClearBeforeFill = true;
            // 
            // examBindingSource2
            // 
            this.examBindingSource2.DataMember = "exam";
            this.examBindingSource2.DataSource = this.cCoption;
            // 
            // exam1TableAdapter
            // 
            this.exam1TableAdapter.ClearBeforeFill = true;
            // 
            // cCoption2
            // 
            this.cCoption2.DataSetName = "CCoption";
            this.cCoption2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource3
            // 
            this.examBindingSource3.DataMember = "exam";
            this.examBindingSource3.DataSource = this.cCoption2;
            // 
            // examBindingSource4
            // 
            this.examBindingSource4.DataMember = "exam";
            this.examBindingSource4.DataSource = this.cCoption2;
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.cCoption;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentResultTableAdapter = this.studentResultTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coacching_Center_V1.CCoptionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "exam";
            this.examBindingSource.DataSource = this.cCDataSet;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titleBindingSource1, "title", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // titleBindingSource1
            // 
            this.titleBindingSource1.DataMember = "title";
            this.titleBindingSource1.DataSource = this.examtile;
            // 
            // examtile
            // 
            this.examtile.DataSetName = "examtile";
            this.examtile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataMember = "title";
            this.titleBindingSource.DataSource = this.examtile;
            // 
            // titleTableAdapter
            // 
            this.titleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.titleTableAdapter = this.titleTableAdapter;
            this.tableAdapterManager4.UpdateOrder = Coacching_Center_V1.examtileTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exam1TableAdapter1
            // 
            this.exam1TableAdapter1.ClearBeforeFill = true;
            // 
            // exam2TableAdapter1
            // 
            this.exam2TableAdapter1.ClearBeforeFill = true;
            // 
            // exam3TableAdapter1
            // 
            this.exam3TableAdapter1.ClearBeforeFill = true;
            // 
            // exam4TableAdapter1
            // 
            this.exam4TableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // ques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ques";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoption2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examtile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCDataSet cCDataSet;
        private System.Windows.Forms.BindingSource examBindingSource;
        private CCDataSetTableAdapters.examTableAdapter examTableAdapter;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CCoption cCoption;
        private BindingSource examBindingSource1;
        private CCoptionTableAdapters.examTableAdapter examTableAdapter1;
        private BindingSource examBindingSource2;
        private BindingSource exam1BindingSource;
        private CCoptionTableAdapters.exam1TableAdapter exam1TableAdapter;
        private BindingSource exam1BindingSource4;
        private BindingSource exam1BindingSource3;
        private BindingSource exam1BindingSource2;
        private BindingSource exam1BindingSource1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CCoption cCoption1;
        private CCoption cCoption2;
        private BindingSource examBindingSource3;
        private BindingSource examBindingSource4;
        private Button button3;
        private Button button1;
        private BindingSource studentResultBindingSource;
        private CCoptionTableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private CCoptionTableAdapters.TableAdapterManager tableAdapterManager;
        private CCDataSet9 cCDataSet9;
        private BindingSource studentDataBindingSource;
        private CCDataSet9TableAdapters.StudentDataTableAdapter studentDataTableAdapter;
        private CCDataSet9TableAdapters.TableAdapterManager tableAdapterManager1;
        private Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private CCDataSet1 cCDataSet1;
        private BindingSource resultBindingSource;
        private CCDataSet1TableAdapters.ResultTableAdapter resultTableAdapter;
        private CCDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private CCDataSet8 cCDataSet8;
        private BindingSource studentDataBindingSource1;
        private CCDataSet8TableAdapters.StudentDataTableAdapter studentDataTableAdapter1;
        private CCDataSet8TableAdapters.TableAdapterManager tableAdapterManager3;
        private RichTextBox richTextBox1;
        private BindingSource examBindingSource5;
        private Button button4;
        private Button button6;
        private Label label1;
        private examtile examtile;
        private BindingSource titleBindingSource;
        private examtileTableAdapters.titleTableAdapter titleTableAdapter;
        private examtileTableAdapters.TableAdapterManager tableAdapterManager4;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label8;
        private CCoptionTableAdapters.exam1TableAdapter exam1TableAdapter1;
        private CCoptionTableAdapters.exam2TableAdapter exam2TableAdapter1;
        private CCoptionTableAdapters.exam3TableAdapter exam3TableAdapter1;
        private CCoptionTableAdapters.exam4TableAdapter exam4TableAdapter1;
        private BindingSource exam1BindingSource5;
        private BindingSource exam4BindingSource;
        private BindingSource exam3BindingSource;
        private BindingSource exam2BindingSource;
        private Button button2;
        private BindingSource titleBindingSource1;
        private GroupBox groupBox2;
    }
}