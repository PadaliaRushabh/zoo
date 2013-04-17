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
        public Main_Form()
        {
            InitializeComponent();
            StoreInfo.sharedStoreInfo().main = this;

            //show username
            username_label.Text = StoreInfo.sharedStoreInfo().Global_Username; 

            //Cage manager
            GenerateCageList();

            //Animal Manager
            GenerateAnimalList();
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
        /// <summary>
        /// Generate the Cage List
        /// </summary>
        public void GenerateCageList()
        {
            cage_list_box.Items.Clear();
            cage_choosen.Items.Clear();
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");
            foreach (DataTable table in cage.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string name = row.ItemArray[1].ToString();
                    cage_list_box.Items.Add(id + ": " + name);
                    cage_choosen.Items.Add(id + ": " + name);
                }
            }
            cage_list_box.SelectedIndex = 0;
            cage_choosen.SelectedIndex = 0;
        }

        /// <summary>
        /// Show Details After Select Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cage_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cage_list_box.SelectedIndex;
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");

            foreach (DataTable table in cage.Tables)
            {
                cage_id_output.Text = table.Rows[index].ItemArray[0].ToString();
                cage_name_input.Text = table.Rows[index].ItemArray[1].ToString();
                size_height_input.Text = table.Rows[index].ItemArray[2].ToString();
                size_width_input.Text = table.Rows[index].ItemArray[3].ToString();
                size_length_input.Text = table.Rows[index].ItemArray[4].ToString();
                location_latitude_input.Text = table.Rows[index].ItemArray[5].ToString();
                location_longitude_input.Text = table.Rows[index].ItemArray[6].ToString();
                cage_door_input.Text = table.Rows[index].ItemArray[7].ToString();
            }
        }

        /// <summary>
        /// Click Add cage Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_cage_btn_Click(object sender, EventArgs e)
        {
            Add_Cage_Form acf = new Add_Cage_Form();
            acf.ShowDialog();
        }

        /// <summary>
        /// Click Update Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cage_update_btn_Click(object sender, EventArgs e)
        {
            //Check Constraint
            int ID = Convert.ToInt32(cage_id_output.Text);
            string name = cage_name_input.Text;
            int height = Convert.ToInt32(size_height_input.Text);
            int width = Convert.ToInt32(size_width_input.Text);
            int length = Convert.ToInt32(size_length_input.Text);
            float latitude = float.Parse(location_latitude_input.Text);
            float longitude = float.Parse(location_longitude_input.Text);
            int door = Convert.ToInt32(cage_door_input.Text);

            if (StoreInfo.sharedStoreInfo().UpdateCage(ID, name, height, width, length, latitude, longitude, door))
            {
                this.GenerateCageList();
                MessageBox.Show("Update successfully!");
            }
            else
            {
                MessageBox.Show("Update failed!!!!");
            }
        }

        /// <summary>
        /// Click Delete Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cage_delete_btn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cage_id_output.Text);

            if (StoreInfo.sharedStoreInfo().DeleteCage(ID))
            {
                this.GenerateCageList();
                MessageBox.Show("Update successfully!");
            }
            else
            {
                MessageBox.Show("Update failed!!!!");
            }
        }
        #endregion

        #region Animal Tab
        /// <summary>
        /// Generate Animal List
        /// </summary>
        public void GenerateAnimalList()
        {
            animal_list_box.Items.Clear();
            animal_manager_list_box.Items.Clear();
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");
            foreach (DataTable table in cage.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string name = row.ItemArray[1].ToString();
                    animal_list_box.Items.Add(id + ": " + name);
                    animal_manager_list_box.Items.Add(id + ": " + name);
                }
            }
            animal_list_box.SelectedIndex = 0;
            animal_manager_list_box.SelectedIndex = 0;
        }

        /// <summary>
        /// Click Animal List Based on Index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animal_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = animal_list_box.SelectedIndex;
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");

            foreach (DataTable table in cage.Tables)
            {
                this.animal_id_output.Text = table.Rows[index].ItemArray[0].ToString();
                this.animal_name_input.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        /// <summary>
        /// Click Add New Animal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_new_animal_btn_Click(object sender, EventArgs e)
        {
            Add_Animal_Form aaf = new Add_Animal_Form();
            aaf.ShowDialog();
        }

        /// <summary>
        /// Click Update Animal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_animal_btn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(animal_id_output.Text);
            string name = animal_name_input.Text;

            if (StoreInfo.sharedStoreInfo().UpdateAnimal(ID, name))
            {
                this.GenerateAnimalList();
                MessageBox.Show("Update successfully!");
            }
            else
            {
                MessageBox.Show("Update failed!!!!");
            }

        }

        /// <summary>
        /// Click Delete Animal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_animal_btn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(animal_id_output.Text);

            if (StoreInfo.sharedStoreInfo().DeleteAnimal(ID))
            {
                this.GenerateAnimalList();
                MessageBox.Show("Delete successfully!");
            }
            else
            {
                MessageBox.Show("Delete failed!!!!");
            }
        }
        #endregion

        #region Animal Manager Tab

        private void AMGenerateAnimalList()
        {
            animal_manager_list_box.Items.Clear();
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");
            foreach (DataTable table in cage.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string name = row.ItemArray[1].ToString();
                    animal_manager_list_box.Items.Add(id + ": " + name);
                }
            }
        }

        private void AMGenerateCageList()
        {
            cage_choosen.Items.Clear();
            DataSet cage = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");
            foreach (DataTable table in cage.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string name = row.ItemArray[1].ToString();
                    cage_choosen.Items.Add(id + ": " + name);
                }
            }
        }

        private void cage_choosen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventory.Items.Clear();
            int index = cage_choosen.SelectedIndex;
            DataSet ds = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");

            foreach (DataTable table in ds.Tables)
            {
                AM_cage_id_output.Text = table.Rows[index].ItemArray[0].ToString();
                AM_cage_name_output.Text = table.Rows[index].ItemArray[1].ToString();
                AM_size_height_output.Text = table.Rows[index].ItemArray[2].ToString();
                AM_size_width_output.Text = table.Rows[index].ItemArray[3].ToString();
                AM_size_length_output.Text = table.Rows[index].ItemArray[4].ToString();
                AM_location_latitude_output.Text = table.Rows[index].ItemArray[5].ToString();
                AM_location_longitude_output.Text = table.Rows[index].ItemArray[6].ToString();
                AM_doors_output.Text = table.Rows[index].ItemArray[7].ToString();
            }

            DataSet ds2 = StoreInfo.sharedStoreInfo().LoadTable("animal_tb");
            foreach (DataTable table in ds2.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row.ItemArray[1].ToString() == AM_cage_id_output.Text)
                    {
                        Inventory.Items.Add(LoadAnimalName(Convert.ToInt32(row.ItemArray[2])) + Convert.ToInt32(row.ItemArray[0]));
                    }
                }
            }
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
            int animalIndex = animal_manager_list_box.SelectedIndex;
            int cageIndex = cage_choosen.SelectedIndex;

            int animalID = 0;
            int cageID = 0;
            DataSet ds = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");
            foreach (DataTable table in ds.Tables)
            {
                
                cageID = Convert.ToInt32(table.Rows[cageIndex].ItemArray[0]);
            }
            DataSet ds2 = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");
            foreach (DataTable table in ds2.Tables)
            {
                animalID = Convert.ToInt32(table.Rows[animalIndex].ItemArray[0]);
            }


            System.Diagnostics.Debug.WriteLine(animalID);
            System.Diagnostics.Debug.WriteLine(cageID);
            if (StoreInfo.sharedStoreInfo().AddNewAnimalManager(cageID, animalID))
            {
                this.AMGenerateAnimalList();
                this.AMGenerateCageList();
                MessageBox.Show("Add successfully!");
            }
            else
            {
                MessageBox.Show("Add failed!!!!");
            }
        }
        #endregion

        

        






    }
}
