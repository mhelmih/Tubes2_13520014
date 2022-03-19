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
        public List<String> rightPath; // list string path dari root menuju file yang dicari
        public List<String> visitedPath;


        public Searching(string rootPath, string fileToSearch)
        {
            this.fileToSearch=fileToSearch;
            this.rootPath=rootPath;
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
            while (temp.Count > 0 && !found)
            {
                Folder temp2 = temp.Pop();
                if (temp2.getVisited() == false)
                {
                    if (temp2.checkFile(this.fileToSearch))
                    {
                        found = true;
                        str = temp2.getFilePath(this.fileToSearch);
                        generatePath(temp2);
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
                this.filePath.Add(str);
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
            return filePath;
        }

        public void generatePath(Folder rightDir)
        {
            if (rightDir != null)
            {
                Folder temp = rightDir;
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

        public void generateGraph(string rootPath, Searching s)
        {
            // Masih error
            Folder ftemp = new Folder(rootPath);
            if (ftemp.getAdj().Count > 0)
            {
                foreach (Folder i in ftemp.getAdj())
                {
                    String s1 = Path.GetFileName(ftemp.getDirname());
                    if (ftemp.getParent() != null)
                    {
                        s1 = Path.GetFileName(ftemp.getParent().getDirname())+ "/" + s1;
                    }
                    String s2 = Path.GetFileName(i.getDirname());
                    if (i.getParent() != null)
                    {
                        s2 = Path.GetFileName(i.getParent().getDirname()) + "/" + s2;
                    }
                    this.graph.AddEdge(s1, s2);
                    generateGraph(i.getDirname(), s);

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
