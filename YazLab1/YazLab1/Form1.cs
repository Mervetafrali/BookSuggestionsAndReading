using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string admin = "admin";
                string adpass = "1234";
                string user1 = "user";
                string uspass = "1212";
                if (usertxt.Equals(admin)&&passwordtxt.Equals(adpass))
                {
                    MessageBox.Show("Admin");
                }
                else if (usertxt.Equals(user1) && passwordtxt.Equals(uspass))
                {
                    MessageBox.Show("User");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void newuserbtn_Click(object sender, EventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.ShowDialog();
        }
    }
}
