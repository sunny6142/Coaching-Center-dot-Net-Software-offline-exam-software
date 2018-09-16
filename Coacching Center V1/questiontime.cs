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
    public partial class questiontime : Form
    {
        public static string examcode;
        public static int examtime; 
        public questiontime()
        {
            InitializeComponent();
        }

        private void questiontime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examtile.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.examtile.title);

        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            /*if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }*/
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            examcode = textBox2.Text.ToString();

       //     MessageBox.Show(examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

         //   examtime = int.Parse(textBox1.Text.ToString());
            titleTableAdapter.InsertQuery(textBox3.Text, examcode);
            this.Hide();
            using (AddQues addquestion = new AddQues())
            {
                addquestion.ShowDialog();
            }
            
           
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examtile);

        }
    }
}
