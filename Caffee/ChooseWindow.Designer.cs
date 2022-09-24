
namespace Caffee
{
    partial class ChooseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseWindow));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_titlebar_logo = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonAddNewWaiter = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.panel_Header.Controls.Add(this.label_title);
            this.panel_Header.Controls.Add(this.pictureBox_titlebar_logo);
            this.panel_Header.Controls.Add(this.button_close);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(330, 32);
            this.panel_Header.TabIndex = 7;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_title.Location = new System.Drawing.Point(40, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(117, 20);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Where to go?";
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
            this.button_close.Location = new System.Drawing.Point(284, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(46, 32);
            this.button_close.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_close, "Close");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.buttonContinue);
            this.panel1.Controls.Add(this.buttonAddNewWaiter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 160);
            this.panel1.TabIndex = 8;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.buttonContinue.Location = new System.Drawing.Point(45, 32);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(240, 32);
            this.buttonContinue.TabIndex = 12;
            this.buttonContinue.Text = "CONTINUE TO CAFFEE";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonAddNewWaiter
            // 
            this.buttonAddNewWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.buttonAddNewWaiter.FlatAppearance.BorderSize = 0;
            this.buttonAddNewWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.buttonAddNewWaiter.Location = new System.Drawing.Point(45, 96);
            this.buttonAddNewWaiter.Name = "buttonAddNewWaiter";
            this.buttonAddNewWaiter.Size = new System.Drawing.Size(240, 32);
            this.buttonAddNewWaiter.TabIndex = 11;
            this.buttonAddNewWaiter.Text = "ADD NEW WAITER";
            this.buttonAddNewWaiter.UseVisualStyleBackColor = false;
            this.buttonAddNewWaiter.Click += new System.EventHandler(this.buttonAddNewWaiter_Click);
            // 
            // ChooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseWindow";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_titlebar_logo;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonAddNewWaiter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}