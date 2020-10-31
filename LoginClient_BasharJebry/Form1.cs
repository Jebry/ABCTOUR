using LoginClient_BasharJebry.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClient_BasharJebry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            TourAuthenticateUserService_BasharClient clienthost =  
                new TourAuthenticateUserService_BasharClient("NetTcpBinding_ITourAuthenticateUserService_Bashar");

            UserInfo usercheck = new UserInfo();
                usercheck.UserName = txtUserName.Text;
            usercheck.Password = txtPassword.Text;


            msg.Text= clienthost.AuthenticateUser(usercheck);
        }
    }
}
