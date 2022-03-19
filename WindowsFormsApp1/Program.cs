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
            string root = @"D:\OneDrive - Institut Teknologi Bandung\Semester 4\Algorithm Strategy";
            string fileToSearch = @"BFS-DFS-2021-Bag2";
            Searching search = new Searching(root, fileToSearch);
            search.DFS();

            folderGraph fg = new folderGraph();
            fg.generateGraph(root, search);
            fg.showGraph();

        }

    }
}
