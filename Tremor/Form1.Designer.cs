namespace Tremor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lv_maps = new System.Windows.Forms.ListView();
            this.b_teleport = new System.Windows.Forms.Button();
            this.tb_mapsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_grave = new System.Windows.Forms.Button();
            this.b_addcurrent = new System.Windows.Forms.Button();
            this.tb_telename = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_z = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.OnTop = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_manual_z = new System.Windows.Forms.TextBox();
            this.tb_manual_y = new System.Windows.Forms.TextBox();
            this.tb_manual_x = new System.Windows.Forms.TextBox();
            this.b_manual = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lv_copper = new System.Windows.Forms.ListView();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.b_delete = new System.Windows.Forms.Button();
            this.lv_player = new System.Windows.Forms.ListView();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_maps
            // 
            this.lv_maps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_maps.FullRowSelect = true;
            this.lv_maps.Location = new System.Drawing.Point(3, 3);
            this.lv_maps.MultiSelect = false;
            this.lv_maps.Name = "lv_maps";
            this.lv_maps.Size = new System.Drawing.Size(334, 174);
            this.lv_maps.TabIndex = 0;
            this.lv_maps.UseCompatibleStateImageBehavior = false;
            this.lv_maps.View = System.Windows.Forms.View.Details;
            this.lv_maps.SelectedIndexChanged += new System.EventHandler(this.lv_maps_SelectedIndexChanged);
            // 
            // b_teleport
            // 
            this.b_teleport.Location = new System.Drawing.Point(8, 34);
            this.b_teleport.Name = "b_teleport";
            this.b_teleport.Size = new System.Drawing.Size(348, 30);
            this.b_teleport.TabIndex = 1;
            this.b_teleport.Text = "Teleport";
            this.b_teleport.UseVisualStyleBackColor = true;
            this.b_teleport.Click += new System.EventHandler(this.b_teleport_Click);
            // 
            // tb_mapsearch
            // 
            this.tb_mapsearch.Location = new System.Drawing.Point(8, 6);
            this.tb_mapsearch.Name = "tb_mapsearch";
            this.tb_mapsearch.Size = new System.Drawing.Size(348, 22);
            this.tb_mapsearch.TabIndex = 2;
            this.tb_mapsearch.TextChanged += new System.EventHandler(this.tb_mapsearch_TextChanged);
            this.tb_mapsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_mapsearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_grave);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands:";
            // 
            // b_grave
            // 
            this.b_grave.Location = new System.Drawing.Point(6, 19);
            this.b_grave.Name = "b_grave";
            this.b_grave.Size = new System.Drawing.Size(155, 23);
            this.b_grave.TabIndex = 0;
            this.b_grave.Text = "Teleport Corpse";
            this.b_grave.UseVisualStyleBackColor = true;
            this.b_grave.Click += new System.EventHandler(this.b_grave_Click);
            // 
            // b_addcurrent
            // 
            this.b_addcurrent.Location = new System.Drawing.Point(6, 49);
            this.b_addcurrent.Name = "b_addcurrent";
            this.b_addcurrent.Size = new System.Drawing.Size(155, 21);
            this.b_addcurrent.TabIndex = 1;
            this.b_addcurrent.Text = "Add Current Location";
            this.b_addcurrent.UseVisualStyleBackColor = true;
            this.b_addcurrent.Click += new System.EventHandler(this.b_addcurrent_Click);
            // 
            // tb_telename
            // 
            this.tb_telename.Location = new System.Drawing.Point(48, 21);
            this.tb_telename.Name = "tb_telename";
            this.tb_telename.Size = new System.Drawing.Size(113, 22);
            this.tb_telename.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.tb_z);
            this.groupBox2.Controls.Add(this.tb_y);
            this.groupBox2.Controls.Add(this.tb_x);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_telename);
            this.groupBox2.Controls.Add(this.b_addcurrent);
            this.groupBox2.Location = new System.Drawing.Point(187, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save Position:";
            // 
            // tb_z
            // 
            this.tb_z.AutoSize = true;
            this.tb_z.Location = new System.Drawing.Point(51, 135);
            this.tb_z.Name = "tb_z";
            this.tb_z.Size = new System.Drawing.Size(13, 13);
            this.tb_z.TabIndex = 8;
            this.tb_z.Text = "0";
            // 
            // tb_y
            // 
            this.tb_y.AutoSize = true;
            this.tb_y.Location = new System.Drawing.Point(51, 122);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(13, 13);
            this.tb_y.TabIndex = 7;
            this.tb_y.Text = "0";
            // 
            // tb_x
            // 
            this.tb_x.AutoSize = true;
            this.tb_x.Location = new System.Drawing.Point(51, 109);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(13, 13);
            this.tb_x.TabIndex = 6;
            this.tb_x.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // OnTop
            // 
            this.OnTop.Enabled = true;
            this.OnTop.Tick += new System.EventHandler(this.OnTop_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 482);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.tb_mapsearch);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.b_teleport);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_manual_z);
            this.tabPage2.Controls.Add(this.tb_manual_y);
            this.tabPage2.Controls.Add(this.tb_manual_x);
            this.tabPage2.Controls.Add(this.b_manual);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X:";
            // 
            // tb_manual_z
            // 
            this.tb_manual_z.Location = new System.Drawing.Point(76, 79);
            this.tb_manual_z.Name = "tb_manual_z";
            this.tb_manual_z.Size = new System.Drawing.Size(144, 22);
            this.tb_manual_z.TabIndex = 3;
            // 
            // tb_manual_y
            // 
            this.tb_manual_y.Location = new System.Drawing.Point(76, 51);
            this.tb_manual_y.Name = "tb_manual_y";
            this.tb_manual_y.Size = new System.Drawing.Size(144, 22);
            this.tb_manual_y.TabIndex = 2;
            // 
            // tb_manual_x
            // 
            this.tb_manual_x.Location = new System.Drawing.Point(76, 22);
            this.tb_manual_x.Name = "tb_manual_x";
            this.tb_manual_x.Size = new System.Drawing.Size(144, 22);
            this.tb_manual_x.TabIndex = 1;
            // 
            // b_manual
            // 
            this.b_manual.Location = new System.Drawing.Point(109, 118);
            this.b_manual.Name = "b_manual";
            this.b_manual.Size = new System.Drawing.Size(75, 23);
            this.b_manual.TabIndex = 0;
            this.b_manual.Text = "Teleport";
            this.b_manual.UseVisualStyleBackColor = true;
            this.b_manual.Click += new System.EventHandler(this.b_manual_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab1);
            this.tabControl2.Controls.Add(this.tab2);
            this.tabControl2.Controls.Add(this.tab3);
            this.tabControl2.Controls.Add(this.tab4);
            this.tabControl2.Location = new System.Drawing.Point(8, 70);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(348, 206);
            this.tabControl2.TabIndex = 7;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.lv_maps);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(340, 180);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Horde - Safe";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lv_copper);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(340, 180);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Copper";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lv_copper
            // 
            this.lv_copper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_copper.FullRowSelect = true;
            this.lv_copper.Location = new System.Drawing.Point(3, 3);
            this.lv_copper.MultiSelect = false;
            this.lv_copper.Name = "lv_copper";
            this.lv_copper.Size = new System.Drawing.Size(334, 174);
            this.lv_copper.TabIndex = 0;
            this.lv_copper.UseCompatibleStateImageBehavior = false;
            this.lv_copper.View = System.Windows.Forms.View.Details;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(340, 180);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Tin";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(6, 76);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(155, 23);
            this.b_delete.TabIndex = 9;
            this.b_delete.Text = "Delete Selected";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // lv_player
            // 
            this.lv_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_player.FullRowSelect = true;
            this.lv_player.Location = new System.Drawing.Point(3, 3);
            this.lv_player.MultiSelect = false;
            this.lv_player.Name = "lv_player";
            this.lv_player.Size = new System.Drawing.Size(334, 174);
            this.lv_player.TabIndex = 8;
            this.lv_player.UseCompatibleStateImageBehavior = false;
            this.lv_player.View = System.Windows.Forms.View.Details;
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.lv_player);
            this.tab4.Location = new System.Drawing.Point(4, 22);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(340, 180);
            this.tab4.TabIndex = 3;
            this.tab4.Text = "Player";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "1.12.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_maps;
        private System.Windows.Forms.Button b_teleport;
        private System.Windows.Forms.TextBox tb_mapsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_grave;
        private System.Windows.Forms.Button b_addcurrent;
        private System.Windows.Forms.TextBox tb_telename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tb_z;
        private System.Windows.Forms.Label tb_y;
        private System.Windows.Forms.Label tb_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Timer OnTop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_manual_z;
        private System.Windows.Forms.TextBox tb_manual_y;
        private System.Windows.Forms.TextBox tb_manual_x;
        private System.Windows.Forms.Button b_manual;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.ListView lv_copper;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.TabPage tab4;
        private System.Windows.Forms.ListView lv_player;
    }
}

