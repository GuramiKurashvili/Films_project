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
    public partial class Update : Form
    {
        String NameObj;
        public Update(String name)
        {
            InitializeComponent();
            NameObj = name;

            loadData();
        }

        public void loadData()
        {
            using (Films_dbEntities db = new Films_dbEntities())
            {
                var films = db.Films.Where(x => x.Name.Equals(NameObj)).FirstOrDefault();
                if (films != null)
                {
                    NameField.Text = NameObj;
                    MarkField.Text = films.Mark;
                    GenreField.Text = films.Genre;

                }
            }
        }


            private void Upload_Click(object sender, EventArgs e)
        {
            using (Films_dbEntities db = new Films_dbEntities())
            {
                var result = db.Films.SingleOrDefault(b => b.Name == NameObj);
                if (result != null)
                {
                    result.Name = NameField.Text;
                    result.Mark = MarkField.Text;
                    result.Genre = GenreField.Text;
                    db.SaveChanges();

                    MessageBox.Show("Film " + NameField.Text + " is Updated");
                    this.Hide();
                }
            }
        }
    }
}
