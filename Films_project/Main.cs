using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films_project
{
    public partial class Main : Form
    {

        public class PostDto
        {
            public string PostTitle { get; set; }
        }


        public Main()
        {
            InitializeComponent();
            loadTable();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.AllowUserToOrderColumns = true;
            var context = new Films_dbEntities();


            var posts = context.Users
                       .Where(p => p.Admin == 1);

            var query = posts.ToList();


            foreach (var nm in query)
            {

                if (!string.Equals(ControlID.UserName, nm.Name))
                {
                    Delete.Visible = false;
                    Insert.Visible = false;
                    FeedBacks.Visible = false;
                    UpdateButton.Visible = false;

                    dataGridView.ReadOnly = true;
                }
                else
                {
                    Delete.Visible = true;
                    Insert.Visible = true;
                    FeedBack.Visible = false;
                }
            }

        }


        public static class ControlID
        {
            public static string UserName { get; set; }
        }



        //public static IQueryable<Film> Get()
        //{
        //    var context1 = new Films_dbEntities();

        //    return context1.Films ;
        //}
        int page = 0, PageCount;
        public void loadTable()
        {
            using (Films_dbEntities db = new Films_dbEntities())
            {
                var result = from Films in db.Films
                             select Films;


                dataGridView.DataSource = result.OrderBy(x => x.ID).Skip(5*page).Take(5).ToList();

                int Count = result.ToList().Count();
                PageCount = Count / 5;

                if (Count % 5 > 0)
                    PageCount = PageCount + 1;

                PageLabel.Text = page + 1 + "/" + PageCount;

            }

            //var result = Get();
            //List<Film> FilmList = result.ToList();

        }


        private void plus_Click(object sender, EventArgs e)
        {
            if(page >= 0 && page+1 < PageCount)
                page = page + 1;



            loadTable();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (page > 0)
                page = page - 1;


            loadTable();
        }


        private void OnButton1Click(object sender, EventArgs e)
        {
            
            var form2 = new feedbk();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new insert()));
            t.Start();
        }


        String RowName;

        public void CellName(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow seelectedRow = dataGridView.Rows[index];
    
            RowName = seelectedRow.Cells[1].Value.ToString();


        }

        public void Delete_Click1(object sender, EventArgs e)
        {

            var Context = new Films_dbEntities();
            var itemToRemove = Context.Films.SingleOrDefault(x => x.Name == RowName); 

            if (itemToRemove != null)
            {
                Context.Films.Remove(itemToRemove);
                Context.SaveChanges();


                loadTable();
                MessageBox.Show(RowName + "is deleted");
            }
        }

        private void Update(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Update(RowName)));
            t.Start();
        }

        private void FeedBacks_Click(object sender, EventArgs e)
        {

            var t = new Thread(() => Application.Run(new Feedbacks()));
            t.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var t = new Thread(() => Application.Run(new Main()));
            //t.Start();
            loadTable();
        }
    }
}
