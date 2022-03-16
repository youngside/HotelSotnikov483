using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelSotnikov483
{
    public partial class FormAdminManageAccs : Form
    {
        SotnikovHotelDataSetTableAdapters.UsersTableAdapter useradapter = new SotnikovHotelDataSetTableAdapters.UsersTableAdapter();
        SotnikovHotelDataSet.UsersDataTable dataUser;

        public FormAdminManageAccs()
        {
            InitializeComponent();
        }
        /// <summary>
        /// formLoad, fill dataGridViewAccounts and fill comboUsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdminManageAccs_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            dataUser = this.useradapter.GetData();
            //Отбор только с ролью бегун (1) и спонсор (2)
            var filter = dataUser.Where(rec => rec.idRole == 2);
            //Количество записей
            int totalCount = filter.Count();
            //Отобразить полученные записи в компоненте
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            //Выделять всю строку

            dataGridViewAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();     //Выбрать первую строку    

            //fill comboUsers
            comboUsers.ValueMember = "idUser";
            comboUsers.DisplayMember = "idUser";
            comboUsers.DataSource = filter.CopyToDataTable();
        }

        /// <summary>
        /// add new account to db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string log = txtb_Login.Text;
            string pas = txtb_Passwd.Text;

            //Контроль корректности заполнения полей
            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (txtb_Passwd.Text.Length < 6)
            {
                MessageBox.Show("Пароль меньше 6 символов");
                return;
            }
            if (Regex.IsMatch(log, "^[А-Яа-я]+$"))
            {
                MessageBox.Show("В логине есть русские символы");
                return;
            }
            if (Regex.IsMatch(pas, "^[А-Яа-я]+$"))
            {
                MessageBox.Show("В пароле есть русские символы");
                return;
            }

            //Поиск совпадений по данным
            var filter = dataUser.Where(rec => rec.Login == log);
            if (filter.Count() == 0)	//Нет записей – совпадение логина не найдено
            {
                try
                {
                    //default idRole = 2
                    useradapter.Insert(2, log, pas);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    FormAdminManageAccs_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                    Environment.NewLine + " Введите другие данные");
                return;

            }
        }
        /// <summary>
        /// return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// delete user by id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idUser = (int)comboUsers.SelectedValue;
            useradapter.DeleteQuery(idUser);

            //update dataGridViewAccounts
            dataUser = this.useradapter.GetData();
            var filter = dataUser.Where(rec => rec.idRole == 2);
            //Количество записей
            int totalCount = filter.Count();
            //Отобразить полученные записи в компоненте
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();

        }
    }
}
