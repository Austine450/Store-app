namespace Store_app
{
    partial class Form1
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
            this.panelfooter = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbllogedinUser = new System.Windows.Forms.Label();
            this.lblAppfname = new System.Windows.Forms.Label();
            this.lblAPPlname = new System.Windows.Forms.Label();
            this.lblsubhead = new System.Windows.Forms.Label();
            this.panelfooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelfooter.Controls.Add(this.lblfooter);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 428);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(971, 30);
            this.panelfooter.TabIndex = 0;
            this.panelfooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfooter_Paint);
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfooter.Location = new System.Drawing.Point(609, 4);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(139, 17);
            this.lblfooter.TabIndex = 0;
            this.lblfooter.Text = "Developed by  Austine";
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(971, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lbllogedinUser
            // 
            this.lbllogedinUser.AutoSize = true;
            this.lbllogedinUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogedinUser.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbllogedinUser.Location = new System.Drawing.Point(47, 40);
            this.lbllogedinUser.Name = "lbllogedinUser";
            this.lbllogedinUser.Size = new System.Drawing.Size(115, 17);
            this.lbllogedinUser.TabIndex = 3;
            this.lbllogedinUser.Text = "Austine Mungolo";
            // 
            // lblAppfname
            // 
            this.lblAppfname.AutoSize = true;
            this.lblAppfname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppfname.Location = new System.Drawing.Point(610, 313);
            this.lblAppfname.Name = "lblAppfname";
            this.lblAppfname.Size = new System.Drawing.Size(84, 32);
            this.lblAppfname.TabIndex = 4;
            this.lblAppfname.Text = "STORE";
            // 
            // lblAPPlname
            // 
            this.lblAPPlname.AutoSize = true;
            this.lblAPPlname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPPlname.Location = new System.Drawing.Point(686, 313);
            this.lblAPPlname.Name = "lblAPPlname";
            this.lblAPPlname.Size = new System.Drawing.Size(62, 32);
            this.lblAPPlname.TabIndex = 5;
            this.lblAPPlname.Text = "APP";
            // 
            // lblsubhead
            // 
            this.lblsubhead.AutoSize = true;
            this.lblsubhead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubhead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblsubhead.Location = new System.Drawing.Point(553, 355);
            this.lblsubhead.Name = "lblsubhead";
            this.lblsubhead.Size = new System.Drawing.Size(283, 25);
            this.lblsubhead.TabIndex = 6;
            this.lblsubhead.Text = "Building Inventory Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 458);
            this.Controls.Add(this.lblsubhead);
            this.Controls.Add(this.lblAPPlname);
            this.Controls.Add(this.lblAppfname);
            this.Controls.Add(this.lbllogedinUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbllogedinUser;
        private System.Windows.Forms.Label lblAppfname;
        private System.Windows.Forms.Label lblAPPlname;
        private System.Windows.Forms.Label lblsubhead;
    }
}

