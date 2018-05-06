namespace WindowsFormsApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.mainJournalTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.MainJournalTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.GroupTableAdapter();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.DisciplineTableAdapter();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainJournalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AcademicChange = new System.Windows.Forms.Button();
            this.label_Greating = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iDGroupComboBox = new System.Windows.Forms.ComboBox();
            this.iDDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainJournalBindingSource
            // 
            this.mainJournalBindingSource.DataMember = "MainJournal";
            this.mainJournalBindingSource.DataSource = this.journalDBDataSet;
            // 
            // journalDBDataSet
            // 
            this.journalDBDataSet.DataSetName = "JournalDBDataSet";
            this.journalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainJournalTableAdapter
            // 
            this.mainJournalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = null;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.MainJournalTableAdapter = this.mainJournalTableAdapter;
            this.tableAdapterManager.PhoneNumberTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.journalDBDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.451613F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.54839F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(768, 434);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.49673F));
            this.tableLayoutPanel1.Controls.Add(this.mainJournalDataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.33665F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 401);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // mainJournalDataGridView
            // 
            this.mainJournalDataGridView.AllowUserToAddRows = false;
            this.mainJournalDataGridView.AutoGenerateColumns = false;
            this.mainJournalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainJournalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mainJournalDataGridView.DataSource = this.mainJournalBindingSource;
            this.mainJournalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainJournalDataGridView.Location = new System.Drawing.Point(90, 142);
            this.mainJournalDataGridView.Name = "mainJournalDataGridView";
            this.mainJournalDataGridView.Size = new System.Drawing.Size(669, 256);
            this.mainJournalDataGridView.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "IDAcademic";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDGroup";
            this.dataGridViewTextBoxColumn3.DataSource = this.groupBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Number";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "IDGroup";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDGroup";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDDiscipline";
            this.dataGridViewTextBoxColumn4.DataSource = this.disciplineBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "IDDiscipline";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDDiscipline";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_AcademicChange);
            this.panel1.Controls.Add(this.label_Greating);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 133);
            this.panel1.TabIndex = 3;
            // 
            // button_AcademicChange
            // 
            this.button_AcademicChange.Location = new System.Drawing.Point(3, 57);
            this.button_AcademicChange.Name = "button_AcademicChange";
            this.button_AcademicChange.Size = new System.Drawing.Size(75, 52);
            this.button_AcademicChange.TabIndex = 0;
            this.button_AcademicChange.Text = "Изменить личные данные";
            this.button_AcademicChange.UseVisualStyleBackColor = true;
            this.button_AcademicChange.Click += new System.EventHandler(this.button_AcademicChange_Click_1);
            // 
            // label_Greating
            // 
            this.label_Greating.AutoSize = true;
            this.label_Greating.Location = new System.Drawing.Point(3, 6);
            this.label_Greating.Name = "label_Greating";
            this.label_Greating.Size = new System.Drawing.Size(80, 13);
            this.label_Greating.TabIndex = 1;
            this.label_Greating.Text = "Здравствуйте,";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(19, 29);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 13);
            this.label_Name.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.38168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.61832F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel3.Controls.Add(this.iDGroupComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iDDisciplineComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(669, 133);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // iDGroupComboBox
            // 
            this.iDGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "IDGroup", true));
            this.iDGroupComboBox.DataSource = this.groupBindingSource;
            this.iDGroupComboBox.DisplayMember = "Number";
            this.iDGroupComboBox.FormattingEnabled = true;
            this.iDGroupComboBox.Location = new System.Drawing.Point(3, 3);
            this.iDGroupComboBox.Name = "iDGroupComboBox";
            this.iDGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDGroupComboBox.TabIndex = 1;
            this.iDGroupComboBox.ValueMember = "IDGroup";
            // 
            // iDDisciplineComboBox
            // 
            this.iDDisciplineComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "IDDiscipline", true));
            this.iDDisciplineComboBox.DataSource = this.disciplineBindingSource;
            this.iDDisciplineComboBox.DisplayMember = "Name";
            this.iDDisciplineComboBox.FormattingEnabled = true;
            this.iDDisciplineComboBox.Location = new System.Drawing.Point(132, 3);
            this.iDDisciplineComboBox.Name = "iDDisciplineComboBox";
            this.iDDisciplineComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDDisciplineComboBox.TabIndex = 2;
            this.iDDisciplineComboBox.ValueMember = "IDDiscipline";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 167);
            this.panel2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(768, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 434);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournal_FormClosed);
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainJournalDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource mainJournalBindingSource;
        private JournalDBDataSetTableAdapters.MainJournalTableAdapter mainJournalTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private JournalDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private JournalDBDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView mainJournalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_AcademicChange;
        private System.Windows.Forms.Label label_Greating;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox iDGroupComboBox;
        private System.Windows.Forms.ComboBox iDDisciplineComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}