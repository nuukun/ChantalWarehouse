using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChantalWarehouseWinForm
{
    public partial class ChantalWarehouse : Form
    {
        public ChantalWarehouse()
        {
            InitializeComponent();
        }

        private void lnkItemCateory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemCategoryChildWinForm itemCategoryChildForm = new ItemCategoryChildWinForm();
            itemCategoryChildForm.MdiParent = this;
            itemCategoryChildForm.Show();

        }
    }
}
