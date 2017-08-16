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

namespace MaryPoppins
{
    public partial class UserManual : Form
    {  
        public UserManual()
        {
            //SetTasksLeft.MyProperty = 10;
            InitializeComponent();
            string userManualPath = Path.Combine(Application.StartupPath, "userManual.txt");

            richTextBox1.Text = File.ReadAllText(userManualPath);
            richTextBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
