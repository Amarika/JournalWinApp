namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.textBox_UserPassword = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.button_ConStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Registration
            // 
            this.button_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registration.Location = new System.Drawing.Point(57, 150);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(126, 32);
            this.button_Registration.TabIndex = 7;
            this.button_Registration.Text = "Зарегистрироваться";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // button_LogIn
            // 
            this.button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogIn.Location = new System.Drawing.Point(57, 112);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(126, 32);
            this.button_LogIn.TabIndex = 6;
            this.button_LogIn.Text = "Войти";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // textBox_UserPassword
            // 
            this.textBox_UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserPassword.Location = new System.Drawing.Point(39, 70);
            this.textBox_UserPassword.Name = "textBox_UserPassword";
            this.textBox_UserPassword.PasswordChar = '•';
            this.textBox_UserPassword.Size = new System.Drawing.Size(167, 20);
            this.textBox_UserPassword.TabIndex = 5;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserName.Location = new System.Drawing.Point(39, 33);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(167, 20);
            this.textBox_UserName.TabIndex = 4;
            // 
            // button_ConStr
            // 
            this.button_ConStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConStr.Location = new System.Drawing.Point(12, 205);
            this.button_ConStr.Name = "button_ConStr";
            this.button_ConStr.Size = new System.Drawing.Size(214, 28);
            this.button_ConStr.TabIndex = 8;
            this.button_ConStr.Text = "Изменить подключение к данным";
            this.button_ConStr.UseVisualStyleBackColor = true;
            this.button_ConStr.Click += new System.EventHandler(this.button_ConStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(238, 238);
            this.Controls.Add(this.button_ConStr);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_UserPassword);
            this.Controls.Add(this.textBox_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Вход";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.TextBox textBox_UserPassword;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Button button_ConStr;
    }
}

