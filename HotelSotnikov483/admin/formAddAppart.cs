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
    public partial class formAddAppart : Form
    {
        public formAddAppart()
        {
            InitializeComponent();
        }

        SotnikovHotelDataSetTableAdapters.AppartsCategoryTableAdapter category = new SotnikovHotelDataSetTableAdapters.AppartsCategoryTableAdapter();

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
        /// add new category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int roomCount = (int)numericRoom.Value;
            int bathroomCount = (int)numericBathroom.Value;
            int bedCout = (int)numericBed.Value;
            int price = (int)numericPrice.Value;

            if (title != "")
            {
                var filter = category.GetData().Where(x => x.TitleCategory == title);

                if (filter.Count() == 0)
                {
                    category.InsertQuery(title, roomCount, bathroomCount, bedCout, price);
                    MessageBox.Show("Категория добалена!");

                }
                else
                {
                    MessageBox.Show("Категория уже существует!");
                }
            }
        }
    }
}
