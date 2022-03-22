namespace WindowsFormsApp1
{
    partial class CrawlingBackToYou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrawlingBackToYou));
            this.header = new System.Windows.Forms.Label();
            this.choose_folder_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.side_panel = new System.Windows.Forms.Panel();
            this.search_button = new System.Windows.Forms.Button();
            this.BFS_button = new System.Windows.Forms.RadioButton();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DFS_button = new System.Windows.Forms.RadioButton();
            this.search_method_label = new System.Windows.Forms.Label();
            this.find_all_checkbox = new System.Windows.Forms.CheckBox();
            this.choose_folder_button = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.Label();
            this.graph_panel = new System.Windows.Forms.Panel();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(29, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(181, 27);
            this.header.TabIndex = 0;
            this.header.Text = "Folder Crawling";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header.Click += new System.EventHandler(this.label1_Click);
            // 
            // choose_folder_label
            // 
            this.choose_folder_label.AutoSize = true;
            this.choose_folder_label.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_folder_label.Location = new System.Drawing.Point(30, 101);
            this.choose_folder_label.Name = "choose_folder_label";
            this.choose_folder_label.Size = new System.Drawing.Size(171, 18);
            this.choose_folder_label.TabIndex = 3;
            this.choose_folder_label.Text = "Choose starting directory";
            this.choose_folder_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choose_folder_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.side_panel.Controls.Add(this.search_button);
            this.side_panel.Controls.Add(this.BFS_button);
            this.side_panel.Controls.Add(this.filename_textbox);
            this.side_panel.Controls.Add(this.label1);
            this.side_panel.Controls.Add(this.DFS_button);
            this.side_panel.Controls.Add(this.search_method_label);
            this.side_panel.Controls.Add(this.find_all_checkbox);
            this.side_panel.Controls.Add(this.choose_folder_button);
            this.side_panel.Controls.Add(this.directory);
            this.side_panel.Controls.Add(this.header);
            this.side_panel.Controls.Add(this.choose_folder_label);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(271, 577);
            this.side_panel.TabIndex = 4;
            this.side_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(33, 509);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(189, 25);
            this.search_button.TabIndex = 11;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // BFS_button
            // 
            this.BFS_button.AutoSize = true;
            this.BFS_button.Location = new System.Drawing.Point(33, 431);
            this.BFS_button.Name = "BFS_button";
            this.BFS_button.Size = new System.Drawing.Size(55, 22);
            this.BFS_button.TabIndex = 10;
            this.BFS_button.TabStop = true;
            this.BFS_button.Text = "BFS";
            this.BFS_button.UseVisualStyleBackColor = true;
            this.BFS_button.CheckedChanged += new System.EventHandler(this.BFS_button_CheckedChanged);
            // 
            // filename_textbox
            // 
            this.filename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename_textbox.ForeColor = System.Drawing.Color.Black;
            this.filename_textbox.Location = new System.Drawing.Point(33, 305);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(178, 23);
            this.filename_textbox.TabIndex = 5;
            this.filename_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input file name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DFS_button
            // 
            this.DFS_button.AutoSize = true;
            this.DFS_button.Location = new System.Drawing.Point(33, 406);
            this.DFS_button.Name = "DFS_button";
            this.DFS_button.Size = new System.Drawing.Size(56, 22);
            this.DFS_button.TabIndex = 8;
            this.DFS_button.TabStop = true;
            this.DFS_button.Text = "DFS";
            this.DFS_button.UseVisualStyleBackColor = true;
            this.DFS_button.CheckedChanged += new System.EventHandler(this.DFS_button_CheckedChanged);
            // 
            // search_method_label
            // 
            this.search_method_label.AutoSize = true;
            this.search_method_label.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_method_label.Location = new System.Drawing.Point(30, 388);
            this.search_method_label.Name = "search_method_label";
            this.search_method_label.Size = new System.Drawing.Size(107, 18);
            this.search_method_label.TabIndex = 7;
            this.search_method_label.Text = "Search Method";
            this.search_method_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // find_all_checkbox
            // 
            this.find_all_checkbox.AutoSize = true;
            this.find_all_checkbox.Location = new System.Drawing.Point(33, 356);
            this.find_all_checkbox.Name = "find_all_checkbox";
            this.find_all_checkbox.Size = new System.Drawing.Size(160, 22);
            this.find_all_checkbox.TabIndex = 6;
            this.find_all_checkbox.Text = "Find All Occurences";
            this.find_all_checkbox.UseVisualStyleBackColor = true;
            this.find_all_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // choose_folder_button
            // 
            this.choose_folder_button.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.choose_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_folder_button.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_folder_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.choose_folder_button.Location = new System.Drawing.Point(33, 119);
            this.choose_folder_button.Name = "choose_folder_button";
            this.choose_folder_button.Size = new System.Drawing.Size(111, 25);
            this.choose_folder_button.TabIndex = 5;
            this.choose_folder_button.Text = "Choose folder...";
            this.choose_folder_button.UseVisualStyleBackColor = true;
            this.choose_folder_button.Click += new System.EventHandler(this.choose_folder_button_Click);
            // 
            // directory
            // 
            this.directory.AutoSize = true;
            this.directory.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directory.Location = new System.Drawing.Point(30, 156);
            this.directory.MaximumSize = new System.Drawing.Size(178, 0);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(124, 18);
            this.directory.TabIndex = 5;
            this.directory.Text = "No Folder Chosen";
            this.directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directory.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // graph_panel
            // 
            this.graph_panel.BackColor = System.Drawing.Color.White;
            this.graph_panel.Location = new System.Drawing.Point(295, 33);
            this.graph_panel.Name = "graph_panel";
            this.graph_panel.Size = new System.Drawing.Size(633, 295);
            this.graph_panel.TabIndex = 5;
            // 
            // CrawlingBackToYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.graph_panel);
            this.Controls.Add(this.side_panel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrawlingBackToYou";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label choose_folder_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label directory;
        private System.Windows.Forms.Button choose_folder_button;
        private System.Windows.Forms.CheckBox find_all_checkbox;
        private System.Windows.Forms.RadioButton DFS_button;
        private System.Windows.Forms.Label search_method_label;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.RadioButton BFS_button;
        private System.Windows.Forms.Panel graph_panel;
    }
}

