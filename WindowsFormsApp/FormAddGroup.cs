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
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void FormAddGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.journalDBDataSet.Group);

        }

        private void toolStripButton_AddRecord_Click(object sender, EventArgs e)
        {
            groupBindingSource.AddNew();
        }

        private void toolStripButton_RemoveRecord_Click(object sender, EventArgs e)
        {
            groupBindingSource.RemoveCurrent();
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            groupBindingSource.EndEdit();
            groupTableAdapter.Update(journalDBDataSet);
        }
    }
}
