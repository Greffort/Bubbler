namespace Babbler
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
            this.WindowsChat = new System.Windows.Forms.RichTextBox();
            this.userMassege = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WindowsChat
            // 
            this.WindowsChat.BackColor = System.Drawing.SystemColors.Window;
            this.WindowsChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WindowsChat.CausesValidation = false;
            this.WindowsChat.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsChat.Location = new System.Drawing.Point(12, 12);
            this.WindowsChat.Name = "WindowsChat";
            this.WindowsChat.ReadOnly = true;
            this.WindowsChat.Size = new System.Drawing.Size(350, 288);
            this.WindowsChat.TabIndex = 5;
            this.WindowsChat.Text = "";
            // 
            // userMassege
            // 
            this.userMassege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userMassege.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userMassege.Location = new System.Drawing.Point(12, 306);
            this.userMassege.Multiline = true;
            this.userMassege.Name = "userMassege";
            this.userMassege.Size = new System.Drawing.Size(268, 58);
            this.userMassege.TabIndex = 0;
            this.userMassege.Text = "Напишите сообщение...";
            this.userMassege.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userMassege_KeyUp);
            // 
            // Enter_button
            // 
            this.Enter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Enter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enter_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Enter_button.FlatAppearance.BorderSize = 0;
            this.Enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter_button.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_button.Location = new System.Drawing.Point(286, 306);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(76, 58);
            this.Enter_button.TabIndex = 1;
            this.Enter_button.Text = "Send";
            this.Enter_button.UseVisualStyleBackColor = false;
            this.Enter_button.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(378, 379);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.userMassege);
            this.Controls.Add(this.WindowsChat);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 418);
            this.MinimumSize = new System.Drawing.Size(394, 418);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babbler 0.2";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox WindowsChat;
        private System.Windows.Forms.TextBox userMassege;
        private System.Windows.Forms.Button Enter_button;
    }
}

