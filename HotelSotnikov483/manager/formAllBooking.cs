using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSotnikov483.manager
{
    public partial class formAllBooking : Form
    {
        public formAllBooking()
        {
            InitializeComponent();
        }

        SotnikovHotelDataSetTableAdapters.BookingTableAdapter booking = new SotnikovHotelDataSetTableAdapters.BookingTableAdapter();

        /// <summary>
        /// return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// sill dataGridBooking by data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formAllBooking_Load(object sender, EventArgs e)
        {
            dataGridBooking.DataSource = booking.GetData();
            dataGridBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //fill comboBookings
            comboBookings.DataSource = booking.GetData();
            comboBookings.ValueMember = "idBooking";
            comboBookings.DisplayMember = "idBooking";
        }

        /// <summary>
        /// delete booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idBooking = (int)comboBookings.SelectedValue;
            booking.DeleteQuery(idBooking);

            //update dataGridBooking
            dataGridBooking.DataSource = booking.GetData();

        }
    }
}
