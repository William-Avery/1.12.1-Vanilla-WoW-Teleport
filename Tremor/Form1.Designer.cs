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
            this.lv_maps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_teleport = new System.Windows.Forms.Button();
            this.tb_mapsearch = new System.Windows.Forms.TextBox();
            this.b_defaultlist = new System.Windows.Forms.Button();
            this.b_playerlist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_grave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_maps
            // 
            this.lv_maps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_maps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_maps.FullRowSelect = true;
            this.lv_maps.Location = new System.Drawing.Point(2, 53);
            this.lv_maps.MultiSelect = false;
            this.lv_maps.Name = "lv_maps";
            this.lv_maps.Size = new System.Drawing.Size(209, 220);
            this.lv_maps.TabIndex = 0;
            this.lv_maps.UseCompatibleStateImageBehavior = false;
            this.lv_maps.View = System.Windows.Forms.View.List;
            this.lv_maps.SelectedIndexChanged += new System.EventHandler(this.lv_maps_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "X";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Z";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Map";
            this.columnHeader5.Width = 40;
            // 
            // b_teleport
            // 
            this.b_teleport.Location = new System.Drawing.Point(2, 23);
            this.b_teleport.Name = "b_teleport";
            this.b_teleport.Size = new System.Drawing.Size(209, 30);
            this.b_teleport.TabIndex = 1;
            this.b_teleport.Text = "Teleport";
            this.b_teleport.UseVisualStyleBackColor = true;
            this.b_teleport.Click += new System.EventHandler(this.b_teleport_Click);
            // 
            // tb_mapsearch
            // 
            this.tb_mapsearch.Location = new System.Drawing.Point(2, 0);
            this.tb_mapsearch.Name = "tb_mapsearch";
            this.tb_mapsearch.Size = new System.Drawing.Size(209, 22);
            this.tb_mapsearch.TabIndex = 2;
            this.tb_mapsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_defaultlist
            // 
            this.b_defaultlist.Location = new System.Drawing.Point(106, 292);
            this.b_defaultlist.Name = "b_defaultlist";
            this.b_defaultlist.Size = new System.Drawing.Size(105, 30);
            this.b_defaultlist.TabIndex = 3;
            this.b_defaultlist.Text = "Default Locations";
            this.b_defaultlist.UseVisualStyleBackColor = true;
            this.b_defaultlist.Click += new System.EventHandler(this.b_defaultlist_Click);
            // 
            // b_playerlist
            // 
            this.b_playerlist.Location = new System.Drawing.Point(2, 292);
            this.b_playerlist.Name = "b_playerlist";
            this.b_playerlist.Size = new System.Drawing.Size(105, 30);
            this.b_playerlist.TabIndex = 4;
            this.b_playerlist.Text = "Player Added";
            this.b_playerlist.UseVisualStyleBackColor = true;
            this.b_playerlist.Click += new System.EventHandler(this.b_playerlist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_grave);
            this.groupBox1.Location = new System.Drawing.Point(217, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands:";
            // 
            // b_grave
            // 
            this.b_grave.Location = new System.Drawing.Point(6, 21);
            this.b_grave.Name = "b_grave";
            this.b_grave.Size = new System.Drawing.Size(189, 23);
            this.b_grave.TabIndex = 0;
            this.b_grave.Text = "Teleport Corpse";
            this.b_grave.UseVisualStyleBackColor = true;
            this.b_grave.Click += new System.EventHandler(this.b_grave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Current Location";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_playerlist);
            this.Controls.Add(this.b_defaultlist);
            this.Controls.Add(this.tb_mapsearch);
            this.Controls.Add(this.lv_maps);
            this.Controls.Add(this.b_teleport);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "1.12.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_maps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button b_teleport;
        private System.Windows.Forms.TextBox tb_mapsearch;
        private System.Windows.Forms.Button b_defaultlist;
        private System.Windows.Forms.Button b_playerlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_grave;
        private System.Windows.Forms.Button button1;
    }
}

