namespace ClientMesseger
{
    partial class fMainWindow
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
            this.flpAuthorization = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLoggin = new System.Windows.Forms.TextBox();
            this.bAuthorization = new System.Windows.Forms.Button();
            this.bRegistration = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.flpAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAuthorization
            // 
            this.flpAuthorization.Controls.Add(this.tbLoggin);
            this.flpAuthorization.Controls.Add(this.tbPassword);
            this.flpAuthorization.Controls.Add(this.bAuthorization);
            this.flpAuthorization.Controls.Add(this.bRegistration);
            this.flpAuthorization.Location = new System.Drawing.Point(19, 19);
            this.flpAuthorization.Margin = new System.Windows.Forms.Padding(10);
            this.flpAuthorization.Name = "flpAuthorization";
            this.flpAuthorization.Size = new System.Drawing.Size(405, 73);
            this.flpAuthorization.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(201, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 20);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "Пароль";
            // 
            // tbLoggin
            // 
            this.tbLoggin.Location = new System.Drawing.Point(3, 3);
            this.tbLoggin.Name = "tbLoggin";
            this.tbLoggin.Size = new System.Drawing.Size(192, 20);
            this.tbLoggin.TabIndex = 1;
            this.tbLoggin.Text = "Логин";
            // 
            // bAuthorization
            // 
            this.bAuthorization.Location = new System.Drawing.Point(3, 29);
            this.bAuthorization.Name = "bAuthorization";
            this.bAuthorization.Size = new System.Drawing.Size(192, 37);
            this.bAuthorization.TabIndex = 2;
            this.bAuthorization.Text = "Авторизация";
            this.bAuthorization.UseVisualStyleBackColor = true;
            // 
            // bRegistration
            // 
            this.bRegistration.Location = new System.Drawing.Point(201, 29);
            this.bRegistration.Name = "bRegistration";
            this.bRegistration.Size = new System.Drawing.Size(192, 37);
            this.bRegistration.TabIndex = 3;
            this.bRegistration.Text = "Регистрация";
            this.bRegistration.UseVisualStyleBackColor = true;
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(22, 105);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.Size = new System.Drawing.Size(390, 176);
            this.tbMessages.TabIndex = 1;
            this.tbMessages.Text = "Сообщения чата";
            // 
            // tbUsers
            // 
            this.tbUsers.Location = new System.Drawing.Point(437, 22);
            this.tbUsers.Multiline = true;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(252, 259);
            this.tbUsers.TabIndex = 2;
            this.tbUsers.Text = "Список онлайн-пользователей";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(22, 298);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(446, 37);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "Поле ввода";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(474, 298);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(215, 37);
            this.bSend.TabIndex = 4;
            this.bSend.Text = "Отправить";
            this.bSend.UseVisualStyleBackColor = true;
            // 
            // fMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 354);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.flpAuthorization);
            this.Name = "fMainWindow";
            this.Text = "MainWindow";
            this.flpAuthorization.ResumeLayout(false);
            this.flpAuthorization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAuthorization;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLoggin;
        private System.Windows.Forms.Button bAuthorization;
        private System.Windows.Forms.Button bRegistration;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.TextBox tbUsers;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
    }
}

