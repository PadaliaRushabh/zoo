using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace ZooTesting
{
  class AnimalManager
  {
    private List<Animal> _AnimalList = new List<Animal>();
  
    public List<Animal> AnimalList
    {
        set { _AnimalList = value;}
        get { return _AnimalList; }
    }

    public AnimalManager()
    {
      RefreshList();
    }

    public void RefreshList()
    {
      AnimalList = new List<Animal>();
      DataSet data = StoreInfo.sharedStoreInfo().LoadTable("animalrecords_tb");
      foreach (DataTable table in data.Tables)
      {
        foreach (DataRow row in table.Rows)
        {
          int id = Convert.ToInt32(row.ItemArray[0].ToString());
          string name = row.ItemArray[1].ToString();

          Animal animal = new Animal(id, name);
          AnimalList.Add(animal);
        }
      }
    }

    public ArrayList NameList()
    {
      ArrayList NameList = new ArrayList();
      foreach (Animal animal in _AnimalList)
      {
        NameList.Add(animal.Name);
      }
      return NameList;
    }

    public Animal GetAnimal(int index)
    {
        return _AnimalList[index];
    }
  } 
}
