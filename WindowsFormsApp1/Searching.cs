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
                // check if current folder contains file(s)
                if (current.getAllFiles().Count() > 0)
                {
                    // check if current folder contains file name that we search
                    if (current.checkFile(this.fileToSearch))
                    {
                        filePath.Add(current.getFilePath(fileToSearch));
                        generatePath(current);
                        found = true;
                    }
                }
                foreach (Folder dir in current.getAdj())
                {
                    fileQueue.Enqueue(dir);
                }
            }
                

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
    
}