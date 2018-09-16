namespace Coacching_Center_V1
{
    partial class ConductExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.examtextBox = new System.Windows.Forms.TextBox();
            this.timetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sec3textbox = new System.Windows.Forms.TextBox();
            this.sec3label = new System.Windows.Forms.Label();
            this.sec2textBox = new System.Windows.Forms.TextBox();
            this.sec2label = new System.Windows.Forms.Label();
            this.sec1textBox = new System.Windows.Forms.TextBox();
            this.sec1label = new System.Windows.Forms.Label();
            this.totalseccomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Exam code :";
            // 
            // examtextBox
            // 
            this.examtextBox.Location = new System.Drawing.Point(109, 77);
            this.examtextBox.Name = "examtextBox";
            this.examtextBox.Size = new System.Drawing.Size(100, 20);
            this.examtextBox.TabIndex = 1;
            // 
            // timetextBox
            // 
            this.timetextBox.Location = new System.Drawing.Point(320, 77);
            this.timetextBox.Name = "timetextBox";
            this.timetextBox.Size = new System.Drawing.Size(100, 20);
            this.timetextBox.TabIndex = 3;
            this.timetextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Section :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sec3textbox
            // 
            this.sec3textbox.Location = new System.Drawing.Point(535, 117);
            this.sec3textbox.Name = "sec3textbox";
            this.sec3textbox.Size = new System.Drawing.Size(100, 20);
            this.sec3textbox.TabIndex = 40;
            // 
            // sec3label
            // 
            this.sec3label.AutoSize = true;
            this.sec3label.Location = new System.Drawing.Point(461, 121);
            this.sec3label.Name = "sec3label";
            this.sec3label.Size = new System.Drawing.Size(68, 13);
            this.sec3label.TabIndex = 39;
            this.sec3label.Text = "sec name 3 :";
            // 
            // sec2textBox
            // 
            this.sec2textBox.Location = new System.Drawing.Point(320, 117);
            this.sec2textBox.Name = "sec2textBox";
            this.sec2textBox.Size = new System.Drawing.Size(100, 20);
            this.sec2textBox.TabIndex = 38;
            // 
            // sec2label
            // 
            this.sec2label.AutoSize = true;
            this.sec2label.Location = new System.Drawing.Point(246, 121);
            this.sec2label.Name = "sec2label";
            this.sec2label.Size = new System.Drawing.Size(68, 13);
            this.sec2label.TabIndex = 37;
            this.sec2label.Text = "sec name 2 :";
            // 
            // sec1textBox
            // 
            this.sec1textBox.Location = new System.Drawing.Point(109, 117);
            this.sec1textBox.Name = "sec1textBox";
            this.sec1textBox.Size = new System.Drawing.Size(100, 20);
            this.sec1textBox.TabIndex = 36;
            // 
            // sec1label
            // 
            this.sec1label.AutoSize = true;
            this.sec1label.Location = new System.Drawing.Point(35, 121);
            this.sec1label.Name = "sec1label";
            this.sec1label.Size = new System.Drawing.Size(68, 13);
            this.sec1label.TabIndex = 35;
            this.sec1label.Text = "sec name 1 :";
            // 
            // totalseccomboBox
            // 
            this.totalseccomboBox.FormattingEnabled = true;
            this.totalseccomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.totalseccomboBox.Location = new System.Drawing.Point(535, 80);
            this.totalseccomboBox.Name = "totalseccomboBox";
            this.totalseccomboBox.Size = new System.Drawing.Size(100, 21);
            this.totalseccomboBox.TabIndex = 41;
            // 
            // ConductExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 163);
            this.Controls.Add(this.totalseccomboBox);
            this.Controls.Add(this.sec3textbox);
            this.Controls.Add(this.sec3label);
            this.Controls.Add(this.sec2textBox);
            this.Controls.Add(this.sec2label);
            this.Controls.Add(this.sec1textBox);
            this.Controls.Add(this.sec1label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.examtextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConductExam";
            this.Text = "Conduct an  Exam";
            this.Load += new System.EventHandler(this.ConductExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox examtextBox;
        private System.Windows.Forms.TextBox timetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sec3textbox;
        private System.Windows.Forms.Label sec3label;
        private System.Windows.Forms.TextBox sec2textBox;
        private System.Windows.Forms.Label sec2label;
        private System.Windows.Forms.TextBox sec1textBox;
        private System.Windows.Forms.Label sec1label;
        private System.Windows.Forms.ComboBox totalseccomboBox;
    }
}