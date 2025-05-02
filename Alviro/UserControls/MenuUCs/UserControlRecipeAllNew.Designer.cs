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
            label1 = new Label();
            textBoxSearch = new TextBox();
            panelNewRecipe = new Panel();
            panel1 = new Panel();
            comboBoxOrder = new ComboBox();
            buttonAddNewRecipe = new Button();
            buttonRefresh = new Button();
            panelTableHead = new Panel();
            panelRecipeName = new Panel();
            label3 = new Label();
            panelLastModified = new Panel();
            label4 = new Label();
            panelPlaceholderControl = new Panel();
            label2 = new Label();
            panelRecipeViewer = new Panel();
            pictureBoxLoading = new PictureBox();
            panelHeader.SuspendLayout();
            panelNewRecipe.SuspendLayout();
            panel1.SuspendLayout();
            panelTableHead.SuspendLayout();
            panelRecipeName.SuspendLayout();
            panelLastModified.SuspendLayout();
            panelPlaceholderControl.SuspendLayout();
            panelRecipeViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(104, 123, 82);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(textBoxSearch);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1179, 55);
            panelHeader.TabIndex = 0;
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
            // panelNewRecipe
            // 
            panelNewRecipe.BackColor = Color.FromArgb(104, 123, 82);
            panelNewRecipe.Controls.Add(panel1);
            panelNewRecipe.Controls.Add(buttonAddNewRecipe);
            panelNewRecipe.Controls.Add(buttonRefresh);
            panelNewRecipe.Dock = DockStyle.Right;
            panelNewRecipe.Location = new Point(884, 55);
            panelNewRecipe.Name = "panelNewRecipe";
            panelNewRecipe.Size = new Size(295, 549);
            panelNewRecipe.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(comboBoxOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 77);
            panel1.TabIndex = 9;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrder.FlatStyle = FlatStyle.Flat;
            comboBoxOrder.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(11, 21);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(271, 38);
            comboBoxOrder.TabIndex = 2;
            comboBoxOrder.SelectedIndexChanged += comboBoxOrder_SelectedIndexChanged;
            // 
            // buttonAddNewRecipe
            // 
            buttonAddNewRecipe.Anchor = AnchorStyles.Top;
            buttonAddNewRecipe.BackColor = Color.FromArgb(86, 99, 111);
            buttonAddNewRecipe.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonAddNewRecipe.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonAddNewRecipe.FlatStyle = FlatStyle.Flat;
            buttonAddNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddNewRecipe.ForeColor = Color.White;
            buttonAddNewRecipe.Location = new Point(68, 160);
            buttonAddNewRecipe.Name = "buttonAddNewRecipe";
            buttonAddNewRecipe.Size = new Size(158, 57);
            buttonAddNewRecipe.TabIndex = 1;
            buttonAddNewRecipe.Text = "Új recept";
            buttonAddNewRecipe.UseVisualStyleBackColor = false;
            buttonAddNewRecipe.Click += buttonAddNewRecipe_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top;
            buttonRefresh.BackColor = Color.FromArgb(86, 99, 111);
            buttonRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(68, 92);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(158, 57);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Frissítés";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panelTableHead
            // 
            panelTableHead.Controls.Add(panelRecipeName);
            panelTableHead.Controls.Add(panelLastModified);
            panelTableHead.Controls.Add(panelPlaceholderControl);
            panelTableHead.Dock = DockStyle.Top;
            panelTableHead.Location = new Point(0, 55);
            panelTableHead.MinimumSize = new Size(850, 58);
            panelTableHead.Name = "panelTableHead";
            panelTableHead.Size = new Size(884, 77);
            panelTableHead.TabIndex = 8;
            // 
            // panelRecipeName
            // 
            panelRecipeName.BackColor = Color.FromArgb(51, 51, 51);
            panelRecipeName.Controls.Add(label3);
            panelRecipeName.Dock = DockStyle.Fill;
            panelRecipeName.Location = new Point(0, 0);
            panelRecipeName.Name = "panelRecipeName";
            panelRecipeName.Size = new Size(336, 77);
            panelRecipeName.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 0;
            label3.Text = "Recept név";
            // 
            // panelLastModified
            // 
            panelLastModified.BackColor = Color.FromArgb(51, 51, 51);
            panelLastModified.Controls.Add(label4);
            panelLastModified.Dock = DockStyle.Right;
            panelLastModified.Location = new Point(336, 0);
            panelLastModified.Name = "panelLastModified";
            panelLastModified.Size = new Size(283, 77);
            panelLastModified.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 23);
            label4.MaximumSize = new Size(220, 40);
            label4.Name = "label4";
            label4.Size = new Size(195, 30);
            label4.TabIndex = 3;
            label4.Text = "Utoljára módosítva";
            // 
            // panelPlaceholderControl
            // 
            panelPlaceholderControl.BackColor = Color.FromArgb(51, 51, 51);
            panelPlaceholderControl.Controls.Add(label2);
            panelPlaceholderControl.Dock = DockStyle.Right;
            panelPlaceholderControl.Location = new Point(619, 0);
            panelPlaceholderControl.Name = "panelPlaceholderControl";
            panelPlaceholderControl.Size = new Size(265, 77);
            panelPlaceholderControl.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(153, 25);
            label2.MaximumSize = new Size(220, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 4;
            label2.Text = "Rendezés:";
            // 
            // panelRecipeViewer
            // 
            panelRecipeViewer.AutoScroll = true;
            panelRecipeViewer.BackColor = Color.White;
            panelRecipeViewer.Controls.Add(pictureBoxLoading);
            panelRecipeViewer.Dock = DockStyle.Fill;
            panelRecipeViewer.Location = new Point(0, 132);
            panelRecipeViewer.Name = "panelRecipeViewer";
            panelRecipeViewer.Size = new Size(884, 472);
            panelRecipeViewer.TabIndex = 9;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(365, 227);
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
            BackColor = Color.FromArgb(104, 123, 82);
            Controls.Add(panelRecipeViewer);
            Controls.Add(panelTableHead);
            Controls.Add(panelNewRecipe);
            Controls.Add(panelHeader);
            Name = "UserControlRecipeAllNew";
            Size = new Size(1179, 604);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNewRecipe.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelTableHead.ResumeLayout(false);
            panelRecipeName.ResumeLayout(false);
            panelRecipeName.PerformLayout();
            panelLastModified.ResumeLayout(false);
            panelLastModified.PerformLayout();
            panelPlaceholderControl.ResumeLayout(false);
            panelPlaceholderControl.PerformLayout();
            panelRecipeViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private TextBox textBoxSearch;
        private Panel panelNewRecipe;
        private Label label1;
        private Button buttonRefresh;
        private Button buttonAddNewRecipe;
        private Panel panelTableHead;
        private Panel panelRecipeName;
        private Label label3;
        private Panel panelLastModified;
        private Label label4;
        private Panel panelPlaceholderControl;
        private Panel panelRecipeViewer;
        private PictureBox pictureBoxLoading;
        private ComboBox comboBoxOrder;
        private Panel panel1;
        private Label label2;
    }
}
