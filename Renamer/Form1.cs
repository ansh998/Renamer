using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer
{
    public partial class Renamer : Form
    {

        TreeNode mn = new TreeNode();
        public Renamer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            files.Nodes.Remove(mn);
            if (path.Text.Length == 0)
            {
                DialogResult res = fbd1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    path.Text = fbd1.SelectedPath;
                }
            }
            else
            {
                string[] fi = Directory.GetFiles(path.Text);
                mn = files.Nodes.Add(path.Text);
                for (int i = 0; i < fi.Length; i++)
                {

                    if (Path.GetExtension(fi[i]).Equals(".mp3"))
                    {
                        files.Nodes[0].Nodes.Add(Path.GetFileName(fi[i]));
                    }
                }
            }
        }

        private void ren_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(path.Text);
            FileInfo[] info = d.GetFiles("*.mp3");
            foreach (FileInfo f in info)
            {
                String na = f.Name;
                System.IO.File.Move(path.Text + "\\" + na, path.Text + "\\" + na.Substring(4));
            }
            this.button1_Click(sender, e);
        }

        private void path_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.button1_Click(sender, e);
            }
        }
    }
}
