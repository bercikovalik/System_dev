namespace Alviro
{
    partial class FormSelectProducts
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
            panelHeader = new Panel();
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearchProduct = new TextBox();
            panelIngredientsProductsViewer = new Panel();
            panelProductsTable = new Panel();
            panel3 = new Panel();
            buttonSelectAllProduct = new Button();
            buttonSave = new Button();
            buttonClose = new Button();
            panelPagination = new Panel();
            buttonLastPage = new Button();
            buttonFirstPage = new Button();
            labelPage = new Label();
            buttonPreviousChunk = new Button();
            buttonNextChunk = new Button();
            comboBoxCategorySelector = new ComboBox();
            buttonRefreshProducts = new Button();
            panel2 = new Panel();
            label2 = new Label();
            comboBoxSortProducts = new ComboBox();
            label4 = new Label();
            panelHeader.SuspendLayout();
            panelIngredientsProductsViewer.SuspendLayout();
            panel3.SuspendLayout();
            panelPagination.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(104, 123, 82);
            panelHeader.Controls.Add(buttonSearch);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(textBoxSearchProduct);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1407, 52);
            panelHeader.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Left;
            buttonSearch.BackColor = Color.FromArgb(86, 99, 111);
            buttonSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(409, 7);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(111, 39);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Keresés";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 4;
            label1.Text = "Keresés:";
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.BackColor = Color.White;
            textBoxSearchProduct.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchProduct.Location = new Point(122, 12);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Size = new Size(255, 31);
            textBoxSearchProduct.TabIndex = 3;
            textBoxSearchProduct.TextChanged += textBoxSearchProduct_TextChanged;
            textBoxSearchProduct.KeyDown += textBoxSearchProduct_KeyDown;
            // 
            // panelIngredientsProductsViewer
            // 
            panelIngredientsProductsViewer.BackColor = Color.White;
            panelIngredientsProductsViewer.Controls.Add(panelProductsTable);
            panelIngredientsProductsViewer.Controls.Add(panel3);
            panelIngredientsProductsViewer.Controls.Add(panel2);
            panelIngredientsProductsViewer.Dock = DockStyle.Fill;
            panelIngredientsProductsViewer.Location = new Point(0, 52);
            panelIngredientsProductsViewer.Name = "panelIngredientsProductsViewer";
            panelIngredientsProductsViewer.Size = new Size(1407, 636);
            panelIngredientsProductsViewer.TabIndex = 5;
            // 
            // panelProductsTable
            // 
            panelProductsTable.AutoScroll = true;
            panelProductsTable.Dock = DockStyle.Fill;
            panelProductsTable.Location = new Point(0, 77);
            panelProductsTable.Name = "panelProductsTable";
            panelProductsTable.Size = new Size(1098, 559);
            panelProductsTable.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(104, 123, 82);
            panel3.Controls.Add(buttonSelectAllProduct);
            panel3.Controls.Add(buttonSave);
            panel3.Controls.Add(buttonClose);
            panel3.Controls.Add(panelPagination);
            panel3.Controls.Add(comboBoxCategorySelector);
            panel3.Controls.Add(buttonRefreshProducts);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1098, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 559);
            panel3.TabIndex = 13;
            // 
            // buttonSelectAllProduct
            // 
            buttonSelectAllProduct.Anchor = AnchorStyles.Bottom;
            buttonSelectAllProduct.BackColor = Color.FromArgb(86, 99, 111);
            buttonSelectAllProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonSelectAllProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonSelectAllProduct.FlatStyle = FlatStyle.Flat;
            buttonSelectAllProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSelectAllProduct.ForeColor = Color.White;
            buttonSelectAllProduct.Location = new Point(60, 234);
            buttonSelectAllProduct.Name = "buttonSelectAllProduct";
            buttonSelectAllProduct.Size = new Size(194, 74);
            buttonSelectAllProduct.TabIndex = 12;
            buttonSelectAllProduct.Text = "Összes kijelölése";
            buttonSelectAllProduct.UseVisualStyleBackColor = false;
            buttonSelectAllProduct.Click += buttonSelectAllProduct_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom;
            buttonSave.BackColor = Color.FromArgb(86, 99, 111);
            buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(60, 326);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(194, 57);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom;
            buttonClose.BackColor = Color.FromArgb(255, 128, 128);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonClose.ForeColor = Color.Black;
            buttonClose.Location = new Point(60, 402);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(194, 52);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Bezárás";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += button1_Click;
            // 
            // panelPagination
            // 
            panelPagination.Controls.Add(buttonLastPage);
            panelPagination.Controls.Add(buttonFirstPage);
            panelPagination.Controls.Add(labelPage);
            panelPagination.Controls.Add(buttonPreviousChunk);
            panelPagination.Controls.Add(buttonNextChunk);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(0, 464);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(309, 95);
            panelPagination.TabIndex = 9;
            // 
            // buttonLastPage
            // 
            buttonLastPage.Anchor = AnchorStyles.Bottom;
            buttonLastPage.BackColor = Color.FromArgb(86, 99, 111);
            buttonLastPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonLastPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonLastPage.FlatStyle = FlatStyle.Flat;
            buttonLastPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonLastPage.ForeColor = Color.White;
            buttonLastPage.Location = new Point(250, 27);
            buttonLastPage.Name = "buttonLastPage";
            buttonLastPage.Size = new Size(56, 53);
            buttonLastPage.TabIndex = 7;
            buttonLastPage.Text = ">>";
            buttonLastPage.UseVisualStyleBackColor = false;
            buttonLastPage.Click += buttonLastPage_Click_1;
            // 
            // buttonFirstPage
            // 
            buttonFirstPage.Anchor = AnchorStyles.Bottom;
            buttonFirstPage.BackColor = Color.FromArgb(86, 99, 111);
            buttonFirstPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonFirstPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonFirstPage.FlatStyle = FlatStyle.Flat;
            buttonFirstPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonFirstPage.ForeColor = Color.White;
            buttonFirstPage.Location = new Point(0, 27);
            buttonFirstPage.Name = "buttonFirstPage";
            buttonFirstPage.Size = new Size(57, 53);
            buttonFirstPage.TabIndex = 6;
            buttonFirstPage.Text = "<<";
            buttonFirstPage.UseVisualStyleBackColor = false;
            buttonFirstPage.Click += buttonFirstPage_Click_1;
            // 
            // labelPage
            // 
            labelPage.Anchor = AnchorStyles.Bottom;
            labelPage.AutoSize = true;
            labelPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelPage.ForeColor = Color.White;
            labelPage.Location = new Point(126, 27);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(41, 48);
            labelPage.TabIndex = 5;
            labelPage.Text = "1";
            labelPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPreviousChunk
            // 
            buttonPreviousChunk.Anchor = AnchorStyles.Bottom;
            buttonPreviousChunk.BackColor = Color.FromArgb(86, 99, 111);
            buttonPreviousChunk.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonPreviousChunk.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonPreviousChunk.FlatStyle = FlatStyle.Flat;
            buttonPreviousChunk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonPreviousChunk.ForeColor = Color.White;
            buttonPreviousChunk.Location = new Point(60, 27);
            buttonPreviousChunk.Name = "buttonPreviousChunk";
            buttonPreviousChunk.Size = new Size(57, 53);
            buttonPreviousChunk.TabIndex = 4;
            buttonPreviousChunk.Text = "<";
            buttonPreviousChunk.UseVisualStyleBackColor = false;
            buttonPreviousChunk.Click += buttonPreviousChunk_Click;
            // 
            // buttonNextChunk
            // 
            buttonNextChunk.Anchor = AnchorStyles.Bottom;
            buttonNextChunk.BackColor = Color.FromArgb(86, 99, 111);
            buttonNextChunk.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonNextChunk.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonNextChunk.FlatStyle = FlatStyle.Flat;
            buttonNextChunk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonNextChunk.ForeColor = Color.White;
            buttonNextChunk.Location = new Point(190, 27);
            buttonNextChunk.Name = "buttonNextChunk";
            buttonNextChunk.Size = new Size(56, 53);
            buttonNextChunk.TabIndex = 3;
            buttonNextChunk.Text = ">";
            buttonNextChunk.UseVisualStyleBackColor = false;
            buttonNextChunk.Click += buttonNextChunk_Click;
            // 
            // comboBoxCategorySelector
            // 
            comboBoxCategorySelector.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategorySelector.BackColor = Color.White;
            comboBoxCategorySelector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorySelector.FlatStyle = FlatStyle.Flat;
            comboBoxCategorySelector.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxCategorySelector.FormattingEnabled = true;
            comboBoxCategorySelector.Location = new Point(16, 104);
            comboBoxCategorySelector.Name = "comboBoxCategorySelector";
            comboBoxCategorySelector.Size = new Size(277, 38);
            comboBoxCategorySelector.TabIndex = 8;
            comboBoxCategorySelector.SelectedIndexChanged += comboBoxCategorySelector_SelectedIndexChanged;
            // 
            // buttonRefreshProducts
            // 
            buttonRefreshProducts.Anchor = AnchorStyles.Top;
            buttonRefreshProducts.BackColor = Color.FromArgb(86, 99, 111);
            buttonRefreshProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonRefreshProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonRefreshProducts.FlatStyle = FlatStyle.Flat;
            buttonRefreshProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonRefreshProducts.ForeColor = Color.White;
            buttonRefreshProducts.Location = new Point(78, 18);
            buttonRefreshProducts.Name = "buttonRefreshProducts";
            buttonRefreshProducts.Size = new Size(158, 57);
            buttonRefreshProducts.TabIndex = 2;
            buttonRefreshProducts.Text = "Frissítés";
            buttonRefreshProducts.UseVisualStyleBackColor = false;
            buttonRefreshProducts.Click += buttonRefreshProducts_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxSortProducts);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1407, 77);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(375, 32);
            label2.TabIndex = 9;
            label2.Text = "Hozzávalóhoz rendelt termékek";
            // 
            // comboBoxSortProducts
            // 
            comboBoxSortProducts.Anchor = AnchorStyles.Right;
            comboBoxSortProducts.BackColor = Color.White;
            comboBoxSortProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortProducts.FlatStyle = FlatStyle.Flat;
            comboBoxSortProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxSortProducts.FormattingEnabled = true;
            comboBoxSortProducts.Items.AddRange(new object[] { "Alapértelmezett", "Név (A-Z)", "Név (Z-A)" });
            comboBoxSortProducts.Location = new Point(980, 19);
            comboBoxSortProducts.Name = "comboBoxSortProducts";
            comboBoxSortProducts.Size = new Size(411, 38);
            comboBoxSortProducts.TabIndex = 7;
            comboBoxSortProducts.SelectedIndexChanged += comboBoxSortProducts_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(864, 22);
            label4.MaximumSize = new Size(220, 40);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 8;
            label4.Text = "Rendezés:";
            // 
            // FormSelectProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 688);
            Controls.Add(panelIngredientsProductsViewer);
            Controls.Add(panelHeader);
            Name = "FormSelectProducts";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Termékek hozzárendelése";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelIngredientsProductsViewer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private TextBox textBoxSearchProduct;
        private Panel panelIngredientsProductsViewer;
        private Panel panel3;
        public ComboBox comboBoxCategorySelector;
        private Button buttonRefreshProducts;
        private Panel panel2;
        private ComboBox comboBoxSortProducts;
        private Label label4;
        private Label labelIngredientName;
        public Panel panelProductsTable;
        private Panel panelPagination;
        private Button buttonPreviousChunk;
        private Button buttonNextChunk;
        private Label labelPage;
        private Button buttonSave;
        private Button buttonClose;
        private Button buttonSearch;
        private Button buttonLastPage;
        private Button buttonFirstPage;
        private Label label2;
        private Button buttonSelectAllProduct;
    }
}