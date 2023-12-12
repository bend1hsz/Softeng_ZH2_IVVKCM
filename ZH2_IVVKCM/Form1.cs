using ZH2_IVVKCM.Models;

namespace ZH2_IVVKCM
{
    public partial class Form1 : Form
    {
        TankonyvContext context = new TankonyvContext();
        UserControl1 uc1 = new UserControl1();
        UserControl2 uc2 = new UserControl2();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUC1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
            uc1.Size = panel1.Size;
            uc1.Dock = DockStyle.Fill;
        }

        private void buttonUC2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);
            uc2.Size = panel1.Size;
            uc2.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kilép = MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kilép == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}