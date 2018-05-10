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
    public partial class FormAddDiscipline : Form
    {
        public FormAddDiscipline()
        {
            InitializeComponent();
        }

        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void FormAddDiscipline_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.journalDBDataSet.Discipline);

        }

        private void toolStripButton_AddRecord_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.AddNew();
        }

        private void toolStripButton_RemoveRecord_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.RemoveCurrent();
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.EndEdit();
            disciplineTableAdapter.Update(journalDBDataSet);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
