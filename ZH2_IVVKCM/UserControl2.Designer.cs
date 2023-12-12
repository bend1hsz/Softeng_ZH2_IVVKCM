namespace ZH2_IVVKCM
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTanulo = new ListBox();
            listRendelt = new ListBox();
            textTanulo = new TextBox();
            listKonyv = new ListBox();
            textKonyv = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listTanulo
            // 
            listTanulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listTanulo.FormattingEnabled = true;
            listTanulo.ItemHeight = 15;
            listTanulo.Location = new Point(13, 98);
            listTanulo.Name = "listTanulo";
            listTanulo.Size = new Size(199, 379);
            listTanulo.TabIndex = 0;
            listTanulo.SelectedIndexChanged += listTanulo_SelectedIndexChanged;
            // 
            // listRendelt
            // 
            listRendelt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listRendelt.FormattingEnabled = true;
            listRendelt.ItemHeight = 15;
            listRendelt.Location = new Point(218, 98);
            listRendelt.Name = "listRendelt";
            listRendelt.Size = new Size(207, 379);
            listRendelt.TabIndex = 1;
            listRendelt.SelectedIndexChanged += listRendelt_SelectedIndexChanged;
            // 
            // textTanulo
            // 
            textTanulo.Location = new Point(13, 60);
            textTanulo.Name = "textTanulo";
            textTanulo.Size = new Size(199, 23);
            textTanulo.TabIndex = 2;
            textTanulo.TextChanged += textTanulo_TextChanged;
            // 
            // listKonyv
            // 
            listKonyv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listKonyv.FormattingEnabled = true;
            listKonyv.ItemHeight = 15;
            listKonyv.Location = new Point(510, 98);
            listKonyv.Name = "listKonyv";
            listKonyv.Size = new Size(208, 379);
            listKonyv.TabIndex = 3;
            // 
            // textKonyv
            // 
            textKonyv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textKonyv.Location = new Point(510, 60);
            textKonyv.Name = "textKonyv";
            textKonyv.Size = new Size(208, 23);
            textKonyv.TabIndex = 4;
            textKonyv.TextChanged += textKonyv_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Location = new Point(431, 124);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(73, 69);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemove.Location = new Point(431, 373);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(73, 69);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "-";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textKonyv);
            Controls.Add(listKonyv);
            Controls.Add(textTanulo);
            Controls.Add(listRendelt);
            Controls.Add(listTanulo);
            Name = "UserControl2";
            Size = new Size(736, 527);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTanulo;
        private ListBox listRendelt;
        private TextBox textTanulo;
        private ListBox listKonyv;
        private TextBox textKonyv;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}
