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
            this.add_cage_btn = new System.Windows.Forms.Button();
            this.cage_delete_btn = new System.Windows.Forms.Button();
            this.cage_update_btn = new System.Windows.Forms.Button();
            this.cage_gridview = new System.Windows.Forms.DataGridView();
            this.animal_tab = new System.Windows.Forms.TabPage();
            this.location_tab = new System.Windows.Forms.TabPage();
            this.type_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_type_btn = new System.Windows.Forms.Button();
            this.update_type_btn = new System.Windows.Forms.Button();
            this.delete_type_btn = new System.Windows.Forms.Button();
            this.logout_panel.SuspendLayout();
            this.content_panel.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.cage_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cage_gridview)).BeginInit();
            this.type_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cage_tab.Controls.Add(this.add_cage_btn);
            this.cage_tab.Controls.Add(this.cage_delete_btn);
            this.cage_tab.Controls.Add(this.cage_update_btn);
            this.cage_tab.Controls.Add(this.cage_gridview);
            this.cage_tab.Location = new System.Drawing.Point(4, 22);
            this.cage_tab.Name = "cage_tab";
            this.cage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cage_tab.Size = new System.Drawing.Size(749, 452);
            this.cage_tab.TabIndex = 0;
            this.cage_tab.Text = "Cage";
            this.cage_tab.UseVisualStyleBackColor = true;
            // 
            // add_cage_btn
            // 
            this.add_cage_btn.Location = new System.Drawing.Point(6, 406);
            this.add_cage_btn.Name = "add_cage_btn";
            this.add_cage_btn.Size = new System.Drawing.Size(107, 23);
            this.add_cage_btn.TabIndex = 0;
            this.add_cage_btn.Text = "Add New Cage";
            this.add_cage_btn.UseVisualStyleBackColor = true;
            // 
            // cage_delete_btn
            // 
            this.cage_delete_btn.Location = new System.Drawing.Point(218, 406);
            this.cage_delete_btn.Name = "cage_delete_btn";
            this.cage_delete_btn.Size = new System.Drawing.Size(90, 23);
            this.cage_delete_btn.TabIndex = 2;
            this.cage_delete_btn.Text = "Delete";
            this.cage_delete_btn.UseVisualStyleBackColor = true;
            // 
            // cage_update_btn
            // 
            this.cage_update_btn.Location = new System.Drawing.Point(119, 406);
            this.cage_update_btn.Name = "cage_update_btn";
            this.cage_update_btn.Size = new System.Drawing.Size(93, 23);
            this.cage_update_btn.TabIndex = 1;
            this.cage_update_btn.Text = "Update";
            this.cage_update_btn.UseVisualStyleBackColor = true;
            // 
            // cage_gridview
            // 
            this.cage_gridview.AllowUserToOrderColumns = true;
            this.cage_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cage_gridview.Location = new System.Drawing.Point(6, 6);
            this.cage_gridview.Name = "cage_gridview";
            this.cage_gridview.Size = new System.Drawing.Size(733, 380);
            this.cage_gridview.TabIndex = 0;
            // 
            // animal_tab
            // 
            this.animal_tab.Location = new System.Drawing.Point(4, 22);
            this.animal_tab.Name = "animal_tab";
            this.animal_tab.Padding = new System.Windows.Forms.Padding(3);
            this.animal_tab.Size = new System.Drawing.Size(749, 452);
            this.animal_tab.TabIndex = 1;
            this.animal_tab.Text = "Animal";
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
            this.type_tab.Controls.Add(this.delete_type_btn);
            this.type_tab.Controls.Add(this.update_type_btn);
            this.type_tab.Controls.Add(this.add_type_btn);
            this.type_tab.Controls.Add(this.dataGridView1);
            this.type_tab.Location = new System.Drawing.Point(4, 22);
            this.type_tab.Name = "type_tab";
            this.type_tab.Padding = new System.Windows.Forms.Padding(3);
            this.type_tab.Size = new System.Drawing.Size(749, 452);
            this.type_tab.TabIndex = 3;
            this.type_tab.Text = "Type";
            this.type_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_type_btn
            // 
            this.add_type_btn.Location = new System.Drawing.Point(7, 423);
            this.add_type_btn.Name = "add_type_btn";
            this.add_type_btn.Size = new System.Drawing.Size(105, 23);
            this.add_type_btn.TabIndex = 1;
            this.add_type_btn.Text = "Add New Type";
            this.add_type_btn.UseVisualStyleBackColor = true;
            this.add_type_btn.Click += new System.EventHandler(this.add_type_btn_Click);
            // 
            // update_type_btn
            // 
            this.update_type_btn.Location = new System.Drawing.Point(118, 423);
            this.update_type_btn.Name = "update_type_btn";
            this.update_type_btn.Size = new System.Drawing.Size(75, 23);
            this.update_type_btn.TabIndex = 2;
            this.update_type_btn.Text = "Update";
            this.update_type_btn.UseVisualStyleBackColor = true;
            // 
            // delete_type_btn
            // 
            this.delete_type_btn.Location = new System.Drawing.Point(199, 423);
            this.delete_type_btn.Name = "delete_type_btn";
            this.delete_type_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_type_btn.TabIndex = 3;
            this.delete_type_btn.Text = "Delete";
            this.delete_type_btn.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.cage_gridview)).EndInit();
            this.type_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView cage_gridview;
        private System.Windows.Forms.Button cage_delete_btn;
        private System.Windows.Forms.Button cage_update_btn;
        private System.Windows.Forms.Button delete_type_btn;
        private System.Windows.Forms.Button update_type_btn;
        private System.Windows.Forms.Button add_type_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}