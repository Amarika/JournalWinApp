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

            label_Name.Text = queriesTableAdapter1.FunUserName(Properties.Settings.Default.UserID);

            mainJournalBindingSource.Filter = "IDAcademic = \'" + Properties.Settings.Default.UserID + "\'";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button_AcademicChange_Click(object sender, EventArgs e)
        {
            FormAcademic formAcadenic = new FormAcademic();
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
        }

        private void mainJournalDataGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void mainJournalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button_AcademicChange_Click_1(object sender, EventArgs e)
        {
            FormAcademic formAcadenic = new FormAcademic();
            formAcadenic.ShowDialog();
        }

        private void mainJournalDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           }

        private void toolStripButton_AddJournal_Click(object sender, EventArgs e)
        {
            mainJournalBindingSource.AddNew();
            mainJournalDataGridView.CurrentRow.Cells[1].Value = Properties.Settings.Default.UserID;
            //mainJournalDataGridView.CurrentRow.Cells[2].Value = mainJournalDataGridView.Rows[mainJournalDataGridView.CurrentRow.Index-1].Cells[2].Value;
            //mainJournalDataGridView.CurrentRow.Cells[3].Value = mainJournalDataGridView.Rows[mainJournalDataGridView.CurrentRow.Index - 1].Cells[3].Value;
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            mainJournalBindingSource.EndEdit();
            mainJournalTableAdapter.Update(journalDBDataSet);
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IDJournal = Convert.ToInt32(mainJournalDataGridView.CurrentRow.Cells[0].Value);

            FormJournal formJournal = new FormJournal();
            formJournal.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
