using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dying_Light_Dev_Menu_To_Original
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            byte[] myfile = Properties.Resources.mod_Data3;
            File.WriteAllBytes(textBox1.Text + "\\Data3.pak", myfile);
            MessageBox.Show("The Game is now Modded!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            byte[] myfile = Properties.Resources.orig_Data3;
            File.WriteAllBytes(textBox1.Text + "\\Data3.pak", myfile);
            MessageBox.Show("The Game is now UnModded! You Can Now go online", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pictureBox1_Load(object sender, EventArgs e)
        {
            using (Stream imgStream = Assembly.GetExecutingAssembly()
               .GetManifestResourceStream(
               "Dying_Light_Dev_Menu_To_Original.Resources.banner.png"))
            {
                var image = new Bitmap(imgStream);
                pictureBox1.Image = image;
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program was made by Z3chs Army! I hope you enjoy it. :)");
        }
    }
}
