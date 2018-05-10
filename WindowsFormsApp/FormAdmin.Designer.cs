namespace WindowsFormsApp
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainJournalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.academicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddDiscipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddGroup = new System.Windows.Forms.ToolStripButton();
            this.disciplineTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.DisciplineTableAdapter();
            this.academicTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.AcademicTableAdapter();
            this.groupTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.GroupTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.mainJournalTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.MainJournalTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mainJournalDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.309456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.69054F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainJournalDataGridView
            // 
            this.mainJournalDataGridView.AllowUserToAddRows = false;
            this.mainJournalDataGridView.AutoGenerateColumns = false;
            this.mainJournalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainJournalDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.mainJournalDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainJournalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainJournalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mainJournalDataGridView.DataSource = this.mainJournalBindingSource;
            this.mainJournalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainJournalDataGridView.Location = new System.Drawing.Point(3, 32);
            this.mainJournalDataGridView.Name = "mainJournalDataGridView";
            this.mainJournalDataGridView.ReadOnly = true;
            this.mainJournalDataGridView.Size = new System.Drawing.Size(632, 314);
            this.mainJournalDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDJournal";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDJournal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDAcademic";
            this.dataGridViewTextBoxColumn2.DataSource = this.academicBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FullName";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "Препадователь";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IDAcademic";
            // 
            // academicBindingSource
            // 
            this.academicBindingSource.DataMember = "Academic";
            this.academicBindingSource.DataSource = this.journalDBDataSet;
            // 
            // journalDBDataSet
            // 
            this.journalDBDataSet.DataSetName = "JournalDBDataSet";
            this.journalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDGroup";
            this.dataGridViewTextBoxColumn3.DataSource = this.groupBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Number";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn3.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDGroup";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.journalDBDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDDiscipline";
            this.dataGridViewTextBoxColumn4.DataSource = this.disciplineBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDDiscipline";
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.journalDBDataSet;
            // 
            // mainJournalBindingSource
            // 
            this.mainJournalBindingSource.DataMember = "MainJournal";
            this.mainJournalBindingSource.DataSource = this.journalDBDataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Open,
            this.toolStripButton_AddDiscipline,
            this.toolStripButton_AddGroup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Open.Image")));
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(119, 26);
            this.toolStripButton_Open.Text = "Открыть журнал";
            this.toolStripButton_Open.Click += new System.EventHandler(this.toolStripButton_Open_Click);
            // 
            // toolStripButton_AddDiscipline
            // 
            this.toolStripButton_AddDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddDiscipline.Image")));
            this.toolStripButton_AddDiscipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddDiscipline.Name = "toolStripButton_AddDiscipline";
            this.toolStripButton_AddDiscipline.Size = new System.Drawing.Size(149, 26);
            this.toolStripButton_AddDiscipline.Text = "Добавить дисциплину";
            this.toolStripButton_AddDiscipline.Click += new System.EventHandler(this.toolStripButton_AddDiscipline_Click);
            // 
            // toolStripButton_AddGroup
            // 
            this.toolStripButton_AddGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddGroup.Image")));
            this.toolStripButton_AddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddGroup.Name = "toolStripButton_AddGroup";
            this.toolStripButton_AddGroup.Size = new System.Drawing.Size(120, 26);
            this.toolStripButton_AddGroup.Text = "Добавить группу";
            this.toolStripButton_AddGroup.Click += new System.EventHandler(this.toolStripButton_AddGroup_Click);
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // academicTableAdapter
            // 
            this.academicTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = this.academicTableAdapter;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.GroupTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.MainJournalTableAdapter = this.mainJournalTableAdapter;
            this.tableAdapterManager.PhoneNumberTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // mainJournalTableAdapter
            // 
            this.mainJournalTableAdapter.ClearBeforeFill = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Администрирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private JournalDBDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.DataGridView mainJournalDataGridView;
        private System.Windows.Forms.BindingSource academicBindingSource;
        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource mainJournalBindingSource;
        private JournalDBDataSetTableAdapters.AcademicTableAdapter academicTableAdapter;
        private JournalDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private JournalDBDataSetTableAdapters.MainJournalTableAdapter mainJournalTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddDiscipline;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}