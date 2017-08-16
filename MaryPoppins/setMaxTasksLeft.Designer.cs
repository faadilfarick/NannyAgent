namespace MaryPoppins
{
    partial class setMaxTasksLeft
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.setMaxTasksLeftButton = new System.Windows.Forms.Button();
            this.smtCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(34, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // setMaxTasksLeftButton
            // 
            this.setMaxTasksLeftButton.Location = new System.Drawing.Point(220, 49);
            this.setMaxTasksLeftButton.Name = "setMaxTasksLeftButton";
            this.setMaxTasksLeftButton.Size = new System.Drawing.Size(75, 23);
            this.setMaxTasksLeftButton.TabIndex = 1;
            this.setMaxTasksLeftButton.Text = "Set";
            this.setMaxTasksLeftButton.UseVisualStyleBackColor = true;
            this.setMaxTasksLeftButton.Click += new System.EventHandler(this.setMaxTasksLeftButton_Click);
            // 
            // smtCloseButton
            // 
            this.smtCloseButton.Location = new System.Drawing.Point(333, 49);
            this.smtCloseButton.Name = "smtCloseButton";
            this.smtCloseButton.Size = new System.Drawing.Size(75, 23);
            this.smtCloseButton.TabIndex = 2;
            this.smtCloseButton.Text = "Cancel";
            this.smtCloseButton.UseVisualStyleBackColor = true;
            this.smtCloseButton.Click += new System.EventHandler(this.smtCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set New Maximum number of tasks the Nanny can do per day";
            // 
            // setMaxTasksLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smtCloseButton);
            this.Controls.Add(this.setMaxTasksLeftButton);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "setMaxTasksLeft";
            this.Text = "Start New Day";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button setMaxTasksLeftButton;
        private System.Windows.Forms.Button smtCloseButton;
        private System.Windows.Forms.Label label1;
    }
}