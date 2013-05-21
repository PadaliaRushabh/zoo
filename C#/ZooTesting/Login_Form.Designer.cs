namespace ZooTesting
{
    partial class Login_Form
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
      this.username_label = new System.Windows.Forms.Label();
      this.password_label = new System.Windows.Forms.Label();
      this.username_input = new System.Windows.Forms.TextBox();
      this.password_input = new System.Windows.Forms.TextBox();
      this.login_btn = new System.Windows.Forms.Button();
      this.cancel_btn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // username_label
      // 
      this.username_label.AutoSize = true;
      this.username_label.Location = new System.Drawing.Point(31, 68);
      this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.username_label.Name = "username_label";
      this.username_label.Size = new System.Drawing.Size(77, 17);
      this.username_label.TabIndex = 0;
      this.username_label.Text = "Username:";
      // 
      // password_label
      // 
      this.password_label.AutoSize = true;
      this.password_label.Location = new System.Drawing.Point(35, 108);
      this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.password_label.Name = "password_label";
      this.password_label.Size = new System.Drawing.Size(73, 17);
      this.password_label.TabIndex = 1;
      this.password_label.Text = "Password:";
      // 
      // username_input
      // 
      this.username_input.Location = new System.Drawing.Point(117, 68);
      this.username_input.Margin = new System.Windows.Forms.Padding(4);
      this.username_input.Name = "username_input";
      this.username_input.Size = new System.Drawing.Size(189, 22);
      this.username_input.TabIndex = 2;
      // 
      // password_input
      // 
      this.password_input.Location = new System.Drawing.Point(119, 108);
      this.password_input.Margin = new System.Windows.Forms.Padding(4);
      this.password_input.Name = "password_input";
      this.password_input.Size = new System.Drawing.Size(188, 22);
      this.password_input.TabIndex = 3;
      // 
      // login_btn
      // 
      this.login_btn.Location = new System.Drawing.Point(117, 162);
      this.login_btn.Margin = new System.Windows.Forms.Padding(4);
      this.login_btn.Name = "login_btn";
      this.login_btn.Size = new System.Drawing.Size(100, 28);
      this.login_btn.TabIndex = 4;
      this.login_btn.Text = "Login";
      this.login_btn.UseVisualStyleBackColor = true;
      this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
      // 
      // cancel_btn
      // 
      this.cancel_btn.Location = new System.Drawing.Point(227, 162);
      this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
      this.cancel_btn.Name = "cancel_btn";
      this.cancel_btn.Size = new System.Drawing.Size(100, 28);
      this.cancel_btn.TabIndex = 5;
      this.cancel_btn.Text = "Cancel";
      this.cancel_btn.UseVisualStyleBackColor = true;
      this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
      // 
      // Login_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(379, 220);
      this.Controls.Add(this.cancel_btn);
      this.Controls.Add(this.login_btn);
      this.Controls.Add(this.password_input);
      this.Controls.Add(this.username_input);
      this.Controls.Add(this.password_label);
      this.Controls.Add(this.username_label);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Login_Form";
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Login_Form_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}

