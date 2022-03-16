namespace WindowsFormsApp1
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
            this.header = new System.Windows.Forms.Label();
            this.choose_folder_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.find_all_checkbox = new System.Windows.Forms.CheckBox();
            this.choose_folder_button = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.search_method_label = new System.Windows.Forms.Label();
            this.DFS_button = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.BFS_button = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(29, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(144, 22);
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
            this.choose_folder_label.Size = new System.Drawing.Size(143, 15);
            this.choose_folder_label.TabIndex = 3;
            this.choose_folder_label.Text = "Choose starting directory";
            this.choose_folder_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choose_folder_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.BFS_button);
            this.panel1.Controls.Add(this.filename_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DFS_button);
            this.panel1.Controls.Add(this.search_method_label);
            this.panel1.Controls.Add(this.find_all_checkbox);
            this.panel1.Controls.Add(this.choose_folder_button);
            this.panel1.Controls.Add(this.directory);
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.choose_folder_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 577);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // find_all_checkbox
            // 
            this.find_all_checkbox.AutoSize = true;
            this.find_all_checkbox.Location = new System.Drawing.Point(33, 356);
            this.find_all_checkbox.Name = "find_all_checkbox";
            this.find_all_checkbox.Size = new System.Drawing.Size(134, 19);
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
            this.directory.Location = new System.Drawing.Point(30, 156);
            this.directory.MaximumSize = new System.Drawing.Size(178, 0);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(105, 15);
            this.directory.TabIndex = 5;
            this.directory.Text = "No Folder Chosen";
            this.directory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.directory.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.Black;
            this.close_button.Location = new System.Drawing.Point(914, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 25);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // search_method_label
            // 
            this.search_method_label.AutoSize = true;
            this.search_method_label.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_method_label.Location = new System.Drawing.Point(30, 388);
            this.search_method_label.Name = "search_method_label";
            this.search_method_label.Size = new System.Drawing.Size(90, 15);
            this.search_method_label.TabIndex = 7;
            this.search_method_label.Text = "Search Method";
            this.search_method_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DFS_button
            // 
            this.DFS_button.AutoSize = true;
            this.DFS_button.Location = new System.Drawing.Point(33, 406);
            this.DFS_button.Name = "DFS_button";
            this.DFS_button.Size = new System.Drawing.Size(48, 19);
            this.DFS_button.TabIndex = 8;
            this.DFS_button.TabStop = true;
            this.DFS_button.Text = "DFS";
            this.DFS_button.UseVisualStyleBackColor = true;
            this.DFS_button.CheckedChanged += new System.EventHandler(this.DFS_button_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input file name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filename_textbox
            // 
            this.filename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename_textbox.ForeColor = System.Drawing.Color.Black;
            this.filename_textbox.Location = new System.Drawing.Point(33, 305);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(178, 20);
            this.filename_textbox.TabIndex = 5;
            this.filename_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BFS_button
            // 
            this.BFS_button.AutoSize = true;
            this.BFS_button.Location = new System.Drawing.Point(33, 431);
            this.BFS_button.Name = "BFS_button";
            this.BFS_button.Size = new System.Drawing.Size(47, 19);
            this.BFS_button.TabIndex = 10;
            this.BFS_button.TabStop = true;
            this.BFS_button.Text = "BFS";
            this.BFS_button.UseVisualStyleBackColor = true;
            this.BFS_button.CheckedChanged += new System.EventHandler(this.BFS_button_CheckedChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label choose_folder_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label directory;
        private System.Windows.Forms.Button choose_folder_button;
        private System.Windows.Forms.CheckBox find_all_checkbox;
        private System.Windows.Forms.RadioButton DFS_button;
        private System.Windows.Forms.Label search_method_label;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.RadioButton BFS_button;
    }
}

