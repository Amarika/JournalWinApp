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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void academicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.MainJournal". При необходимости она может быть перемещена или удалена.
            this.mainJournalTableAdapter.Fill(this.journalDBDataSet.MainJournal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.journalDBDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.journalDBDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Academic". При необходимости она может быть перемещена или удалена.
            this.academicTableAdapter.Fill(this.journalDBDataSet.Academic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.MainJournal". При необходимости она может быть перемещена или удалена.
            this.mainJournalTableAdapter.Fill(this.journalDBDataSet.MainJournal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Academic". При необходимости она может быть перемещена или удалена.
            this.academicTableAdapter.Fill(this.journalDBDataSet.Academic);

        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IDJournal = Convert.ToInt32(mainJournalDataGridView.CurrentRow.Cells[0].Value);


            FormJournal formJournal = new FormJournal();
            formJournal.ShowDialog(this);
        }

        private void mainJournalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mainJournalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton_AddDiscipline_Click(object sender, EventArgs e)
        {
            FormAddDiscipline formAddDiscipline = new FormAddDiscipline();
            formAddDiscipline.ShowDialog();
        }

        private void toolStripButton_AddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup formAddGroup = new FormAddGroup();
            formAddGroup.ShowDialog();
        }
    }
}
