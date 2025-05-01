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
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            panelMenuItem2 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panelMenuItem1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panelLeftInfo = new Panel();
            labelDate = new Label();
            pictureBoxRightArrow = new PictureBox();
            panelMain = new Panel();
            pictureBoxArrowLeft = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelMenuItem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelMenuItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLeftInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArrowLeft).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(51, 51, 51);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 51);
            panelMenu.Controls.Add(panelMenuItem2);
            panelMenu.Controls.Add(panelMenuItem1);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(panelLeftInfo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(258, 656);
            panelMenu.TabIndex = 1;
            // 
            // panelMenuItem2
            // 
            panelMenuItem2.Controls.Add(label2);
            panelMenuItem2.Controls.Add(pictureBox4);
            panelMenuItem2.Cursor = Cursors.Hand;
            panelMenuItem2.Dock = DockStyle.Top;
            panelMenuItem2.Location = new Point(0, 210);
            panelMenuItem2.Name = "panelMenuItem2";
            panelMenuItem2.Size = new Size(258, 54);
            panelMenuItem2.TabIndex = 7;
            panelMenuItem2.Click += panelMenuItem2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 11);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 2;
            label2.Text = "Hozzávalók";
            label2.Click += label2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panelMenuItem1
            // 
            panelMenuItem1.Controls.Add(label1);
            panelMenuItem1.Controls.Add(pictureBox3);
            panelMenuItem1.Cursor = Cursors.Hand;
            panelMenuItem1.Dock = DockStyle.Top;
            panelMenuItem1.Location = new Point(0, 156);
            panelMenuItem1.Name = "panelMenuItem1";
            panelMenuItem1.Size = new Size(258, 54);
            panelMenuItem1.TabIndex = 6;
            panelMenuItem1.Click += panelMenuItem1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 2;
            label1.Text = "Receptek";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 27);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(51, 51, 51);
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panelLeftInfo
            // 
            panelLeftInfo.BackColor = Color.FromArgb(29, 55, 46);
            panelLeftInfo.Controls.Add(labelDate);
            panelLeftInfo.Dock = DockStyle.Bottom;
            panelLeftInfo.Location = new Point(0, 582);
            panelLeftInfo.Name = "panelLeftInfo";
            panelLeftInfo.Size = new Size(258, 74);
            panelLeftInfo.TabIndex = 0;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.None;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelDate.ForeColor = Color.FromArgb(239, 238, 236);
            labelDate.Location = new Point(65, 37);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(113, 32);
            labelDate.TabIndex = 0;
            labelDate.Text = "-Dátum-";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxRightArrow
            // 
            pictureBoxRightArrow.BackColor = Color.Transparent;
            pictureBoxRightArrow.Cursor = Cursors.Hand;
            pictureBoxRightArrow.Enabled = false;
            pictureBoxRightArrow.Image = (Image)resources.GetObject("pictureBoxRightArrow.Image");
            pictureBoxRightArrow.Location = new Point(3, 5);
            pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            pictureBoxRightArrow.Size = new Size(45, 45);
            pictureBoxRightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRightArrow.TabIndex = 1;
            pictureBoxRightArrow.TabStop = false;
            pictureBoxRightArrow.Visible = false;
            pictureBoxRightArrow.Click += pictureBoxRightArrow_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Silver;
            panelMain.Controls.Add(pictureBoxRightArrow);
            panelMain.Controls.Add(pictureBoxArrowLeft);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(258, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(938, 656);
            panelMain.TabIndex = 3;
            // 
            // pictureBoxArrowLeft
            // 
            pictureBoxArrowLeft.BackColor = Color.Transparent;
            pictureBoxArrowLeft.Cursor = Cursors.Hand;
            pictureBoxArrowLeft.Image = (Image)resources.GetObject("pictureBoxArrowLeft.Image");
            pictureBoxArrowLeft.Location = new Point(3, 4);
            pictureBoxArrowLeft.Name = "pictureBoxArrowLeft";
            pictureBoxArrowLeft.Size = new Size(45, 45);
            pictureBoxArrowLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxArrowLeft.TabIndex = 0;
            pictureBoxArrowLeft.TabStop = false;
            pictureBoxArrowLeft.Click += pictureBoxArrowLeft_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 656);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alviro - Receptkezelő";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenuItem2.ResumeLayout(false);
            panelMenuItem2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelMenuItem1.ResumeLayout(false);
            panelMenuItem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLeftInfo.ResumeLayout(false);
            panelLeftInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).EndInit();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxArrowLeft).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLeftInfo;
        private PictureBox pictureBox1;
        private Label labelDate;
        private Panel panelMain;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panelMenuItem1;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panelMenuItem2;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBoxArrowLeft;
        private PictureBox pictureBoxRightArrow;
    }
}
