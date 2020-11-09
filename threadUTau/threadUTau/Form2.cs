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
    public partial class Form2 : Form
    {
        public Form2(string username)
        {
            InitializeComponent();
            sliderPanel.Height = buttonHome.Height;
            sliderPanel.Top = buttonHome.Top;
            homeUserControl1.BringToFront();
            label1.Text = "Hello, " + username + "!";
            label2.Text = username;
        }

        private void buttonSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 firstForm = new Form1();
            firstForm.Show();
            //this.Close();
            return;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonHome.Height;
            sliderPanel.Top = buttonHome.Top;
            homeUserControl1.BringToFront();
        }

        private void buttonThreads_Click(object sender, EventArgs e)
        {
            sliderPanel.Height = buttonThreads.Height;
            sliderPanel.Top = buttonThreads.Top;
            homeUserControl1.SendToBack();
        }
 
        private void circularButtonSports_Click(object sender, EventArgs e)
        {
            String username = label2.Text;
            this.Hide();
            Sports sportForm = new Sports(username);
            sportForm.Show();
            //this.Close();
            return;
        }

        private void circularButtonTransport_Click(object sender, EventArgs e)
        {
            String username = label2.Text;
            this.Hide();
            Transport transportForm = new Transport(username);
            transportForm.Show();
            //this.Close();
            return;
        }

        private void circularButtonEvents_Click(object sender, EventArgs e)
        {
            String username = label2.Text;
            this.Hide();
            Events eventsForm = new Events(username);
            eventsForm.Show();
            //this.Close();
            return;
        }

        private void circularButtonUniversity_Click(object sender, EventArgs e)
        {
            String username = label2.Text;
            this.Hide();
            University universityForm = new University(username);
            universityForm.Show();
            //this.Close();
            return;
        }
    }
}
