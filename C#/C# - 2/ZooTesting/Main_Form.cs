using System;
using System.Collections.Generic;
using System.Collections;
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
        private CageManager cg = new CageManager();
        private AnimalManager am = new AnimalManager();

        public Main_Form()
        {
            InitializeComponent();
            StoreInfo.sharedStoreInfo().main = this;

            //show username
            username_label.Text = StoreInfo.sharedStoreInfo().Global_Username; 

            //Cage manager
            RefreshNameCageList();

            //Animal Manager
            RefreshNameAnimalList();
            CheckInventory();
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

        private void add_type_btn_Click(object sender, EventArgs e)
        {
        }

        #region Cage Tab

            #region Input Cage
        private void size_height_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Height = Convert.ToInt32(size_height_input.Value);
        }

        private void size_width_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Width = Convert.ToInt32(size_width_input.Value);
        }

        private void size_length_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Length = Convert.ToInt32(size_length_input.Value);
        }

        private void location_latitude_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Latitude = (float)(location_latitude_input.Value);
        }

        private void location_longitude_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Longitude = (float)(location_longitude_input.Value);
        }

        private void cage_door_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.NumberOfDoors = Convert.ToInt32(cage_door_input.Value);
        }

        private void people_limit_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.NumberOfPeople = Convert.ToInt32(people_limit_input.Value);
        }

        private void animal_limit_input_ValueChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.NumberOfAnimal = Convert.ToInt32(animal_limit_input.Value);
        }

        private void cage_closed_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Open = Convert.ToBoolean(cage_closed_dropdown.SelectedIndex);
            System.Diagnostics.Debug.WriteLine(cage.Open);
        }

        private void human_inside_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.HumanInside = Convert.ToBoolean(human_inside_dropdown.SelectedIndex);
        }

        private void exhibit_inside_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.ExhibitInside = Convert.ToBoolean(exhibit_inside_dropdown.SelectedIndex);
        }
        #endregion

        public void RefreshNameCageList()
        {
            cg.RefreshList();
            cage_list_box.DataSource = cg.NameList();
            cage_choosen.DataSource = cg.NameList();
        }
        
        private void cage_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);

            cage_id_output.Text = Convert.ToString(cage.Id);

            cage_name_input.Text = cage.Name;
            size_height_input.Text = Convert.ToString(cage.Height);
            size_width_input.Text = Convert.ToString(cage.Width);
            size_length_input.Text = Convert.ToString(cage.Length);
            location_latitude_input.Text = Convert.ToString(cage.Latitude);
            location_longitude_input.Text = Convert.ToString(cage.Longitude);
            cage_door_input.Text = Convert.ToString(cage.NumberOfDoors);
            animal_limit_input.Text = Convert.ToString(cage.NumberOfAnimal);
            people_limit_input.Text = Convert.ToString(cage.NumberOfPeople);
            cage_closed_dropdown.SelectedIndex = Convert.ToInt32(cage.Open);
            human_inside_dropdown.SelectedIndex = Convert.ToInt32(cage.HumanInside);
            exhibit_inside_dropdown.SelectedIndex = Convert.ToInt32(cage.ExhibitInside);
        }

        private void add_cage_btn_Click(object sender, EventArgs e)
        {
            Add_Cage_Form acf = new Add_Cage_Form();
            acf.ShowDialog();
        }

        private void cage_update_btn_Click(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Update();
        }

        private void cage_delete_btn_Click(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            Cage cage = cg.GetCage(index);
            cage.Delete();
            RefreshNameCageList();
        }
        #endregion

        #region Animal Tab

            #region Set Input
        private void animal_name_input_TextChanged(object sender, EventArgs e)
        {
            int index = animal_list_box.SelectedIndex;
            Animal animal = am.GetAnimal(index);
            animal.Name = animal_name_input.Text.ToString();
        }
        #endregion

        public void RefreshNameAnimalList()
        {
            am.RefreshList();
            animal_list_box.DataSource = am.NameList();
            animal_manager_list_box.DataSource = am.NameList();
        }

        private void animal_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = animal_list_box.SelectedIndex;
            Animal animal = am.GetAnimal(index);

            animal_id_output.Text = animal.Id.ToString();
            animal_name_input.Text = animal.Name.ToString();
            
        }

        private void add_new_animal_btn_Click(object sender, EventArgs e)
        {
            Add_Animal_Form aaf = new Add_Animal_Form();
            aaf.ShowDialog();
        }

        private void update_animal_btn_Click(object sender, EventArgs e)
        {
            int index = animal_list_box.SelectedIndex;
            Animal animal = am.GetAnimal(index);
            animal.Update();
            RefreshNameAnimalList();
        }

        private void delete_animal_btn_Click(object sender, EventArgs e)
        {
            int index = animal_list_box.SelectedIndex;
            Animal animal = am.GetAnimal(index);
            animal.Delete();
            RefreshNameAnimalList();
        }
        #endregion

        #region Animal Manager Tab

        

       

        private void cage_choosen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = cage_choosen.SelectedIndex;
            Cage cage = cg.GetCage(index);

            AM_cage_id_output.Text = cage.Id.ToString();
            AM_cage_name_output.Text = cage.Name.ToString(); ;
            AM_size_height_output.Text = cage.Height.ToString(); 
            AM_size_width_output.Text = cage.Width.ToString();
            AM_size_length_output.Text = cage.Length.ToString();
            AM_location_latitude_output.Text = cage.Latitude.ToString();
            AM_location_longitude_output.Text = cage.Longitude.ToString();
            AM_doors_output.Text = cage.NumberOfDoors.ToString();

            Inventory.Items.Clear();

            foreach (Animal animal in cage.Inventory)
            {
                Inventory.Items.Add(animal.Name);
            }
            CheckInventory();
        }

        private string LoadAnimalName(int ID)
        {
            string mock = null;

            DataSet ds = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToInt32(row.ItemArray[0]) == ID)
                    {
                        mock = row.ItemArray[1].ToString();
                    }
                }
            }
            return mock;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (CheckInventory())
            {
                int selectedAnimal = animal_manager_list_box.SelectedIndex;
                int index = cage_choosen.SelectedIndex;

                Cage cage = cg.GetCage(index);
                Animal animal = am.GetAnimal(selectedAnimal);

                cage.AddAnimalToInventory(animal.Id);

                RefreshNameAnimalList();
                RefreshNameCageList();
                cage_choosen.SelectedIndex = index;
            }
            else
            {
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int selectedAnimal = Inventory.SelectedIndex;
            int index = cage_choosen.SelectedIndex;

            Cage cage = cg.GetCage(index);
            List<Animal> animalList = cage.ShowInventory();

            cage.DeleteAnimalFromInventory(animalList[selectedAnimal].OrderId);
            RefreshNameAnimalList();
            RefreshNameCageList();
            CheckInventory();

            cage_choosen.SelectedIndex = index;
        }

        private bool CheckInventory()
        {
            int index = cage_choosen.SelectedIndex;

            Cage cage = cg.GetCage(index);

            int max = cage.NumberOfAnimal;
            int cur = cage.CountItems();

            limit.Text = cur + "/" + max;

            if (cur < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        
        
    }
}
