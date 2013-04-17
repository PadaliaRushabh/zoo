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
    public partial class Add_Cage_Form : Form
    {
        public Add_Cage_Form()
        {
            InitializeComponent();
        }

        private void add_new_cage_btn_Click(object sender, EventArgs e)
        {
            //Add constrain
            Adding();
            StoreInfo.sharedStoreInfo().main.GenerateCageList();
            this.Close();
        }

        private void Adding()
        {
            string name = cage_name_input.Text;
            int height = Convert.ToInt32(cage_height_input.Text);
            int width = Convert.ToInt32(cage_width_input.Text);
            int length = Convert.ToInt32(cage_length_input.Text);
            float latitude = float.Parse(cage_latitude_input.Text);
            float longitude = float.Parse(cage_longitude_input.Text);
            int door = Convert.ToInt32(cage_door_input.Text);

            StoreInfo.sharedStoreInfo().AddNewCage(name, height, width, length, latitude, longitude, door);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
