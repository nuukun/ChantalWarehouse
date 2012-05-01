namespace ChantalWarehouseWinForm
{
    partial class ChantalWarehouse
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
            this.menuSplitter = new System.Windows.Forms.Splitter();
            this.lnkItemCateory = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSplitter
            // 
            this.menuSplitter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuSplitter.Location = new System.Drawing.Point(0, 24);
            this.menuSplitter.Name = "menuSplitter";
            this.menuSplitter.Size = new System.Drawing.Size(140, 299);
            this.menuSplitter.TabIndex = 0;
            this.menuSplitter.TabStop = false;
            // 
            // lnkItemCateory
            // 
            this.lnkItemCateory.AutoSize = true;
            this.lnkItemCateory.Location = new System.Drawing.Point(12, 41);
            this.lnkItemCateory.Name = "lnkItemCateory";
            this.lnkItemCateory.Size = new System.Drawing.Size(72, 13);
            this.lnkItemCateory.TabIndex = 2;
            this.lnkItemCateory.TabStop = true;
            this.lnkItemCateory.Text = "Item Category";
            this.lnkItemCateory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkItemCateory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkItemCateory_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem2.Text = "\\";
            // 
            // ChantalWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 323);
            this.Controls.Add(this.lnkItemCateory);
            this.Controls.Add(this.menuSplitter);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChantalWarehouse";
            this.Text = "This is Parent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter menuSplitter;
        private System.Windows.Forms.LinkLabel lnkItemCateory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

