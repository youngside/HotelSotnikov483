namespace HotelSotnikov483
{
    partial class FormAdminManageAccs
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
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txtb_Login = new System.Windows.Forms.TextBox();
            this.txtb_Passwd = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.oic_Logo = new System.Windows.Forms.PictureBox();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Passwd = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUsers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(406, 375);
            this.dataGridViewAccounts.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(444, 425);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(188, 57);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Назад";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txtb_Login
            // 
            this.txtb_Login.Location = new System.Drawing.Point(444, 286);
            this.txtb_Login.Name = "txtb_Login";
            this.txtb_Login.Size = new System.Drawing.Size(188, 20);
            this.txtb_Login.TabIndex = 2;
            // 
            // txtb_Passwd
            // 
            this.txtb_Passwd.Location = new System.Drawing.Point(444, 336);
            this.txtb_Passwd.Name = "txtb_Passwd";
            this.txtb_Passwd.Size = new System.Drawing.Size(188, 20);
            this.txtb_Passwd.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(444, 362);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(188, 57);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // oic_Logo
            // 
            this.oic_Logo.Image = global::HotelSotnikov483.Properties.Resources.kisspng_hotel_icon_5_star_computer_icons_5ae44565d93681_6717417515249094138897;
            this.oic_Logo.Location = new System.Drawing.Point(433, 7);
            this.oic_Logo.Name = "oic_Logo";
            this.oic_Logo.Size = new System.Drawing.Size(188, 149);
            this.oic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oic_Logo.TabIndex = 5;
            this.oic_Logo.TabStop = false;
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(518, 264);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(38, 13);
            this.lb_Login.TabIndex = 6;
            this.lb_Login.Text = "Логин";
            // 
            // lb_Passwd
            // 
            this.lb_Passwd.AutoSize = true;
            this.lb_Passwd.Location = new System.Drawing.Point(518, 320);
            this.lb_Passwd.Name = "lb_Passwd";
            this.lb_Passwd.Size = new System.Drawing.Size(45, 13);
            this.lb_Passwd.TabIndex = 7;
            this.lb_Passwd.Text = "Пароль";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 57);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "idUser:";
            // 
            // comboUsers
            // 
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(79, 397);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.Size = new System.Drawing.Size(121, 21);
            this.comboUsers.TabIndex = 11;
            // 
            // FormAdminManageAccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 496);
            this.Controls.Add(this.comboUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lb_Passwd);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.oic_Logo);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtb_Passwd);
            this.Controls.Add(this.txtb_Login);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Name = "FormAdminManageAccs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminManageAccs";
            this.Load += new System.EventHandler(this.FormAdminManageAccs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txtb_Login;
        private System.Windows.Forms.TextBox txtb_Passwd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.PictureBox oic_Logo;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Passwd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUsers;
    }
}