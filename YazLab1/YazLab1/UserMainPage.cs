using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazLab1
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb; Integrated Security = true");

        void KitaplariGetir()
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("SELECT [ISBN],[Book-Title],[Book-Author],[Year-Of-Publication],[Publisher],[Image-URL-M] FROM ['BX-Books']", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void LastAdditionBring()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("SELECT top 5 [Book-Title],[Book-Author] FROM ['BX-Books'] ORDER BY [dd] DESC", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        void Popular()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("select top 20 SUM(['BX-Book-Ratings'].[Book-Rating]) as toplam_oy , ['BX-Books'].[Book-Title] from ['BX-Book-Ratings'] inner join['BX-Books'] on['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  group by['BX-Books'].[Book-Title]  order by toplam_oy desc", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();

        }
        void TopTen()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("select top 10 AVG(['BX-Book-Ratings'].[Book-Rating]) as ortalama_oy, ['BX-Books'].[Book-Title] from ['BX-Book-Ratings'] inner join ['BX-Books'] on ['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  group by['BX-Books'].[Book-Title]  order by ortalama_oy desc", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserMainPage_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = YazLab1; Integrated Security = true");
            KitaplariGetir();
            LastAdditionBring();
            Popular();
            TopTen();
        
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb; Integrated Security = true");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIsbn.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblBookTitle.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            lblBookAuthor.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            lblyop.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            lblPublisher.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
           
            pictureBox1.Load(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            // set file filter of dialog 

            dlg.Filter = "pdf files (08333696.pdf) |08333696.pdf;";

            dlg.ShowDialog();

            if (dlg.FileName != null)

            {

                // use the LoadFile(ByVal fileName As String) function for open the pdf in control

                axAcroPDF1.LoadFile(dlg.FileName);

            }


        }
    }
}
