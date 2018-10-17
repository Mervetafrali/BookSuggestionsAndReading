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
            kisiGetir();
        }
       void kisiGetir()
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT * FROM ['BX-Users'] ", baglanti);


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
            SqlCommand cmd = new SqlCommand("SELECT * FROM ['BX-Books'] ", baglanti);


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

        
    }
}
