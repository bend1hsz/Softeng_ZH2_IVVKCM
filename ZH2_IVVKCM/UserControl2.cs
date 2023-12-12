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

namespace ZH2_IVVKCM
{
    public partial class UserControl2 : UserControl
    {
        TankonyvContext context = new TankonyvContext();
        public UserControl2()
        {
            InitializeComponent();
            BackColor = Color.Fuchsia;
            listTanulo.DisplayMember = "Name";
            listKonyv.DisplayMember = "Title";
            listRendelt.DisplayMember = "Title";

            listRendelt.ValueMember = "OrderSK";
            TanuloListazas();
            KonyvListazas();
            RendelesListazas();
        }

        private void RendelesListazas()
        {
            Student tanulo = (Student)listTanulo.SelectedItem;
            var rendel = from y in context.Order
                         join z in context.Textbook on y.TextbookFk equals z.TextbookId
                         where y.StudentFk == tanulo.StudentId
                         select new
                         {
                             z.Title
                         };
            listRendelt.DataSource = rendel.ToList();
        }

        private void KonyvListazas()
        {
            listKonyv.DataSource = (from x in context.Textbook
                                    where x.Title.Contains(textKonyv.Text)
                                    select x).ToList();
        }

        private void TanuloListazas()
        {
            listTanulo.DataSource = (from s in context.Student
                                     where s.Name.Contains(textTanulo.Text)
                                     select s).ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void textTanulo_TextChanged(object sender, EventArgs e)
        {
            TanuloListazas();

        }

        private void textKonyv_TextChanged(object sender, EventArgs e)
        {
            KonyvListazas();
        }

        private void listRendelt_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }

        private void listTanulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }
    }
}
