using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows;
using System.Net;
using System.Net.Mail;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Madalin\Downloads\facultate\An 3 sem2\II\II Project\Final\threadutau\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security = True");

        [WebMethod]
        public String changePassword(string currentPassword, string newPassword, string username)
        {
            String qry = "UPDATE UserInfo SET Password = '" + newPassword + "' WHERE Username = '" + username + "' AND Password = '" + currentPassword + "'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    myCon.Open();

                    int rowsAdded = cmd.ExecuteNonQuery();
                    myCon.Close();
                    if (rowsAdded > 0)
                        return "Password changed!";
                    else
                        return "Username or password incorect!";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
                return "Error!";
            }

        }

        [WebMethod]
        public DataTable insertTable_sp()
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM Sport";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "Sport");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_ev()
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM Event";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "Event");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_tr()
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM Transport";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "Transport");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_un()
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM University";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "University");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_sp_comm(int id)
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT Comment_sp_comm,Username_sp_comm,PostTime_sp_comm FROM SportComments WHERE ID_sp_comm = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "SportComments");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_ev_comm(int id)
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT Comment_ev_comm,Username_ev_comm,PostTime_ev_comm FROM EventComments WHERE ID_ev_comm = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "EventComments");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_tr_comm(int id)
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT Comment_tr_comm,Username_tr_comm,PostTime_tr_comm FROM TransportComments WHERE ID_tr_comm = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "TransportComments");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]
        public DataTable insertTable_un_comm(int id)
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT Comment_un_comm,Username_un_comm,PostTime_un_comm FROM UniversityComments WHERE ID_un_comm = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "UniversityComments");
            myCon.Close();

            return ds.Tables[0];
        }

        [WebMethod]

        public bool register(string email, string username, string password)
        {
            //aici trebuie sa verificam daca emailul exista in baza de date a facultatii
            //daca da, adaugam in tabela users username si password
            //daca nu, pop-up window "nu sunteti student utcn"
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM ValidityCheck WHERE Email = '" + email + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "validitiyCheck");
            myCon.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("This email doesn't exist in university database");
                return false;
            }
            else
            {
                int used;
                used = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                if (used == 1)
                {
                    MessageBox.Show("This email is already used!");
                    return false;
                }    
            }

            // daca am ajuns pana aici, inseamna ca avem email valid
            string sql = "INSERT INTO UserInfo(Username,Password,Email) Values(@u,@p,@e)"; //!
            string qry2 = "UPDATE ValidityCheck set Used = 1 WHERE Email = '" + email + "'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, myCon))
                {
                    myCon.Open();
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@e", email);

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand(qry2, myCon);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Your account has been created!");
                    }
                    else
                        MessageBox.Show("Cannot create account!");
                    myCon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }

            return true;
        }
        [WebMethod]

        public bool login(string username, string password)
        {
            myCon.Open();
            DataSet ds = new DataSet();
            String qry = "SELECT * FROM UserInfo WHERE Username = '" + username + "' AND Password = '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(ds, "UserInfo");

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Username or password incorrect!");
                return false;
            }

            else
            {
                //MessageBox.Show("Login successful !");
                return true;
            }
            //aici in form te uiti daca se returneaza true sau false si in functie de asta deschizi sau nu form nou.
        }

        [WebMethod]

        public bool postMessage(string CurrentThread, string post, string username)
        {
            string sql = "";
            if (CurrentThread.Equals("Sport"))
            sql = "INSERT INTO Sport(Post_sp,Username_sp,PostDate_sp) Values(@m,@u,@t)";
            else if (CurrentThread.Equals("Event"))
            sql = "INSERT INTO Event(Post_ev,Username_ev,PostDate_ev) Values(@m,@u,@t)";
            else if (CurrentThread.Equals("Transport"))
            sql = "INSERT INTO Transport(Post_tr,Username_tr,PostDate_tr) Values(@m,@u,@t)";
            else if (CurrentThread.Equals("University"))
            sql = "INSERT INTO University(Post_un,Username_un,PostDate_un) Values(@m,@u,@t)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, myCon))
                {
                    myCon.Open();
                    cmd.Parameters.AddWithValue("@m", post);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@t", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm"));

                    int rowsAdded = cmd.ExecuteNonQuery();
                    /*if (rowsAdded > 0)
                        MessageBox.Show("Row inserted!!");
                    else
                        MessageBox.Show("No row inserted");*/
                    myCon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }

            return true;
        }

        [WebMethod]
        public bool deleteMessage(string CurrentThread,int id, string username_table, string username_label)
        {
            // post - postul din tabel
            // username_table - username din tabel
            // username_label - username-ul logat in aplicatie
            

            string sql = "";
            string qry = "";
            if (CurrentThread.Equals("Sport"))
            {
                sql = "Delete from [Sport] where ID_sp = @i AND Username_sp = @u";
                qry = "Delete from [SportComments] where ID_sp_comm = '" + id +"'";
            }
            else if (CurrentThread.Equals("Event"))
            {
                sql = "Delete from [Event] where ID_ev = @i AND Username_ev = @u";
                qry = "Delete from [EventComments] where ID_ev_comm = '" + id + "'";
            }
            else if (CurrentThread.Equals("Transport"))
            {
                sql = "Delete from [Transport] where ID_tr = @i AND Username_tr = @u";
                qry = "Delete from [TransportComments] where ID_tr_comm = '" + id + "'";
            }
            else if (CurrentThread.Equals("University"))
            {
                sql = "Delete from [University] where ID_un = @i AND Username_un = @u";
                qry = "Delete from [UniversityComments] where ID_un_comm = '" + id + "'";
            }

            if (username_label.Equals(username_table))
            {
                try
                {
                    using (SqlCommand cmd2 = new SqlCommand(qry, myCon))
                    {
                        myCon.Open();

                        int rowsAdded = cmd2.ExecuteNonQuery();
                        myCon.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, myCon))
                    {
                        myCon.Open();
                        cmd.Parameters.AddWithValue("@i", id);
                        cmd.Parameters.AddWithValue("@u", username_table);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        /*if (rowsAdded > 0)
                            MessageBox.Show("Post deleted!");
                        else
                            MessageBox.Show("No post deleted!");*/
                        myCon.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to delete this post!");
            }
            return true;
        }

        [WebMethod]

        public bool postComment(string CurrentThread,int id, string comm, string username)
        {

            string sql = "";
            if (CurrentThread.Equals("Sport"))
                sql = "INSERT INTO SportComments(ID_sp_comm, Comment_sp_comm,Username_sp_comm,PostTime_sp_comm) Values(@i,@c,@u,@t)";
            else if (CurrentThread.Equals("Event"))
                sql = "INSERT INTO EventComments(ID_ev_comm, Comment_ev_comm,Username_ev_comm,PostTime_ev_comm) Values(@i,@c,@u,@t)";
            else if (CurrentThread.Equals("Transport"))
                sql = "INSERT INTO TransportComments(ID_tr_comm, Comment_tr_comm,Username_tr_comm,PostTime_tr_comm) Values(@i,@c,@u,@t)";
            else if (CurrentThread.Equals("University"))
                sql = "INSERT INTO UniversityComments(ID_un_comm, Comment_un_comm,Username_un_comm,PostTime_un_comm) Values(@i,@c,@u,@t)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, myCon))
                {
                    myCon.Open();
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.Parameters.AddWithValue("@c", comm);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@t", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm"));

                    int rowsAdded = cmd.ExecuteNonQuery();
                    /*if (rowsAdded > 0)
                        MessageBox.Show("Row inserted!!");
                    else
                        MessageBox.Show("No row inserted");*/
                    myCon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }

            return true;
        }

        [WebMethod]
        public bool deleteComment(string CurrentThread, int id, string comment, string username_table, string username_label)
        {
            // id - id-ul postului
            // comm - comm din tabel
            // username_table - username din tabel
            // username_label - username-ul logat in aplicatie
            // username_post - username-ul al carui post este activ


            string sql = "";
            string qry = "";
            if (CurrentThread.Equals("Sport"))
            {
                sql = "Delete from [SportComments] where Comment_sp_comm = @c AND Username_sp_comm = @u";
                qry = "SELECT Username_sp FROM Sport where ID_sp = '" + id + "'";
            }
            else if (CurrentThread.Equals("Event"))
            {
                sql = "Delete from [EventComments] where Comment_ev_comm = @c AND Username_ev_comm = @u";
                qry = "SELECT Username_ev FROM Event where ID_ev = '" + id + "'";
            }
            else if (CurrentThread.Equals("Transport"))
            {
                sql = "Delete from [TransportComments] where Comment_tr_comm = @c AND Username_tr_comm = @u";
                qry = "SELECT Username_tr FROM Transport where ID_tr = '" + id + "'";
            }
            else if (CurrentThread.Equals("University"))
            {
                sql = "Delete from [UniversityComments] where Comment_un_comm = @c AND Username_un_comm = @u";
                qry = "SELECT Username_un FROM University where ID_un = '" + id + "'";
            }

            myCon.Open();
            DataSet username_post = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(qry, myCon);
            da.Fill(username_post, CurrentThread);
            myCon.Close();

            if (username_label.Equals(username_table) || (username_post.Tables[0].Rows[0][0]).ToString().Equals(username_label))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, myCon))
                    {
                        myCon.Open();
                        cmd.Parameters.AddWithValue("@c", comment);
                        cmd.Parameters.AddWithValue("@u", username_table);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        /*if (rowsAdded > 0)
                            MessageBox.Show("Post deleted!");
                        else
                            MessageBox.Show("No post deleted!");*/
                        myCon.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to delete this post!");
            }
            return true;
        }
        public void Email(string toEmail, string Subject, string body)
        {
            try
            {
                const string fromAddress = "threadutau@gmail.com";
                const string fromPassword = "pepene12345";
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(fromAddress);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = Subject;
                message.Body = body + "\n";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

            }
            catch (Exception) { }
        }

        public string getEmail(String username)
        {
            try
            {

                myCon.Open();
                SqlCommand sqlcom = new SqlCommand("select Email from UserInfo where Username= @username", myCon);
                sqlcom.Parameters.AddWithValue("@username", username);
                SqlDataReader sdr = sqlcom.ExecuteReader();
                string mail = "";
                if (sdr.Read())
                {
                    mail = sdr[0].ToString();
                }
                myCon.Close();
                return mail;
            }
            catch (Exception e) { return " get email problem"; }

        }
        public string getPass(String toemail)
        {



            myCon.Open();
            SqlCommand sqlcom2 = new SqlCommand("select Password from UserInfo where Email= @email", myCon);
            sqlcom2.Parameters.AddWithValue("@email", toemail);
            SqlDataReader sdr2 = sqlcom2.ExecuteReader();
            string pass = "";
            if (sdr2.Read())
            {
                pass = sdr2[0].ToString();
            }
            myCon.Close();
            return pass;


        }
        [WebMethod]
        public void SendPassMail(String username)
        {
            string toEmail = getEmail(username);
            string pass = getPass(toEmail);
            string subjecttitle = " Password recovery";
            string body = " This is a recovery mail for your account to the ThreadUTau application \n";
            body = body + " Your email account is:" + toEmail + "\n";// aici daca vreau pot sa pun sa acceseze si alte date din cont. 
            body = body + " your username is: " + username + "\n";
            body = body + " Your password is: " + pass + "\n";
            body = body + " If you did not ask for your password please contact us ";
            Email(toEmail, subjecttitle, body);
        }
    }
}
