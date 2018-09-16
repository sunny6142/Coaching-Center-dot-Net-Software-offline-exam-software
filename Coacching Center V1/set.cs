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
    public partial class set : MetroFramework.Forms.MetroForm
    {
        public static string s1 ,s3 ,s4 , s5 , s6 , s7 , s8 , s9 , s10;
        public static int s2;
        public static string specificexamcode;
        public set()
        {
            InitializeComponent();
        }

        private void set_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();

            // TODO: This line of code loads data into the 'cCDataSet8.StudentData' table. You can move, or remove it, as needed.
      //      this.studentDataTableAdapter.Fill(this.cCDataSet8.StudentData);
            // TODO: This line of code loads data into the 'cCDataSet4.exam' table. You can move, or remove it, as needed.
          //  this.examTableAdapter1.Fill(this.cCDataSet4.exam);
            // TODO: This line of code loads data into the 'cCDataSet5.exam' table. You can move, or remove it, as needed.
            //   this.examTableAdapter.Fill(this.cCDataSet5.exam);
         //   MessageBox.Show(dataGridView1.RowCount.ToString());
            if (dataGridView1.RowCount > 1)
            {
                s1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                s2 = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                s3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                s4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                s5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                s6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                s7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                s8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                s9 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                s10 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            }

            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            s2 = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            s3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            s4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            s5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            s6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            s7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            s8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            s9 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            s10 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             using (questiontime questime = new questiontime())
            {
                questime.ShowDialog();
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            s2 = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            s3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            s4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            s5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            s6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            s7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            s8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            s9 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            s10 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            s1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            s2 = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            s3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            s4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            s5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            s6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            s7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            s8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            s9 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            s10 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Exam code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            specificexamcode = (string)textBox1.Text;
            this.examTableAdapter1.FillByexamcode(this.cCDataSet4.exam , specificexamcode);
         //   this.examTableAdapter.Fill(this.cCDataSet101.exam, specificexamcode);
            /*  //     View_Question vq = new View_Question();
                //   vq.Show();
                  using (View_Question vq = new View_Question())
                   {
                       vq.ShowDialog();
                   }  */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (ConductExam ce = new ConductExam())
            {
                ce.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Exam code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to Delete ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                examTableAdapter1.DeleteExcode(textBox2.Text);
                this.examTableAdapter1.Fill(this.cCDataSet4.exam);

            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            s2 = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            s3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            s4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            s5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            s6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            s7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            s8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            s9 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            s10 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            //      MessageBox.Show(s1, "Confirmation", MessageBoxButtons.YesNoCancel);
            //      MessageBox.Show(s2.ToString(), "Confirmation", MessageBoxButtons.YesNoCancel);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.examTableAdapter1.FillBy(this.cCDataSet4.exam);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                
                this.examTableAdapter1.DeleteQuery(s1 ,s2);
                this.examTableAdapter1.Fill(this.cCDataSet4.exam);

            }
            
                
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.examTableAdapter1.FillBy(this.cCDataSet4.exam);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Ref()
        {
            try
            {
                this.examTableAdapter1.FillBy(this.cCDataSet4.exam);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  this.Hide();
            using (EditSave edits = new EditSave())
            {
                edits.ShowDialog();
            }
            examTableAdapter1.FillBy(this.cCDataSet4.exam);
        }
    }
}
