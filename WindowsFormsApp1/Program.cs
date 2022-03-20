using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            string root = @"C:\Users\mfaja\Desktop\Cobain";
            string fileToSearch = @"jaja.txt";
            Searching search = new Searching(root, fileToSearch, false);
            search.BFS();
            for (int i = 0; i < search.getFilePath().Count; i++)
            {
                Console.WriteLine(search.getFilePath()[i]);
            }
            Folder a = new Folder(root);
            folderGraph fg = new folderGraph();
            fg.generateGraph(a, search);
            fg.showGraph();

        }

    }
}
