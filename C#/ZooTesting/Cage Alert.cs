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
  public partial class Cage_Alert : Form
  {
    private Alert _alert = new Alert();

    public Cage_Alert()
    {
      InitializeComponent();

      add_new_code_btn.Enabled = false;

      DateTime datetime = DateTime.Now;
      alert_timer_input.Text = datetime.ToString();
      //alert_timer_input.Value = Convert.ToDateTime("00:00");
      
      alert_id_input.DataSource = StoreInfo.sharedStoreInfo().Global_CodeList;
      alert_cage_id.Text = StoreInfo.sharedStoreInfo().Global_Cage_ID.ToString();
      _alert.TimeStart = datetime.ToString();
      _alert.TimeEnd = "Issue Unresolved";
      _alert.IsOpen = true;
      _alert.IdCage = StoreInfo.sharedStoreInfo().Global_Cage_ID;
      
    }

    private void cancel_button_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void add_new_code_btn_Click(object sender, EventArgs e)
    {
      _alert.Add();
      StoreInfo.sharedStoreInfo().main.RefreshIDAlertList();
      this.Close();
    }

    private void alert_id_input_SelectedIndexChanged(object sender, EventArgs e)
    {
      _alert.IdCode = alert_id_input.SelectedValue.ToString();
    }

    private void alert_timer_input_ValueChanged(object sender, EventArgs e)
    {
      _alert.TimeStart = alert_timer_input.Text.ToString();
    }

    private void alert_message_input_TextChanged(object sender, EventArgs e)
    {
      _alert.AdminMessage = alert_message_input.Text;

      if((alert_id_input.SelectedIndex >= 0) && (alert_message_input.TextLength > 0))
        add_new_code_btn.Enabled = true;
    }
  }
}
