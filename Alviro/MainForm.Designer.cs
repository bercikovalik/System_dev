namespace Alviro
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTopBar = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonHideMenu = new Button();
            panelMenu = new Panel();
            buttonMenuItem2 = new Button();
            buttonMenuItem1 = new Button();
            panelLeftInfo = new Panel();
            labelDate = new Label();
            panelMenuHideButton = new Panel();
            panel1 = new Panel();
            panelMain = new Panel();
            buttonRecipeUC = new Button();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelLeftInfo.SuspendLayout();
            panelMenuHideButton.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(35, 54, 46);
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            panelTopBar.Controls.Add(pictureBox2);
            panelTopBar.Controls.Add(pictureBox1);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1196, 55);
            panelTopBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonHideMenu
            // 
            buttonHideMenu.FlatStyle = FlatStyle.Flat;
            buttonHideMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonHideMenu.Location = new Point(5, 9);
            buttonHideMenu.Name = "buttonHideMenu";
            buttonHideMenu.Size = new Size(47, 47);
            buttonHideMenu.TabIndex = 3;
            buttonHideMenu.Text = "<";
            buttonHideMenu.TextAlign = ContentAlignment.TopCenter;
            buttonHideMenu.UseVisualStyleBackColor = true;
            buttonHideMenu.Click += buttonHideMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(86, 99, 111);
            panelMenu.Controls.Add(buttonRecipeUC);
            panelMenu.Controls.Add(buttonMenuItem2);
            panelMenu.Controls.Add(buttonMenuItem1);
            panelMenu.Controls.Add(panelLeftInfo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 55);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(205, 601);
            panelMenu.TabIndex = 1;
            // 
            // buttonMenuItem2
            // 
            buttonMenuItem2.Anchor = AnchorStyles.Top;
            buttonMenuItem2.BackColor = Color.FromArgb(104, 123, 82);
            buttonMenuItem2.FlatStyle = FlatStyle.Popup;
            buttonMenuItem2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMenuItem2.ForeColor = Color.White;
            buttonMenuItem2.Location = new Point(0, 72);
            buttonMenuItem2.Name = "buttonMenuItem2";
            buttonMenuItem2.Size = new Size(205, 58);
            buttonMenuItem2.TabIndex = 2;
            buttonMenuItem2.Text = "Hozzávalók";
            buttonMenuItem2.UseVisualStyleBackColor = false;
            buttonMenuItem2.Click += buttonMenuItem2_Click;
            // 
            // buttonMenuItem1
            // 
            buttonMenuItem1.Anchor = AnchorStyles.Top;
            buttonMenuItem1.BackColor = Color.FromArgb(104, 123, 82);
            buttonMenuItem1.FlatStyle = FlatStyle.Popup;
            buttonMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMenuItem1.ForeColor = Color.White;
            buttonMenuItem1.Location = new Point(0, 8);
            buttonMenuItem1.Margin = new Padding(0);
            buttonMenuItem1.Name = "buttonMenuItem1";
            buttonMenuItem1.Size = new Size(205, 58);
            buttonMenuItem1.TabIndex = 1;
            buttonMenuItem1.Text = "Minden recept";
            buttonMenuItem1.UseVisualStyleBackColor = false;
            buttonMenuItem1.Click += buttonMenuItem1_Click;
            // 
            // panelLeftInfo
            // 
            panelLeftInfo.BackColor = Color.FromArgb(35, 54, 46);
            panelLeftInfo.Controls.Add(labelDate);
            panelLeftInfo.Dock = DockStyle.Bottom;
            panelLeftInfo.Location = new Point(0, 527);
            panelLeftInfo.Name = "panelLeftInfo";
            panelLeftInfo.Size = new Size(205, 74);
            panelLeftInfo.TabIndex = 0;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelDate.ForeColor = Color.FromArgb(239, 238, 236);
            labelDate.Location = new Point(27, 37);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(81, 32);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenuHideButton
            // 
            panelMenuHideButton.BackColor = Color.Silver;
            panelMenuHideButton.Controls.Add(panel1);
            panelMenuHideButton.Dock = DockStyle.Left;
            panelMenuHideButton.Location = new Point(205, 55);
            panelMenuHideButton.Name = "panelMenuHideButton";
            panelMenuHideButton.Size = new Size(58, 601);
            panelMenuHideButton.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHideMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(58, 63);
            panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Silver;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(263, 55);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(933, 601);
            panelMain.TabIndex = 3;
            // 
            // buttonRecipeUC
            // 
            buttonRecipeUC.Anchor = AnchorStyles.Top;
            buttonRecipeUC.BackColor = Color.FromArgb(104, 123, 82);
            buttonRecipeUC.FlatStyle = FlatStyle.Popup;
            buttonRecipeUC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonRecipeUC.ForeColor = Color.White;
            buttonRecipeUC.Location = new Point(0, 137);
            buttonRecipeUC.Name = "buttonRecipeUC";
            buttonRecipeUC.Size = new Size(205, 58);
            buttonRecipeUC.TabIndex = 3;
            buttonRecipeUC.Text = "ReceptUC";
            buttonRecipeUC.UseVisualStyleBackColor = false;
            buttonRecipeUC.Click += buttonRecipeUC_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 656);
            Controls.Add(panelMain);
            Controls.Add(panelMenuHideButton);
            Controls.Add(panelMenu);
            Controls.Add(panelTopBar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alviro - Receptkezelő";
            panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelLeftInfo.ResumeLayout(false);
            panelLeftInfo.PerformLayout();
            panelMenuHideButton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelMenu;
        private Button buttonMenuItem1;
        private Panel panelLeftInfo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonMenuItem2;
        private Label labelDate;
        private Panel panelMenuHideButton;
        private Button buttonHideMenu;
        private Panel panelMain;
        private Panel panel1;
        private Button buttonRecipeUC;
    }
}
