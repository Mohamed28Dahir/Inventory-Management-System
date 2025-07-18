namespace SMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newStudentToolStripMenuItem = new ToolStripMenuItem();
            newParentToolStripMenuItem = new ToolStripMenuItem();
            newLectureToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem, servicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newStudentToolStripMenuItem, newParentToolStripMenuItem, newLectureToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newStudentToolStripMenuItem
            // 
            newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            newStudentToolStripMenuItem.Size = new Size(270, 34);
            newStudentToolStripMenuItem.Text = "New Student";
            newStudentToolStripMenuItem.Click += newStudentToolStripMenuItem_Click;
            // 
            // newParentToolStripMenuItem
            // 
            newParentToolStripMenuItem.Name = "newParentToolStripMenuItem";
            newParentToolStripMenuItem.Size = new Size(270, 34);
            newParentToolStripMenuItem.Text = "New Parent ";
            newParentToolStripMenuItem.Click += newParentToolStripMenuItem_Click;
            // 
            // newLectureToolStripMenuItem
            // 
            newLectureToolStripMenuItem.Name = "newLectureToolStripMenuItem";
            newLectureToolStripMenuItem.Size = new Size(270, 34);
            newLectureToolStripMenuItem.Text = "New Lecture";
            newLectureToolStripMenuItem.Click += newLectureToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(91, 29);
            servicesToolStripMenuItem.Text = "Services";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newStudentToolStripMenuItem;
        private ToolStripMenuItem newParentToolStripMenuItem;
        private ToolStripMenuItem newLectureToolStripMenuItem;
        private ToolStripMenuItem servicesToolStripMenuItem;
    }
}
