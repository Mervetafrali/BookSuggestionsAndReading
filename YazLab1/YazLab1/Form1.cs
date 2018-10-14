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
            
                islem = new UserProvider();
                user1 = islem.getUser(usertxt.Text, passwordtxt.Text);
                if (user1 != null)
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

        private void newuserbtn_Click(object sender, EventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.ShowDialog();
        }
    }
}
