using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "JournalDBDataSet.GetRecordsFromDate". При необходимости она может быть перемещена или удалена.
            this.GetRecordsFromDateTableAdapter.Fill(this.JournalDBDataSet.GetRecordsFromDate,
                Properties.Settings.Default.IDJournal,
                Properties.Settings.Default.FirstDay.Date.ToString("MM-dd-yyyy"),
                Properties.Settings.Default.LastDay.Date.ToString("MM-dd-yyyy"));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
