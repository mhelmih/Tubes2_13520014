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
            // Masih error
            int j = 0;
            Boolean flag = false;
            Folder ftemp = folder;

            generateFileGraph(ftemp, s);

            foreach (Folder i in ftemp.getAdj())
            {
                String s1 = Path.GetFileName(ftemp.getDirname());
                String s2 = Path.GetFileName(i.getDirname());
                String visit1 = ftemp.getDirname();
                String visit2 = i.getDirname();
                List<String> rightPath = s.getRightPath();
                List<String> visitedPath = s.getVisitedPath();
                if (visitedPath.Contains(visit1) && visitedPath.Contains(visit2))
                {
                    if (rightPath.Contains(visit1) && rightPath.Contains(visit2))
                    {
                        this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    }
                    else
                    {
                        this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                    generateGraph(i, s);
                }
                else
                {
                    this.graph.AddEdge(s1, s2);
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
                string s1 = Path.GetFileName(ftemp.getDirname());
                if (ftemp.getParent() != null)
                {
                    s1 = Path.GetFileName(ftemp.getParent().getDirname()) + "/" + s1;
                }
                string s2 = Path.GetFileName(ftemp.getDirname()) + "/" + Path.GetFileName(listAllFiles[j]);
                string s3 = "";
                if (s.getFilePath().Contains(listAllFiles[j]))
                {
                    this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
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
            Searching search = new Searching(this.dir, this.filename, this.find_all);
            if(this.isDFS || this.isBFS)
            {
                if (this.isBFS)
                {
                    search.BFS();
                }
                else
                {
                    search.DFS();
                }

                for (int i = 0; i < search.getFilePath().Count; i++)
                {
                    Console.WriteLine(search.getFilePath()[i]);
                }
                Folder a = new Folder(this.dir);

                if (this.graph != null)
                {
                    this.graph = null;
                    this.graph = new Microsoft.Msagl.Drawing.Graph("graph");
                }
                generateGraph(a, search);
                showGraph();
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

    }
}
