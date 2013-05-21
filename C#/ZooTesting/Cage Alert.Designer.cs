namespace ZooTesting
{
  partial class Cage_Alert
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
      this.animal_name_label = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.alert_message_input = new System.Windows.Forms.RichTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.add_new_code_btn = new System.Windows.Forms.Button();
      this.cancel_button = new System.Windows.Forms.Button();
      this.alert_id_input = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.alert_cage_id = new System.Windows.Forms.Label();
      this.alert_timer_input = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // animal_name_label
      // 
      this.animal_name_label.AutoSize = true;
      this.animal_name_label.Location = new System.Drawing.Point(5, 44);
      this.animal_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.animal_name_label.Name = "animal_name_label";
      this.animal_name_label.Size = new System.Drawing.Size(81, 17);
      this.animal_name_label.TabIndex = 35;
      this.animal_name_label.Text = "Error Code:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 79);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 17);
      this.label1.TabIndex = 39;
      this.label1.Text = "Start Time:";
      // 
      // alert_message_input
      // 
      this.alert_message_input.Location = new System.Drawing.Point(95, 112);
      this.alert_message_input.Margin = new System.Windows.Forms.Padding(4);
      this.alert_message_input.Name = "alert_message_input";
      this.alert_message_input.Size = new System.Drawing.Size(295, 117);
      this.alert_message_input.TabIndex = 41;
      this.alert_message_input.Text = "";
      this.alert_message_input.TextChanged += new System.EventHandler(this.alert_message_input_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 114);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 17);
      this.label2.TabIndex = 42;
      this.label2.Text = "Message:";
      // 
      // add_new_code_btn
      // 
      this.add_new_code_btn.Location = new System.Drawing.Point(109, 276);
      this.add_new_code_btn.Margin = new System.Windows.Forms.Padding(4);
      this.add_new_code_btn.Name = "add_new_code_btn";
      this.add_new_code_btn.Size = new System.Drawing.Size(100, 28);
      this.add_new_code_btn.TabIndex = 43;
      this.add_new_code_btn.Text = "Add";
      this.add_new_code_btn.UseVisualStyleBackColor = true;
      this.add_new_code_btn.Click += new System.EventHandler(this.add_new_code_btn_Click);
      // 
      // cancel_button
      // 
      this.cancel_button.Location = new System.Drawing.Point(217, 276);
      this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
      this.cancel_button.Name = "cancel_button";
      this.cancel_button.Size = new System.Drawing.Size(100, 28);
      this.cancel_button.TabIndex = 44;
      this.cancel_button.Text = "Cancel";
      this.cancel_button.UseVisualStyleBackColor = true;
      this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
      // 
      // alert_id_input
      // 
      this.alert_id_input.FormattingEnabled = true;
      this.alert_id_input.Location = new System.Drawing.Point(95, 41);
      this.alert_id_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.alert_id_input.Name = "alert_id_input";
      this.alert_id_input.Size = new System.Drawing.Size(295, 24);
      this.alert_id_input.TabIndex = 46;
      this.alert_id_input.SelectedIndexChanged += new System.EventHandler(this.alert_id_input_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 17);
      this.label3.TabIndex = 47;
      this.label3.Text = "Cage ID:";
      // 
      // alert_cage_id
      // 
      this.alert_cage_id.AutoSize = true;
      this.alert_cage_id.Location = new System.Drawing.Point(92, 9);
      this.alert_cage_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.alert_cage_id.Name = "alert_cage_id";
      this.alert_cage_id.Size = new System.Drawing.Size(30, 17);
      this.alert_cage_id.TabIndex = 48;
      this.alert_cage_id.Text = "null";
      // 
      // alert_timer_input
      // 
      this.alert_timer_input.Location = new System.Drawing.Point(95, 76);
      this.alert_timer_input.Margin = new System.Windows.Forms.Padding(4);
      this.alert_timer_input.Name = "alert_timer_input";
      this.alert_timer_input.ReadOnly = true;
      this.alert_timer_input.Size = new System.Drawing.Size(295, 22);
      this.alert_timer_input.TabIndex = 54;
      // 
      // Cage_Alert
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(428, 318);
      this.Controls.Add(this.alert_timer_input);
      this.Controls.Add(this.alert_cage_id);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.alert_id_input);
      this.Controls.Add(this.cancel_button);
      this.Controls.Add(this.add_new_code_btn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.alert_message_input);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.animal_name_label);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Cage_Alert";
      this.Text = "Cage_Alert";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label animal_name_label;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox alert_message_input;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button add_new_code_btn;
    private System.Windows.Forms.Button cancel_button;
    private System.Windows.Forms.ComboBox alert_id_input;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label alert_cage_id;
    private System.Windows.Forms.TextBox alert_timer_input;
  }
}