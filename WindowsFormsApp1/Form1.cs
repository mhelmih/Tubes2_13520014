using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class CrawlingBackToYou : Form
    {
        string dir;
        string filename;
        Boolean find_all;
        Boolean isDFS;
        Boolean isBFS;

        public CrawlingBackToYou()
        {
            InitializeComponent();
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            dir = "";
            filename = "";
            find_all = false;
            isDFS = false;
            isBFS = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.find_all)
            {
                this.find_all = false;
            } else
            {
                this.find_all = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filename = filename_textbox.Text;
        }

        private void generateGraph(Folder folder, Searching s)
        {
            Folder ftemp = folder;
            Stack<Folder> fileStack = new Stack<Folder>();
            Queue<Folder> fileQueue = new Queue<Folder>();

            List<String> rightPath = s.getRightPath();
            List<String> visitedPath = s.getVisitedPath();


            if (this.isDFS)
            {
                fileStack.Push(ftemp);
                while(fileStack.Count > 0)
                {
                    Folder temp2 = fileStack.Pop();
                    
                    if (temp2.getParent() != null)
                    {
                        String parent = temp2.getParent().getDirname();
                        String visit = temp2.getDirname();
                        if (visitedPath.Contains(parent) && visitedPath.Contains(visit))
                        {
                            if (rightPath.Contains(parent) && rightPath.Contains(visit))
                            {
                                this.graph.AddEdge(parent, visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                                this.graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                                this.graph.FindNode(visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                            }
                            else
                            {
                                this.graph.AddEdge(parent, visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                                this.graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                                this.graph.FindNode(visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            }
                            generateFileGraph(temp2, s);

                        }
                        else
                        {
                            this.graph.AddEdge(parent, visit);
                            this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                            this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                            
                        }
                    }
                    else
                    {
                        generateFileGraph(temp2, s);
                    }

                    if (s.getVisitedPath().Contains(temp2.getDirname()))
                    {
                        List<Folder> temp3 = temp2.getAdj();
                        temp3.Reverse();
                        foreach (Folder i in temp3)
                        {
                            
                            fileStack.Push(i);
                            
                        }
                    }

                }
            }
            else
            {
                fileQueue.Enqueue(ftemp);
                while(fileQueue.Count > 0)
                {
                    Folder temp2 = fileQueue.Dequeue();
                    if (temp2.getParent() != null)
                    {
                        String parent = temp2.getParent().getDirname();
                        String visit = temp2.getDirname();
                        if (visitedPath.Contains(parent) && visitedPath.Contains(visit))
                        {
                            if (rightPath.Contains(parent) && rightPath.Contains(visit))
                            {
                                this.graph.AddEdge(parent, visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                                this.graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                                this.graph.FindNode(visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                            }
                            else
                            {
                                this.graph.AddEdge(parent, visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                                this.graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                                this.graph.FindNode(visit).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            }
                            generateFileGraph(temp2, s);

                        }
                        else
                        {
                            this.graph.AddEdge(parent, visit);
                            this.graph.FindNode(parent).LabelText = Path.GetFileName(parent);
                            this.graph.FindNode(visit).LabelText = Path.GetFileName(visit);
                            
                        }
                    }
                    else
                    {
                        generateFileGraph(temp2, s);
                    }

                    if (s.getVisitedPath().Contains(temp2.getDirname()))
                    {
                        foreach (Folder i in temp2.getAdj())
                        {
                            
                             fileQueue.Enqueue(i);
                            
                        }
                    }
                }
            }
        }

        private void generateFileGraph(Folder folder, Searching s)
        {
            int j = 0;
            Boolean flag = false;
            Folder ftemp = folder;
            string[] listAllFiles = ftemp.getAllFiles();

            while (j < folder.getAllFiles().Length && !flag)
            {
                string s1 = ftemp.getDirname();
                string s2 = listAllFiles[j];
                if (s.getFilePath().Contains(listAllFiles[j]))
                {
                    this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    this.graph.FindNode(s1).LabelText = Path.GetFileName(s1);
                    this.graph.FindNode(s1).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    this.graph.FindNode(s2).LabelText = Path.GetFileName(s2);
                    this.graph.FindNode(s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    if (this.find_all)
                    {
                        flag = false;
                        j++;
                    }
                    else
                    {
                        flag = true;

                    }

                }
                else
                {
                    this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    this.graph.FindNode(s1).LabelText = Path.GetFileName(s1);
                    this.graph.FindNode(s1).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    this.graph.FindNode(s2).LabelText = Path.GetFileName(s2);
                    this.graph.FindNode(s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    j++;
                }
            }
        }

        public void showGraph()
        {
            this.viewer.Graph = this.graph;
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // if user didnt choose the starting folder and didnt input the filename, do nothing
            if (this.dir != "" && this.filename != "")
            {
                Searching search = new Searching(this.dir, this.filename, this.find_all);
                // if user didnt choose the search method, do nothing
                if (this.isDFS || this.isBFS)
                {
                    var watch = new Stopwatch();
                    watch.Start();

                    // find the file
                    if (this.isBFS)
                    {
                        search.BFS();
                    }
                    else
                    {
                        search.DFS();
                    }

                    Folder a = new Folder(this.dir);

                    // Clear graph if it has created before
                    if (this.graph != null)
                    {
                        this.graph = null;
                        this.graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    }

                    // Clear full path panel if it has created before
                    this.full_path_panel.Controls.Clear();
                    this.full_path_panel.RowCount = 1;

                    // Generate graph
                    generateGraph(a, search);
                    showGraph();

                    watch.Stop();

                    // Generate full path hyperlinks
                    if (search.getFilePath().Count() == 0)
                    {
                        this.full_path_panel.Controls.Add(new Label() { Text = "File not found." }, 1, this.full_path_panel.RowCount - 1);
                    }
                    else if (search.getFilePath().Count() > 0)
                    {
                        for (int i = 0; i < search.getFilePath().Count(); i++)
                        {
                            LinkLabel link = new LinkLabel();
                            link.Text = search.getFilePath()[i];
                            link.AutoSize = true;
                            link.Links.Add(0, link.Text.Count(), link.Text);
                            link.Links[0].LinkData = link.Text;
                            link.LinkClicked += this.full_path_links_LinkClicked;
                            this.full_path_panel.Controls.Add(link, 1, this.full_path_panel.RowCount - 1);
                            this.full_path_panel.RowCount += 1;
                        }
                    }

                    this.time_spent_label.Text = "Time Spent: " + watch.ElapsedMilliseconds + " ms";
                }
            }
            
            
        }

        private void choose_folder_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directory.Text = diag.SelectedPath;
                dir = diag.SelectedPath;
            }
            else
            { directory.Text = "No Folder Chosen"; }
        }

        private void DFS_button_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.isBFS && !this.isDFS)
            {
                this.isDFS = true;
            } else
            {
                this.isDFS = true;
                this.isBFS = false;
            }
        }

        private void BFS_button_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.isBFS && !this.isDFS)
            {
                this.isBFS = true;
            }
            else
            {
                this.isDFS = false;
                this.isBFS = true;
            }
        }

        private void full_path_links_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = e.Link.LinkData as string;
            string argument = "/select, \"" + @path + "\"";
            Process.Start("explorer.exe", argument);
        }

        private void CrawlingBackToYou_Load(object sender, EventArgs e)
        {

        }
    }
}
