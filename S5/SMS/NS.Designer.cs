namespace SMS
{
    partial class NS
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
            IDlabel = new Label();
            Addlabel = new Label();
            Nlabel = new Label();
            FNText = new MaskedTextBox();
            AddText = new MaskedTextBox();
            CLASSText = new MaskedTextBox();
            SHbutton = new Button();
            otlabel = new Label();
            SuspendLayout();
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(166, 56);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(68, 25);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "FName";
            // 
            // Addlabel
            // 
            Addlabel.AutoSize = true;
            Addlabel.Location = new Point(166, 101);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(77, 25);
            Addlabel.TabIndex = 1;
            Addlabel.Text = "Address";
            // 
            // Nlabel
            // 
            Nlabel.AutoSize = true;
            Nlabel.Location = new Point(166, 153);
            Nlabel.Name = "Nlabel";
            Nlabel.Size = new Size(52, 25);
            Nlabel.TabIndex = 2;
            Nlabel.Text = "Class";
            // 
            // FNText
            // 
            FNText.Location = new Point(278, 55);
            FNText.Name = "FNText";
            FNText.Size = new Size(283, 31);
            FNText.TabIndex = 4;
            // 
            // AddText
            // 
            AddText.Location = new Point(278, 102);
            AddText.Name = "AddText";
            AddText.Size = new Size(283, 31);
            AddText.TabIndex = 5;
            // 
            // CLASSText
            // 
            CLASSText.Location = new Point(278, 153);
            CLASSText.Name = "CLASSText";
            CLASSText.Size = new Size(283, 31);
            CLASSText.TabIndex = 6;
            // 
            // SHbutton
            // 
            SHbutton.Location = new Point(311, 214);
            SHbutton.Name = "SHbutton";
            SHbutton.Size = new Size(129, 50);
            SHbutton.TabIndex = 7;
            SHbutton.Text = "Show";
            SHbutton.UseVisualStyleBackColor = true;
            SHbutton.Click += SHbutton_Click;
            // 
            // otlabel
            // 
            otlabel.Location = new Point(166, 299);
            otlabel.Name = "otlabel";
            otlabel.Size = new Size(395, 129);
            otlabel.TabIndex = 8;
            otlabel.Click += label1_Click;
            // 
            // NS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(otlabel);
            Controls.Add(SHbutton);
            Controls.Add(CLASSText);
            Controls.Add(AddText);
            Controls.Add(FNText);
            Controls.Add(Nlabel);
            Controls.Add(Addlabel);
            Controls.Add(IDlabel);
            Name = "NS";
            Text = "NS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDlabel;
        private Label Addlabel;
        private Label Nlabel;
        private MaskedTextBox FNText;
        private MaskedTextBox AddText;
        private MaskedTextBox CLASSText;
        private Button SHbutton;
        private Label otlabel;
    }
}