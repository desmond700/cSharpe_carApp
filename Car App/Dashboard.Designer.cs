namespace Car_App
{
    partial class Dashboard
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMCars = new System.Windows.Forms.MenuStrip();
            this.addNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageCarLink = new System.Windows.Forms.LinkLabel();
            this.adminLink = new System.Windows.Forms.LinkLabel();
            this.manageCarPanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.editProfilePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listAllCarsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStripAdmin.SuspendLayout();
            this.menuStripMCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.manageCarPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            this.editProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.Controls.Add(this.menuStripAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStripMCars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStripAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStripAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStripAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 68);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStripAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripAdmin.Size = new System.Drawing.Size(784, 29);
            this.menuStripAdmin.TabIndex = 3;
            this.menuStripAdmin.Text = "menuStrip2";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.editProfileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(135, 0, 0, 0);
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.editProfileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            this.editProfileToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            this.changePasswordToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            this.logoutToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin\'s Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripMCars
            // 
            this.menuStripMCars.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStripMCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStripMCars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarToolStripMenuItem,
            this.editExistingCarToolStripMenuItem,
            this.viewCarDetailsToolStripMenuItem,
            this.findCarToolStripMenuItem,
            this.listAllCarsToolStripMenuItem});
            this.menuStripMCars.Location = new System.Drawing.Point(0, 66);
            this.menuStripMCars.Name = "menuStripMCars";
            this.menuStripMCars.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStripMCars.Size = new System.Drawing.Size(784, 31);
            this.menuStripMCars.TabIndex = 1;
            this.menuStripMCars.Text = "menuStrip1";
            this.menuStripMCars.Visible = false;
            // 
            // addNewCarToolStripMenuItem
            // 
            this.addNewCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addNewCarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(135, 0, 0, 0);
            this.addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            this.addNewCarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addNewCarToolStripMenuItem.Size = new System.Drawing.Size(85, 31);
            this.addNewCarToolStripMenuItem.Text = "Add new car";
            this.addNewCarToolStripMenuItem.Click += new System.EventHandler(this.addNewCarToolStripMenuItem_Click);
            this.addNewCarToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManageCarToolStripMenuItem_MouseDown);
            // 
            // editExistingCarToolStripMenuItem
            // 
            this.editExistingCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.editExistingCarToolStripMenuItem.Name = "editExistingCarToolStripMenuItem";
            this.editExistingCarToolStripMenuItem.Size = new System.Drawing.Size(101, 31);
            this.editExistingCarToolStripMenuItem.Text = "Edit existing car";
            this.editExistingCarToolStripMenuItem.Click += new System.EventHandler(this.editExistingCarToolStripMenuItem_Click);
            this.editExistingCarToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManageCarToolStripMenuItem_MouseDown);
            // 
            // viewCarDetailsToolStripMenuItem
            // 
            this.viewCarDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.viewCarDetailsToolStripMenuItem.Name = "viewCarDetailsToolStripMenuItem";
            this.viewCarDetailsToolStripMenuItem.Size = new System.Drawing.Size(100, 31);
            this.viewCarDetailsToolStripMenuItem.Text = "View car details";
            this.viewCarDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCarDetailsToolStripMenuItem_Click);
            this.viewCarDetailsToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManageCarToolStripMenuItem_MouseDown);
            // 
            // findCarToolStripMenuItem
            // 
            this.findCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.findCarToolStripMenuItem.Name = "findCarToolStripMenuItem";
            this.findCarToolStripMenuItem.Size = new System.Drawing.Size(61, 31);
            this.findCarToolStripMenuItem.Text = "Find car";
            this.findCarToolStripMenuItem.Click += new System.EventHandler(this.findCarToolStripMenuItem_Click);
            this.findCarToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManageCarToolStripMenuItem_MouseDown);
            // 
            // listAllCarsToolStripMenuItem
            // 
            this.listAllCarsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.listAllCarsToolStripMenuItem.Name = "listAllCarsToolStripMenuItem";
            this.listAllCarsToolStripMenuItem.Size = new System.Drawing.Size(76, 31);
            this.listAllCarsToolStripMenuItem.Text = "List all cars";
            this.listAllCarsToolStripMenuItem.Click += new System.EventHandler(this.listAllCarsToolStripMenuItem_Click);
            this.listAllCarsToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManageCarToolStripMenuItem_MouseDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.manageCarPanel);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(784, 460);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ManageCarLink);
            this.panel1.Controls.Add(this.adminLink);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 455);
            this.panel1.TabIndex = 2;
            // 
            // ManageCarLink
            // 
            this.ManageCarLink.AutoSize = true;
            this.ManageCarLink.BackColor = System.Drawing.SystemColors.Highlight;
            this.ManageCarLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCarLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ManageCarLink.LinkColor = System.Drawing.Color.White;
            this.ManageCarLink.Location = new System.Drawing.Point(0, 84);
            this.ManageCarLink.Name = "ManageCarLink";
            this.ManageCarLink.Padding = new System.Windows.Forms.Padding(31, 10, 31, 10);
            this.ManageCarLink.Size = new System.Drawing.Size(142, 36);
            this.ManageCarLink.TabIndex = 1;
            this.ManageCarLink.TabStop = true;
            this.ManageCarLink.Text = "Manage car";
            this.ManageCarLink.Click += new System.EventHandler(this.linkLabel2_LinkClicked);
            this.ManageCarLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LinkItem_MouseDown);
            // 
            // adminLink
            // 
            this.adminLink.AutoSize = true;
            this.adminLink.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminLink.Font = new System.Drawing.Font("Segoe UI Symbol", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.adminLink.LinkColor = System.Drawing.Color.White;
            this.adminLink.Location = new System.Drawing.Point(0, 34);
            this.adminLink.Name = "adminLink";
            this.adminLink.Padding = new System.Windows.Forms.Padding(48, 10, 48, 10);
            this.adminLink.Size = new System.Drawing.Size(141, 37);
            this.adminLink.TabIndex = 0;
            this.adminLink.TabStop = true;
            this.adminLink.Text = "Admin";
            this.adminLink.Click += new System.EventHandler(this.linkLabel1_LinkClicked);
            this.adminLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LinkItem_MouseDown);
            // 
            // manageCarPanel
            // 
            this.manageCarPanel.AutoScroll = true;
            this.manageCarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manageCarPanel.Controls.Add(this.adminPanel);
            this.manageCarPanel.Controls.Add(this.listAllCarsPanel);
            this.manageCarPanel.Location = new System.Drawing.Point(1, 0);
            this.manageCarPanel.Name = "manageCarPanel";
            this.manageCarPanel.Size = new System.Drawing.Size(632, 455);
            this.manageCarPanel.TabIndex = 1;
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPanel.Controls.Add(this.changePasswordPanel);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(0, 0);
            this.adminPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(632, 455);
            this.adminPanel.TabIndex = 3;
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.Controls.Add(this.editProfilePanel);
            this.changePasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(632, 455);
            this.changePasswordPanel.TabIndex = 4;
            // 
            // editProfilePanel
            // 
            this.editProfilePanel.Controls.Add(this.tableLayoutPanel1);
            this.editProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.editProfilePanel.Name = "editProfilePanel";
            this.editProfilePanel.Size = new System.Drawing.Size(632, 455);
            this.editProfilePanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.06202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.93798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listAllCarsPanel
            // 
            this.listAllCarsPanel.AutoScroll = true;
            this.listAllCarsPanel.AutoSize = true;
            this.listAllCarsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listAllCarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAllCarsPanel.Location = new System.Drawing.Point(0, 0);
            this.listAllCarsPanel.Name = "listAllCarsPanel";
            this.listAllCarsPanel.Size = new System.Drawing.Size(632, 455);
            this.listAllCarsPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStripAdmin;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dashboard";
            this.Text = "Car App";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.menuStripMCars.ResumeLayout(false);
            this.menuStripMCars.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.manageCarPanel.ResumeLayout(false);
            this.manageCarPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.changePasswordPanel.ResumeLayout(false);
            this.editProfilePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ManageCarLink;
        private System.Windows.Forms.LinkLabel adminLink;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel manageCarPanel;
        private System.Windows.Forms.MenuStrip menuStripMCars;
        private System.Windows.Forms.ToolStripMenuItem addNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCarDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllCarsToolStripMenuItem;
        private System.Windows.Forms.Panel listAllCarsPanel;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel changePasswordPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel editProfilePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}