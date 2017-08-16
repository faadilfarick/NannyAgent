using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaryPoppins
{
    public partial class setMaxTasksLeft : Form
    {
        public int newMaxTasks = 0;
        public setMaxTasksLeft()
        {            
            InitializeComponent();            
        }

        //Set new Maximum no. of tasks per day
        public void setMaxTasksLeftButton_Click(object sender, EventArgs e)
        {     
            TheNannyAgent na = new TheNannyAgent();
            na.Hide();
            this.Hide();
            Nanny.setMaxTasksLeftcounter = Convert.ToInt16(numericUpDown1.Value);
            na.LabelText = "Tasks Left = " + Nanny.setMaxTasksLeftcounter;
            na.ShowDialog();
        }
        private void smtCloseButton_Click(object sender, EventArgs e)
        {
            TheNannyAgent na = new TheNannyAgent();
            this.Hide();
            na.ShowDialog();
        }
     
    }
}
