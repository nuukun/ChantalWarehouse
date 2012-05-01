namespace ChantalWarehouseWinForm
{
    partial class ItemCategoryChildWinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itmCategoryDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itmCategoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itmCategoryDataGrid
            // 
            this.itmCategoryDataGrid.AllowUserToOrderColumns = true;
            this.itmCategoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itmCategoryDataGrid.Location = new System.Drawing.Point(12, 59);
            this.itmCategoryDataGrid.Name = "itmCategoryDataGrid";
            this.itmCategoryDataGrid.Size = new System.Drawing.Size(344, 150);
            this.itmCategoryDataGrid.TabIndex = 0;
            // 
            // ItemCategoryChildWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 306);
            this.Controls.Add(this.itmCategoryDataGrid);
            this.Name = "ItemCategoryChildWinForm";
            this.Text = "ItemCategoryChildWinForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemCategoryChildWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itmCategoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itmCategoryDataGrid;

    }
}