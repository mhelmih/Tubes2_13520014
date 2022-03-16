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
        private string fileToSearch;
        private string rootPath;

        public Searching(string fileToSearch, string rootPath)
        {
            this.fileToSearch = fileToSearch;
            this.rootPath = rootPath;
        }

        public void BFS()
        {
            bool found = false;
            // string[] dirs = Directory.GetFileSystemEntries(rootPath);

            Queue<string> fileQueue = new Queue<string>();
            fileQueue.Enqueue(rootPath);

            // chek if queue is not empty
            while (fileQueue.Any() && !found)
            {
                string current = fileQueue.Dequeue();
                string[] files = Directory.GetFiles(current);
                if (files != null)
                {
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        if (String.Equals(fileToSearch, fileName))
                        {
                            Console.WriteLine("found");
                            found = true;
                            return;
                        }
                    }
                }
                string[] dirs = Directory.GetDirectories(current);
                if (dirs != null)
                {
                    foreach (string dir in dirs)
                    {
                        fileQueue.Enqueue(dir);
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("NOT found");
            }
            return;
        }
    }
}
