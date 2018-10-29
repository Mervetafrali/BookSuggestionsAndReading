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
using System.Diagnostics;

namespace YazLab1
{
    public partial class UserMainPage : Form
    {
        public string id;
        public class topten
        {
            public string booktitle;
            public string bookauthor;
        }
        public class popular
        {
            public string booktitle;
            public string bookauthor;
        }
        public class last
        {
            public string booktitle;
            public string bookauthor;
        }
        public class SeninOyladıkların
        {
            public string booktitle;
            public string busr;
            
        }
        public class Oneri
        {
            public string booktitle;
        }
        public UserMainPage()
        {
            InitializeComponent();
        }
        Label[] _Labels = new Label[20];
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
            List<last> last = new List<last>();
            SqlDataReader myReader = null;
            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                last f = new last();
                //düzenlenecek
                f.bookauthor = (myReader["Book-Author"].ToString());
                f.booktitle = (myReader["Book-Title"].ToString());
                last.Add(f);

            }
            baglanti.Close();
            for (int i = 0; i < 5; i++)
            {
                label54.Text = last[0].booktitle.ToString();
                label55.Text = last[0].bookauthor.ToString();
                label56.Text = last[1].booktitle.ToString();
                label57.Text = last[1].bookauthor.ToString();
                label58.Text = last[2].booktitle.ToString();
                label59.Text = last[2].bookauthor.ToString();
                label50.Text = last[3].booktitle.ToString();
                label51.Text = last[3].bookauthor.ToString();
                label52.Text = last[4].booktitle.ToString();
                label53.Text = last[4].bookauthor.ToString();
            }

            
            baglanti.Close();
        }
        void Popular()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("select top 10 count(['BX-Book-Ratings'].[Book-Rating]) as kac_kisi_oyladi, ['BX-Books'].[Book-Title] from ['BX-Book-Ratings'] inner join['BX-Books'] on ['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  group by['BX-Books'].[Book-Title]  order by kac_kisi_oyladi desc", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            List<popular> popular = new List<popular>();
            SqlDataReader myReader = null;
            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                popular f = new popular();
                //düzenlenecek
                f.booktitle = (myReader["kac_kisi_oyladi"].ToString());
                f.bookauthor = (myReader["Book-Title"].ToString());
                popular.Add(f);

            }
                baglanti.Close();
            
                label29.Text = popular[0].booktitle.ToString();
                label30.Text = popular[0].bookauthor.ToString();
                label31.Text = popular[1].booktitle.ToString();
                label32.Text = popular[1].bookauthor.ToString();
                label33.Text = popular[2].booktitle.ToString();
                label34.Text = popular[2].bookauthor.ToString();
                label35.Text = popular[3].booktitle.ToString();
                label36.Text = popular[3].bookauthor.ToString();
                label37.Text = popular[4].booktitle.ToString();
                label38.Text = popular[4].bookauthor.ToString();
                label39.Text = popular[5].booktitle.ToString();
                label40.Text = popular[5].bookauthor.ToString();
                label41.Text = popular[6].booktitle.ToString();
                label42.Text = popular[6].bookauthor.ToString();
                label43.Text = popular[7].booktitle.ToString();
                label44.Text = popular[7].bookauthor.ToString();
                label45.Text = popular[8].booktitle.ToString();
                label46.Text = popular[8].bookauthor.ToString();
                label47.Text = popular[9].booktitle.ToString();
                label48.Text = popular[9].bookauthor.ToString();      

            baglanti.Close();

        }
        void tten()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand(" select top 10 AVG(['BX-Book-Ratings'].[Book-Rating]) as ortalama_oy, ['BX-Books'].[Book-Title] from ['BX-Book-Ratings'] inner join['BX-Books'] on ['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  group by['BX-Books'].[Book-Title]  order by ortalama_oy desc", baglanti);
            List<topten> fruits = new List<topten>();
            SqlDataReader myReader = null;

            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                topten f = new topten();
                //düzenlenecek
                f.bookauthor = (myReader["ortalama_oy"].ToString());
                f.booktitle = (myReader["Book-Title"].ToString());
                fruits.Add(f);

            }
            baglanti.Close();
            for (int i = 0; i < 10; i++)
            {
                label93.Text = fruits[0].booktitle.ToString();

                label104.Text = fruits[1].booktitle.ToString();

                label105.Text = fruits[2].booktitle.ToString();

                label106.Text = fruits[3].booktitle.ToString();

                label107.Text = fruits[4].booktitle.ToString();

                label108.Text = fruits[5].booktitle.ToString();

                label109.Text = fruits[6].booktitle.ToString();

                label110.Text = fruits[7].booktitle.ToString();

                label111.Text = fruits[8].booktitle.ToString();

                label112.Text = fruits[9].booktitle.ToString();



            }

        }
        void TopTen()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand(" select top 10 AVG(['BX-Book-Ratings'].[Book-Rating]) as ortalama_oy, ['BX-Books'].[Book-Title] from ['BX-Book-Ratings'] inner join['BX-Books'] on ['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  group by['BX-Books'].[Book-Title]  order by ortalama_oy desc", baglanti);
            List<topten> fruits = new List<topten>();
            SqlDataReader myReader = null;
          
            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                topten f = new topten();
                //düzenlenecek
                f.booktitle = (myReader["ortalama_oy"].ToString());
                f.bookauthor = (myReader["Book-Title"].ToString());
                fruits.Add(f);
                
            }
            baglanti.Close();
            for (int i = 0; i < 10; i++)
            {
                label9.Text = fruits[0].booktitle.ToString();
                label10.Text = fruits[0].bookauthor.ToString();
                label11.Text = fruits[1].booktitle.ToString();
                label12.Text = fruits[1].bookauthor.ToString();
                label13.Text = fruits[2].booktitle.ToString();
                label14.Text = fruits[2].bookauthor.ToString();
                label15.Text = fruits[3].booktitle.ToString();
                label16.Text = fruits[3].bookauthor.ToString();
                label17.Text = fruits[4].booktitle.ToString();
                label18.Text = fruits[4].bookauthor.ToString();
                label19.Text = fruits[5].booktitle.ToString();
                label20.Text = fruits[5].bookauthor.ToString();
                label21.Text = fruits[6].booktitle.ToString();
                label22.Text = fruits[6].bookauthor.ToString();
                label23.Text = fruits[7].booktitle.ToString();
                label24.Text = fruits[7].bookauthor.ToString();
                label25.Text = fruits[8].booktitle.ToString();
                label26.Text = fruits[8].bookauthor.ToString();
                label27.Text = fruits[9].booktitle.ToString();
                label28.Text = fruits[9].bookauthor.ToString();
                
                
            }

        }
        void kontrol()
        {

                var connection = Database.GetConnection();
                var stmt = new SqlCommand("SELECT COUNT([Book-Rating]) FROM[bb].[dbo].['BX-Book-Ratings'] where['BX-Book-Ratings'].[User-ID] ='" +id + "' or ['BX-Book-Ratings'].[User-ID]>278859");
                int count = 0;
                stmt.Connection = connection;
                connection.Open();

                count = Int32.Parse(stmt.ExecuteScalar().ToString());
                if (count < 10)
                {
                    NUserRating page1 = new NUserRating();
                    page1.id = id;
                    page1.ShowDialog();
                    this.Hide();
                }
                connection.Close();
            
            
           }
        void SOyladıkların()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("select ['BX-Books'].[Book-Title] from ['BX-Books'] inner join ['BX-Book-Ratings'] on ['BX-Book-Ratings'].ISBN = ['BX-Books'].ISBN  where ['BX-Book-Ratings'].[User-ID]= '" +id + "' order by ['BX-Book-Ratings'].[User-ID]", baglanti);
            List<SeninOyladıkların> f2 = new List<SeninOyladıkların>();
            SqlDataReader myReader = null;

            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                SeninOyladıkların so = new SeninOyladıkların();
                //düzenlenecek
                so.booktitle = (myReader["Book-Title"].ToString());
                
                f2.Add(so);

            }
            baglanti.Close();
            int a = f2.Count;
            if (a==1)
            {
                label83.Text = f2[0].booktitle.ToString();
            }
            if (a==2)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
            }
            if (a==3)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
            }
            if (a==4)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
            }
            if (a==5)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
            }
            if (a==6)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
                label88.Text = f2[5].booktitle.ToString();
            }
            if (a==7)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
                label88.Text = f2[5].booktitle.ToString();
                label89.Text = f2[6].booktitle.ToString();
            }
            if (a==8)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
                label88.Text = f2[5].booktitle.ToString();
                label89.Text = f2[6].booktitle.ToString();
                label90.Text = f2[7].booktitle.ToString();
            }
            if (a==9)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
                label88.Text = f2[5].booktitle.ToString();
                label89.Text = f2[6].booktitle.ToString();
                label90.Text = f2[7].booktitle.ToString();
                label91.Text = f2[8].booktitle.ToString();
            }
            if (a==10)
            {
                label83.Text = f2[0].booktitle.ToString();
                label84.Text = f2[1].booktitle.ToString();
                label85.Text = f2[2].booktitle.ToString();
                label86.Text = f2[3].booktitle.ToString();
                label87.Text = f2[4].booktitle.ToString();
                label88.Text = f2[5].booktitle.ToString();
                label89.Text = f2[6].booktitle.ToString();
                label90.Text = f2[7].booktitle.ToString();
                label91.Text = f2[8].booktitle.ToString();
                label92.Text = f2[9].booktitle.ToString();
            }
            


           


            

        }
        
        void Onerilenler()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand c = new SqlCommand("select top 10 ['BX-Books'].[Book-Title] from ['BX-Books'] where ['BX-Books'].ISBN in (select['BX-Book-Ratings'].ISBN from ['BX-Book-Ratings'] where ['BX-Book-Ratings'].[User-ID] in (select['BX-Book-Ratings'].[User-ID] from ['BX-Book-Ratings'] where ['BX-Book-Ratings'].ISBN in (select top 1['BX-Books'].ISBN from dbo.['BX-Books'] inner join dbo.['BX-Book-Ratings'] on dbo.['BX-Book-Ratings'].ISBN = dbo.['BX-Books'].ISBN where ['BX-Book-Ratings'].[User-ID] = '" + id + "' order by dbo.['BX-Book-Ratings'].[Book-Rating] desc)))", baglanti);
            SqlDataAdapter a = new SqlDataAdapter(c);
            List<Oneri> oneri = new List<Oneri>();
            SqlDataReader myReader = null;
            SqlDataAdapter adp = new SqlDataAdapter(c);
            myReader = c.ExecuteReader();
            while (myReader.Read())
            {
                Oneri f = new Oneri();
                f.booktitle = (myReader["Book-Title"].ToString());
                oneri.Add(f);

            }
            baglanti.Close();

            int x = oneri.Count();
            
            if(x ==0)
            {
                tten();
            }
            if (x == 1)
            {
                label93.Text = oneri[0].booktitle.ToString();
            }
            if (x == 2)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
            }
            if (x == 3)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
            }
            if (x == 4)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
            }
            if (x == 5)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
            }
            if (x == 6)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
                label108.Text = oneri[5].booktitle.ToString();
            }
            if (x == 7)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
                label108.Text = oneri[5].booktitle.ToString();
                label109.Text = oneri[6].booktitle.ToString();
            }
            if (x == 8)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
                label108.Text = oneri[5].booktitle.ToString();
                label109.Text = oneri[6].booktitle.ToString();
                label110.Text = oneri[7].booktitle.ToString();
            }
            if (x == 9)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
                label108.Text = oneri[5].booktitle.ToString();
                label109.Text = oneri[6].booktitle.ToString();
                label110.Text = oneri[7].booktitle.ToString();
                label111.Text = oneri[8].booktitle.ToString();
            }
            if (x == 10)
            {
                label93.Text = oneri[0].booktitle.ToString();
                label104.Text = oneri[1].booktitle.ToString();
                label105.Text = oneri[2].booktitle.ToString();
                label106.Text = oneri[3].booktitle.ToString();
                label107.Text = oneri[4].booktitle.ToString();
                label108.Text = oneri[5].booktitle.ToString();
                label109.Text = oneri[6].booktitle.ToString();
                label110.Text = oneri[7].booktitle.ToString();
                label111.Text = oneri[8].booktitle.ToString();
                label112.Text = oneri[9].booktitle.ToString();
            }



            baglanti.Close();

        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label83.Text);
         
        }

        private void UserMainPage_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb; Integrated Security = true");
            kontrol();
            KitaplariGetir();
            LastAdditionBring();
            Popular();
            TopTen();
            SOyladıkların();
            Onerilenler();
            
            /*_Labels[0] = this.label94;
            _Labels[1] = this.label95;
            _Labels[2] = this.label96;
            _Labels[3] = this.label97;
            _Labels[4] = this.label98;
            _Labels[5] = this.label99;
            _Labels[6] = this.label100;
            _Labels[7] = this.label101;
            _Labels[8] = this.label102;
            _Labels[9] = this.label103;*/
            



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = MSI; Initial Catalog = yl1; Integrated Security = true");

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
            try
            {
                
                Process.Start("08333696.pdf");
            }
            catch (Exception )
            {
                MessageBox.Show("Could not open the file.", "Error");
            }


        }
        

        private void UserMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            SOyladıkların();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label93_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label93.Text);
            }
        }

        private void label104_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label104.Text);
            }
        }

        private void label105_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label105.Text);
            }
        }

        private void label106_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label106.Text);
            }
        }

        private void label107_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label107.Text);
            }
        }

        private void label108_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label108.Text);
            }
        }

        private void label109_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label109.Text);
            }
        }

        private void label110_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label110.Text);
            }
        }

        private void label111_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label111.Text);
            }
        }

        private void label112_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label112.Text);
            }
        }

        private void label92_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void label85_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click_1(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label83.Text);
            }

        }

        private void label84_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label84.Text);
            }

        }

        private void label85_Click_1(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label85.Text);
            }

        }

        private void label86_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label86.Text);
            }

        }

        private void label87_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label87.Text);
            }

        }

        private void label88_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label88.Text);
            }
        }

        private void label89_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label89.Text);
            }

        }

        private void label90_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label90.Text);
            }

        }

        private void label91_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label91.Text);
            }

        }

        private void label92_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            if (x <= 9)
            {
                listBox1.Items.Add(label92.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;


            if (a == 0)
            {
                try
                {

                    Process.Start("1.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 1)
            {
                try
                {

                    Process.Start("2.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 2)
            {
                try
                {

                    Process.Start("3.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 3)
            {
                try
                {

                    Process.Start("4.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 4)
            {
                try
                {

                    Process.Start("5.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 5)
            {
                try
                {

                    Process.Start("6.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a== 6)
            {
                try
                {

                    Process.Start("7.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 7)
            {
                try
                {

                    Process.Start("8.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 8)
            {
                try
                {

                    Process.Start("9.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }
            if (a == 9)
            {
                try
                {

                    Process.Start("10.pdf");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the file.", "Error");
                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                Process.Start("1.pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open the file.", "Error");
            }
        }
    }
}
