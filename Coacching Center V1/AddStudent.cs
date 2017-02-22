using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coacching_Center_V1
{
    public partial class AddStudent : MetroFramework.Forms.MetroForm
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void login_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logininfo);

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logininfo.login_info' table. You can move, or remove it, as needed.
            this.login_infoTableAdapter.Fill(this.logininfo.login_info);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 0 && e.KeyChar > 9 && e.KeyChar != (char)8)
            {
                MessageBox.Show("Enter Valid Phone Number");
            }
            /*if(textBox3.Text.ToString().Length > 9 )
            {
                MessageBox.Show("Enter Valid Phone Number");
            } */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter User id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (textBox3.Text.ToString().Length != 10)
            {
                MessageBox.Show("Enter Valid Phone Number");
                return;
            }
            //////////////////////
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T6L7KFD\\SQLEXPRESS2016;Initial Catalog=CC;User ID=sa;Password=mypc107");

            SqlDataReader rdr = null;
            

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Expr1 FROM login_info WHERE userid ='" + textBox1.Text.ToString() + "'", conn);
                //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if ((int)rdr[0] > 0)
                {

                    MessageBox.Show("User id Already Exist"+rdr[0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    login_infoTableAdapter.InsertQuery(textBox1.Text.ToString(), textBox2.Text.ToString(), long.Parse(textBox3.Text));
                    this.login_infoTableAdapter.Fill(this.logininfo.login_info);
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error s9989", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
            /////////////////////
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
             this.Hide();
            ad.Show();
        }

        private void login_infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           DialogResult result = MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                this.login_infoTableAdapter.DeleteQuery(login_infoDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.login_infoTableAdapter.Fill(this.logininfo.login_info);

            }
        }
    }
}
