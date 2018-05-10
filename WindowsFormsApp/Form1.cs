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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            string userName = textBox_UserName.Text;
            string userPassword = textBox_UserPassword.Text;

            if (userName == "admin" & userPassword == "admin")
            {
                FormAdmin formAdmin = new FormAdmin();
                this.Hide();
                formAdmin.Show();
            }
            else {

                string sqlReq = "select dbo.FunUserIDReturns('" + userName + "','" + userPassword + "')";

                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.JournalDBConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlReq, conn);
                    Properties.Settings.Default.UserID = (int)cmd.ExecuteScalar();

                    if (Properties.Settings.Default.UserID != 0)
                    {
                        Form formJournal = new FormMain();
                        this.Hide();
                        formJournal.Show();


                    }
                    else
                    {
                        MessageBox.Show("Данный пользователь не наден. Проверьте введенные данные или зарегистрируйте нового пользователя.",
                                        "Ошибка входа", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            Form formRegistration = new FormRegistration();
            this.Hide();
            formRegistration.ShowDialog();
            textBox_UserName.Text = Properties.Settings.Default.UserName;
            textBox_UserPassword.Text = Properties.Settings.Default.UserPassword;
            this.Show();
        }

        private void button_ConStr_Click(object sender, EventArgs e)
        {
            FormConStr formConStr = new FormConStr();
            formConStr.ShowDialog();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button_LogIn_Click(sender, e);
            }
        }
    }
}
