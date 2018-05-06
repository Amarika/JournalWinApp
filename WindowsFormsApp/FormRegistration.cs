using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string userName = textBox_UserName.Text;
            string userPassword = textBox_UserPassword.Text;

            string sqlReq = "insert dbo.Users values ('" + userName + "','" + userPassword + "')";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.JournalDBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlReq, conn);
                cmd.ExecuteNonQuery();
            }


            sqlReq = "select dbo.FunUserIDReturns('" + userName + "','" + userPassword + "')";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.JournalDBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlReq, conn);
                Properties.Settings.Default.UserID = (int)cmd.ExecuteScalar();
            }
                
            sqlReq = "insert into dbo.Academic(IDAcademic) values ('" + Properties.Settings.Default.UserID + "')";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.JournalDBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlReq, conn);
                cmd.ExecuteNonQuery();
            }

            Properties.Settings.Default.UserName = userName;
            Properties.Settings.Default.UserPassword = userPassword;
            this.Close();
        }
    }
}
