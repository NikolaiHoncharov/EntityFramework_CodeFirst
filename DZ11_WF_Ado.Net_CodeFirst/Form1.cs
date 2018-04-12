using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ11_WF_Ado.Net_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                bttnSearch.BackgroundImage = new Bitmap(@".../searxh.png");
                bttnSearch.Enabled = true;
            }
            else {
                bttnSearch.BackgroundImage = new Bitmap(@".../qwe.png");
                bttnSearch.Enabled = false;
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            using (AuthorContext db = new AuthorContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Authors.Where(a=>a.LastName==txtLastName.Text).ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            //using (AuthorContext db = new AuthorContext())
            //{
            //    List<Author> Auth = new List<Net_CodeFirst.Author> {
            //       new Author {FirstName = "Николай", LastName="Гончаров" },
            //       new Author { FirstName = "Леонид", LastName = "Андреев" },
            //       new Author {FirstName = "Борис", LastName="Акунин" },
            //       new Author { FirstName = "Айзек", LastName = "Азимов" },
            //       new Author {FirstName = "Андрей", LastName="Белый" },
            //       new Author { FirstName = "Джон", LastName = "Апдайк" },
            //       new Author {FirstName = "Виктор", LastName="Гончаров" },
            //       new Author { FirstName = "Виктор", LastName = "Астафьев" },
            //       new Author {FirstName = "Николай", LastName="Астафьев" }
            //       };
            //    db.Authors.AddRange(Auth);
            //    db.SaveChanges();
            //}

            }
        }
}
