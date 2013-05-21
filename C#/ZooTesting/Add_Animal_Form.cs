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
        private Animal animal = new Animal();
        public Add_Animal_Form()
        {
            InitializeComponent();
            animal.Add();
            animal.Id = animal.FindTempId();
            add_new_animal_btn.Enabled = false;
        }

        private void add_new_animal_btn_Click(object sender, EventArgs e)
        {
            animal.Update();
            StoreInfo.sharedStoreInfo().main.RefreshNameAnimalList();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            animal.Delete();
            this.Close();
        }

        private void animal_name_input_TextChanged(object sender, EventArgs e)
        {
            animal.Name = animal_name_input.Text.ToString();

            add_new_animal_btn.Enabled = true;
            if (animal_name_input.TextLength == 0)
              add_new_animal_btn.Enabled = false;
        }
    }
}
