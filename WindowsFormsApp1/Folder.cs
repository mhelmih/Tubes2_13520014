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
}

