using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films_project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            PswField.PasswordChar = '*';
        }

        private void Upload_Click(object sender, EventArgs e)
        {

            string Nm, PSW;
            Nm = NameField.Text;
            PSW = PswField.Text;


            using (Films_dbEntities db = new Films_dbEntities())
            {
                var user = db.Users.Where(x => x.Name.Equals(Nm) && x.Password.Equals(PSW)).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Sign In Succesfully");

                    this.Hide();


                    Main.ControlID.UserName = Nm;

                    var form2 = new Main();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("password or Email is incorrect");
                    NameField.ResetText();
                    PswField.ResetText();
                }
            }

            
        }

        private void reg_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Registration()));
            t.Start();
            this.Close();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
