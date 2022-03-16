using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSotnikov483.admin
{
    public partial class FormAdminHistory : Form
    {
        public FormAdminHistory()
        {
            InitializeComponent();
        }
        SotnikovHotelDataSetTableAdapters.HistoryTableAdapter history = new SotnikovHotelDataSetTableAdapters.HistoryTableAdapter();


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
        /// fill dataGridView by data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdminHistory_Load(object sender, EventArgs e)
        {
            dataGridHistory.DataSource = history.GetData();
            dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
