
namespace Caffee
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_titlebar_logo = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_windowed = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_showMenu = new System.Windows.Forms.Button();
            this.button_hideMenu = new System.Windows.Forms.Button();
            this.panel_sideMenu = new System.Windows.Forms.Panel();
            this.labelCopyrightInfo = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_dailyRecap = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_addTable = new System.Windows.Forms.Button();
            this.panel_accountPanel = new System.Windows.Forms.Panel();
            this.panel_accountLabelPanel = new System.Windows.Forms.Panel();
            this.label_accountRole = new System.Windows.Forms.Label();
            this.label_accountUsername = new System.Windows.Forms.Label();
            this.pictureBox_accountPicture = new System.Windows.Forms.PictureBox();
            this.panelFloor = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).BeginInit();
            this.panel_sideMenu.SuspendLayout();
            this.panel_accountPanel.SuspendLayout();
            this.panel_accountLabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_accountPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.panel_Header.Controls.Add(this.label_title);
            this.panel_Header.Controls.Add(this.pictureBox_titlebar_logo);
            this.panel_Header.Controls.Add(this.button_minimize);
            this.panel_Header.Controls.Add(this.button_windowed);
            this.panel_Header.Controls.Add(this.button_close);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1206, 32);
            this.panel_Header.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_title.Location = new System.Drawing.Point(40, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(85, 20);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "MyCaffee";
            // 
            // pictureBox_titlebar_logo
            // 
            this.pictureBox_titlebar_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_titlebar_logo.BackgroundImage")));
            this.pictureBox_titlebar_logo.Location = new System.Drawing.Point(6, 0);
            this.pictureBox_titlebar_logo.Name = "pictureBox_titlebar_logo";
            this.pictureBox_titlebar_logo.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_titlebar_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_titlebar_logo.TabIndex = 1;
            this.pictureBox_titlebar_logo.TabStop = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_minimize.Location = new System.Drawing.Point(1068, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(46, 32);
            this.button_minimize.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_minimize, "Minimize");
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_windowed
            // 
            this.button_windowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_windowed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_windowed.BackgroundImage")));
            this.button_windowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_windowed.FlatAppearance.BorderSize = 0;
            this.button_windowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_windowed.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_windowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_windowed.Location = new System.Drawing.Point(1114, 0);
            this.button_windowed.Name = "button_windowed";
            this.button_windowed.Size = new System.Drawing.Size(46, 32);
            this.button_windowed.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_windowed, "Restore Down");
            this.button_windowed.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.AccessibleDescription = "";
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_close.Location = new System.Drawing.Point(1160, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(46, 32);
            this.button_close.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_close, "Close");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_showMenu
            // 
            this.button_showMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_showMenu.BackgroundImage")));
            this.button_showMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showMenu.FlatAppearance.BorderSize = 0;
            this.button_showMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showMenu.Location = new System.Drawing.Point(0, 0);
            this.button_showMenu.Name = "button_showMenu";
            this.button_showMenu.Size = new System.Drawing.Size(38, 38);
            this.button_showMenu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_showMenu, "Show Menu");
            this.button_showMenu.UseVisualStyleBackColor = true;
            this.button_showMenu.Click += new System.EventHandler(this.button_showMenu_Click);
            // 
            // button_hideMenu
            // 
            this.button_hideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hideMenu.BackgroundImage")));
            this.button_hideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hideMenu.FlatAppearance.BorderSize = 0;
            this.button_hideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hideMenu.Location = new System.Drawing.Point(178, 0);
            this.button_hideMenu.Name = "button_hideMenu";
            this.button_hideMenu.Size = new System.Drawing.Size(38, 38);
            this.button_hideMenu.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_hideMenu, "Hide Menu");
            this.button_hideMenu.UseVisualStyleBackColor = true;
            this.button_hideMenu.Click += new System.EventHandler(this.button_hideMenu_Click);
            // 
            // panel_sideMenu
            // 
            this.panel_sideMenu.AutoScroll = true;
            this.panel_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.panel_sideMenu.Controls.Add(this.labelCopyrightInfo);
            this.panel_sideMenu.Controls.Add(this.button_logout);
            this.panel_sideMenu.Controls.Add(this.button_dailyRecap);
            this.panel_sideMenu.Controls.Add(this.button_menu);
            this.panel_sideMenu.Controls.Add(this.button_addTable);
            this.panel_sideMenu.Controls.Add(this.panel_accountPanel);
            this.panel_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideMenu.Location = new System.Drawing.Point(0, 32);
            this.panel_sideMenu.Name = "panel_sideMenu";
            this.panel_sideMenu.Size = new System.Drawing.Size(216, 652);
            this.panel_sideMenu.TabIndex = 1;
            // 
            // labelCopyrightInfo
            // 
            this.labelCopyrightInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCopyrightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyrightInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.labelCopyrightInfo.Location = new System.Drawing.Point(0, 629);
            this.labelCopyrightInfo.Name = "labelCopyrightInfo";
            this.labelCopyrightInfo.Size = new System.Drawing.Size(216, 23);
            this.labelCopyrightInfo.TabIndex = 4;
            this.labelCopyrightInfo.Text = "© Slozna Braca Software Inc.";
            this.labelCopyrightInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_logout
            // 
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_logout.Location = new System.Drawing.Point(0, 342);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(216, 39);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_dailyRecap
            // 
            this.button_dailyRecap.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dailyRecap.FlatAppearance.BorderSize = 0;
            this.button_dailyRecap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dailyRecap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dailyRecap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_dailyRecap.Location = new System.Drawing.Point(0, 303);
            this.button_dailyRecap.Name = "button_dailyRecap";
            this.button_dailyRecap.Size = new System.Drawing.Size(216, 39);
            this.button_dailyRecap.TabIndex = 2;
            this.button_dailyRecap.Text = "DAILY REPORT";
            this.button_dailyRecap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dailyRecap.UseVisualStyleBackColor = true;
            this.button_dailyRecap.Click += new System.EventHandler(this.button_dailyRecap_Click);
            // 
            // button_menu
            // 
            this.button_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_menu.Location = new System.Drawing.Point(0, 264);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(216, 39);
            this.button_menu.TabIndex = 1;
            this.button_menu.Text = "MENU";
            this.button_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_addTable
            // 
            this.button_addTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_addTable.FlatAppearance.BorderSize = 0;
            this.button_addTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_addTable.Location = new System.Drawing.Point(0, 225);
            this.button_addTable.Name = "button_addTable";
            this.button_addTable.Size = new System.Drawing.Size(216, 39);
            this.button_addTable.TabIndex = 0;
            this.button_addTable.Text = "ADD TABLE";
            this.button_addTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTable.UseVisualStyleBackColor = true;
            this.button_addTable.Click += new System.EventHandler(this.button_addTable_Click);
            // 
            // panel_accountPanel
            // 
            this.panel_accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.panel_accountPanel.Controls.Add(this.panel_accountLabelPanel);
            this.panel_accountPanel.Controls.Add(this.pictureBox_accountPicture);
            this.panel_accountPanel.Controls.Add(this.button_showMenu);
            this.panel_accountPanel.Controls.Add(this.button_hideMenu);
            this.panel_accountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accountPanel.Location = new System.Drawing.Point(0, 0);
            this.panel_accountPanel.Name = "panel_accountPanel";
            this.panel_accountPanel.Size = new System.Drawing.Size(216, 225);
            this.panel_accountPanel.TabIndex = 0;
            // 
            // panel_accountLabelPanel
            // 
            this.panel_accountLabelPanel.Controls.Add(this.label_accountRole);
            this.panel_accountLabelPanel.Controls.Add(this.label_accountUsername);
            this.panel_accountLabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_accountLabelPanel.Location = new System.Drawing.Point(0, 178);
            this.panel_accountLabelPanel.Name = "panel_accountLabelPanel";
            this.panel_accountLabelPanel.Size = new System.Drawing.Size(216, 47);
            this.panel_accountLabelPanel.TabIndex = 4;
            // 
            // label_accountRole
            // 
            this.label_accountRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_accountRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accountRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_accountRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_accountRole.Location = new System.Drawing.Point(0, 21);
            this.label_accountRole.Name = "label_accountRole";
            this.label_accountRole.Size = new System.Drawing.Size(216, 21);
            this.label_accountRole.TabIndex = 4;
            this.label_accountRole.Text = "Role";
            this.label_accountRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_accountUsername
            // 
            this.label_accountUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_accountUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accountUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_accountUsername.Location = new System.Drawing.Point(0, 0);
            this.label_accountUsername.Name = "label_accountUsername";
            this.label_accountUsername.Size = new System.Drawing.Size(216, 21);
            this.label_accountUsername.TabIndex = 3;
            this.label_accountUsername.Text = "Username";
            this.label_accountUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_accountPicture
            // 
            this.pictureBox_accountPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_accountPicture.Location = new System.Drawing.Point(44, 44);
            this.pictureBox_accountPicture.Name = "pictureBox_accountPicture";
            this.pictureBox_accountPicture.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_accountPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_accountPicture.TabIndex = 2;
            this.pictureBox_accountPicture.TabStop = false;
            // 
            // panelFloor
            // 
            this.panelFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.panelFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFloor.Location = new System.Drawing.Point(216, 32);
            this.panelFloor.Name = "panelFloor";
            this.panelFloor.Size = new System.Drawing.Size(990, 652);
            this.panelFloor.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 684);
            this.Controls.Add(this.panelFloor);
            this.Controls.Add(this.panel_sideMenu);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MyCaffee";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).EndInit();
            this.panel_sideMenu.ResumeLayout(false);
            this.panel_accountPanel.ResumeLayout(false);
            this.panel_accountLabelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_accountPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_windowed;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_titlebar_logo;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_sideMenu;
        private System.Windows.Forms.Button button_addTable;
        private System.Windows.Forms.Panel panel_accountPanel;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_dailyRecap;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_hideMenu;
        private System.Windows.Forms.Button button_showMenu;
        private System.Windows.Forms.Panel panelFloor;
        private System.Windows.Forms.PictureBox pictureBox_accountPicture;
        private System.Windows.Forms.Label label_accountUsername;
        private System.Windows.Forms.Panel panel_accountLabelPanel;
        private System.Windows.Forms.Label label_accountRole;
        private System.Windows.Forms.Label labelCopyrightInfo;
    }
}

