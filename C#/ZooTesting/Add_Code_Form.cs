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
    public partial class Add_Code_Form : Form
    {
        private Code _alert = new Code();
        public Add_Code_Form()
        {
            InitializeComponent();
            add_new_code_btn.Enabled = false;
        }

        private void add_new_alert_btn_Click(object sender, EventArgs e)
        {
            _alert.Add(); ;
            StoreInfo.sharedStoreInfo().main.RefreshIDCodeList();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alert_id_input_TextChanged(object sender, EventArgs e)
        {
            _alert.Id = code_id_input.Text.ToString();
        }

        private void alert_message_input_TextChanged(object sender, EventArgs e)
        {
            _alert.Message = code_message_input.Text.ToString();
            if ((code_id_input.TextLength > 0) && (code_message_input.TextLength > 0))
              add_new_code_btn.Enabled = true;
            else
              add_new_code_btn.Enabled = false;
        }
    }
}
