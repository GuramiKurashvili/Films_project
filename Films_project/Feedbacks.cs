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
    public partial class Feedbacks : Form
    {
        public Feedbacks()
        {
            InitializeComponent();
            loadTable();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].Visible = false;
        }

        public static IQueryable<Feedback> Get()
        {
            var context1 = new Films_dbEntities();

            return context1.Feedbacks;
        }

        public void loadTable()
        {


            var result = Get();
            List<Feedback> ss = result.ToList();

            dataGridView.DataSource = ss;


        }

        private void Feedbacks_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
