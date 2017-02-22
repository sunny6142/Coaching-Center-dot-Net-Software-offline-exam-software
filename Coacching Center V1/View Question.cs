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
    public partial class View_Question : MetroFramework.Forms.MetroForm
    {
        public View_Question()
        {
            InitializeComponent();
        }

        private void examBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cCDataSet10);

        }

        private void View_Question_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cCDataSet10.exam' table. You can move, or remove it, as needed.
           // this.T = ConfigurationManager.AppSettings["DefaultTitle"];
            this.examTableAdapter.Fill(this.cCDataSet10.exam,set.specificexamcode);
            this.Text = "Examcode : " + set.specificexamcode;
        }

        private void examDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
