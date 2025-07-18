namespace SMS
{
    partial class NL
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
            NumText = new MaskedTextBox();
            AddText = new MaskedTextBox();
            FNText = new MaskedTextBox();
            Nlabel = new Label();
            FNlabel = new Label();
            FNabel = new Label();
            Sublabel = new Label();
            SubText = new MaskedTextBox();
            otlabel = new Label();
            SHbutton = new Button();
            SuspendLayout();
            // 
            // NumText
            // 
            NumText.Location = new Point(276, 163);
            NumText.Name = "NumText";
            NumText.Size = new Size(283, 31);
            NumText.TabIndex = 12;
            // 
            // AddText
            // 
            AddText.Location = new Point(276, 112);
            AddText.Name = "AddText";
            AddText.Size = new Size(283, 31);
            AddText.TabIndex = 11;
            // 
            // FNText
            // 
            FNText.Location = new Point(276, 65);
            FNText.Name = "FNText";
            FNText.Size = new Size(283, 31);
            FNText.TabIndex = 10;
            // 
            // Nlabel
            // 
            Nlabel.AutoSize = true;
            Nlabel.Location = new Point(164, 163);
            Nlabel.Name = "Nlabel";
            Nlabel.Size = new Size(77, 25);
            Nlabel.TabIndex = 9;
            Nlabel.Text = "Number";
            // 
            // FNlabel
            // 
            FNlabel.AutoSize = true;
            FNlabel.Location = new Point(164, 111);
            FNlabel.Name = "FNlabel";
            FNlabel.Size = new Size(77, 25);
            FNlabel.TabIndex = 8;
            FNlabel.Text = "Address";
            // 
            // FNabel
            // 
            FNabel.AutoSize = true;
            FNabel.Location = new Point(164, 66);
            FNabel.Name = "FNabel";
            FNabel.Size = new Size(68, 25);
            FNabel.TabIndex = 7;
            FNabel.Text = "FName";
            // 
            // Sublabel
            // 
            Sublabel.AutoSize = true;
            Sublabel.Location = new Point(164, 224);
            Sublabel.Name = "Sublabel";
            Sublabel.Size = new Size(70, 25);
            Sublabel.TabIndex = 13;
            Sublabel.Text = "Subject";
            // 
            // SubText
            // 
            SubText.Location = new Point(276, 218);
            SubText.Name = "SubText";
            SubText.Size = new Size(283, 31);
            SubText.TabIndex = 14;
            // 
            // otlabel
            // 
            otlabel.Location = new Point(165, 352);
            otlabel.Name = "otlabel";
            otlabel.Size = new Size(422, 87);
            otlabel.TabIndex = 15;
            // 
            // SHbutton
            // 
            SHbutton.Location = new Point(314, 275);
            SHbutton.Name = "SHbutton";
            SHbutton.Size = new Size(129, 50);
            SHbutton.TabIndex = 16;
            SHbutton.Text = "Show";
            SHbutton.UseVisualStyleBackColor = true;
            SHbutton.Click += SHbutton_Click;
            // 
            // NL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SHbutton);
            Controls.Add(otlabel);
            Controls.Add(SubText);
            Controls.Add(Sublabel);
            Controls.Add(NumText);
            Controls.Add(AddText);
            Controls.Add(FNText);
            Controls.Add(Nlabel);
            Controls.Add(FNlabel);
            Controls.Add(FNabel);
            Name = "NL";
            Text = "NL";
            Load += NL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox NumText;
        private MaskedTextBox AddText;
        private MaskedTextBox FNText;
        private Label Nlabel;
        private Label FNlabel;
        private Label FNabel;
        private Label Sublabel;
        private MaskedTextBox SubText;
        private Label otlabel;
        private Button SHbutton;
    }
}