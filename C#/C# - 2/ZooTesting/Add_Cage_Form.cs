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
        private Cage cage = new Cage();
        public Add_Cage_Form()
        {
            InitializeComponent();
            cage.Add();
            cage.Name = CageName();
            cage.Id = cage.FindTempId();
            
            System.Diagnostics.Debug.WriteLine("----cage---");
            System.Diagnostics.Debug.WriteLine(cage.Id);
            System.Diagnostics.Debug.WriteLine(cage.Name);
            System.Diagnostics.Debug.WriteLine(cage.Height);
            System.Diagnostics.Debug.WriteLine(cage.Width);
            System.Diagnostics.Debug.WriteLine(cage.Length);
            System.Diagnostics.Debug.WriteLine(cage.Longitude);
            System.Diagnostics.Debug.WriteLine(cage.Latitude);
            System.Diagnostics.Debug.WriteLine(cage.NumberOfDoors);
            System.Diagnostics.Debug.WriteLine(cage.NumberOfPeople);
            System.Diagnostics.Debug.WriteLine(cage.NumberOfAnimal);
            System.Diagnostics.Debug.WriteLine(cage.Open);
            System.Diagnostics.Debug.WriteLine(cage.HumanInside);
            System.Diagnostics.Debug.WriteLine(cage.ExhibitInside);
        }

        private string CageName()
        {
            return "Cage " + cage.FindTempId();
        }


        private void add_new_cage_btn_Click(object sender, EventArgs e)
        {
            //Add constrain
            cage.Update();
            StoreInfo.sharedStoreInfo().main.RefreshNameCageList();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cage.Delete();
            this.Close();
        }

        #region Set Input
        

        private void cage_height_input_ValueChanged(object sender, EventArgs e)
        {
            cage.Height = Convert.ToInt32(cage_height_input.Value);
            System.Diagnostics.Debug.WriteLine(cage.Height);
        }

        private void cage_width_input_ValueChanged(object sender, EventArgs e)
        {
            cage.Width = Convert.ToInt32(cage_width_input.Value);
        }

        private void cage_length_input_ValueChanged(object sender, EventArgs e)
        {
            cage.Length = Convert.ToInt32(cage_length_input.Value);
        }

        private void cage_longitude_input_ValueChanged(object sender, EventArgs e)
        {
            cage.Longitude = (float)(cage_longitude_input.Value);
        }

        private void cage_latitude_input_ValueChanged(object sender, EventArgs e)
        {
            cage.Latitude = (float)(cage_latitude_input.Value);
        }

        private void cage_door_input_ValueChanged(object sender, EventArgs e)
        {
            cage.NumberOfDoors = Convert.ToInt32(cage_door_input.Value);
        }

        private void cage_visitors_input_ValueChanged(object sender, EventArgs e)
        {
            cage.NumberOfPeople = Convert.ToInt32(cage_visitors_input.Value);
        }

        private void cage_animal_input_ValueChanged(object sender, EventArgs e)
        {
            cage.NumberOfAnimal = Convert.ToInt32(cage_animal_input.Value);
        }
        #endregion
    }
}
