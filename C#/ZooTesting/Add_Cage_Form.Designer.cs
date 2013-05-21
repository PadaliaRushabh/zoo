namespace ZooTesting
{
    partial class Add_Cage_Form
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
      this.cage_height_label = new System.Windows.Forms.Label();
      this.cage_width_label = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.add_new_cage_btn = new System.Windows.Forms.Button();
      this.cancel_button = new System.Windows.Forms.Button();
      this.cage_height_input = new System.Windows.Forms.NumericUpDown();
      this.cage_width_input = new System.Windows.Forms.NumericUpDown();
      this.cage_length_input = new System.Windows.Forms.NumericUpDown();
      this.cage_longitude_input = new System.Windows.Forms.NumericUpDown();
      this.cage_latitude_input = new System.Windows.Forms.NumericUpDown();
      this.cage_door_input = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.cage_height_input)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_width_input)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_length_input)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_longitude_input)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_latitude_input)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_door_input)).BeginInit();
      this.SuspendLayout();
      // 
      // cage_height_label
      // 
      this.cage_height_label.AutoSize = true;
      this.cage_height_label.Location = new System.Drawing.Point(19, 53);
      this.cage_height_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.cage_height_label.Name = "cage_height_label";
      this.cage_height_label.Size = new System.Drawing.Size(84, 17);
      this.cage_height_label.TabIndex = 3;
      this.cage_height_label.Text = "Size Height:";
      // 
      // cage_width_label
      // 
      this.cage_width_label.AutoSize = true;
      this.cage_width_label.Location = new System.Drawing.Point(19, 85);
      this.cage_width_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.cage_width_label.Name = "cage_width_label";
      this.cage_width_label.Size = new System.Drawing.Size(79, 17);
      this.cage_width_label.TabIndex = 4;
      this.cage_width_label.Text = "Size Width:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(19, 117);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(87, 17);
      this.label5.TabIndex = 5;
      this.label5.Text = "Size Length:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(19, 149);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(133, 17);
      this.label6.TabIndex = 6;
      this.label6.Text = "Location Longitude:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(19, 181);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(125, 17);
      this.label7.TabIndex = 7;
      this.label7.Text = "Location Latitude: ";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(19, 213);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(50, 17);
      this.label8.TabIndex = 8;
      this.label8.Text = "Doors:";
      // 
      // add_new_cage_btn
      // 
      this.add_new_cage_btn.Location = new System.Drawing.Point(159, 321);
      this.add_new_cage_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.add_new_cage_btn.Name = "add_new_cage_btn";
      this.add_new_cage_btn.Size = new System.Drawing.Size(100, 28);
      this.add_new_cage_btn.TabIndex = 16;
      this.add_new_cage_btn.Text = "Add";
      this.add_new_cage_btn.UseVisualStyleBackColor = true;
      this.add_new_cage_btn.Click += new System.EventHandler(this.add_new_cage_btn_Click);
      // 
      // cancel_button
      // 
      this.cancel_button.Location = new System.Drawing.Point(267, 321);
      this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cancel_button.Name = "cancel_button";
      this.cancel_button.Size = new System.Drawing.Size(100, 28);
      this.cancel_button.TabIndex = 17;
      this.cancel_button.Text = "Cancel";
      this.cancel_button.UseVisualStyleBackColor = true;
      this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
      // 
      // cage_height_input
      // 
      this.cage_height_input.Location = new System.Drawing.Point(164, 50);
      this.cage_height_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_height_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_height_input.Name = "cage_height_input";
      this.cage_height_input.Size = new System.Drawing.Size(295, 22);
      this.cage_height_input.TabIndex = 19;
      this.cage_height_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_height_input.ValueChanged += new System.EventHandler(this.cage_height_input_ValueChanged);
      // 
      // cage_width_input
      // 
      this.cage_width_input.Location = new System.Drawing.Point(164, 82);
      this.cage_width_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_width_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_width_input.Name = "cage_width_input";
      this.cage_width_input.Size = new System.Drawing.Size(295, 22);
      this.cage_width_input.TabIndex = 20;
      this.cage_width_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_width_input.ValueChanged += new System.EventHandler(this.cage_width_input_ValueChanged);
      // 
      // cage_length_input
      // 
      this.cage_length_input.Location = new System.Drawing.Point(164, 114);
      this.cage_length_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_length_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_length_input.Name = "cage_length_input";
      this.cage_length_input.Size = new System.Drawing.Size(295, 22);
      this.cage_length_input.TabIndex = 21;
      this.cage_length_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_length_input.ValueChanged += new System.EventHandler(this.cage_length_input_ValueChanged);
      // 
      // cage_longitude_input
      // 
      this.cage_longitude_input.Location = new System.Drawing.Point(164, 146);
      this.cage_longitude_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_longitude_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_longitude_input.Name = "cage_longitude_input";
      this.cage_longitude_input.Size = new System.Drawing.Size(295, 22);
      this.cage_longitude_input.TabIndex = 22;
      this.cage_longitude_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_longitude_input.ValueChanged += new System.EventHandler(this.cage_longitude_input_ValueChanged);
      // 
      // cage_latitude_input
      // 
      this.cage_latitude_input.Location = new System.Drawing.Point(164, 178);
      this.cage_latitude_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_latitude_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_latitude_input.Name = "cage_latitude_input";
      this.cage_latitude_input.Size = new System.Drawing.Size(295, 22);
      this.cage_latitude_input.TabIndex = 23;
      this.cage_latitude_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_latitude_input.ValueChanged += new System.EventHandler(this.cage_latitude_input_ValueChanged);
      // 
      // cage_door_input
      // 
      this.cage_door_input.Location = new System.Drawing.Point(164, 210);
      this.cage_door_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cage_door_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_door_input.Name = "cage_door_input";
      this.cage_door_input.Size = new System.Drawing.Size(295, 22);
      this.cage_door_input.TabIndex = 24;
      this.cage_door_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cage_door_input.ValueChanged += new System.EventHandler(this.cage_door_input_ValueChanged);
      // 
      // Add_Cage_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 382);
      this.Controls.Add(this.cage_door_input);
      this.Controls.Add(this.cage_latitude_input);
      this.Controls.Add(this.cage_longitude_input);
      this.Controls.Add(this.cage_length_input);
      this.Controls.Add(this.cage_width_input);
      this.Controls.Add(this.cage_height_input);
      this.Controls.Add(this.cancel_button);
      this.Controls.Add(this.add_new_cage_btn);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cage_width_label);
      this.Controls.Add(this.cage_height_label);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Add_Cage_Form";
      this.Text = "Add New Cage";
      ((System.ComponentModel.ISupportInitialize)(this.cage_height_input)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_width_input)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_length_input)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_longitude_input)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_latitude_input)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cage_door_input)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cage_height_label;
        private System.Windows.Forms.Label cage_width_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_new_cage_btn;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.NumericUpDown cage_height_input;
        private System.Windows.Forms.NumericUpDown cage_width_input;
        private System.Windows.Forms.NumericUpDown cage_length_input;
        private System.Windows.Forms.NumericUpDown cage_longitude_input;
        private System.Windows.Forms.NumericUpDown cage_latitude_input;
        private System.Windows.Forms.NumericUpDown cage_door_input;
    }
}