using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSotnikov483
{
    public partial class FormAuthorization : Form
    {
        SotnikovHotelDataSetTableAdapters.UsersTableAdapter users = new SotnikovHotelDataSetTableAdapters.UsersTableAdapter();
        SotnikovHotelDataSetTableAdapters.HistoryTableAdapter history = new SotnikovHotelDataSetTableAdapters.HistoryTableAdapter();

        bool visible_pass = false;
        public FormAuthorization()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        /// <summary>
        /// show/hide password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_ShowPasswd_Click(object sender, EventArgs e)
        {
            if (visible_pass == false)
            {
                this.txtbox_Passwd.PasswordChar = '\0';
                visible_pass = true;
            }
            else
            {
                this.txtbox_Passwd.PasswordChar = '*';
                visible_pass = false;
            }
        }

        /// <summary>
        /// authtorize 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Auth_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.txtbox_Login.Text;
            log = this.txtbox_Passwd.Text;          //Исходные данные

            DateTime dt = DateTime.Now;			//Дата для истории
            string timeString = dt.ToLongTimeString();

            //Наложить на все записи фильтр на совпадение по логину и паролю
            var filter = users.GetData().Where(rec => rec.Login == log && rec.Password == pas);
            if (filter.Count() == 0)
            {
                MessageBox.Show("Таких данных нет.");

                //add new line to historyTable
                history.InsertQuery(Total.idUser, false, DateTime.Now);
            }
            else
            {

                Total.idUser = filter.ElementAt(0).idUser;
                Total.idRole = filter.ElementAt(0).idRole;
                Total.login = filter.ElementAt(0).Login;

                //add new success line to historyTable
                history.InsertQuery(Total.idUser, true, DateTime.Now);


                //Переход к формам в зависимости от роли
                switch (Total.idRole)
                {
                    case 1:
                        MessageBox.Show("Успешный вход(администратор)!");
                        FormAdmin fa = new FormAdmin(); ;
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        MessageBox.Show("Успешный вход(менеджер)!");
                        FormManager fs = new FormManager();
                        this.Hide();
                        fs.ShowDialog();
                        this.Show();
                        break;
                }

            }
        }
    }

}
