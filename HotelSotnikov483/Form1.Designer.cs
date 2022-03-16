namespace HotelSotnikov483
{
    partial class FormAuthorization
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
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Passwd = new System.Windows.Forms.Label();
            this.txtbox_Login = new System.Windows.Forms.TextBox();
            this.txtbox_Passwd = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.pic_ShowPasswd = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ShowPasswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Login.Location = new System.Drawing.Point(38, 202);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(47, 16);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Логин";
            // 
            // lb_Passwd
            // 
            this.lb_Passwd.AutoSize = true;
            this.lb_Passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Passwd.Location = new System.Drawing.Point(32, 251);
            this.lb_Passwd.Name = "lb_Passwd";
            this.lb_Passwd.Size = new System.Drawing.Size(57, 16);
            this.lb_Passwd.TabIndex = 1;
            this.lb_Passwd.Text = "Пароль";
            // 
            // txtbox_Login
            // 
            this.txtbox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbox_Login.Location = new System.Drawing.Point(93, 196);
            this.txtbox_Login.Multiline = true;
            this.txtbox_Login.Name = "txtbox_Login";
            this.txtbox_Login.Size = new System.Drawing.Size(175, 30);
            this.txtbox_Login.TabIndex = 2;
            this.txtbox_Login.Text = "manager";
            this.txtbox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Passwd
            // 
            this.txtbox_Passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbox_Passwd.Location = new System.Drawing.Point(93, 246);
            this.txtbox_Passwd.Multiline = true;
            this.txtbox_Passwd.Name = "txtbox_Passwd";
            this.txtbox_Passwd.Size = new System.Drawing.Size(175, 30);
            this.txtbox_Passwd.TabIndex = 3;
            this.txtbox_Passwd.Text = "manager";
            this.txtbox_Passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(93, 296);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(175, 56);
            this.btnAuth.TabIndex = 4;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // pic_ShowPasswd
            // 
            this.pic_ShowPasswd.Image = global::HotelSotnikov483.Properties.Resources._481_4810872_hide_password_hide_show_password_icon_png_transparent;
            this.pic_ShowPasswd.Location = new System.Drawing.Point(274, 246);
            this.pic_ShowPasswd.Name = "pic_ShowPasswd";
            this.pic_ShowPasswd.Size = new System.Drawing.Size(30, 30);
            this.pic_ShowPasswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ShowPasswd.TabIndex = 6;
            this.pic_ShowPasswd.TabStop = false;
            this.pic_ShowPasswd.Click += new System.EventHandler(this.pic_ShowPasswd_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::HotelSotnikov483.Properties.Resources.kisspng_hotel_icon_5_star_computer_icons_5ae44565d93681_6717417515249094138897;
            this.pic_Logo.Location = new System.Drawing.Point(93, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(175, 168);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 5;
            this.pic_Logo.TabStop = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 390);
            this.Controls.Add(this.pic_ShowPasswd);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtbox_Passwd);
            this.Controls.Add(this.txtbox_Login);
            this.Controls.Add(this.lb_Passwd);
            this.Controls.Add(this.lb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pic_ShowPasswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Passwd;
        private System.Windows.Forms.TextBox txtbox_Login;
        private System.Windows.Forms.TextBox txtbox_Passwd;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.PictureBox pic_ShowPasswd;
    }
}

