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
            this.viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.full_path_label = new System.Windows.Forms.Label();
            this.time_spent_label = new System.Windows.Forms.Label();
            this.full_path_panel = new System.Windows.Forms.TableLayoutPanel();
            this.side_panel.SuspendLayout();
            this.graph_panel.SuspendLayout();
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
            // 
            // side_panel
            // 
            this.side_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(271, 577);
            this.side_panel.TabIndex = 4;
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_button.BackColor = System.Drawing.Color.Black;
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
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // BFS_button
            // 
            this.BFS_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.filename_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.DFS_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.search_method_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.find_all_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.choose_folder_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.choose_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_folder_button.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_folder_button.ForeColor = System.Drawing.Color.Black;
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
            // 
            // graph_panel
            // 
            this.graph_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graph_panel.BackColor = System.Drawing.Color.White;
            this.graph_panel.Controls.Add(this.viewer);
            this.graph_panel.Location = new System.Drawing.Point(295, 33);
            this.graph_panel.Name = "graph_panel";
            this.graph_panel.Size = new System.Drawing.Size(636, 298);
            this.graph_panel.TabIndex = 5;
            // 
            // viewer
            // 
            this.viewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewer.ArrowheadLength = 10D;
            this.viewer.AsyncLayout = false;
            this.viewer.AutoScroll = true;
            this.viewer.AutoSize = true;
            this.viewer.BackwardEnabled = false;
            this.viewer.BuildHitTree = true;
            this.viewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.viewer.EdgeInsertButtonVisible = true;
            this.viewer.FileName = "";
            this.viewer.ForwardEnabled = false;
            this.viewer.Graph = null;
            this.viewer.InsertingEdge = false;
            this.viewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.viewer.LayoutEditingEnabled = true;
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.LooseOffsetForRouting = 0.25D;
            this.viewer.MinimumSize = new System.Drawing.Size(633, 295);
            this.viewer.MouseHitDistance = 0.05D;
            this.viewer.Name = "viewer";
            this.viewer.NavigationVisible = true;
            this.viewer.NeedToCalculateLayout = true;
            this.viewer.OffsetForRelaxingInRouting = 0.6D;
            this.viewer.PaddingForEdgeRouting = 8D;
            this.viewer.PanButtonPressed = false;
            this.viewer.SaveAsImageEnabled = true;
            this.viewer.SaveAsMsaglEnabled = true;
            this.viewer.SaveButtonVisible = true;
            this.viewer.SaveGraphButtonVisible = true;
            this.viewer.SaveInVectorFormatEnabled = true;
            this.viewer.Size = new System.Drawing.Size(633, 295);
            this.viewer.TabIndex = 0;
            this.viewer.TightOffsetForRouting = 0.125D;
            this.viewer.ToolBarIsVisible = true;
            this.viewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("viewer.Transform")));
            this.viewer.UndoRedoButtonsVisible = true;
            this.viewer.WindowZoomButtonPressed = false;
            this.viewer.ZoomF = 1D;
            this.viewer.ZoomWindowThreshold = 0.05D;
            // 
            // full_path_label
            // 
            this.full_path_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.full_path_label.AutoSize = true;
            this.full_path_label.BackColor = System.Drawing.Color.Transparent;
            this.full_path_label.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_path_label.Location = new System.Drawing.Point(292, 360);
            this.full_path_label.Name = "full_path_label";
            this.full_path_label.Size = new System.Drawing.Size(90, 18);
            this.full_path_label.TabIndex = 6;
            this.full_path_label.Text = "Full Path(s):";
            // 
            // time_spent_label
            // 
            this.time_spent_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_spent_label.AutoSize = true;
            this.time_spent_label.Location = new System.Drawing.Point(292, 509);
            this.time_spent_label.Name = "time_spent_label";
            this.time_spent_label.Size = new System.Drawing.Size(151, 18);
            this.time_spent_label.TabIndex = 9;
            this.time_spent_label.Text = "Time Spent: 00.00 ms";
            // 
            // full_path_panel
            // 
            this.full_path_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.full_path_panel.AutoScroll = true;
            this.full_path_panel.AutoSize = true;
            this.full_path_panel.BackColor = System.Drawing.Color.White;
            this.full_path_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.full_path_panel.ColumnCount = 1;
            this.full_path_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.full_path_panel.Location = new System.Drawing.Point(295, 388);
            this.full_path_panel.MaximumSize = new System.Drawing.Size(0, 102);
            this.full_path_panel.MinimumSize = new System.Drawing.Size(636, 102);
            this.full_path_panel.Name = "full_path_panel";
            this.full_path_panel.RowCount = 1;
            this.full_path_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.full_path_panel.Size = new System.Drawing.Size(636, 102);
            this.full_path_panel.TabIndex = 8;
            // 
            // CrawlingBackToYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.time_spent_label);
            this.Controls.Add(this.full_path_panel);
            this.Controls.Add(this.full_path_label);
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
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            this.graph_panel.ResumeLayout(false);
            this.graph_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private Microsoft.Msagl.Drawing.Graph graph;
        private System.Windows.Forms.Label full_path_label;
        private System.Windows.Forms.Label time_spent_label;
        private System.Windows.Forms.TableLayoutPanel full_path_panel;
    }
}

