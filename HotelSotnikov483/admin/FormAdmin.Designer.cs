namespace HotelSotnikov483
{
    partial class FormAdmin
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_ManageAllAccounts = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.btnAddNewAppart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(30, 443);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(214, 53);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Выйти из аккаунта";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ManageAllAccounts
            // 
            this.btn_ManageAllAccounts.Location = new System.Drawing.Point(30, 218);
            this.btn_ManageAllAccounts.Name = "btn_ManageAllAccounts";
            this.btn_ManageAllAccounts.Size = new System.Drawing.Size(214, 59);
            this.btn_ManageAllAccounts.TabIndex = 1;
            this.btn_ManageAllAccounts.Text = "Управление аккаунтами работников";
            this.btn_ManageAllAccounts.UseVisualStyleBackColor = true;
            this.btn_ManageAllAccounts.Click += new System.EventHandler(this.btn_ManageAllAccounts_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::HotelSotnikov483.Properties.Resources.kisspng_hotel_icon_5_star_computer_icons_5ae44565d93681_6717417515249094138897;
            this.pic_Logo.Location = new System.Drawing.Point(30, 3);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(214, 197);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 6;
            this.pic_Logo.TabStop = false;
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(30, 292);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(214, 59);
            this.btnShowHistory.TabIndex = 7;
            this.btnShowHistory.Text = "История входов";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnAddNewAppart
            // 
            this.btnAddNewAppart.Location = new System.Drawing.Point(30, 368);
            this.btnAddNewAppart.Name = "btnAddNewAppart";
            this.btnAddNewAppart.Size = new System.Drawing.Size(214, 59);
            this.btnAddNewAppart.TabIndex = 8;
            this.btnAddNewAppart.Text = "Добавить апартаменты";
            this.btnAddNewAppart.UseVisualStyleBackColor = true;
            this.btnAddNewAppart.Click += new System.EventHandler(this.btnAddNewAppart_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 505);
            this.Controls.Add(this.btnAddNewAppart);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.btn_ManageAllAccounts);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_ManageAllAccounts;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Button btnAddNewAppart;
    }
}