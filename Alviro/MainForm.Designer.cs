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
            panelMenu = new Panel();
            buttonMenuItem2 = new Button();
            buttonMenuItem1 = new Button();
            panelLeftInfo = new Panel();
            label1 = new Label();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelLeftInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(35, 54, 46);
            panelTopBar.Controls.Add(pictureBox2);
            panelTopBar.Controls.Add(pictureBox1);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1057, 50);
            panelTopBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 50);
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
            pictureBox1.Size = new Size(86, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(86, 99, 111);
            panelMenu.Controls.Add(buttonMenuItem2);
            panelMenu.Controls.Add(buttonMenuItem1);
            panelMenu.Controls.Add(panelLeftInfo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(205, 507);
            panelMenu.TabIndex = 1;
            // 
            // buttonMenuItem2
            // 
            buttonMenuItem2.Anchor = AnchorStyles.None;
            buttonMenuItem2.BackColor = Color.Transparent;
            buttonMenuItem2.Location = new Point(5, 70);
            buttonMenuItem2.Name = "buttonMenuItem2";
            buttonMenuItem2.Size = new Size(195, 58);
            buttonMenuItem2.TabIndex = 2;
            buttonMenuItem2.Text = "Hozzávalók";
            buttonMenuItem2.UseVisualStyleBackColor = false;
            // 
            // buttonMenuItem1
            // 
            buttonMenuItem1.Anchor = AnchorStyles.None;
            buttonMenuItem1.BackColor = Color.Transparent;
            buttonMenuItem1.Location = new Point(5, 6);
            buttonMenuItem1.Name = "buttonMenuItem1";
            buttonMenuItem1.Size = new Size(195, 58);
            buttonMenuItem1.TabIndex = 1;
            buttonMenuItem1.Text = "Minden recept";
            buttonMenuItem1.UseVisualStyleBackColor = false;
            // 
            // panelLeftInfo
            // 
            panelLeftInfo.BackColor = Color.FromArgb(35, 54, 46);
            panelLeftInfo.Controls.Add(label1);
            panelLeftInfo.Dock = DockStyle.Bottom;
            panelLeftInfo.Location = new Point(0, 433);
            panelLeftInfo.Name = "panelLeftInfo";
            panelLeftInfo.Size = new Size(205, 74);
            panelLeftInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(239, 238, 236);
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 557);
            Controls.Add(panelMenu);
            Controls.Add(panelTopBar);
            Name = "MainForm";
            Text = "Form1";
            panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelLeftInfo.ResumeLayout(false);
            panelLeftInfo.PerformLayout();
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
        private Label label1;
    }
}
