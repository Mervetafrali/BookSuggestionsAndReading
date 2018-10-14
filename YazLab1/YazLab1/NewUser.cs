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
            Islem2 = new UserProvider();
            user = new User();
            user.UserId= newuseridtxt.Text;
            user.Name = usernamenewtxt.Text;
            user.Password = passwordnewtxt.Text;       
            user.Location = locationtxt.Text;
            user.Age = agetxt.Text;
            if (Islem2.InsertUser(user))
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Already exist!");
            }
        }
    }
}
