namespace WindowsFormsApp
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_UserPassword = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(57, 150);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(126, 32);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(57, 112);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(126, 32);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_UserPassword
            // 
            this.textBox_UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserPassword.Location = new System.Drawing.Point(39, 70);
            this.textBox_UserPassword.Name = "textBox_UserPassword";
            this.textBox_UserPassword.PasswordChar = '•';
            this.textBox_UserPassword.Size = new System.Drawing.Size(167, 20);
            this.textBox_UserPassword.TabIndex = 9;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserName.Location = new System.Drawing.Point(39, 33);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(167, 20);
            this.textBox_UserName.TabIndex = 8;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(238, 238);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_UserPassword);
            this.Controls.Add(this.textBox_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_UserPassword;
        private System.Windows.Forms.TextBox textBox_UserName;
    }
}