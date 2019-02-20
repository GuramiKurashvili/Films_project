using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films_project
{
    public partial class feedbk : Form
    {


        public feedbk()
        {
            InitializeComponent();
            Console.WriteLine(Main.ControlID.UserName);
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Texti, UN;
            Texti = richTextBox1.Text;
            UN = Main.ControlID.UserName;

            var context = new Films_dbEntities();


            using (Films_dbEntities db = new Films_dbEntities())
            {
                var user = db.Users.Where(x => x.Name.Equals(UN)).FirstOrDefault();

                var t = new Feedback //Make sure you have a table called test in DB
                {
                    UserID = user.ID,
                    Text = Texti,
                    UserName = UN
                };


                context.Feedbacks.Add(t);
                context.SaveChanges();

                this.Hide();
            }

        }
    }
}
