namespace HotelSotnikov483.admin {
    partial class formAddAppart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericBed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBathroom = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericRoom = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBathroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericBed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericBathroom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericRoom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 205);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "titlleCategoty;";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 25;
            this.txtTitle.Text = "Супер-Люкс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "price per day:";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(119, 170);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrice.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(38, 20);
            this.numericPrice.TabIndex = 24;
            this.numericPrice.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "bedCount:";
            // 
            // numericBed
            // 
            this.numericBed.Location = new System.Drawing.Point(119, 134);
            this.numericBed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericBed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBed.Name = "numericBed";
            this.numericBed.Size = new System.Drawing.Size(38, 20);
            this.numericBed.TabIndex = 22;
            this.numericBed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "bathroomCount:";
            // 
            // numericBathroom
            // 
            this.numericBathroom.Location = new System.Drawing.Point(119, 98);
            this.numericBathroom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericBathroom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBathroom.Name = "numericBathroom";
            this.numericBathroom.Size = new System.Drawing.Size(38, 20);
            this.numericBathroom.TabIndex = 20;
            this.numericBathroom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "RoomCount";
            // 
            // numericRoom
            // 
            this.numericRoom.Location = new System.Drawing.Point(119, 63);
            this.numericRoom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRoom.Name = "numericRoom";
            this.numericRoom.Size = new System.Drawing.Size(38, 20);
            this.numericRoom.TabIndex = 18;
            this.numericRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(214, 59);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 59);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formAddAppart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Name = "formAddAppart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAddAppart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBathroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBathroom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericRoom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}