using HotelSotnikov483.manager;
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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        int price = 0;
        int totalPrice = 0;

        SotnikovHotelDataSetTableAdapters.AppartsCategoryTableAdapter apparts = new SotnikovHotelDataSetTableAdapters.AppartsCategoryTableAdapter();
        SotnikovHotelDataSetTableAdapters.ClientsTableAdapter clients = new SotnikovHotelDataSetTableAdapters.ClientsTableAdapter();
        SotnikovHotelDataSetTableAdapters.BookingTableAdapter booking = new SotnikovHotelDataSetTableAdapters.BookingTableAdapter();


        /// <summary>
        /// close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// fill comboApparts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManager_Load(object sender, EventArgs e)
        {
            comboApparts.DisplayMember = "TitleCategory";
            comboApparts.ValueMember = "idCategory";
            comboApparts.DataSource = apparts.GetData();
        }

        /// <summary>
        /// fill info about appart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboApparts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = (int)comboApparts.SelectedValue;
            var filter = apparts.GetData().Where(x => x.idCategory == idCategory);

            txtBathroomCount.Text = "Bathroom count: " + filter.ElementAt(0).BathroomCount.ToString();
            txtBedCount.Text = "Bed count: " + filter.ElementAt(0).BedCount.ToString();
            txtRoomCount.Text = "Room count: " + filter.ElementAt(0).RoomCount.ToString();
            txtPricePerDay.Text = "Price per day: " + filter.ElementAt(0).PricePerDay.ToString();

            //change total price
            price = filter.ElementAt(0).PricePerDay;
            totalPrice = price * (int)numericCountOfDays.Value;
            labelPrice.Text = "Total price: " + totalPrice;
        }

        /// <summary>
        /// show all booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btShowBooking_Click(object sender, EventArgs e)
        {
            formAllBooking form = new formAllBooking();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// register new client, add new booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReg_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string patronymic = txtPatron.Text;
            DateTime date = dtDob.Value;
            int countDays = (int)numericCountOfDays.Value;

            //add client
            clients.InsertQuery(lastname, firstname, patronymic, date.ToString());

            //add new booking
            int idClient = clients.GetData().Where(x => x.Surname == lastname && x.Name == firstname && x.Patronomic == patronymic).ElementAt(0).idClient;
            int idCategory = (int)comboApparts.SelectedValue;
            int roomNum = (int)numericRoomNumber.Value;
            booking.InsertQuery(idClient, idCategory, countDays, date, totalPrice, roomNum);

            MessageBox.Show("Успешно добавлена запись  о бронировании!");
        }

        /// <summary>
        /// change price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericCountOfDays_ValueChanged(object sender, EventArgs e)
        {
            //change total price
            totalPrice = price * (int)numericCountOfDays.Value;
            labelPrice.Text = "Total price: " + totalPrice;
        }
    }
}
