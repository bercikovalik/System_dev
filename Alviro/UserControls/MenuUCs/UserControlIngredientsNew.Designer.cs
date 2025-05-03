namespace Alviro
{
    partial class UserControlIngredientsNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlIngredientsNew));
            panelHeader = new Panel();
            label1 = new Label();
            textBoxSearch = new TextBox();
            pictureBoxRightArrow = new PictureBox();
            panelIngredientsViewer = new Panel();
            panelIngredientsTable = new Panel();
            pictureBoxLoading = new PictureBox();
            panelIngredientsButtons = new Panel();
            buttonAddNewIngredients = new Button();
            buttonRefresh = new Button();
            panelIngredientsHeader = new Panel();
            panelSort = new Panel();
            comboBoxOrder = new ComboBox();
            label2 = new Label();
            panelIngredientName = new Panel();
            label3 = new Label();
            panelIngredientsProductsViewer = new Panel();
            labelTempSelectedIngredient = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).BeginInit();
            panelIngredientsViewer.SuspendLayout();
            panelIngredientsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            panelIngredientsButtons.SuspendLayout();
            panelIngredientsHeader.SuspendLayout();
            panelSort.SuspendLayout();
            panelIngredientName.SuspendLayout();
            panelIngredientsProductsViewer.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(104, 123, 82);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(textBoxSearch);
            panelHeader.Controls.Add(pictureBoxRightArrow);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1554, 52);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 4;
            label1.Text = "Keresés:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(164, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(255, 31);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBoxRightArrow
            // 
            pictureBoxRightArrow.BackColor = Color.Transparent;
            pictureBoxRightArrow.Cursor = Cursors.Hand;
            pictureBoxRightArrow.Enabled = false;
            pictureBoxRightArrow.Image = (Image)resources.GetObject("pictureBoxRightArrow.Image");
            pictureBoxRightArrow.Location = new Point(4, 5);
            pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            pictureBoxRightArrow.Size = new Size(45, 45);
            pictureBoxRightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRightArrow.TabIndex = 2;
            pictureBoxRightArrow.TabStop = false;
            pictureBoxRightArrow.Visible = false;
            // 
            // panelIngredientsViewer
            // 
            panelIngredientsViewer.Controls.Add(panelIngredientsTable);
            panelIngredientsViewer.Controls.Add(panelIngredientsButtons);
            panelIngredientsViewer.Controls.Add(panelIngredientsHeader);
            panelIngredientsViewer.Dock = DockStyle.Left;
            panelIngredientsViewer.Location = new Point(0, 52);
            panelIngredientsViewer.Name = "panelIngredientsViewer";
            panelIngredientsViewer.Size = new Size(901, 815);
            panelIngredientsViewer.TabIndex = 1;
            // 
            // panelIngredientsTable
            // 
            panelIngredientsTable.AutoScroll = true;
            panelIngredientsTable.BackColor = Color.White;
            panelIngredientsTable.Controls.Add(pictureBoxLoading);
            panelIngredientsTable.Dock = DockStyle.Fill;
            panelIngredientsTable.Location = new Point(0, 77);
            panelIngredientsTable.Name = "panelIngredientsTable";
            panelIngredientsTable.Size = new Size(727, 738);
            panelIngredientsTable.TabIndex = 13;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(323, 331);
            pictureBoxLoading.MinimumSize = new Size(80, 80);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(80, 80);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 6;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // panelIngredientsButtons
            // 
            panelIngredientsButtons.BackColor = Color.FromArgb(104, 123, 82);
            panelIngredientsButtons.Controls.Add(buttonAddNewIngredients);
            panelIngredientsButtons.Controls.Add(buttonRefresh);
            panelIngredientsButtons.Dock = DockStyle.Right;
            panelIngredientsButtons.Location = new Point(727, 77);
            panelIngredientsButtons.Name = "panelIngredientsButtons";
            panelIngredientsButtons.Size = new Size(174, 738);
            panelIngredientsButtons.TabIndex = 12;
            // 
            // buttonAddNewIngredients
            // 
            buttonAddNewIngredients.Anchor = AnchorStyles.Top;
            buttonAddNewIngredients.BackColor = Color.FromArgb(86, 99, 111);
            buttonAddNewIngredients.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonAddNewIngredients.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonAddNewIngredients.FlatStyle = FlatStyle.Flat;
            buttonAddNewIngredients.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddNewIngredients.ForeColor = Color.White;
            buttonAddNewIngredients.Location = new Point(8, 77);
            buttonAddNewIngredients.Name = "buttonAddNewIngredients";
            buttonAddNewIngredients.Size = new Size(158, 57);
            buttonAddNewIngredients.TabIndex = 3;
            buttonAddNewIngredients.Text = "Új hozzávaló";
            buttonAddNewIngredients.UseVisualStyleBackColor = false;
            buttonAddNewIngredients.Click += buttonAddNewIngredients_Click;
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
            buttonRefresh.Location = new Point(8, 9);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(158, 57);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Frissítés";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panelIngredientsHeader
            // 
            panelIngredientsHeader.BackColor = Color.FromArgb(51, 51, 51);
            panelIngredientsHeader.Controls.Add(panelSort);
            panelIngredientsHeader.Controls.Add(panelIngredientName);
            panelIngredientsHeader.Dock = DockStyle.Top;
            panelIngredientsHeader.Location = new Point(0, 0);
            panelIngredientsHeader.Name = "panelIngredientsHeader";
            panelIngredientsHeader.Size = new Size(901, 77);
            panelIngredientsHeader.TabIndex = 11;
            // 
            // panelSort
            // 
            panelSort.BackColor = Color.FromArgb(51, 51, 51);
            panelSort.Controls.Add(comboBoxOrder);
            panelSort.Controls.Add(label2);
            panelSort.Dock = DockStyle.Fill;
            panelSort.Location = new Point(199, 0);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(702, 77);
            panelSort.TabIndex = 13;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOrder.BackColor = Color.White;
            comboBoxOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrder.FlatStyle = FlatStyle.Flat;
            comboBoxOrder.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(335, 20);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(358, 38);
            comboBoxOrder.TabIndex = 5;
            comboBoxOrder.SelectedIndexChanged += comboBoxOrder_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 23);
            label2.MaximumSize = new Size(220, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 6;
            label2.Text = "Rendezés:";
            // 
            // panelIngredientName
            // 
            panelIngredientName.BackColor = Color.FromArgb(51, 51, 51);
            panelIngredientName.Controls.Add(label3);
            panelIngredientName.Dock = DockStyle.Left;
            panelIngredientName.Location = new Point(0, 0);
            panelIngredientName.Name = "panelIngredientName";
            panelIngredientName.Size = new Size(199, 77);
            panelIngredientName.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 0;
            label3.Text = "Hozzávaló";
            // 
            // panelIngredientsProductsViewer
            // 
            panelIngredientsProductsViewer.BackColor = Color.White;
            panelIngredientsProductsViewer.Controls.Add(labelTempSelectedIngredient);
            panelIngredientsProductsViewer.Dock = DockStyle.Fill;
            panelIngredientsProductsViewer.Location = new Point(901, 52);
            panelIngredientsProductsViewer.Name = "panelIngredientsProductsViewer";
            panelIngredientsProductsViewer.Size = new Size(653, 815);
            panelIngredientsProductsViewer.TabIndex = 2;
            // 
            // labelTempSelectedIngredient
            // 
            labelTempSelectedIngredient.AutoSize = true;
            labelTempSelectedIngredient.Location = new Point(141, 102);
            labelTempSelectedIngredient.Name = "labelTempSelectedIngredient";
            labelTempSelectedIngredient.Size = new Size(59, 25);
            labelTempSelectedIngredient.TabIndex = 0;
            labelTempSelectedIngredient.Text = "label1";
            // 
            // UserControlIngredientsNew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelIngredientsProductsViewer);
            Controls.Add(panelIngredientsViewer);
            Controls.Add(panelHeader);
            Name = "UserControlIngredientsNew";
            Size = new Size(1554, 867);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).EndInit();
            panelIngredientsViewer.ResumeLayout(false);
            panelIngredientsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            panelIngredientsButtons.ResumeLayout(false);
            panelIngredientsHeader.ResumeLayout(false);
            panelSort.ResumeLayout(false);
            panelSort.PerformLayout();
            panelIngredientName.ResumeLayout(false);
            panelIngredientName.PerformLayout();
            panelIngredientsProductsViewer.ResumeLayout(false);
            panelIngredientsProductsViewer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelIngredientsViewer;
        private Panel panelIngredientsProductsViewer;
        private PictureBox pictureBoxRightArrow;
        private Panel panelIngredientsHeader;
        private Label label3;
        private Panel panelSort;
        private Panel panelIngredientName;
        private Label label2;
        private ComboBox comboBoxOrder;
        private Panel panelIngredientsButtons;
        private Panel panelIngredientsTable;
        private Button buttonAddNewIngredients;
        private Button buttonRefresh;
        private Label labelTempSelectedIngredient;
        private PictureBox pictureBoxLoading;
        private Label label1;
        private TextBox textBoxSearch;
    }
}
