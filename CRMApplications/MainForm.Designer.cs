
namespace CRMApplications
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProductToolStripMenuItem,
            this.searchProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // createProductToolStripMenuItem
            // 
            this.createProductToolStripMenuItem.Name = "createProductToolStripMenuItem";
            this.createProductToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createProductToolStripMenuItem.Text = "Create product";
            this.createProductToolStripMenuItem.Click += new System.EventHandler(this.createProductToolStripMenuItem_Click_1);
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.searchProductToolStripMenuItem.Text = "Search product";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click_1);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.searchClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewClientToolStripMenuItem.Text = "Add new client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchClientToolStripMenuItem.Text = "Search client";
            this.searchClientToolStripMenuItem.Click += new System.EventHandler(this.searchClientToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewOrderToolStripMenuItem,
            this.searchOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // createNewOrderToolStripMenuItem
            // 
            this.createNewOrderToolStripMenuItem.Name = "createNewOrderToolStripMenuItem";
            this.createNewOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewOrderToolStripMenuItem.Text = "Create new order";
            this.createNewOrderToolStripMenuItem.Click += new System.EventHandler(this.createNewOrderToolStripMenuItem_Click);
            // 
            // searchOrdersToolStripMenuItem
            // 
            this.searchOrdersToolStripMenuItem.Name = "searchOrdersToolStripMenuItem";
            this.searchOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchOrdersToolStripMenuItem.Text = "Search orders";
            this.searchOrdersToolStripMenuItem.Click += new System.EventHandler(this.searchOrdersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 439);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
    }
}

