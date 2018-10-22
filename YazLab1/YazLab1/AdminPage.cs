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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
          
        }
        // baglanti nesnesi oluşturulur:
        SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb; Integrated Security = true");

        int Id = 0;
        
        // kisiler tablosundaki verileri çekmek için yazılan fonksiyon:
       
        private void deletetxt_Click(object sender, EventArgs e)
        {
            // try ile yazacağımız kod denenir:
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
                SqlCommand cmd = new SqlCommand("DELETE FROM ['BX-Users'] WHERE [User-ID]=@Id", baglanti);


                // Fare ile seçili satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);





                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();


                // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                kisiGetir();


                // Silindi mesajı gösterilir:
                MessageBox.Show("Deleted.");
            }
            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }
        }
        void kisiGetir()
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
            SqlCommand cmd = new SqlCommand("SELECT * FROM ['BX-Users'] ORDER BY [User-ID] ASC", baglanti);


            /* Veriler ile proje arasında adaptör görevi 

            sağlayan bir ara eleman olan adp nesnesi oluşturulur: */
            SqlDataAdapter adp = new SqlDataAdapter(cmd);


            // DataTable türündeki dtable nesnesi oluşturulur:
            DataTable dtable = new DataTable();


            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:
            adp.Fill(dtable);


            // dataGridView'ımız verileri dtable'dan alır ve gösterir:
            dataGridView1.DataSource = dtable;

            // Bağlantı kapatılır:
            baglanti.Close();
        }
        void kisiGetir2()
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
            SqlCommand cmd = new SqlCommand("SELECT *  FROM ['BX-Books'] ORDER BY [ISBN] ASC", baglanti);


            /* Veriler ile proje arasında adaptör görevi 

            sağlayan bir ara eleman olan adp nesnesi oluşturulur: */
            SqlDataAdapter adp = new SqlDataAdapter(cmd);


            // DataTable türündeki dtable nesnesi oluşturulur:
            DataTable dtable = new DataTable();


            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:
            adp.Fill(dtable);


            // dataGridView'ımız verileri dtable'dan alır ve gösterir:
            dataGridView2.DataSource = dtable;

            // Bağlantı kapatılır:
            baglanti.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb; Integrated Security = true");
            kisiGetir();
            kisiGetir2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            useridtxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            locationtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            agetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Passwordtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kapalı ise açılır:
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("UPDATE ['BX-Users'] SET [User-ID]=@Id,[Location]=@Location,[Age]=@Age,[_Password]=@Password WHERE [User-ID]=@Id ", baglanti);


                // Fare ile seçilmiş satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                //cmd.Parameters.AddWithValue("@Id", useridtxt.Text);




                cmd.Parameters.AddWithValue("@Location", locationtxt.Text);
                cmd.Parameters.AddWithValue("@Age", agetxt.Text);
                cmd.Parameters.AddWithValue("@Password", Passwordtxt.Text);
               

                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();


                // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                kisiGetir();


                // Güncellendi mesajı gösterilir:
                MessageBox.Show("Updated.");
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            isbntxt.Text = (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            booktitletxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            bookauthortxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            yoptxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            publishertxt.Text = (dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString());
            urlstxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            urlmtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            urlltxt.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(isbntxt.Text) && !String.IsNullOrEmpty(booktitletxt.Text) && !String.IsNullOrEmpty(bookauthortxt.Text) && !String.IsNullOrEmpty(yoptxt.Text) && !String.IsNullOrEmpty(publishertxt.Text) && !String.IsNullOrEmpty(urlstxt.Text) && !String.IsNullOrEmpty(urlmtxt.Text) && !String.IsNullOrEmpty(urlltxt.Text))
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();

                    }



                    // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                    // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                    SqlCommand cmd = new SqlCommand("INSERT INTO ['BX-Books'] ([ISBN],[Book-Title],[Book-Author],[Year-Of-Publication],[Publisher],[Image-URL-S],[Image-URL-M],[Image-URL-L],[dd])" +
                    " VALUES (@ISBN,@BookTitle,@BookAuthor,@YearOfPublicatin,@Publisher,@ImageURLS,@ImageURLM,@ImageURLL,@dd)", baglanti);
                    DateTime now = DateTime.Now;

                    // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                    cmd.Parameters.AddWithValue("@ISBN", isbntxt.Text);
                    cmd.Parameters.AddWithValue("@BookTitle", booktitletxt.Text);
                    cmd.Parameters.AddWithValue("@BookAuthor", bookauthortxt.Text);
                    cmd.Parameters.AddWithValue("@YearOfPublicatin", yoptxt.Text);
                    cmd.Parameters.AddWithValue("@Publisher", publishertxt.Text);
                    cmd.Parameters.AddWithValue("@ImageURLS", urlstxt.Text);
                    cmd.Parameters.AddWithValue("@ImageURLM", urlmtxt.Text);
                    cmd.Parameters.AddWithValue("@ImageURLL", urlltxt.Text);
                    cmd.Parameters.AddWithValue("@dd", now);
                    //Bağlantı kapalı ise açılır:

                    // Sorgu çalıştırılır:
                    cmd.ExecuteNonQuery();


                    // Bağlantı kapatılır:
                    baglanti.Close();


                    // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                    kisiGetir2();


                    // Eklendi mesajı gösterilir:
                    MessageBox.Show("Added.");
                }
                else
                {
                    MessageBox.Show("Fill the blank!");
                }
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }

          

        


    }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kapalı ise açılır:
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("UPDATE ['BX-Books'] SET [ISBN]=@ISBN,[Book-Title]=@BookTitle,[Book-Author]=@BookAuthor,[Year-Of-Publication]=@YearOfPublicatin,[Publisher]=@Publisher" +
                    ",[Image-URL-S]=@ImageURLS,[Image-URL-M]=@ImageURLM,[Image-URL-L]=@ImageURLL WHERE [ISBN]=@isbn ", baglanti);


                // Fare ile seçilmiş satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@isbn", dataGridView2.CurrentRow.Cells[0].Value);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                // cmd.Parameters.AddWithValue("@isbn, isbntxt.Text);
                cmd.Parameters.AddWithValue("@ISBN", isbntxt.Text);
                cmd.Parameters.AddWithValue("@BookTitle", booktitletxt.Text);
                cmd.Parameters.AddWithValue("@BookAuthor", bookauthortxt.Text);
                cmd.Parameters.AddWithValue("@YearOfPublicatin", yoptxt.Text);
                cmd.Parameters.AddWithValue("@Publisher", publishertxt.Text);
                cmd.Parameters.AddWithValue("@ImageURLS", urlstxt.Text);
                cmd.Parameters.AddWithValue("@ImageURLM", urlmtxt.Text);
                cmd.Parameters.AddWithValue("@ImageURLL", urlltxt.Text);

                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();


                // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                kisiGetir2();


                // Güncellendi mesajı gösterilir:
                MessageBox.Show("Updated.");
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }
        }

        private void bookdeletetxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
                SqlCommand cmd = new SqlCommand("DELETE FROM ['BX-Books'] WHERE ISBN=@Isbn", baglanti);


                // Fare ile seçili satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@Isbn", dataGridView2.CurrentRow.Cells[0].Value);





                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();


                // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                kisiGetir2();


                // Silindi mesajı gösterilir:
                MessageBox.Show("Deleted.");
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}

