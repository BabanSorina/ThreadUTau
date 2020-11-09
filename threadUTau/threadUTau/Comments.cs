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
    public partial class Comments : Form
    {
        public threadUTau.ServiceReference1.WebService1SoapClient service = new threadUTau.ServiceReference1.WebService1SoapClient();
        public Comments(String username, String currentThread, int id)
        {
            InitializeComponent();
            DataTable table;
            if (currentThread.Equals("Sport"))
            {
                table = service.insertTable_sp_comm(id);
                dataGridView1.DataSource = table;
            }
            else if(currentThread.Equals("Transport"))
            {
                table = service.insertTable_tr_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("Event"))
            {
                table = service.insertTable_ev_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("University"))
            {
                table = service.insertTable_un_comm(id);
                dataGridView1.DataSource = table;
            }
            label2.Text = username;
            label3.Text = currentThread;
            label4.Text = Convert.ToString(id);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            String username = label2.Text;
            String currentThread = label3.Text;
            this.Hide();
            if (currentThread.Equals("Sport"))
            {
                Sports sportForm = new Sports(username);
                sportForm.Show();
            }
            else if (currentThread.Equals("Transport"))
            {
                Transport transportForm = new Transport(username);
                transportForm.Show();
            }
            else if (currentThread.Equals("Event"))
            {
                Events eventsForm = new Events(username);
                eventsForm.Show();
            }
            else if (currentThread.Equals("University"))
            {
                University universityForm = new University(username);
                universityForm.Show();
            }
            return;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            String comm = textBoxComment.Text;
            service.postComment(label3.Text, Convert.ToInt32(label4.Text), comm, label2.Text);

            int id;
            id = Convert.ToInt32(label4.Text);
            String currentThread = label3.Text;
            DataTable table;
            if (currentThread.Equals("Sport"))
            {
                table = service.insertTable_sp_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("Transport"))
            {
                table = service.insertTable_tr_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("Event"))
            {
                table = service.insertTable_ev_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("University"))
            {
                table = service.insertTable_un_comm(id);
                dataGridView1.DataSource = table;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        { 
            service.deleteComment(label3.Text, Convert.ToInt32(label4.Text), Convert.ToString(dataGridView1.SelectedCells[0].Value.ToString()), Convert.ToString(dataGridView1.SelectedCells[1].Value.ToString()), label2.Text);

            int id;
            id = Convert.ToInt32(label4.Text);
            String currentThread = label3.Text;
            DataTable table;
            if (currentThread.Equals("Sport"))
            {
                table = service.insertTable_sp_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("Transport"))
            {
                table = service.insertTable_tr_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("Event"))
            {
                table = service.insertTable_ev_comm(id);
                dataGridView1.DataSource = table;
            }
            else if (currentThread.Equals("University"))
            {
                table = service.insertTable_un_comm(id);
                dataGridView1.DataSource = table;
            }
        }
    }
}
