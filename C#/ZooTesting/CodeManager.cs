using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace ZooTesting
{
  class CodeManager
  {
    private List<Code> _codeList = new List<Code>();

    public CodeManager() { }

    public List<Code> CodeList
    {
        set { _codeList = value; }
        get { return _codeList; }
    }
    public void RefreshList()
    {
      _codeList = new List<Code>();
      DataSet data = StoreInfo.sharedStoreInfo().LoadTable("code_tb");
      foreach (DataTable table in data.Tables)
      {
        foreach (DataRow row in table.Rows)
        {
          string id = row.ItemArray[0].ToString();
          string message = row.ItemArray[1].ToString();

          Code alert = new Code(id, message);
          _codeList.Add(alert);
        }
      }
    }

    public ArrayList IDList()
    {
      ArrayList nameList = new ArrayList();
      foreach (Code alert in _codeList)
      {
        nameList.Add(alert.Id);
      }
      return nameList;
    }

    public Code GetCode(int index)
    {
      return _codeList[index];
    }

  }
}
