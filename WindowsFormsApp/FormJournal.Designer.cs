namespace WindowsFormsApp
{
    partial class FormJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_Report = new System.Windows.Forms.ToolStripSplitButton();
            this.периодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.RecordTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.ActivityTableAdapter();
            this.getDatesTableAdapter1 = new WindowsFormsApp.JournalDBDataSetTableAdapters.GetDatesTableAdapter();
            this.getRecordsTableAdapter1 = new WindowsFormsApp.JournalDBDataSetTableAdapters.GetRecordsTableAdapter();
            this.queriesTableAdapter1 = new WindowsFormsApp.JournalDBDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(794, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_Report});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton_Report
            // 
            this.toolStripSplitButton_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.периодToolStripMenuItem});
            this.toolStripSplitButton_Report.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_Report.Image")));
            this.toolStripSplitButton_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_Report.Name = "toolStripSplitButton_Report";
            this.toolStripSplitButton_Report.Size = new System.Drawing.Size(115, 24);
            this.toolStripSplitButton_Report.Text = "Создать отчет";
            // 
            // периодToolStripMenuItem
            // 
            this.периодToolStripMenuItem.Name = "периодToolStripMenuItem";
            this.периодToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.периодToolStripMenuItem.Text = "Период";
            this.периодToolStripMenuItem.Click += new System.EventHandler(this.периодToolStripMenuItem_Click);
            // 
            // journalDBDataSet
            // 
            this.journalDBDataSet.DataSetName = "JournalDBDataSet";
            this.journalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "Record";
            this.recordBindingSource.DataSource = this.journalDBDataSet;
            // 
            // recordTableAdapter
            // 
            this.recordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.MainJournalTableAdapter = null;
            this.tableAdapterManager.PhoneNumberTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = this.recordTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.journalDBDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // getDatesTableAdapter1
            // 
            this.getDatesTableAdapter1.ClearBeforeFill = true;
            // 
            // getRecordsTableAdapter1
            // 
            this.getRecordsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJournal";
            this.Text = " Журнал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJournal_FormClosing);
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private JournalDBDataSetTableAdapters.RecordTableAdapter recordTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private JournalDBDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JournalDBDataSetTableAdapters.GetDatesTableAdapter getDatesTableAdapter1;
        private JournalDBDataSetTableAdapters.GetRecordsTableAdapter getRecordsTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private JournalDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_Report;
        private System.Windows.Forms.ToolStripMenuItem периодToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn date;
    }
}