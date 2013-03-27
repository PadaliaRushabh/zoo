using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zoo
{
  public partial class Form1 : Form
  {
    public List<Cage> cage_list = new List<Cage>();

    public Form1()
    {
      InitializeComponent();
    }

    private void Cage_Add_Button_Click(object sender, EventArgs e)
    {
      // Store Cage Values for Constructor
      decimal Cage_Quantity = Cage_Quantity1.Value;
      decimal Cage_Doors = Cage_Doors1.Value;
      object Animal_Type = Animal_Type1.SelectedIndex;
      object Cage_Location = Cage_Location1.SelectedIndex;

      Cage c = new Cage(cage_list.Count(), Cage_Quantity, Cage_Location1.SelectedIndex.ToString(), Cage_Doors, Animal_Type1.SelectedIndex.ToString());
      for(int j = 0; j < Cage_Quantity; ++j)
        cage_list.Add(c);

      // Populate List of Cages
      Delete_Cage_List.Items.Clear();
      CageUI_List.Items.Clear();
      for (int i = 0; i < cage_list.Count(); ++i)
      {
        CageUI_List.Items.Add(cage_list[i].c_Cage_Name.ToString());
        Delete_Cage_List.Items.Add(cage_list[i].c_Cage_Name.ToString());
      }

      MessageBox.Show("Cage(s) Added.");
    }

    private void Cage_Delete_Button_Click(object sender, EventArgs e)
    {
      // Remove Cages
      int i = Delete_Cage_List.SelectedIndex;
      cage_list.RemoveAt(i);
      Delete_Cage_List.Items.RemoveAt(i);
      CageUI_List.Items.RemoveAt(i);
      MessageBox.Show("Cage Deleted.");
    }

    private void CageUI_List_SelectedIndexChanged(object sender, EventArgs e)
    {
      int i = CageUI_List.SelectedIndex;

      // Display Cage Location
      if (cage_list[i].c_Cage_Location == "-1")
        Location_TB.Text = "Unknown Location";
      if (cage_list[i].c_Cage_Location == "0")
        Location_TB.Text = "Location A";
      if (cage_list[i].c_Cage_Location == "1")
        Location_TB.Text = "Location B";
      if (cage_list[i].c_Cage_Location == "2")
        Location_TB.Text = "Location C";
      if (cage_list[i].c_Cage_Location == "3")
        Location_TB.Text = "Location D";
      if (cage_list[i].c_Cage_Location == "4")
        Location_TB.Text = "Location E";

      // Display Cage Type
      if (cage_list[i].c_Animal_Type == "-1")
        Type_TB.Text = "Unknown Animal";
      if (cage_list[i].c_Animal_Type == "0")
        Type_TB.Text = "Alligator";
      if (cage_list[i].c_Animal_Type == "1")
        Type_TB.Text = "Elephant";
      if (cage_list[i].c_Animal_Type == "2")
        Type_TB.Text = "Panda";
      if (cage_list[i].c_Animal_Type == "3")
        Type_TB.Text = "Jaguar";
      if (cage_list[i].c_Animal_Type == "4")
        Type_TB.Text = "Tiger";

      // Display Number of Doors
      Doors_TB.Text = cage_list[i].c_Cage_Doors.ToString();
    }
  }

  public class Cage
  {
    // Cage variables
    public string c_Cage_Name;
    public string c_Cage_Location;
    public string c_Animal_Type;
    public decimal c_Cage_Doors;

    public Cage(int CurrentNum, decimal Cage_Quantity, string Cage_Location, decimal Cage_Doors, string Animal_Type)
    {
      c_Cage_Name = CurrentNum.ToString();

      // Append Location
      if (Cage_Location == "-1")
        c_Cage_Name += "-Unknown Location-";
      if (Cage_Location == "0")
        c_Cage_Name += "-Location A-";
      else if (Cage_Location == "1")
        c_Cage_Name += "-Location B-";
      else if (Cage_Location == "2")
        c_Cage_Name += "-Location C-";
      else if (Cage_Location == "3")
        c_Cage_Name += "-Location D-";
      else if (Cage_Location == "4")
        c_Cage_Name += "-Location E-";

      // Append Animal Type
      if (Animal_Type == "-1")
        c_Cage_Name += "-Unknown Animal-";
      if (Animal_Type == "0")
        c_Cage_Name += "-Alligator-";
      else if (Animal_Type == "1")
        c_Cage_Name += "-Elephant-";
      else if (Animal_Type == "2")
        c_Cage_Name += "-Panda-";
      else if (Animal_Type == "3")
        c_Cage_Name += "-Jaguar-";
      else if (Animal_Type == "4")
        c_Cage_Name += "-Tiger-";

      // Append Number of Doors
      c_Cage_Name += Cage_Doors.ToString() + " Door(s)";

      // Save data
      c_Cage_Location = Cage_Location;
      c_Cage_Doors = Cage_Doors;
      c_Animal_Type = Animal_Type;
    }
  }
}
