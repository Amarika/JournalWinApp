namespace WindowsFormsApp
{
    partial class FormAddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddGroup));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RemoveRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.groupTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.GroupTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.10526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AutoGenerateColumns = false;
            this.groupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.groupDataGridView.DataSource = this.groupBindingSource;
            this.groupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDataGridView.Location = new System.Drawing.Point(3, 29);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.Size = new System.Drawing.Size(582, 310);
            this.groupDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDGroup";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDGroup";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер группы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Specialty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.journalDBDataSet;
            // 
            // journalDBDataSet
            // 
            this.journalDBDataSet.DataSetName = "JournalDBDataSet";
            this.journalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddRecord,
            this.toolStripButton_RemoveRecord,
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_AddRecord
            // 
            this.toolStripButton_AddRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddRecord.Image")));
            this.toolStripButton_AddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddRecord.Name = "toolStripButton_AddRecord";
            this.toolStripButton_AddRecord.Size = new System.Drawing.Size(119, 23);
            this.toolStripButton_AddRecord.Text = "Добавить запись";
            this.toolStripButton_AddRecord.Click += new System.EventHandler(this.toolStripButton_AddRecord_Click);
            // 
            // toolStripButton_RemoveRecord
            // 
            this.toolStripButton_RemoveRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RemoveRecord.Image")));
            this.toolStripButton_RemoveRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RemoveRecord.Name = "toolStripButton_RemoveRecord";
            this.toolStripButton_RemoveRecord.Size = new System.Drawing.Size(111, 23);
            this.toolStripButton_RemoveRecord.Text = "Удалить запись";
            this.toolStripButton_RemoveRecord.Click += new System.EventHandler(this.toolStripButton_RemoveRecord_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(148, 23);
            this.toolStripButton_Save.Text = "Сохранить изменения";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.MainJournalTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(588, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddGroup";
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.FormAddGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private JournalDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_RemoveRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
    }
}