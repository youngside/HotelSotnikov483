namespace HotelSotnikov483
{
    partial class FormManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericCountOfDays = new System.Windows.Forms.NumericUpDown();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPricePerDay = new System.Windows.Forms.Label();
            this.txtBedCount = new System.Windows.Forms.Label();
            this.txtBathroomCount = new System.Windows.Forms.Label();
            this.txtRoomCount = new System.Windows.Forms.Label();
            this.comboApparts = new System.Windows.Forms.ComboBox();
            this.textBox33 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btShowBooking = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountOfDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(353, 391);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(141, 54);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Назад";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericRoomNumber);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericCountOfDays);
            this.groupBox1.Controls.Add(this.dtDob);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPatron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Location = new System.Drawing.Point(4, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные клиента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Номер апартаментов:";
            // 
            // numericRoomNumber
            // 
            this.numericRoomNumber.Location = new System.Drawing.Point(130, 189);
            this.numericRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRoomNumber.Name = "numericRoomNumber";
            this.numericRoomNumber.Size = new System.Drawing.Size(129, 20);
            this.numericRoomNumber.TabIndex = 20;
            this.numericRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Дней проживания:";
            // 
            // numericCountOfDays
            // 
            this.numericCountOfDays.Location = new System.Drawing.Point(130, 154);
            this.numericCountOfDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountOfDays.Name = "numericCountOfDays";
            this.numericCountOfDays.Size = new System.Drawing.Size(129, 20);
            this.numericCountOfDays.TabIndex = 18;
            this.numericCountOfDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountOfDays.ValueChanged += new System.EventHandler(this.numericCountOfDays_ValueChanged);
            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(130, 117);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(129, 20);
            this.dtDob.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(130, 88);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(129, 20);
            this.txtPatron.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(130, 62);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(129, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(130, 34);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(129, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPricePerDay);
            this.groupBox2.Controls.Add(this.txtBedCount);
            this.groupBox2.Controls.Add(this.txtBathroomCount);
            this.groupBox2.Controls.Add(this.txtRoomCount);
            this.groupBox2.Controls.Add(this.comboApparts);
            this.groupBox2.Controls.Add(this.textBox33);
            this.groupBox2.Location = new System.Drawing.Point(303, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите тип апартаментов";
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.AutoSize = true;
            this.txtPricePerDay.Location = new System.Drawing.Point(20, 136);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(98, 13);
            this.txtPricePerDay.TabIndex = 16;
            this.txtPricePerDay.Text = "Стоимость/сутки:";
            // 
            // txtBedCount
            // 
            this.txtBedCount.AutoSize = true;
            this.txtBedCount.Location = new System.Drawing.Point(20, 113);
            this.txtBedCount.Name = "txtBedCount";
            this.txtBedCount.Size = new System.Drawing.Size(124, 13);
            this.txtBedCount.TabIndex = 15;
            this.txtBedCount.Text = "Кол-во спальных мест:";
            // 
            // txtBathroomCount
            // 
            this.txtBathroomCount.AutoSize = true;
            this.txtBathroomCount.Location = new System.Drawing.Point(20, 88);
            this.txtBathroomCount.Name = "txtBathroomCount";
            this.txtBathroomCount.Size = new System.Drawing.Size(124, 13);
            this.txtBathroomCount.TabIndex = 14;
            this.txtBathroomCount.Text = "Кол-во ванных комнат:";
            // 
            // txtRoomCount
            // 
            this.txtRoomCount.AutoSize = true;
            this.txtRoomCount.Location = new System.Drawing.Point(20, 65);
            this.txtRoomCount.Name = "txtRoomCount";
            this.txtRoomCount.Size = new System.Drawing.Size(84, 13);
            this.txtRoomCount.TabIndex = 13;
            this.txtRoomCount.Text = "Кол-во комнат:";
            // 
            // comboApparts
            // 
            this.comboApparts.FormattingEnabled = true;
            this.comboApparts.Location = new System.Drawing.Point(107, 31);
            this.comboApparts.Name = "comboApparts";
            this.comboApparts.Size = new System.Drawing.Size(121, 21);
            this.comboApparts.TabIndex = 11;
            this.comboApparts.SelectedIndexChanged += new System.EventHandler(this.comboApparts_SelectedIndexChanged);
            // 
            // textBox33
            // 
            this.textBox33.AutoSize = true;
            this.textBox33.Location = new System.Drawing.Point(20, 34);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(63, 13);
            this.textBox33.TabIndex = 1;
            this.textBox33.Text = "Категория:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(342, 241);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(179, 25);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Итоговая сумма:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(353, 269);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(141, 54);
            this.btnReg.TabIndex = 19;
            this.btnReg.Text = "Добавить бронь";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btShowBooking
            // 
            this.btShowBooking.Location = new System.Drawing.Point(353, 329);
            this.btShowBooking.Name = "btShowBooking";
            this.btShowBooking.Size = new System.Drawing.Size(141, 54);
            this.btShowBooking.TabIndex = 20;
            this.btShowBooking.Text = "Все брони";
            this.btShowBooking.UseVisualStyleBackColor = true;
            this.btShowBooking.Click += new System.EventHandler(this.btShowBooking_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::HotelSotnikov483.Properties.Resources.kisspng_hotel_icon_5_star_computer_icons_5ae44565d93681_6717417515249094138897;
            this.pic_Logo.Location = new System.Drawing.Point(4, 4);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(273, 231);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 7;
            this.pic_Logo.TabStop = false;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 477);
            this.Controls.Add(this.btShowBooking);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pic_Logo);
            this.Name = "FormManager";
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountOfDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericCountOfDays;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtPricePerDay;
        private System.Windows.Forms.Label txtBedCount;
        private System.Windows.Forms.Label txtBathroomCount;
        private System.Windows.Forms.Label txtRoomCount;
        private System.Windows.Forms.ComboBox comboApparts;
        private System.Windows.Forms.Label textBox33;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btShowBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericRoomNumber;
    }
}