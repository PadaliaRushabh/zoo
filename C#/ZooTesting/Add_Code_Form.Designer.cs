namespace ZooTesting
{
    partial class Add_Code_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.cancel_button = new System.Windows.Forms.Button();
      this.add_new_code_btn = new System.Windows.Forms.Button();
      this.code_id_input = new System.Windows.Forms.TextBox();
      this.animal_name_label = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.code_message_input = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // cancel_button
      // 
      this.cancel_button.Location = new System.Drawing.Point(219, 207);
      this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
      this.cancel_button.Name = "cancel_button";
      this.cancel_button.Size = new System.Drawing.Size(100, 28);
      this.cancel_button.TabIndex = 37;
      this.cancel_button.Text = "Cancel";
      this.cancel_button.UseVisualStyleBackColor = true;
      this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
      // 
      // add_new_code_btn
      // 
      this.add_new_code_btn.Location = new System.Drawing.Point(111, 207);
      this.add_new_code_btn.Margin = new System.Windows.Forms.Padding(4);
      this.add_new_code_btn.Name = "add_new_code_btn";
      this.add_new_code_btn.Size = new System.Drawing.Size(100, 28);
      this.add_new_code_btn.TabIndex = 36;
      this.add_new_code_btn.Text = "Add";
      this.add_new_code_btn.UseVisualStyleBackColor = true;
      this.add_new_code_btn.Click += new System.EventHandler(this.add_new_alert_btn_Click);
      // 
      // code_id_input
      // 
      this.code_id_input.Location = new System.Drawing.Point(113, 15);
      this.code_id_input.Margin = new System.Windows.Forms.Padding(4);
      this.code_id_input.Name = "code_id_input";
      this.code_id_input.Size = new System.Drawing.Size(295, 22);
      this.code_id_input.TabIndex = 35;
      this.code_id_input.TextChanged += new System.EventHandler(this.alert_id_input_TextChanged);
      // 
      // animal_name_label
      // 
      this.animal_name_label.AutoSize = true;
      this.animal_name_label.Location = new System.Drawing.Point(24, 18);
      this.animal_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.animal_name_label.Name = "animal_name_label";
      this.animal_name_label.Size = new System.Drawing.Size(25, 17);
      this.animal_name_label.TabIndex = 34;
      this.animal_name_label.Text = "ID:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 50);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 17);
      this.label1.TabIndex = 38;
      this.label1.Text = "Message:";
      // 
      // code_message_input
      // 
      this.code_message_input.Location = new System.Drawing.Point(113, 47);
      this.code_message_input.Margin = new System.Windows.Forms.Padding(4);
      this.code_message_input.Name = "code_message_input";
      this.code_message_input.Size = new System.Drawing.Size(295, 117);
      this.code_message_input.TabIndex = 39;
      this.code_message_input.Text = "";
      this.code_message_input.TextChanged += new System.EventHandler(this.alert_message_input_TextChanged);
      // 
      // Add_Code_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(455, 250);
      this.Controls.Add(this.code_message_input);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cancel_button);
      this.Controls.Add(this.add_new_code_btn);
      this.Controls.Add(this.code_id_input);
      this.Controls.Add(this.animal_name_label);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Add_Code_Form";
      this.Text = "Add New Code";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_new_code_btn;
        private System.Windows.Forms.TextBox code_id_input;
        private System.Windows.Forms.Label animal_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox code_message_input;
    }
}