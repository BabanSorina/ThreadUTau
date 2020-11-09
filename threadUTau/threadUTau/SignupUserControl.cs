using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadUTau
{
    public partial class SignupUserControl : UserControl
    {
        //public threadUTau.ServiceReference1.WebService1SoapClient service = new threadUTau.ServiceReference1.WebService1SoapClient();
        public SignupUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool confirm;
            String email, username, password;
            email = textBoxSignUpMail.Text;
            username = textBoxSIgnUpUser.Text;
            password = textBoxSignUpPass.Text;
            //confirm = service.register(email, username, password);
        }
    }
}
