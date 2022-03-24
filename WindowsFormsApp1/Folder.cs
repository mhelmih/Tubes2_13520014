using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Folder
    {
        private string[] listFile; // List all file from current folder
        private string[] listFolder; // List all folder from current folder

        private String dirName; // String of directory of current folder
        private Folder parent; // Parent folder from current folder
        private List<Folder> adjFolder; // turing listFolder to List of Folder type
        Boolean visited; // boolean for visited or not

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
            this.dirName = root;
            this.listFile = Directory.GetFiles(root);
            this.listFolder = Directory.GetDirectories(root);
            this.adjFolder = new List<Folder>();
            this.parent = null;
            foreach (string i in listFolder)
            {
                this.adjFolder.Add(new Folder(this, i));

            }

        }

        public Folder(Folder parent, string str)
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
        // setter
        public void setVisited(Boolean val)
        {
            this.visited = val;
        }
        // getter
        public string[] getAllDir()
        {
            return this.listFolder;
        }

        // getter
        public string[] getAllFiles()
        {
            return this.listFile;
        }

        // setter
        public List<Folder> getAdj()
        {
            return this.adjFolder;
        }

        // getter
        public Boolean getVisited()
        {
            return this.visited;
        }

        // getter
        public String getDirname()
        {
            return this.dirName;
        }

        // getter
        public Folder getParent()
        {
            return this.parent;
        }

        // return true if folder contains right file
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

        // return full path from given filename
        public string getFilePath(string filename)
        {
            string temp = "";
            int i = 0;
            Boolean flag = false;
            while (i < listFile.Length && !flag)
            {
                if (Path.GetFileName(listFile[i]).Equals(filename))
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
}

