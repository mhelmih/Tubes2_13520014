using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string dir;
        string filename;
        Boolean find_all;
        Boolean isDFS;
        Boolean isBFS;

        public Form1()
        {
            InitializeComponent();
            dir = "";
            filename = "";
            find_all = false;
            isDFS = false;
            isBFS = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            find_all = !find_all;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filename = filename_textbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void choose_folder_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directory.Text = diag.SelectedPath;
                dir = diag.SelectedPath;
            }
            else
            { directory.Text = "No Folder Chosen"; }
        }

        private void DFS_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BFS_button_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
