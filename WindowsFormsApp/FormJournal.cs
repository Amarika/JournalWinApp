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
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
        }

        private void recordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.recordBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.journalDBDataSet);

        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Activity". При необходимости она может быть перемещена или удалена.
            this.activityTableAdapter.Fill(this.journalDBDataSet.Activity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDBDataSet.Record". При необходимости она может быть перемещена или удалена.
            this.recordTableAdapter.Fill(this.journalDBDataSet.Record);

                     

            foreach (var item in this.activityTableAdapter.GetData())
            {
                dataGridView1.Columns.Add(item.IDActivity.ToString(), item.Name);
            }

            foreach (var item in this.getDatesTableAdapter1.GetData(Properties.Settings.Default.IDJournal))
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.Date.ToShortDateString();
                dataGridView1.Rows.Add(row);
            }

            foreach (var item in this.getRecordsTableAdapter1.GetData(Properties.Settings.Default.IDJournal))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == item.Date.ToShortDateString())
                    {
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            if (column.HeaderText.ToString() == item.Name.ToString())
                            {
                                dataGridView1[column.Index, row.Index].Value = item.Record.ToString();
                            }
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dataGridView1.CurrentCell.Value != null)
                    Properties.Settings.Default.Date = Convert.ToDateTime(dataGridView1.CurrentCell.Value).Date;

                FormDate formDate = new FormDate();
                formDate.ShowDialog();

                dataGridView1.CurrentCell.Value = Properties.Settings.Default.Date.ToString("d.M.yy");
            }


        }

        private void FormJournal_FormClosing(object sender, FormClosingEventArgs e)
        {
            queriesTableAdapter1.ProcRecordDelete(Properties.Settings.Default.IDJournal);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.HeaderText != "Дата" & row.Cells[0].Value != null)
                    {
                        queriesTableAdapter1.ProcRecordAdd(Properties.Settings.Default.IDJournal,
                                                           Convert.ToDateTime(row.Cells[0].Value).Date,
                                                           Convert.ToInt32(dataGridView1[column.Index, row.Index].Value),
                                                           column.HeaderText.ToString());
                    }
                }
            }

        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = DateTime.Now.Date;
            dataGridView1.Rows.Add(row);
        }

        private void периодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.ProcRecordDelete(Properties.Settings.Default.IDJournal);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.HeaderText != "Дата" & row.Cells[0].Value != null)
                    {
                        queriesTableAdapter1.ProcRecordAdd(Properties.Settings.Default.IDJournal,
                                                           Convert.ToDateTime(row.Cells[0].Value).Date,
                                                           Convert.ToInt32(dataGridView1[column.Index, row.Index].Value),
                                                           column.HeaderText.ToString());
                    }
                }
            }

            FormDateOKCancel formDateOKCancel = new FormDateOKCancel();
            formDateOKCancel.ShowDialog();

        }
    }
}
