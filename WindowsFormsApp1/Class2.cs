using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Folder
    {
        private string[] listFile;
        private string[] listFolder;

        private String dirName;
        private Folder parent;
        private List<Folder> adjFolder;
        Boolean visited;

        public Folder()
        {
            this.visited = false;
            this.listFile = new string[0];
            this.listFolder = new string[0];
            this.dirName = "";
        }

        public Folder(string root)
        {
            // Ctr dengan path root
            this.visited = false;
            this.dirName= root;
            this.listFile = Directory.GetFiles(root);
            this.listFolder = Directory.GetDirectories(root);
            this.adjFolder = new List<Folder>();
            this.parent = null;
            foreach (string i in listFolder)
            {
                this.adjFolder.Add(new Folder(this,i));

            }
            
        }

        public Folder(Folder parent,string str)
        {
            this.visited = false;
            this.dirName = str;
            this.listFile = Directory.GetFiles(str);
            this.listFolder = Directory.GetDirectories(str);
            this.adjFolder = new List<Folder>();
            this.parent = parent;
            foreach (string i in listFolder)
            {
                this.adjFolder.Add(new Folder(this, i));

            }
        }

        public void setVisited(Boolean val)
        {
            this.visited = val;
        }

        public string[] getAllDir()
        {
            return this.listFolder;
        }

        public string[] getAllFiles()
        {
            return this.listFile;
        }

        public List<Folder> getAdj()
        {
            return this.adjFolder;
        }

        public Boolean getVisited()
        {
            return this.visited;
        }

        public String getDirname()
        {
            return this.dirName;
        }

        public Folder getParent()
        {
            return this.parent;
        }

        public Boolean checkFile(string name)
        {
            Boolean Flag = false;
            int i = 0;
            while (i < listFile.Length && !Flag)
            {
                string file = Path.GetFileName(listFile[i]);
                if (file.Equals(name))
                {
                    Flag = true;
                }
                else
                {
                    i += 1;
                }
            }
            this.visited = true;
            return Flag;
        }

        public string getFilePath(string name)
        {
            string temp = "";
            int i = 0;
            Boolean flag = false;
            while (i < listFile.Length && !flag)
            {
                if (Path.GetFileName(listFile[i]).Equals(name))
                {
                    temp = listFile[i];
                    flag = true;
                }
                else
                {
                    i++;
                }
            }
            return temp;
        }

    }

    class Searching
    {
        // Buat dfs
        private Folder check;
        private Stack<Folder> temp;

        // Buat path file yang bener
        private String filePath;
        private Folder rightDir;
        public List<String> rightPath;
        


        public Searching(Folder folder)
        {
            // Ctr Searching pass object Folder
            this.check = folder;
            this.temp = new Stack<Folder>();
            this.rightPath = new List<string>();
            this.rightDir = null;
        }

        public void DFS(string name)
        {
            // Cuma nyari 1 file
            string str = "";
            Boolean found = false;
            temp.Push(check);
            while (temp.Count > 0 && !found)
            {
                Folder temp2 = temp.Pop();
                if (temp2.getVisited() == false)
                {
                    if (temp2.checkFile(name))
                    {
                        found = true;
                        str = temp2.getFilePath(name);
                        this.rightDir = temp2;
                    }
                }

                foreach (Folder i in temp2.getAdj())
                {
                    if (!i.getVisited())
                    {
                        temp.Push(i);
                    }
                }

            }
            if (found)
            {
                this.filePath = str;
            }
            else
            {
                this.filePath = "Not found";
            }
        }


        public String getFilePath()
        {
            return filePath;
        }

        public void generatePath()
        {
            if (this.rightDir != null)
            {
                Folder temp = this.rightDir;
                while (temp != null)
                {
                    rightPath.Add(temp.getDirname());
                    temp = temp.getParent();
                }
            }
        }


    }


    class folderGraph
    {
        public System.Windows.Forms.Form form;
        public Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        public Microsoft.Msagl.Drawing.Graph graph;
        private Stack<Folder> temp;

        public folderGraph()
        {
            this.form = new System.Windows.Forms.Form();
            this.viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.graph = new Microsoft.Msagl.Drawing.Graph("graph");
            this.temp = new Stack<Folder>();
        }

        public void generateGraph(Folder root, Searching s)
        {
            // Masih error
            Folder ftemp = root;
            String s1 = Path.GetFileName(ftemp.getDirname());
            if (ftemp.getAdj().Count > 0)
            {
                foreach (Folder i in ftemp.getAdj())
                {
                    if (ftemp.getParent() != null)
                    {
                        s1 = Path.GetFileName(ftemp.getParent().getDirname())+ "/" + s1;
                    }
                    string s2 = Path.GetFileName(i.getDirname());
                    if (i.getParent() != null)
                    {
                        s2 = Path.GetFileName(i.getParent().getDirname()) + "/" + s2;
                    }
                    this.graph.AddEdge(s1, s2);

                }
                
            }
        }

        public void showGraph()
        {
            this.viewer.Graph = this.graph;
            this.form.SuspendLayout();
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Controls.Add(this.viewer);
            this.form.ResumeLayout();
            this.form.ShowDialog();
        }


    }
}
