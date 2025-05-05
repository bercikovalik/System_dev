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
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            buttonSave = new Button();
            buttonClose = new Button();
            panelPagination = new Panel();
            buttonFirstPage = new Button();
            buttonLastPage = new Button();
            labelPage = new Label();
            buttonPreviousChunk = new Button();
            buttonNextChunk = new Button();
            comboBoxCategorySelector = new ComboBox();
            buttonRefreshProducts = new Button();
            panel2 = new Panel();
            comboBoxSortProducts = new ComboBox();
            label4 = new Label();
            labelIngredientName = new Label();
            panelHeader.SuspendLayout();
            panelIngredientsProductsViewer.SuspendLayout();
            panel4.SuspendLayout();
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
            panelHeader.Size = new Size(1202, 52);
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
            // 
            // panelIngredientsProductsViewer
            // 
            panelIngredientsProductsViewer.BackColor = Color.White;
            panelIngredientsProductsViewer.Controls.Add(panelProductsTable);
            panelIngredientsProductsViewer.Controls.Add(panel4);
            panelIngredientsProductsViewer.Controls.Add(panel3);
            panelIngredientsProductsViewer.Controls.Add(panel2);
            panelIngredientsProductsViewer.Dock = DockStyle.Fill;
            panelIngredientsProductsViewer.Location = new Point(0, 52);
            panelIngredientsProductsViewer.Name = "panelIngredientsProductsViewer";
            panelIngredientsProductsViewer.Size = new Size(1202, 636);
            panelIngredientsProductsViewer.TabIndex = 5;
            // 
            // panelProductsTable
            // 
            panelProductsTable.AutoScroll = true;
            panelProductsTable.Dock = DockStyle.Fill;
            panelProductsTable.Location = new Point(0, 154);
            panelProductsTable.Name = "panelProductsTable";
            panelProductsTable.Size = new Size(881, 482);
            panelProductsTable.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 51, 51);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(881, 77);
            panel4.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2654, -27);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 2;
            label5.Text = "Hozzávaló";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 20);
            label6.Name = "label6";
            label6.Size = new Size(375, 32);
            label6.TabIndex = 1;
            label6.Text = "Hozzávalóhoz rendelt termékek";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(104, 123, 82);
            panel3.Controls.Add(buttonSave);
            panel3.Controls.Add(buttonClose);
            panel3.Controls.Add(panelPagination);
            panel3.Controls.Add(comboBoxCategorySelector);
            panel3.Controls.Add(buttonRefreshProducts);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(881, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 559);
            panel3.TabIndex = 13;
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
            buttonSave.Location = new Point(81, 326);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 57);
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
            buttonClose.Location = new Point(82, 397);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(158, 57);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Bezárás";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += button1_Click;
            // 
            // panelPagination
            // 
            panelPagination.Controls.Add(buttonFirstPage);
            panelPagination.Controls.Add(buttonLastPage);
            panelPagination.Controls.Add(labelPage);
            panelPagination.Controls.Add(buttonPreviousChunk);
            panelPagination.Controls.Add(buttonNextChunk);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(0, 464);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(321, 95);
            panelPagination.TabIndex = 9;
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
            buttonFirstPage.Location = new Point(13, 24);
            buttonFirstPage.Name = "buttonFirstPage";
            buttonFirstPage.Size = new Size(57, 57);
            buttonFirstPage.TabIndex = 7;
            buttonFirstPage.Text = "<<";
            buttonFirstPage.UseVisualStyleBackColor = false;
            buttonFirstPage.Click += buttonFirstPage_Click;
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
            buttonLastPage.Location = new Point(260, 23);
            buttonLastPage.Name = "buttonLastPage";
            buttonLastPage.Size = new Size(57, 57);
            buttonLastPage.TabIndex = 6;
            buttonLastPage.Text = ">>";
            buttonLastPage.UseVisualStyleBackColor = false;
            buttonLastPage.Click += buttonLastPage_Click;
            // 
            // labelPage
            // 
            labelPage.Anchor = AnchorStyles.Bottom;
            labelPage.AutoSize = true;
            labelPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelPage.ForeColor = Color.White;
            labelPage.Location = new Point(133, 27);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(62, 48);
            labelPage.TabIndex = 5;
            labelPage.Text = "11";
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
            buttonPreviousChunk.Location = new Point(76, 24);
            buttonPreviousChunk.Name = "buttonPreviousChunk";
            buttonPreviousChunk.Size = new Size(57, 57);
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
            buttonNextChunk.Location = new Point(197, 23);
            buttonNextChunk.Name = "buttonNextChunk";
            buttonNextChunk.Size = new Size(57, 57);
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
            comboBoxCategorySelector.Size = new Size(289, 38);
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
            buttonRefreshProducts.Location = new Point(84, 18);
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
            panel2.Controls.Add(comboBoxSortProducts);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelIngredientName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 77);
            panel2.TabIndex = 1;
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
            comboBoxSortProducts.Location = new Point(775, 19);
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
            label4.Location = new Point(659, 22);
            label4.MaximumSize = new Size(220, 40);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 8;
            label4.Text = "Rendezés:";
            // 
            // labelIngredientName
            // 
            labelIngredientName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelIngredientName.AutoSize = true;
            labelIngredientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelIngredientName.ForeColor = Color.White;
            labelIngredientName.Location = new Point(12, 22);
            labelIngredientName.Name = "labelIngredientName";
            labelIngredientName.Size = new Size(132, 32);
            labelIngredientName.TabIndex = 2;
            labelIngredientName.Text = "Hozzávaló";
            labelIngredientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSelectProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 688);
            Controls.Add(panelIngredientsProductsViewer);
            Controls.Add(panelHeader);
            Name = "FormSelectProducts";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Termékek hozzárendelése";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelIngredientsProductsViewer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private ComboBox comboBoxCategorySelector;
        private Button buttonRefreshProducts;
        private Panel panel2;
        private ComboBox comboBoxSortProducts;
        private Label label4;
        private Label labelIngredientName;
        private Panel panelProductsTable;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Panel panelPagination;
        private Button buttonPreviousChunk;
        private Button buttonNextChunk;
        private Label labelPage;
        private Button buttonSave;
        private Button buttonClose;
        private Button buttonSearch;
        private Button buttonFirstPage;
        private Button buttonLastPage;
    }
}