namespace WindowsFormsApp
{
    partial class FormAcadenic
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
            System.Windows.Forms.Label iDAcademicLabel;
            System.Windows.Forms.Label passportPersonalNumberLabel;
            System.Windows.Forms.Label jobPositionLabel;
            System.Windows.Forms.Label insuranceNumberLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passportIssuedByLabel;
            System.Windows.Forms.Label jobCompanyNameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label academicDegreeLabel;
            System.Windows.Forms.Label passportIssueDateLabel;
            System.Windows.Forms.Label academicRankLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label passportNumberLabel;
            System.Windows.Forms.Label contractLastDateLabel;
            System.Windows.Forms.Label passportSeriesLabel;
            System.Windows.Forms.Label contractFirstDateLabel;
            System.Windows.Forms.Label localityLabel;
            System.Windows.Forms.Label contractLoadVolumeLabel;
            System.Windows.Forms.Label apartmentLabel;
            System.Windows.Forms.Label contractDateLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label contractNumberLabel;
            System.Windows.Forms.Label streetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcadenic));
            this.passportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.academicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalDBDataSet = new WindowsFormsApp.JournalDBDataSet();
            this.passportPersonalNumberTextBox = new System.Windows.Forms.TextBox();
            this.jobPositionTextBox = new System.Windows.Forms.TextBox();
            this.iDAcademicTextBox = new System.Windows.Forms.TextBox();
            this.passportIssuedByTextBox = new System.Windows.Forms.TextBox();
            this.jobCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.insuranceNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportIssueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.academicDegreeTextBox = new System.Windows.Forms.TextBox();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.academicRankTextBox = new System.Windows.Forms.TextBox();
            this.contractLastDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.contractFirstDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.contractLoadVolumeTextBox = new System.Windows.Forms.TextBox();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.contractDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.localityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.contractNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.academicTableAdapter = new WindowsFormsApp.JournalDBDataSetTableAdapters.AcademicTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            iDAcademicLabel = new System.Windows.Forms.Label();
            passportPersonalNumberLabel = new System.Windows.Forms.Label();
            jobPositionLabel = new System.Windows.Forms.Label();
            insuranceNumberLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            passportIssuedByLabel = new System.Windows.Forms.Label();
            jobCompanyNameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            academicDegreeLabel = new System.Windows.Forms.Label();
            passportIssueDateLabel = new System.Windows.Forms.Label();
            academicRankLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            passportNumberLabel = new System.Windows.Forms.Label();
            contractLastDateLabel = new System.Windows.Forms.Label();
            passportSeriesLabel = new System.Windows.Forms.Label();
            contractFirstDateLabel = new System.Windows.Forms.Label();
            localityLabel = new System.Windows.Forms.Label();
            contractLoadVolumeLabel = new System.Windows.Forms.Label();
            apartmentLabel = new System.Windows.Forms.Label();
            contractDateLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            contractNumberLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDAcademicLabel
            // 
            iDAcademicLabel.AutoSize = true;
            iDAcademicLabel.Location = new System.Drawing.Point(-35, -3);
            iDAcademicLabel.Name = "iDAcademicLabel";
            iDAcademicLabel.Size = new System.Drawing.Size(68, 13);
            iDAcademicLabel.TabIndex = 46;
            iDAcademicLabel.Text = "IDAcademic:";
            iDAcademicLabel.Visible = false;
            // 
            // passportPersonalNumberLabel
            // 
            passportPersonalNumberLabel.AutoSize = true;
            passportPersonalNumberLabel.Location = new System.Drawing.Point(23, 465);
            passportPersonalNumberLabel.Name = "passportPersonalNumberLabel";
            passportPersonalNumberLabel.Size = new System.Drawing.Size(124, 13);
            passportPersonalNumberLabel.TabIndex = 86;
            passportPersonalNumberLabel.Text = "Личный № по паспорту";
            // 
            // jobPositionLabel
            // 
            jobPositionLabel.AutoSize = true;
            jobPositionLabel.Location = new System.Drawing.Point(23, 573);
            jobPositionLabel.Name = "jobPositionLabel";
            jobPositionLabel.Size = new System.Drawing.Size(211, 13);
            jobPositionLabel.TabIndex = 90;
            jobPositionLabel.Text = "Должность по основному месту работы";
            // 
            // insuranceNumberLabel
            // 
            insuranceNumberLabel.AutoSize = true;
            insuranceNumberLabel.Location = new System.Drawing.Point(23, 495);
            insuranceNumberLabel.Name = "insuranceNumberLabel";
            insuranceNumberLabel.Size = new System.Drawing.Size(74, 13);
            insuranceNumberLabel.TabIndex = 54;
            insuranceNumberLabel.Text = "Страховой №";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(183, 44);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(130, 13);
            fullNameLabel.TabIndex = 48;
            fullNameLabel.Text = "(фамилия имя отчество)";
            // 
            // passportIssuedByLabel
            // 
            passportIssuedByLabel.AutoSize = true;
            passportIssuedByLabel.Location = new System.Drawing.Point(216, 435);
            passportIssuedByLabel.Name = "passportIssuedByLabel";
            passportIssuedByLabel.Size = new System.Drawing.Size(68, 13);
            passportIssuedByLabel.TabIndex = 84;
            passportIssuedByLabel.Text = "(кем выдан)";
            passportIssuedByLabel.Click += new System.EventHandler(this.passportIssuedByLabel_Click);
            // 
            // jobCompanyNameLabel
            // 
            jobCompanyNameLabel.AutoSize = true;
            jobCompanyNameLabel.Location = new System.Drawing.Point(23, 542);
            jobCompanyNameLabel.Name = "jobCompanyNameLabel";
            jobCompanyNameLabel.Size = new System.Drawing.Size(130, 13);
            jobCompanyNameLabel.TabIndex = 88;
            jobCompanyNameLabel.Text = "Место основной работы";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(23, 263);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(42, 13);
            countryLabel.TabIndex = 56;
            countryLabel.Text = "страна";
            // 
            // academicDegreeLabel
            // 
            academicDegreeLabel.AutoSize = true;
            academicDegreeLabel.Location = new System.Drawing.Point(88, 95);
            academicDegreeLabel.Name = "academicDegreeLabel";
            academicDegreeLabel.Size = new System.Drawing.Size(91, 13);
            academicDegreeLabel.TabIndex = 50;
            academicDegreeLabel.Text = "(ученая степень)";
            // 
            // passportIssueDateLabel
            // 
            passportIssueDateLabel.AutoSize = true;
            passportIssueDateLabel.Location = new System.Drawing.Point(274, 382);
            passportIssueDateLabel.Name = "passportIssueDateLabel";
            passportIssueDateLabel.Size = new System.Drawing.Size(39, 13);
            passportIssueDateLabel.TabIndex = 82;
            passportIssueDateLabel.Text = "выдан";
            // 
            // academicRankLabel
            // 
            academicRankLabel.AutoSize = true;
            academicRankLabel.Location = new System.Drawing.Point(328, 95);
            academicRankLabel.Name = "academicRankLabel";
            academicRankLabel.Size = new System.Drawing.Size(86, 13);
            academicRankLabel.TabIndex = 52;
            academicRankLabel.Text = "(ученое звание)";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(234, 263);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(72, 13);
            regionLabel.TabIndex = 58;
            regionLabel.Text = ",       область";
            // 
            // passportNumberLabel
            // 
            passportNumberLabel.AutoSize = true;
            passportNumberLabel.Location = new System.Drawing.Point(157, 382);
            passportNumberLabel.Name = "passportNumberLabel";
            passportNumberLabel.Size = new System.Drawing.Size(18, 13);
            passportNumberLabel.TabIndex = 80;
            passportNumberLabel.Text = "№";
            // 
            // contractLastDateLabel
            // 
            contractLastDateLabel.AutoSize = true;
            contractLastDateLabel.Location = new System.Drawing.Point(270, 193);
            contractLastDateLabel.Name = "contractLastDateLabel";
            contractLastDateLabel.Size = new System.Drawing.Size(19, 13);
            contractLastDateLabel.TabIndex = 76;
            contractLastDateLabel.Text = "по";
            // 
            // passportSeriesLabel
            // 
            passportSeriesLabel.AutoSize = true;
            passportSeriesLabel.Location = new System.Drawing.Point(23, 382);
            passportSeriesLabel.Name = "passportSeriesLabel";
            passportSeriesLabel.Size = new System.Drawing.Size(83, 13);
            passportSeriesLabel.TabIndex = 78;
            passportSeriesLabel.Text = "Паспорт серии";
            passportSeriesLabel.Click += new System.EventHandler(this.passportSeriesLabel_Click);
            // 
            // contractFirstDateLabel
            // 
            contractFirstDateLabel.AutoSize = true;
            contractFirstDateLabel.Location = new System.Drawing.Point(23, 192);
            contractFirstDateLabel.Name = "contractFirstDateLabel";
            contractFirstDateLabel.Size = new System.Drawing.Size(61, 13);
            contractFirstDateLabel.TabIndex = 74;
            contractFirstDateLabel.Text = "в период с";
            // 
            // localityLabel
            // 
            localityLabel.AutoSize = true;
            localityLabel.Location = new System.Drawing.Point(23, 294);
            localityLabel.Name = "localityLabel";
            localityLabel.Size = new System.Drawing.Size(36, 13);
            localityLabel.TabIndex = 60;
            localityLabel.Text = "город";
            // 
            // contractLoadVolumeLabel
            // 
            contractLoadVolumeLabel.AutoSize = true;
            contractLoadVolumeLabel.Location = new System.Drawing.Point(23, 160);
            contractLoadVolumeLabel.Name = "contractLoadVolumeLabel";
            contractLoadVolumeLabel.Size = new System.Drawing.Size(230, 13);
            contractLoadVolumeLabel.TabIndex = 72;
            contractLoadVolumeLabel.Text = "заключен на выпонение нагрузки в объеме";
            // 
            // apartmentLabel
            // 
            apartmentLabel.AutoSize = true;
            apartmentLabel.Location = new System.Drawing.Point(235, 328);
            apartmentLabel.Name = "apartmentLabel";
            apartmentLabel.Size = new System.Drawing.Size(78, 13);
            apartmentLabel.TabIndex = 66;
            apartmentLabel.Text = ",       квартира";
            // 
            // contractDateLabel
            // 
            contractDateLabel.AutoSize = true;
            contractDateLabel.Location = new System.Drawing.Point(244, 129);
            contractDateLabel.Name = "contractDateLabel";
            contractDateLabel.Size = new System.Drawing.Size(18, 13);
            contractDateLabel.TabIndex = 70;
            contractDateLabel.Text = "от";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(23, 328);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(27, 13);
            houseLabel.TabIndex = 64;
            houseLabel.Text = "дом";
            // 
            // contractNumberLabel
            // 
            contractNumberLabel.AutoSize = true;
            contractNumberLabel.Location = new System.Drawing.Point(23, 128);
            contractNumberLabel.Name = "contractNumberLabel";
            contractNumberLabel.Size = new System.Drawing.Size(65, 13);
            contractNumberLabel.TabIndex = 68;
            contractNumberLabel.Text = "Договор №";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(235, 294);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(60, 13);
            streetLabel.TabIndex = 62;
            streetLabel.Text = ",       улица";
            // 
            // passportSeriesTextBox
            // 
            this.passportSeriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passportSeriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "PassportSeries", true));
            this.passportSeriesTextBox.Location = new System.Drawing.Point(106, 375);
            this.passportSeriesTextBox.Name = "passportSeriesTextBox";
            this.passportSeriesTextBox.Size = new System.Drawing.Size(45, 20);
            this.passportSeriesTextBox.TabIndex = 79;
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
            // passportPersonalNumberTextBox
            // 
            this.passportPersonalNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passportPersonalNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "PassportPersonalNumber", true));
            this.passportPersonalNumberTextBox.Location = new System.Drawing.Point(160, 458);
            this.passportPersonalNumberTextBox.Name = "passportPersonalNumberTextBox";
            this.passportPersonalNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.passportPersonalNumberTextBox.TabIndex = 87;
            // 
            // jobPositionTextBox
            // 
            this.jobPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "JobPosition", true));
            this.jobPositionTextBox.Location = new System.Drawing.Point(240, 566);
            this.jobPositionTextBox.Name = "jobPositionTextBox";
            this.jobPositionTextBox.Size = new System.Drawing.Size(228, 20);
            this.jobPositionTextBox.TabIndex = 91;
            // 
            // iDAcademicTextBox
            // 
            this.iDAcademicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDAcademicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "IDAcademic", true));
            this.iDAcademicTextBox.Location = new System.Drawing.Point(106, -6);
            this.iDAcademicTextBox.Name = "iDAcademicTextBox";
            this.iDAcademicTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDAcademicTextBox.TabIndex = 47;
            this.iDAcademicTextBox.Visible = false;
            // 
            // passportIssuedByTextBox
            // 
            this.passportIssuedByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passportIssuedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "PassportIssuedBy", true));
            this.passportIssuedByTextBox.Location = new System.Drawing.Point(26, 412);
            this.passportIssuedByTextBox.Name = "passportIssuedByTextBox";
            this.passportIssuedByTextBox.Size = new System.Drawing.Size(442, 20);
            this.passportIssuedByTextBox.TabIndex = 85;
            // 
            // jobCompanyNameTextBox
            // 
            this.jobCompanyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobCompanyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "JobCompanyName", true));
            this.jobCompanyNameTextBox.Location = new System.Drawing.Point(174, 535);
            this.jobCompanyNameTextBox.Name = "jobCompanyNameTextBox";
            this.jobCompanyNameTextBox.Size = new System.Drawing.Size(294, 20);
            this.jobCompanyNameTextBox.TabIndex = 89;
            // 
            // insuranceNumberTextBox
            // 
            this.insuranceNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insuranceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "InsuranceNumber", true));
            this.insuranceNumberTextBox.Location = new System.Drawing.Point(103, 488);
            this.insuranceNumberTextBox.Name = "insuranceNumberTextBox";
            this.insuranceNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.insuranceNumberTextBox.TabIndex = 55;
            // 
            // passportIssueDateDateTimePicker
            // 
            this.passportIssueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.academicBindingSource, "PassportIssueDate", true));
            this.passportIssueDateDateTimePicker.Location = new System.Drawing.Point(319, 376);
            this.passportIssueDateDateTimePicker.Name = "passportIssueDateDateTimePicker";
            this.passportIssueDateDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.passportIssueDateDateTimePicker.TabIndex = 83;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(26, 21);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(442, 20);
            this.fullNameTextBox.TabIndex = 49;
            this.fullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countryTextBox
            // 
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(73, 256);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(153, 20);
            this.countryTextBox.TabIndex = 57;
            // 
            // academicDegreeTextBox
            // 
            this.academicDegreeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.academicDegreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "AcademicDegree", true));
            this.academicDegreeTextBox.Location = new System.Drawing.Point(26, 72);
            this.academicDegreeTextBox.Name = "academicDegreeTextBox";
            this.academicDegreeTextBox.Size = new System.Drawing.Size(200, 20);
            this.academicDegreeTextBox.TabIndex = 51;
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passportNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "PassportNumber", true));
            this.passportNumberTextBox.Location = new System.Drawing.Point(174, 375);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(94, 20);
            this.passportNumberTextBox.TabIndex = 81;
            // 
            // academicRankTextBox
            // 
            this.academicRankTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.academicRankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "AcademicRank", true));
            this.academicRankTextBox.Location = new System.Drawing.Point(268, 72);
            this.academicRankTextBox.Name = "academicRankTextBox";
            this.academicRankTextBox.Size = new System.Drawing.Size(200, 20);
            this.academicRankTextBox.TabIndex = 53;
            // 
            // contractLastDateDateTimePicker
            // 
            this.contractLastDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.academicBindingSource, "ContractLastDate", true));
            this.contractLastDateDateTimePicker.Location = new System.Drawing.Point(306, 186);
            this.contractLastDateDateTimePicker.Name = "contractLastDateDateTimePicker";
            this.contractLastDateDateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.contractLastDateDateTimePicker.TabIndex = 77;
            // 
            // regionTextBox
            // 
            this.regionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(315, 256);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(153, 20);
            this.regionTextBox.TabIndex = 59;
            // 
            // contractFirstDateDateTimePicker
            // 
            this.contractFirstDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.academicBindingSource, "ContractFirstDate", true));
            this.contractFirstDateDateTimePicker.Location = new System.Drawing.Point(90, 186);
            this.contractFirstDateDateTimePicker.Name = "contractFirstDateDateTimePicker";
            this.contractFirstDateDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.contractFirstDateDateTimePicker.TabIndex = 75;
            // 
            // houseTextBox
            // 
            this.houseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "House", true));
            this.houseTextBox.Location = new System.Drawing.Point(73, 321);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(153, 20);
            this.houseTextBox.TabIndex = 65;
            // 
            // contractLoadVolumeTextBox
            // 
            this.contractLoadVolumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractLoadVolumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "ContractLoadVolume", true));
            this.contractLoadVolumeTextBox.Location = new System.Drawing.Point(268, 153);
            this.contractLoadVolumeTextBox.Name = "contractLoadVolumeTextBox";
            this.contractLoadVolumeTextBox.Size = new System.Drawing.Size(156, 20);
            this.contractLoadVolumeTextBox.TabIndex = 73;
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "Apartment", true));
            this.apartmentTextBox.Location = new System.Drawing.Point(315, 321);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(153, 20);
            this.apartmentTextBox.TabIndex = 67;
            // 
            // contractDateDateTimePicker
            // 
            this.contractDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.academicBindingSource, "ContractDate", true));
            this.contractDateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contractDateDateTimePicker.Location = new System.Drawing.Point(268, 122);
            this.contractDateDateTimePicker.Name = "contractDateDateTimePicker";
            this.contractDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.contractDateDateTimePicker.TabIndex = 71;
            // 
            // localityTextBox
            // 
            this.localityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "Locality", true));
            this.localityTextBox.Location = new System.Drawing.Point(73, 287);
            this.localityTextBox.Name = "localityTextBox";
            this.localityTextBox.Size = new System.Drawing.Size(153, 20);
            this.localityTextBox.TabIndex = 61;
            // 
            // streetTextBox
            // 
            this.streetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(315, 287);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(153, 20);
            this.streetTextBox.TabIndex = 63;
            // 
            // contractNumberTextBox
            // 
            this.contractNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "ContractNumber", true));
            this.contractNumberTextBox.Location = new System.Drawing.Point(94, 121);
            this.contractNumberTextBox.Name = "contractNumberTextBox";
            this.contractNumberTextBox.Size = new System.Drawing.Size(132, 20);
            this.contractNumberTextBox.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "часов";
            // 
            // academicTableAdapter
            // 
            this.academicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicTableAdapter = this.academicTableAdapter;
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.MainJournalTableAdapter = null;
            this.tableAdapterManager.PhoneNumberTableAdapter = null;
            this.tableAdapterManager.RecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.JournalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Домашний адрес:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAcadenic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(494, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passportSeriesTextBox);
            this.Controls.Add(iDAcademicLabel);
            this.Controls.Add(this.passportPersonalNumberTextBox);
            this.Controls.Add(this.jobPositionTextBox);
            this.Controls.Add(passportPersonalNumberLabel);
            this.Controls.Add(this.iDAcademicTextBox);
            this.Controls.Add(this.passportIssuedByTextBox);
            this.Controls.Add(jobPositionLabel);
            this.Controls.Add(insuranceNumberLabel);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(passportIssuedByLabel);
            this.Controls.Add(this.jobCompanyNameTextBox);
            this.Controls.Add(this.insuranceNumberTextBox);
            this.Controls.Add(jobCompanyNameLabel);
            this.Controls.Add(this.passportIssueDateDateTimePicker);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(academicDegreeLabel);
            this.Controls.Add(passportIssueDateLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.academicDegreeTextBox);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(academicRankLabel);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.academicRankTextBox);
            this.Controls.Add(passportNumberLabel);
            this.Controls.Add(this.contractLastDateDateTimePicker);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(contractLastDateLabel);
            this.Controls.Add(passportSeriesLabel);
            this.Controls.Add(this.contractFirstDateDateTimePicker);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(contractFirstDateLabel);
            this.Controls.Add(localityLabel);
            this.Controls.Add(this.contractLoadVolumeTextBox);
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(contractLoadVolumeLabel);
            this.Controls.Add(apartmentLabel);
            this.Controls.Add(this.contractDateDateTimePicker);
            this.Controls.Add(this.localityTextBox);
            this.Controls.Add(contractDateLabel);
            this.Controls.Add(houseLabel);
            this.Controls.Add(contractNumberLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.contractNumberTextBox);
            this.Controls.Add(streetLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAcadenic";
            this.Text = "Изменение личных данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcadenic_FormClosing);
            this.Load += new System.EventHandler(this.FormAcadenic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JournalDBDataSet journalDBDataSet;
        private System.Windows.Forms.BindingSource academicBindingSource;
        private JournalDBDataSetTableAdapters.AcademicTableAdapter academicTableAdapter;
        private JournalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox passportSeriesTextBox;
        private System.Windows.Forms.TextBox passportPersonalNumberTextBox;
        private System.Windows.Forms.TextBox jobPositionTextBox;
        private System.Windows.Forms.TextBox iDAcademicTextBox;
        private System.Windows.Forms.TextBox passportIssuedByTextBox;
        private System.Windows.Forms.TextBox jobCompanyNameTextBox;
        private System.Windows.Forms.TextBox insuranceNumberTextBox;
        private System.Windows.Forms.DateTimePicker passportIssueDateDateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox academicDegreeTextBox;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.TextBox academicRankTextBox;
        private System.Windows.Forms.DateTimePicker contractLastDateDateTimePicker;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.DateTimePicker contractFirstDateDateTimePicker;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox contractLoadVolumeTextBox;
        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.DateTimePicker contractDateDateTimePicker;
        private System.Windows.Forms.TextBox localityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox contractNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}