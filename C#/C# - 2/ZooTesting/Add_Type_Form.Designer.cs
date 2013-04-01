namespace ZooTesting
{
    partial class Add_Type_Form
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
            this.description_label = new System.Windows.Forms.Label();
            this.description_input = new System.Windows.Forms.RichTextBox();
            this.type_name_label = new System.Windows.Forms.Label();
            this.type_name_input = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.quantity_input = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(12, 79);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(63, 13);
            this.description_label.TabIndex = 0;
            this.description_label.Text = "Description:";
            // 
            // description_input
            // 
            this.description_input.Location = new System.Drawing.Point(84, 76);
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(261, 96);
            this.description_input.TabIndex = 1;
            this.description_input.Text = "";
            // 
            // type_name_label
            // 
            this.type_name_label.AutoSize = true;
            this.type_name_label.Location = new System.Drawing.Point(13, 38);
            this.type_name_label.Name = "type_name_label";
            this.type_name_label.Size = new System.Drawing.Size(65, 13);
            this.type_name_label.TabIndex = 2;
            this.type_name_label.Text = "Type Name:";
            // 
            // type_name_input
            // 
            this.type_name_input.Location = new System.Drawing.Point(84, 38);
            this.type_name_input.Name = "type_name_input";
            this.type_name_input.Size = new System.Drawing.Size(261, 20);
            this.type_name_input.TabIndex = 3;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(13, 197);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(49, 13);
            this.quantity_label.TabIndex = 4;
            this.quantity_label.Text = "Quantity:";
            // 
            // quantity_input
            // 
            this.quantity_input.Location = new System.Drawing.Point(84, 194);
            this.quantity_input.Name = "quantity_input";
            this.quantity_input.Size = new System.Drawing.Size(261, 20);
            this.quantity_input.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(84, 235);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(166, 234);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 284);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.quantity_input);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.type_name_input);
            this.Controls.Add(this.type_name_label);
            this.Controls.Add(this.description_input);
            this.Controls.Add(this.description_label);
            this.Name = "Add_Type_Form";
            this.Text = "Add New Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.RichTextBox description_input;
        private System.Windows.Forms.Label type_name_label;
        private System.Windows.Forms.TextBox type_name_input;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox quantity_input;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}