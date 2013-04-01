using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZooTesting
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            username_label.Text = StoreInfo.sharedStoreInfo().Global_Username;
            
            cage_gridview.DataSource = StoreInfo.sharedStoreInfo().CageLoadData().Tables[0];
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            StoreInfo.sharedStoreInfo().Global_LoginStatus = false;
            MessageBox.Show("Log out successfully!!");
            this.Hide();
            Login_Form lg = new Login_Form();
            lg.ShowDialog();
            this.Close();
            
        }
        private void GenerateCage()
        {
            var column = new DataGridViewComboBoxColumn();
            DataSet ds = new DataSet("MyTables");
            ds.Tables.Add("Cage");
            DataTable cageTable = ds.Tables["Cage"];
            cageTable.Columns.Add("Check", typeof(bool));
            
            foreach (DataTable table in StoreInfo.sharedStoreInfo().CageLoadData().Tables)
            {
                foreach (DataRow rows in table.Rows)
                {
                }
            }
            
        }

        private void add_type_btn_Click(object sender, EventArgs e)
        {
            Add_Type_Form atf = new Add_Type_Form();
            atf.ShowDialog();
        }
       
    }
}
