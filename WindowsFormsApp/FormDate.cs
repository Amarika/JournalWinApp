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
    public partial class FormDate : Form
    {
        public FormDate()
        {
            InitializeComponent();
        }

        private void FormDate_Load(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(Properties.Settings.Default.Date);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Properties.Settings.Default.Date = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.Date);
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
