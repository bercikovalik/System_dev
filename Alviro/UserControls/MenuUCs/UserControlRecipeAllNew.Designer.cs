namespace Alviro
{
    partial class UserControlRecipeAllNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRecipeAllNew));
            panelHeader = new Panel();
            panelTableHead = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            labelLastModified = new Label();
            panel2 = new Panel();
            label1 = new Label();
            textBoxSearch = new TextBox();
            panelRecipeViewer = new Panel();
            pictureBoxLoading = new PictureBox();
            panelHeader.SuspendLayout();
            panelTableHead.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelRecipeViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(104, 123, 82);
            panelHeader.Controls.Add(panelTableHead);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(textBoxSearch);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(933, 133);
            panelHeader.TabIndex = 0;
            // 
            // panelTableHead
            // 
            panelTableHead.Controls.Add(panel4);
            panelTableHead.Controls.Add(panel3);
            panelTableHead.Controls.Add(panel2);
            panelTableHead.Dock = DockStyle.Bottom;
            panelTableHead.Location = new Point(0, 56);
            panelTableHead.MinimumSize = new Size(850, 58);
            panelTableHead.Name = "panelTableHead";
            panelTableHead.Size = new Size(933, 77);
            panelTableHead.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 51, 51);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 77);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 0;
            label2.Text = "Recept név";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 51, 51);
            panel3.Controls.Add(labelLastModified);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(385, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 77);
            panel3.TabIndex = 9;
            // 
            // labelLastModified
            // 
            labelLastModified.Anchor = AnchorStyles.None;
            labelLastModified.AutoSize = true;
            labelLastModified.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelLastModified.ForeColor = Color.White;
            labelLastModified.Location = new Point(0, 23);
            labelLastModified.MaximumSize = new Size(220, 40);
            labelLastModified.Name = "labelLastModified";
            labelLastModified.Size = new Size(195, 30);
            labelLastModified.TabIndex = 3;
            labelLastModified.Text = "Utoljára módosítva";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 77);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 1;
            label1.Text = "Keresés:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(174, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(255, 31);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // panelRecipeViewer
            // 
            panelRecipeViewer.AutoScroll = true;
            panelRecipeViewer.BackColor = Color.White;
            panelRecipeViewer.Controls.Add(pictureBoxLoading);
            panelRecipeViewer.Dock = DockStyle.Fill;
            panelRecipeViewer.Location = new Point(0, 133);
            panelRecipeViewer.Name = "panelRecipeViewer";
            panelRecipeViewer.Size = new Size(933, 468);
            panelRecipeViewer.TabIndex = 1;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(417, 177);
            pictureBoxLoading.MinimumSize = new Size(80, 80);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(80, 80);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 6;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // UserControlRecipeAllNew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRecipeViewer);
            Controls.Add(panelHeader);
            Name = "UserControlRecipeAllNew";
            Size = new Size(933, 601);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTableHead.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelRecipeViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private TextBox textBoxSearch;
        private Panel panelRecipeViewer;
        private PictureBox pictureBoxLoading;
        private Label label1;
        private Panel panelTableHead;
        private Panel panel2;
        private Panel panel3;
        private Label labelLastModified;
        private Panel panel4;
        private Label label2;
    }
}
