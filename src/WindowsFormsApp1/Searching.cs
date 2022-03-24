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
        private bool isAllOccurence; // Flag for all occurance or not
        private string fileToSearch; // String of searched fileName
        private string rootPath; // String of rootpath for starting search
        
        private List<String> filePath; // List of file path
        private List<String> rightPath; // list of right path from folder to root
        private List<String> visitedPath; // list of visitedPath of visited folder when searching


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
            Stack<Folder> folderStack;
            List<Folder> adjacentFolders;
            Folder rootFolder, currentFolder;
            Boolean found;

            rootFolder = new Folder(this.rootPath);
            folderStack = new Stack<Folder>();
            found = false;

            // push folder root to stack
            folderStack.Push(rootFolder);
            // check if stack contains any folder
            while (folderStack.Count > 0 && (!found || isAllOccurence))
            {
                // Pop currentFolder from stack
                currentFolder = folderStack.Pop();
                visitedPath.Add(currentFolder.getDirname());
                        
                // Check file in folder
                if (currentFolder.checkFile(fileToSearch))
                {
                    generatePath(currentFolder);
                    filePath.Add(currentFolder.getFilePath(fileToSearch));
                    found = true;
                }
                    
                // *optional : Reverse list (only for visualization matter)
                adjacentFolders = currentFolder.getAdj();
                adjacentFolders.Reverse();
                foreach (Folder adjacentFolder in adjacentFolders)
                {
                    // Push adjecency folder to stack
                    folderStack.Push(adjacentFolder);
                }

            }
        }

        public void BFS()
        {
            Queue<Folder> folderQueue;
            List<Folder> adjacentFolders;
            Folder rootFolder, currentFolder;
            bool found;

            folderQueue = new Queue<Folder>();
            rootFolder = new Folder(this.rootPath);
            found = false;

            // enqueue folder root to queue
            folderQueue.Enqueue(rootFolder);
            // chek if queue is not empty
            while (folderQueue.Any() && (!found || isAllOccurence))
            {
                currentFolder = folderQueue.Dequeue();
                visitedPath.Add(currentFolder.getDirname());
                
                // check if current folder contains file name that we search
                if (currentFolder.checkFile(fileToSearch))
                {
                    filePath.Add(currentFolder.getFilePath(fileToSearch));
                    generatePath(currentFolder);
                    found = true;
                }
                
                adjacentFolders = currentFolder.getAdj();
                // enqueue all adjacent folders of current folder
                foreach (Folder adjacentFolder in adjacentFolders)
                {
                    folderQueue.Enqueue(adjacentFolder);
                }

            }
                

        }


        public List<String> getFilePath()
        // Get List of file path
        {
            return this.filePath;
        }

        public List<String> getRightPath()
        // Get List of Right path from root to file
        {
            return this.rightPath;
        }

        public List<String> getVisitedPath()
        // Get List of visited path
        {
            return this.visitedPath;
        }

        public void generatePath(Folder rightDir)
        // Generate right path from file to root
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