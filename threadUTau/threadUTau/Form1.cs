using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadUTau
{
    public partial class Form1 : Form
    {
        public threadUTau.ServiceReference1.WebService1SoapClient service = new threadUTau.ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
            sliderPanel.Height = buttonHome.Height;
            sliderPanel.Top = buttonHome.Top;
            homeUserControl2.BringToFront();
        }

        /*
        private void buttonHome_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonHome.Height;
            sliderPanel.Top = buttonHome.Top;
            homeUserControl1.BringToFront();
        }


        private void buttonSignupPage_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonSignupPage.Height;
            sliderPanel.Top = buttonSignupPage.Top;
            signupUserControl1.BringToFront();
        }
        */

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool confirm;
            String username, password;
            username = placeHolderTextBoxUsername.Text;
            password = placeHolderPasswordBoxPassword.Text;
            confirm = service.login(username, password);

            if (confirm == true)
            {
                this.Hide();
                Form2 secondForm = new Form2(username);
                secondForm.Show();
                //this.Close();
                return;
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonHome.Height;
            sliderPanel.Top = buttonHome.Top;
            homeUserControl2.BringToFront();
        }

        private void buttonSignupPage_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonSignupPage.Height;
            sliderPanel.Top = buttonSignupPage.Top;
            homeUserControl2.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool confirm;
            String email, username, password;
            email = textBoxSignUpMail.Text;
            username = textBoxSIgnUpUser.Text;
            password = textBoxSignUpPass.Text;
            confirm = service.register(email, username, password);
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            String username = placeHolderTextBoxUsername.Text;
            service.SendPassMail(username);
            MessageBox.Show("Your password has been sent over email!");
        }
    }
}
