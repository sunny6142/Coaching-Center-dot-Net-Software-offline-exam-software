using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coacching_Center_V1
{
    public partial class EditSave : MetroFramework.Forms.MetroForm
    {
        public EditSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

//                examTableAdapter.UpdateQuery(richTextBox1.Text.ToString(), textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), comboBox1.Text.ToString(), int.Parse(textBox5.Text.ToString()), set.s1, set.s2);

                //this.examTableAdapter1.Fill(this.cCDataSet4.exam);

            }
                  }

        private void EditSave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nExamData.exam' table. You can move, or remove it, as needed.
          //  this.examTableAdapter.Fill(this.nExamData.exam);
            // TODO: This line of code loads data into the 'cCDataSet4.exam' table. You can move, or remove it, as needed.
            //      this.examTableAdapter.Fill(this.cCDataSet4.exam);
            label8.Text = set.s2.ToString();
            richTextBox1.Text = set.s3;
            textBox1.Text = set.s4;
            textBox2.Text = set.s5;
            textBox3.Text = set.s6;
            textBox4.Text = set.s7;
            comboBox1.Text = set.s8;
            textBox5.Text = set.s9;
            textBox6.Text = set.s10;
        }

        private void examBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
      //      this.examBindingSource.EndEdit();
       //     this.tableAdapterManager1.UpdateAll(this.cCDataSet4);

        }

        private void examBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nExamData);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                examTableAdapter.UpdateExamQuery(richTextBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, double.Parse(textBox5.Text), double.Parse(textBox6.Text), set.s2, set.s1);
                this.Hide();
            }
        }
    }
}
