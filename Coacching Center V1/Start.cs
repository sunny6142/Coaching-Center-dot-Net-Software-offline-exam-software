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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ques exm = new ques();
            exm.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ExamStart WHERE examcode LIKE'" + Form1.examcode + "'", conn);


            rdr = cmd.ExecuteReader();
            //    while(rdr.Read())
            //     MessageBox.Show(rdr[0].ToString());
            rdr.Read();
            if ((int)rdr[0] > 0)
            {
                this.Hide();
                ques exm = new ques();
                exm.Show();
            }

        }
    }
}
