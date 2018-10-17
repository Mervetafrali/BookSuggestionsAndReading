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

        public User user;
        public User user1;
        private UserProvider islem;
        

        private void enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
            if (usertxt.Text.Equals("admin")&&passwordtxt.Text.Equals("1234"))
            {
                
                MessageBox.Show("true");
                AdminPage pagead = new AdminPage();
                pagead.ShowDialog();

            }
            if (!usertxt.Text.Equals("admin"))
            {
                islem = new UserProvider();
                user1 = islem.getUser(usertxt.Text, passwordtxt.Text);
            
             if (user1 != null  )
                {
                    MessageBox.Show("true");
                    UserMainPage page = new UserMainPage();
                     page.ShowDialog();
                }
                else
                {
                    MessageBox.Show("error!");
                }
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Error!");
            }
            
                
            
           
        }

        private void newuserbtn_Click(object sender, EventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Load("https://www.agac.gen.tr/images/agac-nedir.jpg");
        }
    }
}
