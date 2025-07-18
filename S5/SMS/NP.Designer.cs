namespace SMS
{
    partial class NP
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
            SHbutton = new Button();
            otlabel = new Label();
            NumText = new MaskedTextBox();
            AddText = new MaskedTextBox();
            FNText = new MaskedTextBox();
            Nlabel = new Label();
            FNlabel = new Label();
            FNabel = new Label();
            SuspendLayout();
            // 
            // SHbutton
            // 
            SHbutton.Location = new Point(338, 207);
            SHbutton.Name = "SHbutton";
            SHbutton.Size = new Size(129, 50);
            SHbutton.TabIndex = 26;
            SHbutton.Text = "Show";
            SHbutton.UseVisualStyleBackColor = true;
            SHbutton.Click += SHbutton_Click;
            // 
            // otlabel
            // 
            otlabel.Location = new Point(189, 284);
            otlabel.Name = "otlabel";
            otlabel.Size = new Size(422, 87);
            otlabel.TabIndex = 25;
            // 
            // NumText
            // 
            NumText.Location = new Point(301, 136);
            NumText.Name = "NumText";
            NumText.Size = new Size(283, 31);
            NumText.TabIndex = 22;
            // 
            // AddText
            // 
            AddText.Location = new Point(301, 85);
            AddText.Name = "AddText";
            AddText.Size = new Size(283, 31);
            AddText.TabIndex = 21;
            // 
            // FNText
            // 
            FNText.Location = new Point(301, 38);
            FNText.Name = "FNText";
            FNText.Size = new Size(283, 31);
            FNText.TabIndex = 20;
            // 
            // Nlabel
            // 
            Nlabel.AutoSize = true;
            Nlabel.Location = new Point(189, 136);
            Nlabel.Name = "Nlabel";
            Nlabel.Size = new Size(77, 25);
            Nlabel.TabIndex = 19;
            Nlabel.Text = "Number";
            // 
            // FNlabel
            // 
            FNlabel.AutoSize = true;
            FNlabel.Location = new Point(189, 84);
            FNlabel.Name = "FNlabel";
            FNlabel.Size = new Size(77, 25);
            FNlabel.TabIndex = 18;
            FNlabel.Text = "Address";
            // 
            // FNabel
            // 
            FNabel.AutoSize = true;
            FNabel.Location = new Point(189, 39);
            FNabel.Name = "FNabel";
            FNabel.Size = new Size(68, 25);
            FNabel.TabIndex = 17;
            FNabel.Text = "FName";
            // 
            // NP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SHbutton);
            Controls.Add(otlabel);
            Controls.Add(NumText);
            Controls.Add(AddText);
            Controls.Add(FNText);
            Controls.Add(Nlabel);
            Controls.Add(FNlabel);
            Controls.Add(FNabel);
            Name = "NP";
            Text = "NP";
            Load += NP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SHbutton;
        private Label otlabel;
        private MaskedTextBox NumText;
        private MaskedTextBox AddText;
        private MaskedTextBox FNText;
        private Label Nlabel;
        private Label FNlabel;
        private Label FNabel;
    }
}