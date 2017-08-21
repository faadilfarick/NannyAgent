namespace MaryPoppins
{
    partial class TheNannyAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheNannyAgent));
            this.proceedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stateOfChildComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nannysModeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taskSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNewMaxTasksPerDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.nannyModePictureBox = new System.Windows.Forms.PictureBox();
            this.mainDisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nannyModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(460, 308);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(102, 61);
            this.proceedButton.TabIndex = 0;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 5;
            // 
            // stateOfChildComboBox
            // 
            this.stateOfChildComboBox.FormattingEnabled = true;
            this.stateOfChildComboBox.Items.AddRange(new object[] {
            "----Select----",
            "Asleep",
            "Awake"});
            this.stateOfChildComboBox.Location = new System.Drawing.Point(5, 25);
            this.stateOfChildComboBox.Name = "stateOfChildComboBox";
            this.stateOfChildComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateOfChildComboBox.TabIndex = 6;
            this.stateOfChildComboBox.SelectedIndexChanged += new System.EventHandler(this.stateOfChildComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "State of Child";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stateOfChildComboBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nannysModeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(306, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 61);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nanny\'s Mode";
            // 
            // nannysModeComboBox
            // 
            this.nannysModeComboBox.FormattingEnabled = true;
            this.nannysModeComboBox.Items.AddRange(new object[] {
            "----Select----",
            "Calm",
            "Angry"});
            this.nannysModeComboBox.Location = new System.Drawing.Point(4, 27);
            this.nannysModeComboBox.Name = "nannysModeComboBox";
            this.nannysModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.nannysModeComboBox.TabIndex = 0;
            this.nannysModeComboBox.SelectedIndexChanged += new System.EventHandler(this.nannysModeComboBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.taskSelectionComboBox);
            this.groupBox3.Location = new System.Drawing.Point(159, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 61);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Task Selection";
            // 
            // taskSelectionComboBox
            // 
            this.taskSelectionComboBox.FormattingEnabled = true;
            this.taskSelectionComboBox.Items.AddRange(new object[] {
            "----Select----",
            "Feed Milk",
            "Take Baby to Sleep",
            "Bath the Baby",
            "Make Baby\'s Bed",
            "Diaper the Baby",
            "Sing a Song",
            "Clean the Room",
            "Prepare baby\'s Meal"});
            this.taskSelectionComboBox.Location = new System.Drawing.Point(7, 26);
            this.taskSelectionComboBox.Name = "taskSelectionComboBox";
            this.taskSelectionComboBox.Size = new System.Drawing.Size(130, 21);
            this.taskSelectionComboBox.TabIndex = 0;
            this.taskSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.taskSelectionComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setNewMaxTasksPerDayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setNewMaxTasksPerDayToolStripMenuItem
            // 
            this.setNewMaxTasksPerDayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setNewMaxTasksPerDayToolStripMenuItem.Image")));
            this.setNewMaxTasksPerDayToolStripMenuItem.Name = "setNewMaxTasksPerDayToolStripMenuItem";
            this.setNewMaxTasksPerDayToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.setNewMaxTasksPerDayToolStripMenuItem.Text = "New Day";
            this.setNewMaxTasksPerDayToolStripMenuItem.Click += new System.EventHandler(this.setNewMaxTasksPerDayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(460, 374);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // nannyModePictureBox
            // 
            this.nannyModePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nannyModePictureBox.Location = new System.Drawing.Point(460, 252);
            this.nannyModePictureBox.Name = "nannyModePictureBox";
            this.nannyModePictureBox.Size = new System.Drawing.Size(93, 50);
            this.nannyModePictureBox.TabIndex = 16;
            this.nannyModePictureBox.TabStop = false;
            // 
            // mainDisplayPictureBox
            // 
            this.mainDisplayPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainDisplayPictureBox.Location = new System.Drawing.Point(15, 77);
            this.mainDisplayPictureBox.Name = "mainDisplayPictureBox";
            this.mainDisplayPictureBox.Size = new System.Drawing.Size(538, 225);
            this.mainDisplayPictureBox.TabIndex = 15;
            this.mainDisplayPictureBox.TabStop = false;
            // 
            // TheNannyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 403);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nannyModePictureBox);
            this.Controls.Add(this.mainDisplayPictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TheNannyAgent";
            this.Text = "The Nanny Agent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nannyModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stateOfChildComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nannysModeComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox taskSelectionComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox mainDisplayPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox nannyModePictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripMenuItem setNewMaxTasksPerDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

