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
    public partial class FormDateOKCancel : Form
    {
        public FormDateOKCancel()
        {
            InitializeComponent();
        }

        private void FormDateOKCancel_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FirstDay = dateTimePicker_FirstDay.Value.Date;
            Properties.Settings.Default.LastDay = dateTimePicker_LastDay.Value.Date;
            
            FormReport formReport = new FormReport();
            formReport.ShowDialog();

            this.Close();
        }

        private void FormDateOKCancel_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
