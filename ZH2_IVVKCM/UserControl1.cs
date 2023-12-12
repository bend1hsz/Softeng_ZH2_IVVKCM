using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_IVVKCM.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZH2_IVVKCM
{
    public partial class UserControl1 : UserControl
    {
        TankonyvContext context = new TankonyvContext();
        public UserControl1()
        {
            InitializeComponent();
            BackColor = Color.Blue;
            listStudent.DisplayMember = "Name";
            ListStudent();
        }

        private void ListStudent()
        {
            listStudent.DataSource = (from s in context.Student
                                      where s.Name.Contains(textStudent.Text)
                                      select s).ToList();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textStudent_TextChanged(object sender, EventArgs e)
        {
            ListStudent();
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listáz = from x in context.Order
                         join y in context.Student on x.StudentFk equals y.StudentId
                         join z in context.Textbook on x.TextbookFk equals z.TextbookId
                         where y.Name.Contains(listStudent.Text)
                         select new
                         {
                             Rendelésszám = x.OrderSk,
                             Név = y.Name,
                             Könyvcím = z.Title,
                             Ár = z.Price
                         };

            double? összérték = (from x in listáz
                                 select x.Ár).Sum();
            textOsszertek.Text = összérték.ToString();
            dataGridView1.DataSource = listáz.ToList();
        }
    }
}
