namespace ZooTesting
{
    partial class Main_Form
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.logout_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.cage_tab = new System.Windows.Forms.TabPage();
            this.size_length_label = new System.Windows.Forms.Label();
            this.size_width_label = new System.Windows.Forms.Label();
            this.size_height_label = new System.Windows.Forms.Label();
            this.cage_name_label = new System.Windows.Forms.Label();
            this.cage_list_label = new System.Windows.Forms.Label();
            this.cage_list_box = new System.Windows.Forms.ListBox();
            this.add_cage_btn = new System.Windows.Forms.Button();
            this.cage_delete_btn = new System.Windows.Forms.Button();
            this.cage_update_btn = new System.Windows.Forms.Button();
            this.animal_tab = new System.Windows.Forms.TabPage();
            this.location_tab = new System.Windows.Forms.TabPage();
            this.type_tab = new System.Windows.Forms.TabPage();
            this.location_latitude_label = new System.Windows.Forms.Label();
            this.location_longitude_label = new System.Windows.Forms.Label();
            this.cage_name_input = new System.Windows.Forms.TextBox();
            this.size_height_input = new System.Windows.Forms.TextBox();
            this.size_width_input = new System.Windows.Forms.TextBox();
            this.size_length_input = new System.Windows.Forms.TextBox();
            this.location_latitude_input = new System.Windows.Forms.TextBox();
            this.location_longitude_input = new System.Windows.Forms.TextBox();
            this.cage_id_label = new System.Windows.Forms.Label();
            this.cage_id_output = new System.Windows.Forms.Label();
            this.cage_door_label = new System.Windows.Forms.Label();
            this.cage_door_input = new System.Windows.Forms.TextBox();
            this.animal_id_output = new System.Windows.Forms.Label();
            this.animal_id_label = new System.Windows.Forms.Label();
            this.animal_name_input = new System.Windows.Forms.TextBox();
            this.animal_name_label = new System.Windows.Forms.Label();
            this.animal_list_label = new System.Windows.Forms.Label();
            this.animal_list_box = new System.Windows.Forms.ListBox();
            this.add_new_animal_btn = new System.Windows.Forms.Button();
            this.delete_animal_btn = new System.Windows.Forms.Button();
            this.update_animal_btn = new System.Windows.Forms.Button();
            this.animal_manager_list_box = new System.Windows.Forms.ListBox();
            this.Inventory = new System.Windows.Forms.ListBox();
            this.cage_choosen = new System.Windows.Forms.ComboBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.AM_doors_label = new System.Windows.Forms.Label();
            this.AM_cage_id_label = new System.Windows.Forms.Label();
            this.AM_location_longitude_label = new System.Windows.Forms.Label();
            this.AM_location_latitude_label = new System.Windows.Forms.Label();
            this.AM_size_length_label = new System.Windows.Forms.Label();
            this.AM_size_width_label = new System.Windows.Forms.Label();
            this.AM_size_height_label = new System.Windows.Forms.Label();
            this.AM_cage_name_label = new System.Windows.Forms.Label();
            this.AM_doors_output = new System.Windows.Forms.Label();
            this.AM_cage_id_output = new System.Windows.Forms.Label();
            this.AM_location_longitude_output = new System.Windows.Forms.Label();
            this.AM_location_latitude_output = new System.Windows.Forms.Label();
            this.AM_size_length_output = new System.Windows.Forms.Label();
            this.AM_size_width_output = new System.Windows.Forms.Label();
            this.AM_size_height_output = new System.Windows.Forms.Label();
            this.AM_cage_name_output = new System.Windows.Forms.Label();
            this.logout_panel.SuspendLayout();
            this.content_panel.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.cage_tab.SuspendLayout();
            this.animal_tab.SuspendLayout();
            this.type_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(21, 19);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(81, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "username_label";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(108, 14);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // logout_panel
            // 
            this.logout_panel.Controls.Add(this.username_label);
            this.logout_panel.Controls.Add(this.logout_btn);
            this.logout_panel.Location = new System.Drawing.Point(572, 12);
            this.logout_panel.Name = "logout_panel";
            this.logout_panel.Size = new System.Drawing.Size(200, 50);
            this.logout_panel.TabIndex = 2;
            // 
            // content_panel
            // 
            this.content_panel.Controls.Add(this.tab_control);
            this.content_panel.Location = new System.Drawing.Point(12, 68);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(760, 481);
            this.content_panel.TabIndex = 3;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.cage_tab);
            this.tab_control.Controls.Add(this.animal_tab);
            this.tab_control.Controls.Add(this.location_tab);
            this.tab_control.Controls.Add(this.type_tab);
            this.tab_control.Location = new System.Drawing.Point(0, 3);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(757, 478);
            this.tab_control.TabIndex = 0;
            // 
            // cage_tab
            // 
            this.cage_tab.Controls.Add(this.cage_door_input);
            this.cage_tab.Controls.Add(this.cage_door_label);
            this.cage_tab.Controls.Add(this.cage_id_output);
            this.cage_tab.Controls.Add(this.cage_id_label);
            this.cage_tab.Controls.Add(this.location_longitude_input);
            this.cage_tab.Controls.Add(this.location_latitude_input);
            this.cage_tab.Controls.Add(this.size_length_input);
            this.cage_tab.Controls.Add(this.size_width_input);
            this.cage_tab.Controls.Add(this.size_height_input);
            this.cage_tab.Controls.Add(this.cage_name_input);
            this.cage_tab.Controls.Add(this.location_longitude_label);
            this.cage_tab.Controls.Add(this.location_latitude_label);
            this.cage_tab.Controls.Add(this.size_length_label);
            this.cage_tab.Controls.Add(this.size_width_label);
            this.cage_tab.Controls.Add(this.size_height_label);
            this.cage_tab.Controls.Add(this.cage_name_label);
            this.cage_tab.Controls.Add(this.cage_list_label);
            this.cage_tab.Controls.Add(this.cage_list_box);
            this.cage_tab.Controls.Add(this.add_cage_btn);
            this.cage_tab.Controls.Add(this.cage_delete_btn);
            this.cage_tab.Controls.Add(this.cage_update_btn);
            this.cage_tab.Location = new System.Drawing.Point(4, 22);
            this.cage_tab.Name = "cage_tab";
            this.cage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cage_tab.Size = new System.Drawing.Size(749, 452);
            this.cage_tab.TabIndex = 0;
            this.cage_tab.Text = "Cage Detail";
            this.cage_tab.UseVisualStyleBackColor = true;
            // 
            // size_length_label
            // 
            this.size_length_label.AutoSize = true;
            this.size_length_label.Location = new System.Drawing.Point(134, 163);
            this.size_length_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.size_length_label.Name = "size_length_label";
            this.size_length_label.Size = new System.Drawing.Size(66, 13);
            this.size_length_label.TabIndex = 8;
            this.size_length_label.Text = "Size Length:";
            // 
            // size_width_label
            // 
            this.size_width_label.AutoSize = true;
            this.size_width_label.Location = new System.Drawing.Point(134, 130);
            this.size_width_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.size_width_label.Name = "size_width_label";
            this.size_width_label.Size = new System.Drawing.Size(61, 13);
            this.size_width_label.TabIndex = 7;
            this.size_width_label.Text = "Size Width:";
            // 
            // size_height_label
            // 
            this.size_height_label.AutoSize = true;
            this.size_height_label.Location = new System.Drawing.Point(134, 94);
            this.size_height_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.size_height_label.Name = "size_height_label";
            this.size_height_label.Size = new System.Drawing.Size(64, 13);
            this.size_height_label.TabIndex = 6;
            this.size_height_label.Text = "Size Height:";
            // 
            // cage_name_label
            // 
            this.cage_name_label.AutoSize = true;
            this.cage_name_label.Location = new System.Drawing.Point(134, 61);
            this.cage_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.cage_name_label.Name = "cage_name_label";
            this.cage_name_label.Size = new System.Drawing.Size(69, 13);
            this.cage_name_label.TabIndex = 5;
            this.cage_name_label.Text = "Cage  Name:";
            // 
            // cage_list_label
            // 
            this.cage_list_label.AutoSize = true;
            this.cage_list_label.Location = new System.Drawing.Point(32, 14);
            this.cage_list_label.Name = "cage_list_label";
            this.cage_list_label.Size = new System.Drawing.Size(54, 13);
            this.cage_list_label.TabIndex = 4;
            this.cage_list_label.Text = "Cage List:";
            // 
            // cage_list_box
            // 
            this.cage_list_box.FormattingEnabled = true;
            this.cage_list_box.Location = new System.Drawing.Point(6, 30);
            this.cage_list_box.Name = "cage_list_box";
            this.cage_list_box.Size = new System.Drawing.Size(116, 251);
            this.cage_list_box.TabIndex = 3;
            this.cage_list_box.SelectedIndexChanged += new System.EventHandler(this.cage_list_box_SelectedIndexChanged);
            // 
            // add_cage_btn
            // 
            this.add_cage_btn.Location = new System.Drawing.Point(6, 287);
            this.add_cage_btn.Name = "add_cage_btn";
            this.add_cage_btn.Size = new System.Drawing.Size(107, 23);
            this.add_cage_btn.TabIndex = 0;
            this.add_cage_btn.Text = "Add New Cage";
            this.add_cage_btn.UseVisualStyleBackColor = true;
            this.add_cage_btn.Click += new System.EventHandler(this.add_cage_btn_Click);
            // 
            // cage_delete_btn
            // 
            this.cage_delete_btn.Location = new System.Drawing.Point(218, 287);
            this.cage_delete_btn.Name = "cage_delete_btn";
            this.cage_delete_btn.Size = new System.Drawing.Size(90, 23);
            this.cage_delete_btn.TabIndex = 2;
            this.cage_delete_btn.Text = "Delete";
            this.cage_delete_btn.UseVisualStyleBackColor = true;
            this.cage_delete_btn.Click += new System.EventHandler(this.cage_delete_btn_Click);
            // 
            // cage_update_btn
            // 
            this.cage_update_btn.Location = new System.Drawing.Point(119, 287);
            this.cage_update_btn.Name = "cage_update_btn";
            this.cage_update_btn.Size = new System.Drawing.Size(93, 23);
            this.cage_update_btn.TabIndex = 1;
            this.cage_update_btn.Text = "Update";
            this.cage_update_btn.UseVisualStyleBackColor = true;
            this.cage_update_btn.Click += new System.EventHandler(this.cage_update_btn_Click);
            // 
            // animal_tab
            // 
            this.animal_tab.Controls.Add(this.animal_id_output);
            this.animal_tab.Controls.Add(this.animal_id_label);
            this.animal_tab.Controls.Add(this.animal_name_input);
            this.animal_tab.Controls.Add(this.animal_name_label);
            this.animal_tab.Controls.Add(this.animal_list_label);
            this.animal_tab.Controls.Add(this.animal_list_box);
            this.animal_tab.Controls.Add(this.add_new_animal_btn);
            this.animal_tab.Controls.Add(this.delete_animal_btn);
            this.animal_tab.Controls.Add(this.update_animal_btn);
            this.animal_tab.Location = new System.Drawing.Point(4, 22);
            this.animal_tab.Name = "animal_tab";
            this.animal_tab.Padding = new System.Windows.Forms.Padding(3);
            this.animal_tab.Size = new System.Drawing.Size(749, 452);
            this.animal_tab.TabIndex = 1;
            this.animal_tab.Text = "Animal Detail";
            this.animal_tab.UseVisualStyleBackColor = true;
            // 
            // location_tab
            // 
            this.location_tab.Location = new System.Drawing.Point(4, 22);
            this.location_tab.Name = "location_tab";
            this.location_tab.Padding = new System.Windows.Forms.Padding(3);
            this.location_tab.Size = new System.Drawing.Size(749, 452);
            this.location_tab.TabIndex = 2;
            this.location_tab.Text = "Location";
            this.location_tab.UseVisualStyleBackColor = true;
            // 
            // type_tab
            // 
            this.type_tab.Controls.Add(this.AM_doors_output);
            this.type_tab.Controls.Add(this.AM_cage_id_output);
            this.type_tab.Controls.Add(this.AM_location_longitude_output);
            this.type_tab.Controls.Add(this.AM_location_latitude_output);
            this.type_tab.Controls.Add(this.AM_size_length_output);
            this.type_tab.Controls.Add(this.AM_size_width_output);
            this.type_tab.Controls.Add(this.AM_size_height_output);
            this.type_tab.Controls.Add(this.AM_cage_name_output);
            this.type_tab.Controls.Add(this.AM_doors_label);
            this.type_tab.Controls.Add(this.AM_cage_id_label);
            this.type_tab.Controls.Add(this.AM_location_longitude_label);
            this.type_tab.Controls.Add(this.AM_location_latitude_label);
            this.type_tab.Controls.Add(this.AM_size_length_label);
            this.type_tab.Controls.Add(this.AM_size_width_label);
            this.type_tab.Controls.Add(this.AM_size_height_label);
            this.type_tab.Controls.Add(this.AM_cage_name_label);
            this.type_tab.Controls.Add(this.insert_btn);
            this.type_tab.Controls.Add(this.cage_choosen);
            this.type_tab.Controls.Add(this.Inventory);
            this.type_tab.Controls.Add(this.animal_manager_list_box);
            this.type_tab.Location = new System.Drawing.Point(4, 22);
            this.type_tab.Name = "type_tab";
            this.type_tab.Padding = new System.Windows.Forms.Padding(3);
            this.type_tab.Size = new System.Drawing.Size(749, 452);
            this.type_tab.TabIndex = 3;
            this.type_tab.Text = "Animal Manager";
            this.type_tab.UseVisualStyleBackColor = true;
            // 
            // location_latitude_label
            // 
            this.location_latitude_label.AutoSize = true;
            this.location_latitude_label.Location = new System.Drawing.Point(134, 193);
            this.location_latitude_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.location_latitude_label.Name = "location_latitude_label";
            this.location_latitude_label.Size = new System.Drawing.Size(92, 13);
            this.location_latitude_label.TabIndex = 9;
            this.location_latitude_label.Text = "Location Latitude:";
            // 
            // location_longitude_label
            // 
            this.location_longitude_label.AutoSize = true;
            this.location_longitude_label.Location = new System.Drawing.Point(133, 226);
            this.location_longitude_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.location_longitude_label.Name = "location_longitude_label";
            this.location_longitude_label.Size = new System.Drawing.Size(101, 13);
            this.location_longitude_label.TabIndex = 10;
            this.location_longitude_label.Text = "Location Longitude:";
            // 
            // cage_name_input
            // 
            this.cage_name_input.Location = new System.Drawing.Point(255, 61);
            this.cage_name_input.Name = "cage_name_input";
            this.cage_name_input.Size = new System.Drawing.Size(145, 20);
            this.cage_name_input.TabIndex = 11;
            // 
            // size_height_input
            // 
            this.size_height_input.Location = new System.Drawing.Point(255, 94);
            this.size_height_input.Name = "size_height_input";
            this.size_height_input.Size = new System.Drawing.Size(145, 20);
            this.size_height_input.TabIndex = 12;
            // 
            // size_width_input
            // 
            this.size_width_input.Location = new System.Drawing.Point(255, 127);
            this.size_width_input.Name = "size_width_input";
            this.size_width_input.Size = new System.Drawing.Size(145, 20);
            this.size_width_input.TabIndex = 13;
            // 
            // size_length_input
            // 
            this.size_length_input.Location = new System.Drawing.Point(255, 160);
            this.size_length_input.Name = "size_length_input";
            this.size_length_input.Size = new System.Drawing.Size(145, 20);
            this.size_length_input.TabIndex = 14;
            // 
            // location_latitude_input
            // 
            this.location_latitude_input.Location = new System.Drawing.Point(255, 193);
            this.location_latitude_input.Name = "location_latitude_input";
            this.location_latitude_input.Size = new System.Drawing.Size(145, 20);
            this.location_latitude_input.TabIndex = 15;
            // 
            // location_longitude_input
            // 
            this.location_longitude_input.Location = new System.Drawing.Point(255, 226);
            this.location_longitude_input.Name = "location_longitude_input";
            this.location_longitude_input.Size = new System.Drawing.Size(145, 20);
            this.location_longitude_input.TabIndex = 16;
            // 
            // cage_id_label
            // 
            this.cage_id_label.AutoSize = true;
            this.cage_id_label.Location = new System.Drawing.Point(134, 30);
            this.cage_id_label.Name = "cage_id_label";
            this.cage_id_label.Size = new System.Drawing.Size(49, 13);
            this.cage_id_label.TabIndex = 17;
            this.cage_id_label.Text = "Cage ID:";
            // 
            // cage_id_output
            // 
            this.cage_id_output.AutoSize = true;
            this.cage_id_output.Location = new System.Drawing.Point(255, 29);
            this.cage_id_output.Name = "cage_id_output";
            this.cage_id_output.Size = new System.Drawing.Size(23, 13);
            this.cage_id_output.TabIndex = 18;
            this.cage_id_output.Text = "null";
            // 
            // cage_door_label
            // 
            this.cage_door_label.AutoSize = true;
            this.cage_door_label.Location = new System.Drawing.Point(134, 259);
            this.cage_door_label.Name = "cage_door_label";
            this.cage_door_label.Size = new System.Drawing.Size(38, 13);
            this.cage_door_label.TabIndex = 19;
            this.cage_door_label.Text = "Doors:";
            // 
            // cage_door_input
            // 
            this.cage_door_input.Location = new System.Drawing.Point(255, 256);
            this.cage_door_input.Name = "cage_door_input";
            this.cage_door_input.Size = new System.Drawing.Size(145, 20);
            this.cage_door_input.TabIndex = 20;
            // 
            // animal_id_output
            // 
            this.animal_id_output.AutoSize = true;
            this.animal_id_output.Location = new System.Drawing.Point(255, 21);
            this.animal_id_output.Name = "animal_id_output";
            this.animal_id_output.Size = new System.Drawing.Size(23, 13);
            this.animal_id_output.TabIndex = 39;
            this.animal_id_output.Text = "null";
            // 
            // animal_id_label
            // 
            this.animal_id_label.AutoSize = true;
            this.animal_id_label.Location = new System.Drawing.Point(134, 22);
            this.animal_id_label.Name = "animal_id_label";
            this.animal_id_label.Size = new System.Drawing.Size(58, 13);
            this.animal_id_label.TabIndex = 38;
            this.animal_id_label.Text = "Animal ID: ";
            // 
            // animal_name_input
            // 
            this.animal_name_input.Location = new System.Drawing.Point(255, 53);
            this.animal_name_input.Name = "animal_name_input";
            this.animal_name_input.Size = new System.Drawing.Size(145, 20);
            this.animal_name_input.TabIndex = 32;
            // 
            // animal_name_label
            // 
            this.animal_name_label.AutoSize = true;
            this.animal_name_label.Location = new System.Drawing.Point(134, 53);
            this.animal_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.animal_name_label.Name = "animal_name_label";
            this.animal_name_label.Size = new System.Drawing.Size(72, 13);
            this.animal_name_label.TabIndex = 26;
            this.animal_name_label.Text = "Animal Name:";
            // 
            // animal_list_label
            // 
            this.animal_list_label.AutoSize = true;
            this.animal_list_label.Location = new System.Drawing.Point(32, 6);
            this.animal_list_label.Name = "animal_list_label";
            this.animal_list_label.Size = new System.Drawing.Size(60, 13);
            this.animal_list_label.TabIndex = 25;
            this.animal_list_label.Text = "Animal List:";
            // 
            // animal_list_box
            // 
            this.animal_list_box.FormattingEnabled = true;
            this.animal_list_box.Location = new System.Drawing.Point(6, 22);
            this.animal_list_box.Name = "animal_list_box";
            this.animal_list_box.Size = new System.Drawing.Size(116, 238);
            this.animal_list_box.TabIndex = 24;
            this.animal_list_box.SelectedIndexChanged += new System.EventHandler(this.animal_list_box_SelectedIndexChanged);
            // 
            // add_new_animal_btn
            // 
            this.add_new_animal_btn.Location = new System.Drawing.Point(6, 279);
            this.add_new_animal_btn.Name = "add_new_animal_btn";
            this.add_new_animal_btn.Size = new System.Drawing.Size(107, 23);
            this.add_new_animal_btn.TabIndex = 21;
            this.add_new_animal_btn.Text = "Add New Animal";
            this.add_new_animal_btn.UseVisualStyleBackColor = true;
            this.add_new_animal_btn.Click += new System.EventHandler(this.add_new_animal_btn_Click);
            // 
            // delete_animal_btn
            // 
            this.delete_animal_btn.Location = new System.Drawing.Point(218, 279);
            this.delete_animal_btn.Name = "delete_animal_btn";
            this.delete_animal_btn.Size = new System.Drawing.Size(90, 23);
            this.delete_animal_btn.TabIndex = 23;
            this.delete_animal_btn.Text = "Delete";
            this.delete_animal_btn.UseVisualStyleBackColor = true;
            this.delete_animal_btn.Click += new System.EventHandler(this.delete_animal_btn_Click);
            // 
            // update_animal_btn
            // 
            this.update_animal_btn.Location = new System.Drawing.Point(119, 279);
            this.update_animal_btn.Name = "update_animal_btn";
            this.update_animal_btn.Size = new System.Drawing.Size(93, 23);
            this.update_animal_btn.TabIndex = 22;
            this.update_animal_btn.Text = "Update";
            this.update_animal_btn.UseVisualStyleBackColor = true;
            this.update_animal_btn.Click += new System.EventHandler(this.update_animal_btn_Click);
            // 
            // animal_manager_list_box
            // 
            this.animal_manager_list_box.FormattingEnabled = true;
            this.animal_manager_list_box.Location = new System.Drawing.Point(23, 60);
            this.animal_manager_list_box.Name = "animal_manager_list_box";
            this.animal_manager_list_box.Size = new System.Drawing.Size(120, 225);
            this.animal_manager_list_box.TabIndex = 4;
            
