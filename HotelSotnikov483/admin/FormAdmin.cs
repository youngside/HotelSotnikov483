using HotelSotnikov483.admin;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// return to auth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// open manageAllAccounts form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ManageAllAccounts_Click(object sender, EventArgs e)
        {
            FormAdminManageAccs fam = new FormAdminManageAccs();
            this.Hide();
            fam.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// form history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            FormAdminHistory form = new FormAdminHistory();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// add new appart form open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewAppart_Click(object sender, EventArgs e)
        {
            formAddAppart form = new formAddAppart();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
