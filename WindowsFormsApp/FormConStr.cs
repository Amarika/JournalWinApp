using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormConStr : Form
    {
        public FormConStr()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JournalDBConnectionString = textBox_ConStr.Text;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConStr_Load(object sender, EventArgs e)
        {
            textBox_ConStr.Text = Properties.Settings.Default.JournalDBConnectionString;
        }
    }
}
