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
    private CodeManager cm = new CodeManager();
    private AlertManager am2 = new AlertManager();

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

      //Code
      RefreshIDCodeList();

      //Alert
      RefreshIDAlertList();
    }

    #region Cage Tab

    #region Input Cage
    private void size_height_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Height = Convert.ToInt32(size_height_input.Value);
      cage_update_btn.Enabled = true;
    }

    private void size_width_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Width = Convert.ToInt32(size_width_input.Value);
      cage_update_btn.Enabled = true;
    }

    private void size_length_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Length = Convert.ToInt32(size_length_input.Value);
    }

    private void location_latitude_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Latitude = (float)(location_latitude_input.Value);
      cage_update_btn.Enabled = true;
    }

    private void location_longitude_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Longitude = (float)(location_longitude_input.Value);
      cage_update_btn.Enabled = true;
    }

    private void cage_door_input_ValueChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.NumberOfDoors = Convert.ToInt32(cage_door_input.Value);
      cage_update_btn.Enabled = true;
    }

    private void cage_closed_dropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.Open = Convert.ToBoolean(cage_closed_dropdown.SelectedIndex);
      cage_update_btn.Enabled = true;
    }

    private void human_inside_dropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.HumanInside = Convert.ToBoolean(human_inside_dropdown.SelectedIndex);
      cage_update_btn.Enabled = true;
    }

    private void exhibit_inside_dropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Cage cage = cg.GetCage(index);
      cage.ExhibitInside = Convert.ToBoolean(exhibit_inside_dropdown.SelectedIndex);
      cage_update_btn.Enabled = true;
    }
    #endregion

    public void RefreshNameCageList()
    {
      cg.RefreshList();
      cage_list_box.DataSource = cg.NameList();
      cage_choosen.DataSource = cg.NameList();
      ValidateButtonCage();
      cage_update_btn.Enabled = false;
    }

    private void cage_list_box_SelectedIndexChanged(object sender, EventArgs e)
    {
    
      int index = cage_list_box.SelectedIndex;
      cg.RefreshList();
      Cage cage = cg.GetCage(index);

      cage_id_output.Text = Convert.ToString(cage.Id);
      cage_name_input.Text = cage.Name;
      size_height_input.Text = Convert.ToString(cage.Height);
      size_width_input.Text = Convert.ToString(cage.Width);
      size_length_input.Text = Convert.ToString(cage.Length);
      location_latitude_input.Text = Convert.ToString(cage.Latitude);
      location_longitude_input.Text = Convert.ToString(cage.Longitude);
      cage_door_input.Text = Convert.ToString(cage.NumberOfDoors);
      cage_closed_dropdown.SelectedIndex = Convert.ToInt32(cage.Open);
      human_inside_dropdown.SelectedIndex = Convert.ToInt32(cage.HumanInside);
      exhibit_inside_dropdown.SelectedIndex = Convert.ToInt32(cage.ExhibitInside);
      cage_update_btn.Enabled = false;
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
      cage_update_btn.Enabled = false;
    }

    private void cage_delete_btn_Click(object sender, EventArgs e)
    {
      int index = cage_list_box.SelectedIndex;
      Cage cage = cg.GetCage(index);
      System.Diagnostics.Debug.WriteLine(cage.CheckAlert());

      if((cage.Inventory.Count != 0) && (cage.CheckAlert() == true))
        MessageBox.Show("Unable to delete Cage with Animals inside and active Alerts. Remove Animals under 'Animal Manager' tab. Clear Alerts under 'Alert Manager' tab.");
      else if(cage.Inventory.Count != 0)
        MessageBox.Show("Unable to delete Cage with Animals inside. Remove Animals under 'Animal Manager' tab.");
      else if(cage.CheckAlert() == true)
        MessageBox.Show("Unable to delete Cage with active Alerts. Clear Alerts under 'Alert Manager' tab.");
      else
        cage.Delete();

      RefreshNameCageList();
    }

    private void cage_alert_btn_Click(object sender, EventArgs e)
    {
      StoreInfo.sharedStoreInfo().Global_CodeList = cm.IDList();
      StoreInfo.sharedStoreInfo().Global_Cage_ID = cg.GetCage(cage_list_box.SelectedIndex).Id;

      Cage_Alert ca = new Cage_Alert();
      ca.ShowDialog();
    }

    private void ValidateButtonCage()
    {
      if(cm.CodeList.Count == 0)
        cage_alert_btn.Enabled = false;
      else
        cage_alert_btn.Enabled = true;

      if (cg.CageList.Count == 0)
      {
        cage_delete_btn.Enabled = false;
        cage_alert_btn.Enabled = false;
        cage_choosen.Enabled = false;
        cage_choosen.Text = "No Cages";
        cage_id_output.Text = "No Cages";
        cage_name_input.ResetText();
        size_height_input.Enabled = false;
        size_height_input.ResetText();
        size_width_input.Enabled = false;
        size_width_input.ResetText();
        size_length_input.Enabled = false;
        size_length_input.ResetText();
        location_latitude_input.Enabled = false;
        location_latitude_input.ResetText();
        location_longitude_input.Enabled = false;
        location_longitude_input.ResetText();
        cage_door_input.Enabled = false;
        cage_door_input.ResetText();
        cage_closed_dropdown.Enabled = false;
        cage_closed_dropdown.ResetText();
        human_inside_dropdown.Enabled = false;
        human_inside_dropdown.ResetText();
        exhibit_inside_dropdown.Enabled = false;
        exhibit_inside_dropdown.ResetText();

        AM_cage_id_output.ResetText();
        AM_cage_name_output.ResetText();
        AM_size_height_output.ResetText();
        AM_size_width_output.ResetText();
        AM_size_length_output.ResetText();
        AM_location_latitude_output.ResetText();
        AM_location_longitude_output.ResetText();
        AM_doors_output.ResetText();
      }
      else
      {
        cage_delete_btn.Enabled = true;
        cage_alert_btn.Enabled = true;
        cage_choosen.Enabled = true;
        size_height_input.Enabled = true;
        size_width_input.Enabled = true;
        size_length_input.Enabled = true;
        location_latitude_input.Enabled = true;
        location_longitude_input.Enabled = true;
        cage_door_input.Enabled = true;
        cage_closed_dropdown.Enabled = true;
        human_inside_dropdown.Enabled = true;
        exhibit_inside_dropdown.Enabled = true;
      }
    }
    #endregion

    #region Animal Tab

    #region Set Input
    private void animal_name_input_TextChanged(object sender, EventArgs e)
    {
      int index = animal_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Animal animal = am.GetAnimal(index);
      animal.Name = animal_name_input.Text.ToString();
      update_animal_btn.Enabled = true;
    }
    #endregion

    public void RefreshNameAnimalList()
    {
      am.RefreshList();
      animal_list_box.DataSource = am.NameList();
      animal_manager_list_box.DataSource = am.NameList();
      ValidateButtonAnimal();
      update_animal_btn.Enabled = false;
    }

    private void animal_list_box_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = animal_list_box.SelectedIndex;
      am.RefreshList();
      Animal animal = am.GetAnimal(index);

      animal_id_output.Text = animal.Id.ToString();
      animal_name_input.Text = animal.Name.ToString();
      update_animal_btn.Enabled = false;
      
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
      update_animal_btn.Enabled = false;
    }

    private void delete_animal_btn_Click(object sender, EventArgs e)
    {
      int index = animal_list_box.SelectedIndex;
      Animal animal = am.GetAnimal(index);
      if (animal.CheckCage() == false)
      {
          animal.Delete();
      }
      else
      {
          MessageBox.Show("Unable to delete Animal already assigned to a Cage. Remove Animals under 'Animal Manager' tab.");
      }
      RefreshNameAnimalList();
    }

    private void ValidateButtonAnimal()
    {
      if (am.AnimalList.Count == 0)
      {
        update_animal_btn.Enabled = false;
        delete_animal_btn.Enabled = false;
        animal_name_input.Enabled = false;
        animal_name_input.ResetText();
        animal_id_output.Text = "No Animals";
      }
      else
      {
        update_animal_btn.Enabled = true;
        delete_animal_btn.Enabled = true;
        animal_name_input.Enabled = true;
      }
    }
    #endregion

    #region Animal Manager Tab

    private void cage_choosen_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = cage_choosen.SelectedIndex;
      if (cage_choosen.Items.Count == 0)
      {
        cage_choosen.Enabled = false;
      }
      else
      {
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

        delete_btn.Enabled = false;
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
      int selectedAnimal = animal_manager_list_box.SelectedIndex;
      int index = cage_choosen.SelectedIndex;

      Cage cage = cg.GetCage(index);
      Animal animal = am.GetAnimal(selectedAnimal);

      cage.AddAnimalToInventory(animal.Id);

      RefreshNameAnimalList();
      RefreshNameCageList();
      cage_choosen.SelectedIndex = index;
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

      cage_choosen.SelectedIndex = index;
    }

    private void Inventory_SelectedIndexChanged(object sender, EventArgs e)
    {
      delete_btn.Enabled = true;
    }

    #endregion

    #region Code

    #region Set Input
    private void alert_message_input_TextChanged(object sender, EventArgs e)
    {
      int index = code_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Code a = cm.GetCode(index);
      a.Message = code_message_input.Text.ToString();
      update_code_btn.Enabled = true;
    }

    #endregion

    public void RefreshIDCodeList()
    {
      cm.RefreshList();
      code_list_box.DataSource = cm.IDList();
      ValidateButtonCode();
      update_code_btn.Enabled = false;
    }

    private void code_list_box_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = code_list_box.SelectedIndex;
      cm.RefreshList();
      Code a = cm.GetCode(index);

      code_id_input.Text = a.Id.ToString();
      code_message_input.Text = a.Message.ToString();
      update_code_btn.Enabled = false;
    }

    private void add_new_code_btn_Click(object sender, EventArgs e)
    {
      Add_Code_Form aaf = new Add_Code_Form();
      aaf.ShowDialog();
    }

    private void update_code_btn_Click(object sender, EventArgs e)
    {
      int index = code_list_box.SelectedIndex;
      Code a = cm.GetCode(index);
      a.Update();
      RefreshIDCodeList();
      update_code_btn.Enabled = false;
    }

    private void delete_code_btn_Click(object sender, EventArgs e)
    {
      int index = code_list_box.SelectedIndex;
      Code a = cm.GetCode(index);

      if (a.CheckAlert() == true)
        MessageBox.Show("Unable to delete Error Code with Alert attached. Remove Alerts under 'Alert Manager' tab.");
      else
        a.Delete();
      
      RefreshIDCodeList();
    }

    private void ValidateButtonCode()
    {
      if (cm.IDList().Count == 0)
      {
        code_list_box.Enabled = false;
        update_code_btn.Enabled = false;
        delete_code_btn.Enabled = false;
        code_id_input.Enabled = false;
        code_id_input.ResetText();
        code_message_input.Enabled = false;
        code_message_input.ResetText();
      }
      else
      {
        code_list_box.Enabled = true;
        update_code_btn.Enabled = true;
        delete_code_btn.Enabled = true;
        code_id_input.Enabled = true;
        code_message_input.Enabled = true;
      }
    }

    #endregion

    #region Alert

    #region setInput
    private void alert_message_input_TextChanged_1(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Alert a = am2.GetAlert(index);
      a.AdminMessage = alert_message_input.Text.ToString();
      alert_update_btn.Enabled = true;
    }

    private void alert_idcode_input_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;
      if (index == -1)
      {
        return;
      }
      Alert a = am2.GetAlert(index);
      a.IdCode = alert_codeid_input.SelectedValue.ToString();
      alert_update_btn.Enabled = true;
    }
    #endregion

    public void RefreshIDAlertList()
    {
      am2.RefreshList();
      

      
      

      System.Diagnostics.Debug.WriteLine("6");
      alert_list_box.DataSource = am2.NameList();
      alert_codeid_input.DataSource = cm.IDList();
      ValidateButtonAlert();
      alert_update_btn.Enabled = false;
    }

    private void alert_list_box_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;
      System.Diagnostics.Debug.WriteLine(index);
      am2.RefreshList();

      
          Alert a = am2.GetAlert(index);

          alert_id_input.Text = a.Id.ToString();
          alert_cageid_input.Text = a.IdCage.ToString();
          alert_codeid_input.SelectedItem = a.IdCode;

          alert_message_input.Text = a.AdminMessage.ToString();

          if (a.IsOpen == false)
              alert_isopen_input.Text = "Off";
          else
              alert_isopen_input.Text = "On";

          alert_start_input.Text = a.TimeStart;
          alert_end_input.Text = a.TimeEnd;
          alert_update_btn.Enabled = false;
      
      
    }

    private void alert_resolve_btn_Click(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;
      Alert a = am2.GetAlert(index);
      DateTime datetime = DateTime.Now;
      a.TimeEnd = datetime.ToString();
      a.IsOpen = false;
      a.Update();
      RefreshIDAlertList();
    }

    private void alert_update_btn_Click(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;
      Alert a = am2.GetAlert(index);
      a.Update();
      alert_update_btn.Enabled = false;
    }

    private void alert_delete_btn_Click(object sender, EventArgs e)
    {
      int index = alert_list_box.SelectedIndex;

      System.Diagnostics.Debug.WriteLine(index);
      Alert a = am2.GetAlert(index);
      System.Diagnostics.Debug.WriteLine("2");
      a.Delete();
      System.Diagnostics.Debug.WriteLine("3");
      RefreshIDAlertList();
      System.Diagnostics.Debug.WriteLine("4");
    }

    private void ValidateButtonAlert()
    {
      if (am2.AlertList.Count == 0)
      {
        alert_resolve_btn.Enabled = false;
        alert_update_btn.Enabled = false;
        alert_delete_btn.Enabled = false;
        alert_list_box.Enabled = false;
        alert_list_box.ResetText();
        alert_id_input.Enabled = false;
        alert_id_input.ResetText();
        alert_codeid_input.Enabled = false;
        alert_codeid_input.ResetText();
        alert_cageid_input.Enabled = false;
        alert_cageid_input.ResetText();
        alert_message_input.Enabled = false;
        alert_message_input.ResetText();
        alert_isopen_input.Enabled = false;
        alert_isopen_input.ResetText();
        alert_start_input.Enabled = false;
        alert_start_input.ResetText();
        alert_end_input.Enabled = false;
        alert_end_input.ResetText();
      }
      else
      {
        alert_resolve_btn.Enabled = true;
        alert_update_btn.Enabled = true;
        alert_delete_btn.Enabled = true;
        alert_list_box.Enabled = true;
        alert_id_input.Enabled = true;
        alert_codeid_input.Enabled = true;
        alert_cageid_input.Enabled = true;
        alert_message_input.Enabled = true;
        alert_isopen_input.Enabled = true;
        alert_start_input.Enabled = true;
        alert_end_input.Enabled = true;
      }
    }
    #endregion

    private void logout_btn_Click(object sender, EventArgs e)
    {
      StoreInfo.sharedStoreInfo().Global_LoginStatus = false;
      MessageBox.Show("Logout successful.");
      this.Hide();
      Login_Form lg = new Login_Form();
      lg.ShowDialog();
      this.Close();
    }
  }
}
