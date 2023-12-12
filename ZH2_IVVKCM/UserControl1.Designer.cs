namespace ZH2_IVVKCM
{
    partial class UserControl1
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
            listStudent = new ListBox();
            dataGridView1 = new DataGridView();
            textStudent = new TextBox();
            textOsszertek = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listStudent
            // 
            listStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listStudent.FormattingEnabled = true;
            listStudent.ItemHeight = 15;
            listStudent.Location = new Point(18, 102);
            listStudent.Name = "listStudent";
            listStudent.Size = new Size(207, 349);
            listStudent.TabIndex = 0;
            listStudent.SelectedIndexChanged += listStudent_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(478, 349);
            dataGridView1.TabIndex = 1;
            // 
            // textStudent
            // 
            textStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textStudent.Location = new Point(18, 73);
            textStudent.Name = "textStudent";
            textStudent.Size = new Size(207, 23);
            textStudent.TabIndex = 2;
            textStudent.TextChanged += textStudent_TextChanged;
            // 
            // textOsszertek
            // 
            textOsszertek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textOsszertek.Location = new Point(372, 73);
            textOsszertek.Name = "textOsszertek";
            textOsszertek.Size = new Size(155, 23);
            textOsszertek.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(243, 76);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "&Rendelések összértéke";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(textOsszertek);
            Controls.Add(textStudent);
            Controls.Add(dataGridView1);
            Controls.Add(listStudent);
            Name = "UserControl1";
            Size = new Size(741, 534);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listStudent;
        private DataGridView dataGridView1;
        private TextBox textStudent;
        private TextBox textOsszertek;
        private Label label1;
    }
}
