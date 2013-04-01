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
    public partial class Add_Type_Form : Form
    {
        public Add_Type_Form()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string user = type_name_input.Text;
            string des = description_input.Text;
            if (user == null || StoreInfo.sharedStoreInfo().ValidateIdType(user) == false)
            {
                StoreInfo.sharedStoreInfo().Global_ValidateID = true;
                MessageBox.Show("Invalid Id Cage");
                
            }
            else
            {
                if (des == "")
                {
                    MessageBox.Show("Invalid Description");
                }
                else
                {
                    if (quantity_input.Text == "")
                    {
                        MessageBox.Show("Invalid Quantity!!! (Number type)");
                    }
                    else
                    {

                        int qty = Convert.ToInt16(quantity_input.Text);
                        if (StoreInfo.sharedStoreInfo().AddNewType(user, des, qty))
                        {
                            MessageBox.Show("Adding successfully!!!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Unable to add new cage type!!!");
                        }
                    }
                }
            }
        }
    }
}
