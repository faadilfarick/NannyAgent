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
            string nannysMode = nannysModeComboBox.Text;
            string taskSelection = taskSelectionComboBox.Text;
            string stateOfChild = stateOfChildComboBox.Text;
            if (stateOfChild == "Awake")
            {
                if (taskSelection == "Feed Milk")
                {
                    label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                    Nanny.setMaxTasksLeftcounter--;
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
                    label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                    Nanny.setMaxTasksLeftcounter--;
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
                    label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                    Nanny.setMaxTasksLeftcounter--;
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
                    label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                    Nanny.setMaxTasksLeftcounter--;
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
                    label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                    Nanny.setMaxTasksLeftcounter--;
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
                else if (taskSelection == "Sing a Song")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny sings a song!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.singingNanny;
                        label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                        Nanny.setMaxTasksLeftcounter--;
                    }
                    else
                    {
                        label1.Text = ("Nanny is Angry, She will not sing");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                    }
                }
                else if (taskSelection == "Clean the Room")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny cleans the Room!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.cleaningNanny;
                        label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                        Nanny.setMaxTasksLeftcounter--;
                    }
                    else
                    {
                        label1.Text = ("Nanny is angry,she will not clean the room!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                    }
                }
                else if (taskSelection == "Prepare baby's Meal")
                {
                    if (nannysMode == "Calm")
                    {
                        label1.Text = ("Nanny prepares baby's Meals!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.cookingNanny;
                        label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                        Nanny.setMaxTasksLeftcounter--;
                    }
                    else
                    {
                        label1.Text = ("Nanny is angry, She will not cook!");
                        mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                    }
                }

                if (Nanny.setMaxTasksLeftcounter <= 1)
                {
                    proceedButton.Enabled = false;
                    label5.Text = "Maximum Tasks per Day Reached, Nanny is tired. PLease start a new day!";
                }
            }
            else if (stateOfChild == "Asleep")
            {

                if(taskSelection == "Feed Milk" || taskSelection == "Take baby to sleep" || taskSelection == "Bath the Baby" 
                        || taskSelection == "Make Baby's Bed" || taskSelection == "Diaper the Baby")
                {
                    label1.Text = ("Baby is Asleep, Please select a different task");
                    mainDisplayPictureBox.BackgroundImage = Properties.Resources.sleepingChild;

                }
                else
                {
                    if (taskSelection == "Sing a Song")
                    {
                        if (nannysMode == "Calm")
                        {
                            label1.Text = ("Nanny sings a song!");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.singingNanny;
                            label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                            Nanny.setMaxTasksLeftcounter--;
                        }
                        else
                        {
                            label1.Text = ("Nanny is Angry, She will not sing");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                        }
                    }
                    if (taskSelection == "Clean the Room")
                    {
                        if (nannysMode == "Calm")
                        {
                            label1.Text = ("Nanny cleans the Room!");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.cleaningNanny;
                            label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                            Nanny.setMaxTasksLeftcounter--;
                        }
                        else
                        {
                            label1.Text = ("Nanny is angry,she will not clean the room!");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                        }
                    }
                    if (taskSelection == "Prepare baby's Meal")
                    {
                        if (nannysMode == "Calm")
                        {
                            label1.Text = ("Nanny prepares baby's Meals!");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.cookingNanny;
                            label5.Text = "Tasks Left = " + (Nanny.setMaxTasksLeftcounter - 1);
                            Nanny.setMaxTasksLeftcounter--;
                        }
                        else
                        {
                            label1.Text = ("Nanny is angry, She will not cook!");
                            mainDisplayPictureBox.BackgroundImage = Properties.Resources.angryNanny;
                        }
                    }
                }
                if (Nanny.setMaxTasksLeftcounter <= 1)
                {
                    proceedButton.Enabled = false;
                    label5.Text = "Maximum Tasks per Day Reached, Nanny is tired. PLease start a new day!";
                }

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
            //Hide unwanted items according to childs state
            if (stateOfChildComboBox.SelectedIndex == 1)
            {
                taskSelectionComboBox.Items.Remove("Feed Milk");
                taskSelectionComboBox.Items.Remove("Take Baby to Sleep");
                taskSelectionComboBox.Items.Remove("Bath the Baby");
                taskSelectionComboBox.Items.Remove("Make Baby's Bed");
                taskSelectionComboBox.Items.Remove("Diaper the Baby");
            }
            if(stateOfChildComboBox.SelectedIndex == 0 || stateOfChildComboBox.SelectedIndex == 2)
            {
                //Restoring the removed items once the childs' state changed
                if (!taskSelectionComboBox.Items.Contains("Feed Milk"))
                {
                    taskSelectionComboBox.Items.Add("Feed Milk");
                }
                if (!taskSelectionComboBox.Items.Contains("Take Baby to Sleep"))
                {
                    taskSelectionComboBox.Items.Add("Take Baby to Sleep");
                }
                if (!taskSelectionComboBox.Items.Contains("Bath the Baby"))
                {
                    taskSelectionComboBox.Items.Add("Bath the Baby");
                }
                if (!taskSelectionComboBox.Items.Contains("Make Baby's Bed"))
                {
                    taskSelectionComboBox.Items.Add("Make Baby's Bed");
                }
                if (!taskSelectionComboBox.Items.Contains("Diaper the Baby"))
                {
                    taskSelectionComboBox.Items.Add("Diaper the Baby");
                }

            }

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
