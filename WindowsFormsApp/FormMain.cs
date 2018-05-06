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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormJournal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.journalDBDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.journalDBDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.MainJournal". При необходимости она может быть перемещена или удалена.
            this.mainJournalTableAdapter.Fill(this.journalDBDataSet.MainJournal);
            string sqlReq = "select dbo.FunUserName('" + Properties.Settings.Default.UserID + "')";

           // mainJournalDataGridView.Columns[1].DefaultCellStyle.NullValue = Properties.Settings.Default.UserID;

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.JournalDBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlReq, conn);
                label_Name.Text = (string)cmd.ExecuteScalar();

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            mainJournalBindingSource.Filter = "IDAcademic = \'" + Properties.Settings.Default.UserID + "\'";
        }

        private void button_AcademicChange_Click(object sender, EventArgs e)
        {
            FormAcadenic formAcadenic = new FormAcadenic();
            formAcadenic.Show();
        }

        private void mainJournalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mainJournalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainJournalBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(journalDBDataSet);
        }

        private void mainJournalDataGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void mainJournalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainJournalBindingSource.AddNew();
            mainJournalDataGridView.CurrentRow.Cells[1].Value = Properties.Settings.Default.UserID;
        }

        private void iDGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainJournalBindingSource.Filter = "IDGroup = \'" + Convert.ToInt32(iDGroupComboBox.SelectedValue) + "\'";
        }

        private void iDDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainJournalBindingSource.Filter = "IDDiscipline = \'" + Convert.ToInt32(iDDisciplineComboBox.SelectedValue) + "\'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainJournalBindingSource.Filter = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IDJournal = Convert.ToInt32(mainJournalDataGridView.CurrentRow.Cells[0].Value);

            FormJournal formJournal = new FormJournal();
            formJournal.Show();
        }

        private void button_AcademicChange_Click_1(object sender, EventArgs e)
        {
            FormAcadenic formAcadenic = new FormAcadenic();
            formAcadenic.ShowDialog();
        }
    }
}
