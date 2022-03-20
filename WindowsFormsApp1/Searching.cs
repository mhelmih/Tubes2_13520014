using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Searching
    {
        private bool isAllOccurence;
        private string fileToSearch;
        private string rootPath;

        // Buat path file yang bener
        private List<String> filePath; // full path file yang benar, hanya berisi 1 bila find 1 occurence
        private List<String> rightPath; // list string path dari root menuju file yang dicari
        private List<String> visitedPath;


        public Searching(string rootPath, string fileToSearch, bool isAllOccurence)
        {
            this.isAllOccurence = isAllOccurence;
            this.fileToSearch = fileToSearch;
            this.rootPath = rootPath;
            // Ctr Searching pass object Folder
            this.filePath = new List<string>();
            this.rightPath = new List<string>();
            this.visitedPath = new List<string>();

        }

        public void DFS()
        {
            Folder check = new Folder(this.rootPath);
            Stack<Folder> temp = new Stack<Folder>();

            // Cuma nyari 1 file
            string str = "";
            Boolean found = false;
            temp.Push(check);
            if (this.isAllOccurence)
            {
                while (temp.Count > 0)
                {
                    Folder temp2 = temp.Pop();
                    this.visitedPath.Add(temp2.getDirname());
                    if (temp2.getVisited() == false)
                    {
                        if (temp2.checkFile(this.fileToSearch))
                        {

                            str = temp2.getFilePath(this.fileToSearch);
                            generatePath(temp2);
                            this.filePath.Add(str);
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
            }
            else
            {
                while (temp.Count > 0 && !found)
                {
                    Folder temp2 = temp.Pop();
                    this.visitedPath.Add(temp2.getDirname());
                    if (temp2.getVisited() == false)
                    {
                        if (temp2.checkFile(this.fileToSearch))
                        {

                            str = temp2.getFilePath(this.fileToSearch);
                            generatePath(temp2);
                            this.filePath.Add(str);
                            found = true;
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
            }
        }

        public void BFS()
        {
            Folder rootFolder = new Folder(this.rootPath);
            bool found = false;

            Queue<Folder> fileQueue = new Queue<Folder>();
            fileQueue.Enqueue(rootFolder);

            // chek if queue is not empty
            while (fileQueue.Any() && (!found || this.isAllOccurence))
            {
                Folder current = fileQueue.Dequeue();
                this.visitedPath.Add(current.getDirname());
                //string[] files = Directory.GetFiles(current);
                if (current.getAllFiles().Count() > 0)
                {

                    if (current.checkFile(this.fileToSearch))
                    {
                        filePath.Add(current.getFilePath(fileToSearch));

                        if (!found)
                        {
                            found = true;
                            generatePath(current);
                            if (!isAllOccurence)
                            {
                                return;
                            }
                        }


                    }
                }
                foreach (Folder dir in current.getAdj())
                {
                    fileQueue.Enqueue(dir);
                }

            }
            return;
        }

        public List<String> getFilePath()
        {
            return this.filePath;
        }

        public List<String> getRightPath()
        {
            return this.rightPath;
        }

        public List<String> getVisitedPath()
        {
            return this.visitedPath;
        }

        public void generatePath(Folder rightDir)
        {
            Folder temp = rightDir;
            while (temp != null)
            {
                rightPath.Add(temp.getDirname());
                temp = temp.getParent();
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

        public void generateGraph(Folder folder, Searching s)
        {
            // Masih error
            int j  = 0;
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
                string s2 = Path.GetFileName(listAllFiles[j]);
                if (listAllFiles[j] == s.getFilePath()[0] && s.getFilePath().Count > 0)
                {
                    this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    flag = true;
                }
                else
                {
                    this.graph.AddEdge(s1, s2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    j++;
                }

            }

            if (!flag)
            {
                
                foreach (Folder i in ftemp.getAdj())
                {
                    String s1 = Path.GetFileName(ftemp.getDirname());
                    if (ftemp.getParent() != null)
                    {
                        s1 = Path.GetFileName(ftemp.getParent().getDirname()) + "/" + s1;
                    }
                    String s2 = Path.GetFileName(i.getDirname());
                    if (i.getParent() != null)
                    {
                        s2 = Path.GetFileName(i.getParent().getDirname()) + "/" + s2;
                    }
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
