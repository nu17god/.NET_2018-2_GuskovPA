namespace UsersAndAwardsWinFormsPL
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataAwards = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Awards = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAward = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAward = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAward = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAwards)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.dataUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            // 
            // dataUsers
            // 
            this.dataUsers.AllowUserToAddRows = false;
            this.dataUsers.AllowUserToDeleteRows = false;
            this.dataUsers.AllowUserToResizeColumns = false;
            this.dataUsers.AllowUserToResizeRows = false;
            this.dataUsers.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.Location = new System.Drawing.Point(3, 3);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsers.Size = new System.Drawing.Size(1250, 625);
            this.dataUsers.TabIndex = 0;
            this.dataUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataUsers_ColumnHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.dataAwards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Awards";
            // 
            // dataAwards
            // 
            this.dataAwards.AllowUserToAddRows = false;
            this.dataAwards.AllowUserToDeleteRows = false;
            this.dataAwards.AllowUserToResizeRows = false;
            this.dataAwards.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAwards.Location = new System.Drawing.Point(3, 3);
            this.dataAwards.Name = "dataAwards";
            this.dataAwards.ReadOnly = true;
            this.dataAwards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAwards.Size = new System.Drawing.Size(1250, 625);
            this.dataAwards.TabIndex = 0;
            this.dataAwards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataAwards_ColumnHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Users,
            this.Awards,
            this.Exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUser,
            this.UpdateUser,
            this.RemoveUser});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(113, 22);
            this.Users.Text = "Users";
            // 
            // AddUser
            // 
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(143, 22);
            this.AddUser.Text = "Add User";
            this.AddUser.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(143, 22);
            this.UpdateUser.Text = "Update User";
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(143, 22);
            this.RemoveUser.Text = "Remove User";
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // Awards
            // 
            this.Awards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAward,
            this.UpdateAward,
            this.RemoveAward});
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(113, 22);
            this.Awards.Text = "Awards";
            // 
            // AddAward
            // 
            this.AddAward.Name = "AddAward";
            this.AddAward.Size = new System.Drawing.Size(154, 22);
            this.AddAward.Text = "Add Award";
            this.AddAward.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // UpdateAward
            // 
            this.UpdateAward.Name = "UpdateAward";
            this.UpdateAward.Size = new System.Drawing.Size(154, 22);
            this.UpdateAward.Text = "Update Award";
            this.UpdateAward.Click += new System.EventHandler(this.UpdateAward_Click);
            // 
            // RemoveAward
            // 
            this.RemoveAward.Name = "RemoveAward";
            this.RemoveAward.Size = new System.Drawing.Size(154, 22);
            this.RemoveAward.Text = "Remove Award";
            this.RemoveAward.Click += new System.EventHandler(this.RemoveAward_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(720, 405);
            this.Name = "frmMain";
            this.Text = "Users And Awards";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAwards)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserAwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getUsersAwardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUsersAwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAwardToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem Awards;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem UpdateUser;
        private System.Windows.Forms.ToolStripMenuItem RemoveUser;
        private System.Windows.Forms.ToolStripMenuItem AddAward;
        private System.Windows.Forms.ToolStripMenuItem UpdateAward;
        private System.Windows.Forms.ToolStripMenuItem RemoveAward;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.DataGridView dataAwards;
    }
}

