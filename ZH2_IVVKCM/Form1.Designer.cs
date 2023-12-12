namespace ZH2_IVVKCM
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
            buttonUC1 = new Button();
            buttonUC2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // buttonUC1
            // 
            buttonUC1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUC1.Location = new Point(763, 12);
            buttonUC1.Name = "buttonUC1";
            buttonUC1.Size = new Size(124, 97);
            buttonUC1.TabIndex = 0;
            buttonUC1.Text = "UserControl1";
            buttonUC1.UseVisualStyleBackColor = true;
            buttonUC1.Click += buttonUC1_Click;
            // 
            // buttonUC2
            // 
            buttonUC2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUC2.Location = new Point(763, 417);
            buttonUC2.Name = "buttonUC2";
            buttonUC2.Size = new Size(124, 97);
            buttonUC2.TabIndex = 1;
            buttonUC2.Text = "UserControl2";
            buttonUC2.UseVisualStyleBackColor = true;
            buttonUC2.Click += buttonUC2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 502);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 526);
            Controls.Add(panel1);
            Controls.Add(buttonUC2);
            Controls.Add(buttonUC1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUC1;
        private Button buttonUC2;
        private Panel panel1;
    }
}