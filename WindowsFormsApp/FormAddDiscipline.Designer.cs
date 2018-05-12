namespace WindowsFormsApp
{
    partial class FormAddDiscipline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDiscipline));
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.DisciplineTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.disciplineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RemoveRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // journalDBDataSet
            // 
            this.journalDBDataSet.DataSetName = "JournalDBDataSet";
            this.journalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.journalDBDataSet;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.MainJournalTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // disciplineDataGridView
            // 
            this.disciplineDataGridView.AllowUserToAddRows = false;
            this.disciplineDataGridView.AutoGenerateColumns = false;
            this.disciplineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disciplineDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.disciplineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.disciplineDataGridView.DataSource = this.disciplineBindingSource;
            this.disciplineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disciplineDataGridView.Location = new System.Drawing.Point(3, 28);
            this.disciplineDataGridView.Name = "disciplineDataGridView";
            this.disciplineDataGridView.Size = new System.Drawing.Size(509, 311);
            this.disciplineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDDiscipline";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDDiscipline";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.disciplineDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.602339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.39766F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 342);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddRecord,
            this.toolStripButton_RemoveRecord,
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_AddRecord
            // 
            this.toolStripButton_AddRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddRecord.Image")));
            this.toolStripButton_AddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddRecord.Name = "toolStripButton_AddRecord";
            this.toolStripButton_AddRecord.Size = new System.Drawing.Size(119, 22);
            this.toolStripButton_AddRecord.Text = "Добавить запись";
            this.toolStripButton_AddRecord.Click += new System.EventHandler(this.toolStripButton_AddRecord_Click);
            // 
            // toolStripButton_RemoveRecord
            // 
            this.toolStripButton_RemoveRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RemoveRecord.Image")));
            this.toolStripButton_RemoveRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RemoveRecord.Name = "toolStripButton_RemoveRecord";
            this.toolStripButton_RemoveRecord.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton_RemoveRecord.Text = "Удалить запись";
            this.toolStripButton_RemoveRecord.Click += new System.EventHandler(this.toolStripButton_RemoveRecord_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(148, 22);
            this.toolStripButton_Save.Text = "Сохранить изменения";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // FormAddDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(515, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAddDiscipline";
            this.Text = "Добавление дисциплины";
            this.Load += new System.EventHandler(this.FormAddDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private JournalDBDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView disciplineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_RemoveRecord;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
    }
}