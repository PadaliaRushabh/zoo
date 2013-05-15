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
            this.label1 = new System.Windows.Forms.Label();
            this.cage_height_input = new System.Windows.Forms.NumericUpDown();
            this.cage_width_input = new System.Windows.Forms.NumericUpDown();
            this.cage_length_input = new System.Windows.Forms.NumericUpDown();
            this.cage_longitude_input = new System.Windows.Forms.NumericUpDown();
            this.cage_latitude_input = new System.Windows.Forms.NumericUpDown();
            this.cage_door_input = new System.Windows.Forms.NumericUpDown();
            this.cage_visitors_input = new System.Windows.Forms.NumericUpDown();
            this.cage_animal_input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cage_height_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_width_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_length_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_longitude_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_latitude_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_door_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_visitors_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_animal_input)).BeginInit();
            this.SuspendLayout();
            // 
            // cage_height_label
            // 
            this.cage_height_label.AutoSize = true;
            this.cage_height_label.Location = new System.Drawing.Point(14, 43);
            this.cage_height_label.Name = "cage_height_label";
            this.cage_height_label.Size = new System.Drawing.Size(64, 13);
            this.cage_height_label.TabIndex = 3;
            this.cage_height_label.Text = "Size Height:";
            // 
            // cage_width_label
            // 
            this.cage_width_label.AutoSize = true;
            this.cage_width_label.Location = new System.Drawing.Point(14, 69);
            this.cage_width_label.Name = "cage_width_label";
            this.cage_width_label.Size = new System.Drawing.Size(61, 13);
            this.cage_width_label.TabIndex = 4;
            this.cage_width_label.Text = "Size Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Size Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Location Longitude:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Location Latitude: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Doors:";
            // 
            // add_new_cage_btn
            // 
            this.add_new_cage_btn.Location = new System.Drawing.Point(119, 261);
            this.add_new_cage_btn.Name = "add_new_cage_btn";
            this.add_new_cage_btn.Size = new System.Drawing.Size(75, 23);
            this.add_new_cage_btn.TabIndex = 16;
            this.add_new_cage_btn.Text = "Add";
            this.add_new_cage_btn.UseVisualStyleBackColor = true;
            this.add_new_cage_btn.Click += new System.EventHandler(this.add_new_cage_btn_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(200, 261);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Max Visitors:";
            // 
            // cage_height_input
            // 
            this.cage_height_input.Location = new System.Drawing.Point(123, 41);
            this.cage_height_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_height_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_height_input.Name = "cage_height_input";
            this.cage_height_input.Size = new System.Drawing.Size(221, 20);
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
            this.cage_width_input.Location = new System.Drawing.Point(123, 67);
            this.cage_width_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_width_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_width_input.Name = "cage_width_input";
            this.cage_width_input.Size = new System.Drawing.Size(221, 20);
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
            this.cage_length_input.Location = new System.Drawing.Point(123, 93);
            this.cage_length_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_length_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_length_input.Name = "cage_length_input";
            this.cage_length_input.Size = new System.Drawing.Size(221, 20);
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
            this.cage_longitude_input.Location = new System.Drawing.Point(123, 119);
            this.cage_longitude_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_longitude_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_longitude_input.Name = "cage_longitude_input";
            this.cage_longitude_input.Size = new System.Drawing.Size(221, 20);
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
            this.cage_latitude_input.Location = new System.Drawing.Point(123, 145);
            this.cage_latitude_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_latitude_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_latitude_input.Name = "cage_latitude_input";
            this.cage_latitude_input.Size = new System.Drawing.Size(221, 20);
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
            this.cage_door_input.Location = new System.Drawing.Point(123, 171);
            this.cage_door_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_door_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_door_input.Name = "cage_door_input";
            this.cage_door_input.Size = new System.Drawing.Size(221, 20);
            this.cage_door_input.TabIndex = 24;
            this.cage_door_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_door_input.ValueChanged += new System.EventHandler(this.cage_door_input_ValueChanged);
            // 
            // cage_visitors_input
            // 
            this.cage_visitors_input.Location = new System.Drawing.Point(123, 197);
            this.cage_visitors_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cage_visitors_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_visitors_input.Name = "cage_visitors_input";
            this.cage_visitors_input.Size = new System.Drawing.Size(221, 20);
            this.cage_visitors_input.TabIndex = 25;
            this.cage_visitors_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_visitors_input.ValueChanged += new System.EventHandler(this.cage_visitors_input_ValueChanged);
            // 
            // cage_animal_input
            // 
            this.cage_animal_input.Location = new System.Drawing.Point(123, 226);
            this.cage_animal_input.Margin = new System.Windows.Forms.Padding(2);
            this.cage_animal_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_animal_input.Name = "cage_animal_input";
            this.cage_animal_input.Size = new System.Drawing.Size(221, 20);
            this.cage_animal_input.TabIndex = 27;
            this.cage_animal_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cage_animal_input.ValueChanged += new System.EventHandler(this.cage_animal_input_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Max Animal:";
            // 
            // Add_Cage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.cage_animal_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cage_visitors_input);
            this.Controls.Add(this.cage_door_input);
            this.Controls.Add(this.cage_latitude_input);
            this.Controls.Add(this.cage_longitude_input);
            this.Controls.Add(this.cage_length_input);
            this.Controls.Add(this.cage_width_input);
            this.Controls.Add(this.cage_height_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_new_cage_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cage_width_label);
            this.Controls.Add(this.cage_height_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Cage_Form";
            this.Text = "Add New Cage";
            ((System.ComponentModel.ISupportInitialize)(this.cage_height_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_width_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_length_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_longitude_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_latitude_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_door_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_visitors_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage_animal_input)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cage_height_input;
        private System.Windows.Forms.NumericUpDown cage_width_input;
        private System.Windows.Forms.NumericUpDown cage_length_input;
        private System.Windows.Forms.NumericUpDown cage_longitude_input;
        private System.Windows.Forms.NumericUpDown cage_latitude_input;
        private System.Windows.Forms.NumericUpDown cage_door_input;
        private System.Windows.Forms.NumericUpDown cage_visitors_input;
        private System.Windows.Forms.NumericUpDown cage_animal_input;
        private System.Windows.Forms.Label label2;
    }
}