            // 
            // Inventory
            // 
            this.Inventory.FormattingEnabled = true;
            this.Inventory.Location = new System.Drawing.Point(288, 60);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(120, 225);
            this.Inventory.TabIndex = 5;
            // 
            // cage_choosen
            // 
            this.cage_choosen.FormattingEnabled = true;
            this.cage_choosen.Location = new System.Drawing.Point(153, 20);
            this.cage_choosen.Name = "cage_choosen";
            this.cage_choosen.Size = new System.Drawing.Size(121, 21);
            this.cage_choosen.TabIndex = 6;
            this.cage_choosen.SelectedIndexChanged += new System.EventHandler(this.cage_choosen_SelectedIndexChanged);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(177, 126);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 7;
            this.insert_btn.Text = "button1";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // AM_doors_label
            // 
            this.AM_doors_label.AutoSize = true;
            this.AM_doors_label.Location = new System.Drawing.Point(442, 283);
            this.AM_doors_label.Name = "AM_doors_label";
            this.AM_doors_label.Size = new System.Drawing.Size(38, 13);
            this.AM_doors_label.TabIndex = 27;
            this.AM_doors_label.Text = "Doors:";
            // 
            // AM_cage_id_label
            // 
            this.AM_cage_id_label.AutoSize = true;
            this.AM_cage_id_label.Location = new System.Drawing.Point(442, 54);
            this.AM_cage_id_label.Name = "AM_cage_id_label";
            this.AM_cage_id_label.Size = new System.Drawing.Size(49, 13);
            this.AM_cage_id_label.TabIndex = 26;
            this.AM_cage_id_label.Text = "Cage ID:";
            // 
            // AM_location_longitude_label
            // 
            this.AM_location_longitude_label.AutoSize = true;
            this.AM_location_longitude_label.Location = new System.Drawing.Point(441, 250);
            this.AM_location_longitude_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_location_longitude_label.Name = "AM_location_longitude_label";
            this.AM_location_longitude_label.Size = new System.Drawing.Size(101, 13);
            this.AM_location_longitude_label.TabIndex = 25;
            this.AM_location_longitude_label.Text = "Location Longitude:";
            // 
            // AM_location_latitude_label
            // 
            this.AM_location_latitude_label.AutoSize = true;
            this.AM_location_latitude_label.Location = new System.Drawing.Point(442, 217);
            this.AM_location_latitude_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_location_latitude_label.Name = "AM_location_latitude_label";
            this.AM_location_latitude_label.Size = new System.Drawing.Size(92, 13);
            this.AM_location_latitude_label.TabIndex = 24;
            this.AM_location_latitude_label.Text = "Location Latitude:";
            // 
            // AM_size_length_label
            // 
            this.AM_size_length_label.AutoSize = true;
            this.AM_size_length_label.Location = new System.Drawing.Point(442, 187);
            this.AM_size_length_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_length_label.Name = "AM_size_length_label";
            this.AM_size_length_label.Size = new System.Drawing.Size(66, 13);
            this.AM_size_length_label.TabIndex = 23;
            this.AM_size_length_label.Text = "Size Length:";
            // 
            // AM_size_width_label
            // 
            this.AM_size_width_label.AutoSize = true;
            this.AM_size_width_label.Location = new System.Drawing.Point(442, 154);
            this.AM_size_width_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_width_label.Name = "AM_size_width_label";
            this.AM_size_width_label.Size = new System.Drawing.Size(61, 13);
            this.AM_size_width_label.TabIndex = 22;
            this.AM_size_width_label.Text = "Size Width:";
            // 
            // AM_size_height_label
            // 
            this.AM_size_height_label.AutoSize = true;
            this.AM_size_height_label.Location = new System.Drawing.Point(442, 118);
            this.AM_size_height_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_height_label.Name = "AM_size_height_label";
            this.AM_size_height_label.Size = new System.Drawing.Size(64, 13);
            this.AM_size_height_label.TabIndex = 21;
            this.AM_size_height_label.Text = "Size Height:";
            // 
            // AM_cage_name_label
            // 
            this.AM_cage_name_label.AutoSize = true;
            this.AM_cage_name_label.Location = new System.Drawing.Point(442, 85);
            this.AM_cage_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_cage_name_label.Name = "AM_cage_name_label";
            this.AM_cage_name_label.Size = new System.Drawing.Size(69, 13);
            this.AM_cage_name_label.TabIndex = 20;
            this.AM_cage_name_label.Text = "Cage  Name:";
            // 
            // AM_doors_output
            // 
            this.AM_doors_output.AutoSize = true;
            this.AM_doors_output.Location = new System.Drawing.Point(577, 283);
            this.AM_doors_output.Name = "AM_doors_output";
            this.AM_doors_output.Size = new System.Drawing.Size(23, 13);
            this.AM_doors_output.TabIndex = 35;
            this.AM_doors_output.Text = "null";
            // 
            // AM_cage_id_output
            // 
            this.AM_cage_id_output.AutoSize = true;
            this.AM_cage_id_output.Location = new System.Drawing.Point(577, 54);
            this.AM_cage_id_output.Name = "AM_cage_id_output";
            this.AM_cage_id_output.Size = new System.Drawing.Size(23, 13);
            this.AM_cage_id_output.TabIndex = 34;
            this.AM_cage_id_output.Text = "null";
            // 
            // AM_location_longitude_output
            // 
            this.AM_location_longitude_output.AutoSize = true;
            this.AM_location_longitude_output.Location = new System.Drawing.Point(576, 250);
            this.AM_location_longitude_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_location_longitude_output.Name = "AM_location_longitude_output";
            this.AM_location_longitude_output.Size = new System.Drawing.Size(23, 13);
            this.AM_location_longitude_output.TabIndex = 33;
            this.AM_location_longitude_output.Text = "null";
            // 
            // AM_location_latitude_output
            // 
            this.AM_location_latitude_output.AutoSize = true;
            this.AM_location_latitude_output.Location = new System.Drawing.Point(577, 217);
            this.AM_location_latitude_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_location_latitude_output.Name = "AM_location_latitude_output";
            this.AM_location_latitude_output.Size = new System.Drawing.Size(23, 13);
            this.AM_location_latitude_output.TabIndex = 32;
            this.AM_location_latitude_output.Text = "null";
            // 
            // AM_size_length_output
            // 
            this.AM_size_length_output.AutoSize = true;
            this.AM_size_length_output.Location = new System.Drawing.Point(577, 187);
            this.AM_size_length_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_length_output.Name = "AM_size_length_output";
            this.AM_size_length_output.Size = new System.Drawing.Size(23, 13);
            this.AM_size_length_output.TabIndex = 31;
            this.AM_size_length_output.Text = "null";
            // 
            // AM_size_width_output
            // 
            this.AM_size_width_output.AutoSize = true;
            this.AM_size_width_output.Location = new System.Drawing.Point(577, 154);
            this.AM_size_width_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_width_output.Name = "AM_size_width_output";
            this.AM_size_width_output.Size = new System.Drawing.Size(23, 13);
            this.AM_size_width_output.TabIndex = 30;
            this.AM_size_width_output.Text = "null";
            // 
            // AM_size_height_output
            // 
            this.AM_size_height_output.AutoSize = true;
            this.AM_size_height_output.Location = new System.Drawing.Point(577, 118);
            this.AM_size_height_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_size_height_output.Name = "AM_size_height_output";
            this.AM_size_height_output.Size = new System.Drawing.Size(23, 13);
            this.AM_size_height_output.TabIndex = 29;
            this.AM_size_height_output.Text = "null";
            // 
            // AM_cage_name_output
            // 
            this.AM_cage_name_output.AutoSize = true;
            this.AM_cage_name_output.Location = new System.Drawing.Point(577, 85);
            this.AM_cage_name_output.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.AM_cage_name_output.Name = "AM_cage_name_output";
            this.AM_cage_name_output.Size = new System.Drawing.Size(23, 13);
            this.AM_cage_name_output.TabIndex = 28;
            this.AM_cage_name_output.Text = "null";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.logout_panel);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.logout_panel.ResumeLayout(false);
            this.logout_panel.PerformLayout();
            this.content_panel.ResumeLayout(false);
            this.tab_control.ResumeLayout(false);
            this.cage_tab.ResumeLayout(false);
            this.cage_tab.PerformLayout();
            this.animal_tab.ResumeLayout(false);
            this.animal_tab.PerformLayout();
            this.type_tab.ResumeLayout(false);
            this.type_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage cage_tab;
        private System.Windows.Forms.TabPage animal_tab;
        private System.Windows.Forms.TabPage location_tab;
        private System.Windows.Forms.TabPage type_tab;
        private System.Windows.Forms.Button add_cage_btn;
        private System.Windows.Forms.Button cage_delete_btn;
        private System.Windows.Forms.Button cage_update_btn;
        private System.Windows.Forms.Label cage_list_label;
        private System.Windows.Forms.ListBox cage_list_box;
        private System.Windows.Forms.Label cage_name_label;
        private System.Windows.Forms.Label size_height_label;
        private System.Windows.Forms.Label size_length_label;
        private System.Windows.Forms.Label size_width_label;
        private System.Windows.Forms.TextBox location_longitude_input;
        private System.Windows.Forms.TextBox location_latitude_input;
        private System.Windows.Forms.TextBox size_length_input;
        private System.Windows.Forms.TextBox size_width_input;
        private System.Windows.Forms.TextBox size_height_input;
        private System.Windows.Forms.TextBox cage_name_input;
        private System.Windows.Forms.Label location_longitude_label;
        private System.Windows.Forms.Label location_latitude_label;
        private System.Windows.Forms.Label cage_id_output;
        private System.Windows.Forms.Label cage_id_label;
        private System.Windows.Forms.TextBox cage_door_input;
        private System.Windows.Forms.Label cage_door_label;
        private System.Windows.Forms.Label animal_id_output;
        private System.Windows.Forms.Label animal_id_label;
        private System.Windows.Forms.TextBox animal_name_input;
        private System.Windows.Forms.Label animal_name_label;
        private System.Windows.Forms.Label animal_list_label;
        private System.Windows.Forms.ListBox animal_list_box;
        private System.Windows.Forms.Button add_new_animal_btn;
        private System.Windows.Forms.Button delete_animal_btn;
        private System.Windows.Forms.Button update_animal_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.ComboBox cage_choosen;
        private System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.ListBox animal_manager_list_box;
        private System.Windows.Forms.Label AM_doors_output;
        private System.Windows.Forms.Label AM_cage_id_output;
        private System.Windows.Forms.Label AM_location_longitude_output;
        private System.Windows.Forms.Label AM_location_latitude_output;
        private System.Windows.Forms.Label AM_size_length_output;
        private System.Windows.Forms.Label AM_size_width_output;
        private System.Windows.Forms.Label AM_size_height_output;
        private System.Windows.Forms.Label AM_cage_name_output;
        private System.Windows.Forms.Label AM_doors_label;
        private System.Windows.Forms.Label AM_cage_id_label;
        private System.Windows.Forms.Label AM_location_longitude_label;
        private System.Windows.Forms.Label AM_location_latitude_label;
        private System.Windows.Forms.Label AM_size_length_label;
        private System.Windows.Forms.Label AM_size_width_label;
        private System.Windows.Forms.Label AM_size_height_label;
        private System.Windows.Forms.Label AM_cage_name_label;
    }
}