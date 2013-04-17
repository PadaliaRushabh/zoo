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
    public partial class Add_Animal_Form : Form
    {
        public Add_Animal_Form()
        {
            InitializeComponent();
        }

        private void add_new_animal_btn_Click(object sender, EventArgs e)
        {
            //Contraint plz
            Adding();
            StoreInfo.sharedStoreInfo().main.GenerateAnimalList();
            this.Close();
        }

        private void Adding()
        {
            string name = animal_name_input.Text;

            StoreInfo.sharedStoreInfo().AddNewAnimal(name);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
