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

    public partial class TheNannyAgent : Form
    {
        //Initial setup
        public TheNannyAgent()
        {
            setMaxTasksLeft smt = new setMaxTasksLeft();
            Nanny nn = new Nanny();

            Nanny.setMaxTasksLeftcounter = 10;
            InitializeComponent();
            nannysModeComboBox.SelectedIndex = 0;
            taskSelectionComboBox.SelectedIndex = 0;
            stateOfChildComboBox.SelectedIndex = 0;
            label5.Text = "Tasks Left = " + Nanny.setMaxTasksLeftcounter;

            if (Nanny.setMaxTasksLeftcounter <= 1)
            {
                proceedButton.Enabled = false;
                label5.Text = "Maximum Tasks per Day Reached, Nanny is tired. PLease start a new day!";
            }

        }
        public string LabelText
        {
            get
            {
                return this.label5.Text;
            }
            set
            {
                this.label5.Text = value;
            }
        }

        //Game Logic
        private void button1_Click(object sender, EventArgs e)
        {

            label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
            if (Nanny.setMaxTasksLeftcounter <= 1)
            {
                proceedButton.Enabled = false;
                label5.Text = "Maximum Tasks per Day Reached, Nanny is tired. PLease start a new day!";
            }
            Nanny.setMaxTasksLeftcounter--;
            string nannysMode = nannysModeComboBox.Text;
            string taskSelection = taskSelectionComboBox.Text;
            string stateOfChild = stateOfChildComboBox.Text;
            if (stateOfChild == "Awake")
            {
                if (taskSelection == "Feed Milk")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny fetches glass of milk!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.fetchesMilk;

                    }
                    else
                    {
                        label1.Text = ("Nanny fetches a glass of milk Angrily!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.fetchesMilk;
                    }
                }
                else if (taskSelection == "Take baby to sleep")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny makes baby sleep!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.makingBabySleep;
                    }
                    else
                    {
                        label1.Text = ("Nanny makes baby sleep Angrily!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.makingBabySleep;
                    }
                }
                else if (taskSelection == "Bath the Baby")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny bathing the Baby!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.bathingChild;
                    }
                    else
                    {
                        label1.Text = ("Nanny bathing the Baby Angrily!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.bathingChild;
                    }
                }
                else if (taskSelection == "Make Baby's Bed")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny makes baby's Bed!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.makingTheBed;
                    }
                    else
                    {
                        label1.Text = ("Nanny makes baby's Bed Angrily!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.makingTheBed;
                    }
                }
                else if (taskSelection == "Diaper the Baby")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny diapering the Baby!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.diaperBaby;
                    }
                    else
                    {
                        label1.Text = ("Nanny diapering the Baby Angrily!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.diaperBaby;
                    }
                }
            }
            else if (stateOfChild == "Asleep")
            {
                label1.Text = ("Baby is Asleep");
                mainDisplayPictureBox.BackgroundImage = Properties.Resources.sleepingChild;
            }
        }
        //Show UserManual
        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManual um = new UserManual();
            um.ShowDialog();
        }
        //Show About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void nannysModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display Nanny's mode
            if (nannysModeComboBox.SelectedIndex == 1)
            {
                nannyModePictureBox.BackgroundImage = Properties.Resources.NannyHappy;
            }
            else if (nannysModeComboBox.SelectedIndex == 2)
            {
                nannyModePictureBox.BackgroundImage = Properties.Resources.angryNanny;
            }
            //Enabling proceed button only if all the options are selected
            if ((nannysModeComboBox.SelectedIndex > 0) && (stateOfChildComboBox.SelectedIndex > 0)
                    && (taskSelectionComboBox.SelectedIndex > 0))
            {
                proceedButton.Enabled = true;
            }
            else
            {
                proceedButton.Enabled = false;
            }
        }

        private void taskSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stateOfChildComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Open New Day
        private void setNewMaxTasksPerDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            setMaxTasksLeft smt = new setMaxTasksLeft();            
            smt.ShowDialog();
            
        }
    }    
}
