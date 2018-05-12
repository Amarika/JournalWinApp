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
    public partial class FormAcademic : Form
    {
        public FormAcademic()
        {
            InitializeComponent();
        }

        private void academicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void academicBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void FormAcadenic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Academic". При необходимости она может быть перемещена или удалена.
            this.academicTableAdapter.Fill(this.journalDBDataSet.Academic);
            academicBindingSource.Filter = "IDAcademic = \'" + Properties.Settings.Default.UserID + "\'";

            

        }

        private void FormAcadenic_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passportSeriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void passportIssuedByLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
