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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {

            Main mn = new Main();
            string NM,Gnr;
            NM= NameField.Text;
            Gnr = GenreField.Text;

            String Mrk;

            Mrk = MarkField.Text;

            var context = new Films_dbEntities();

            var t = new Film //Make sure you have a table called test in DB
            {
                Name = NM,
                Mark = Mrk,
                Genre = Gnr
            };

            context.Films.Add(t);
            context.SaveChanges();


            NameField.ResetText();
            GenreField.ResetText();
            MarkField.ResetText();

            var form = new Main();
            form.Refresh();

            mn.loadTable();

            MessageBox.Show("Film " + NM + " is added");
        }

        private void insert_Load(object sender, EventArgs e)
        {

        }
    }
}
