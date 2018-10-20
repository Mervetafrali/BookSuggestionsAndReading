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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        public User user;
        private UserProvider ıslem2;

        internal UserProvider Islem2 { get => ıslem2; set => ıslem2 = value; }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void newaddedtxt_Click(object sender, EventArgs e)
        {
            try
            {
                Islem2 = new UserProvider();
                user = new User();
                if (!String.IsNullOrEmpty(passwordnewtxt.Text) && !String.IsNullOrEmpty(locationtxt.Text) && !String.IsNullOrEmpty(agetxt.Text))
                {
                    user.Password = passwordnewtxt.Text;
                    user.Location = locationtxt.Text;
                    user.Age = agetxt.Text;
                    if (Islem2.InsertUser(user))
                     {
                    useridlbl.Text = user.UserId;
                        MessageBox.Show("Please select 10 books to complete your membership ");
                        NUserRating page1 = new NUserRating();
                        page1.id = user.UserId;
                        page1.ShowDialog();
                        
                    }
                    else
                    {
                    MessageBox.Show("Error!");
                     }
                }
                else
                {
                    MessageBox.Show("Fill the blank!");
                    return;

                }
                
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NUserRating page1 = new NUserRating();
            page1.ShowDialog();
        }
    }
}
