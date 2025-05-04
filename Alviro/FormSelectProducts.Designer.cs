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
            label1 = new Label();
            textBoxSearchProduct = new TextBox();
            panelIngredientsProductsViewer = new Panel();
            panel3 = new Panel();
            comboBoxCategorySelector = new ComboBox();
            buttonRefreshProducts = new Button();
            panel2 = new Panel();
            comboBoxSortProducts = new ComboBox();
            label4 = new Label();
            labelIngredientName = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panelProductsTable = new Panel();
            panelPagination = new Panel();
            panelHeader.SuspendLayout();
            panelIngredientsProductsViewer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(104, 123, 82);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(textBoxSearchProduct);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1063, 52);
            panelHeader.TabIndex = 4;
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
            panelIngredientsProductsViewer.Size = new Size(1063, 636);
            panelIngredientsProductsViewer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(104, 123, 82);
            panel3.Controls.Add(panelPagination);
            panel3.Controls.Add(comboBoxCategorySelector);
            panel3.Controls.Add(buttonRefreshProducts);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(810, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 559);
            panel3.TabIndex = 13;
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
            comboBoxCategorySelector.Size = new Size(221, 38);
            comboBoxCategorySelector.TabIndex = 8;
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
            buttonRefreshProducts.Location = new Point(50, 18);
            buttonRefreshProducts.Name = "buttonRefreshProducts";
            buttonRefreshProducts.Size = new Size(158, 57);
            buttonRefreshProducts.TabIndex = 2;
            buttonRefreshProducts.Text = "Frissítés";
            buttonRefreshProducts.UseVisualStyleBackColor = false;
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
            panel2.Size = new Size(1063, 77);
            panel2.TabIndex = 1;
            // 
            // comboBoxSortProducts
            // 
            comboBoxSortProducts.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSortProducts.BackColor = Color.White;
            comboBoxSortProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortProducts.FlatStyle = FlatStyle.Flat;
            comboBoxSortProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxSortProducts.FormattingEnabled = true;
            comboBoxSortProducts.Location = new Point(636, 19);
            comboBoxSortProducts.Name = "comboBoxSortProducts";
            comboBoxSortProducts.Size = new Size(411, 38);
            comboBoxSortProducts.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(520, 22);
            label4.MaximumSize = new Size(220, 40);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 8;
            label4.Text = "Rendezés:";
            // 
            // labelIngredientName
            // 
            labelIngredientName.Anchor = AnchorStyles.Right;
            labelIngredientName.AutoSize = true;
            labelIngredientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelIngredientName.ForeColor = Color.White;
            labelIngredientName.Location = new Point(12, 19);
            labelIngredientName.Name = "labelIngredientName";
            labelIngredientName.Size = new Size(132, 32);
            labelIngredientName.TabIndex = 2;
            labelIngredientName.Text = "Hozzávaló";
            labelIngredientName.TextAlign = ContentAlignment.MiddleCenter;
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2583, -27);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 2;
            label5.Text = "Hozzávaló";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 51, 51);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 77);
            panel4.TabIndex = 15;
            // 
            // panelProductsTable
            // 
            panelProductsTable.AutoScroll = true;
            panelProductsTable.Dock = DockStyle.Fill;
            panelProductsTable.Location = new Point(0, 154);
            panelProductsTable.Name = "panelProductsTable";
            panelProductsTable.Size = new Size(810, 482);
            panelProductsTable.TabIndex = 16;
            // 
            // panelPagination
            // 
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(0, 418);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(253, 141);
            panelPagination.TabIndex = 9;
            // 
            // FormSelectProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 688);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
    }
}