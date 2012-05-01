using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChantalWarehouseWinForm.Business_Components;

namespace ChantalWarehouseWinForm
{
    public partial class ItemCategoryChildWinForm : Form
    {
        public ItemCategoryChildWinForm()
        {
            InitializeComponent();
        }

        private void ItemCategoryChildWinForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = MdiParent.ClientSize;
            this.Location = new Point(0, 0);
            this.Dock = DockStyle.Fill;


            ItemCategoryChild itemCategoryChild = new ItemCategoryChild();
            itmCategoryDataGrid.DataSource = itemCategoryChild.DoRead();

        }
    }
}
