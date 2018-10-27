using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1
{
    public partial class NUserRating : Form
    {
        public NUserRating()
        {
            InitializeComponent();
        }
        public string id;
        SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog =bb; Integrated Security = true");
        int counter = 0;
        void kisiGetir()
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
            SqlCommand cmd = new SqlCommand("SELECT TOP (1) * FROM ['BX-Books'] ORDER BY NEWID()", baglanti);

            SqlDataReader myReader = null;
            /* Veriler ile proje arasında adaptör görevi 

            sağlayan bir ara eleman olan adp nesnesi oluşturulur: */
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                label8.Text= (myReader["ISBN"].ToString());
                label2.Text=(myReader["Book-Title"].ToString());
                label3.Text=(myReader["Book-Author"].ToString());
                label5.Text= (myReader["Year-Of-Publication"].ToString());
                //string load = ;
                pictureBox1.Load(myReader["Image-Url-M"].ToString());
            }
            // Bağlantı kapatılır:
            baglanti.Close();
        }


        private void NUserRating_Load(object sender, EventArgs e)
        {
            kisiGetir();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            label7.Text = id;
        }

        private void votebtn_Click(object sender, EventArgs e)
        {

            try
            {
               
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();

                    }               
                    SqlCommand cmd = new SqlCommand("INSERT INTO ['BX-Book-Ratings'] ([User-ID],[ISBN],[Book-Rating])" +
                    " VALUES (@UserId,@ISBN,@Bookrating)", baglanti);

                    string c = numericUpDown1.Text;
                    // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                    cmd.Parameters.AddWithValue("@UserId", label7.Text);
                    cmd.Parameters.AddWithValue("@ISBN", label8.Text);
                    cmd.Parameters.AddWithValue("@Bookrating", c);
                    cmd.ExecuteNonQuery();
                    
                    baglanti.Close();

                    MessageBox.Show("Added.");
                
                    progressBar1.Value ++;
                    counter ++;
                    kisiGetir();
             


            if (counter == 10)
            {
                this.Hide();
                UserMainPage page2 = new UserMainPage();
                    page2.id = id;
                page2.ShowDialog();
            }
                
                    
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }
                
        }

        private void otherbtn_Click(object sender, EventArgs e)
        {
            kisiGetir();
            
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
