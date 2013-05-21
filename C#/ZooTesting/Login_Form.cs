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
  public partial class Login_Form : Form
  {
    DatabaseRetrieve data = new DatabaseRetrieve();

    public Login_Form()
    {
      InitializeComponent();
      username_input.Text = "abc";
      password_input.Text = "123";
    }

    private void login_btn_Click(object sender, EventArgs e)
    {
      string user = this.username_input.Text;
      string pass = this.password_input.Text;


      if (StoreInfo.sharedStoreInfo().CheckLogin(user, pass))
      {
        this.Hide();
        Main_Form mf = new Main_Form();
        mf.ShowDialog();
        this.Close();
      }
      else
      {
        MessageBox.Show("Login failed. Username/password Incorrect");
      }
    }

    private void cancel_btn_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Login_Form_Load(object sender, EventArgs e)
    {

    }
  }
}
