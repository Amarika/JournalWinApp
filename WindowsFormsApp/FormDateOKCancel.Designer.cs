namespace WindowsFormsApp
{
    partial class FormDateOKCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDateOKCancel));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker_FirstDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_LastDay = new System.Windows.Forms.DateTimePicker();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker_FirstDay);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker_LastDay);
            this.flowLayoutPanel1.Controls.Add(this.button_Ok);
            this.flowLayoutPanel1.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 88);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePicker_FirstDay
            // 
            this.dateTimePicker_FirstDay.CustomFormat = "dd MM YYYY";
            this.dateTimePicker_FirstDay.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker_FirstDay.Name = "dateTimePicker_FirstDay";
            this.dateTimePicker_FirstDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FirstDay.TabIndex = 4;
            // 
            // dateTimePicker_LastDay
            // 
            this.dateTimePicker_LastDay.CustomFormat = "dd MM YYYY";
            this.dateTimePicker_LastDay.Location = new System.Drawing.Point(3, 29);
            this.dateTimePicker_LastDay.Name = "dateTimePicker_LastDay";
            this.dateTimePicker_LastDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_LastDay.TabIndex = 3;
            // 
            // button_Ok
            // 
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(0, 52);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(101, 34);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(101, 52);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(101, 34);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormDateOKCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 88);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDateOKCancel";
            this.ShowInTaskbar = false;
            this.Text = "FormDateOKCancel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDateOKCancel_FormClosed);
            this.Load += new System.EventHandler(this.FormDateOKCancel_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FirstDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_LastDay;
        private System.Windows.Forms.Button button_Cancel;
    }
}