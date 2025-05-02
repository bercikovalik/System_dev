namespace Alviro
{
    partial class UserControlIngredients
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
            panel1 = new Panel();
            panel3 = new Panel();
            listBoxAllIngredients = new ListBox();
            textBoxSearchIngredient = new TextBox();
            buttonAddNewIngredient = new Button();
            textBoxNewIngredienName = new TextBox();
            panel5 = new Panel();
            comboBoxCategoryFilter = new ComboBox();
            textBoxSearchSelectedProduct = new TextBox();
            textBoxSearchProduct = new TextBox();
            buttonRemoveProduct = new Button();
            buttonAddProduct = new Button();
            label2 = new Label();
            label1 = new Label();
            listBoxAllProducts = new ListBox();
            listBoxSelectedProducts = new ListBox();
            panel4 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 606);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxAllIngredients);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 566);
            panel3.TabIndex = 3;
            // 
            // listBoxAllIngredients
            // 
            listBoxAllIngredients.Anchor = AnchorStyles.Top;
            listBoxAllIngredients.FormattingEnabled = true;
            listBoxAllIngredients.Location = new Point(16, 15);
            listBoxAllIngredients.Name = "listBoxAllIngredients";
            listBoxAllIngredients.Size = new Size(221, 529);
            listBoxAllIngredients.TabIndex = 0;
            listBoxAllIngredients.SelectedIndexChanged += listBoxAllIngredients_SelectedIndexChanged;
            // 
            // textBoxSearchIngredient
            // 
            textBoxSearchIngredient.Location = new Point(32, 4);
            textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            textBoxSearchIngredient.Size = new Size(191, 31);
            textBoxSearchIngredient.TabIndex = 1;
            textBoxSearchIngredient.TextChanged += textBoxSearchIngredient_TextChanged;
            // 
            // buttonAddNewIngredient
            // 
            buttonAddNewIngredient.Location = new Point(88, 130);
            buttonAddNewIngredient.Name = "buttonAddNewIngredient";
            buttonAddNewIngredient.Size = new Size(112, 34);
            buttonAddNewIngredient.TabIndex = 1;
            buttonAddNewIngredient.Text = "Hozzáadás";
            buttonAddNewIngredient.UseVisualStyleBackColor = true;
            buttonAddNewIngredient.Click += buttonAddNewIngredient_Click;
            // 
            // textBoxNewIngredienName
            // 
            textBoxNewIngredienName.Location = new Point(53, 93);
            textBoxNewIngredienName.Name = "textBoxNewIngredienName";
            textBoxNewIngredienName.Size = new Size(178, 31);
            textBoxNewIngredienName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBoxCategoryFilter);
            panel5.Controls.Add(textBoxSearchSelectedProduct);
            panel5.Controls.Add(textBoxSearchProduct);
            panel5.Controls.Add(buttonRemoveProduct);
            panel5.Controls.Add(buttonAddProduct);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(listBoxAllProducts);
            panel5.Controls.Add(listBoxSelectedProducts);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(257, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(484, 606);
            panel5.TabIndex = 7;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Location = new Point(238, 498);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(182, 33);
            comboBoxCategoryFilter.TabIndex = 8;
            comboBoxCategoryFilter.SelectedIndexChanged += comboBoxCategoryFilter_SelectedIndexChanged;
            // 
            // textBoxSearchSelectedProduct
            // 
            textBoxSearchSelectedProduct.Anchor = AnchorStyles.None;
            textBoxSearchSelectedProduct.Location = new Point(54, 86);
            textBoxSearchSelectedProduct.Name = "textBoxSearchSelectedProduct";
            textBoxSearchSelectedProduct.Size = new Size(150, 31);
            textBoxSearchSelectedProduct.TabIndex = 7;
            textBoxSearchSelectedProduct.TextChanged += textBoxSearchSelectedProduct_TextChanged;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Anchor = AnchorStyles.None;
            textBoxSearchProduct.Location = new Point(284, 86);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Size = new Size(150, 31);
            textBoxSearchProduct.TabIndex = 6;
            textBoxSearchProduct.TextChanged += textBoxSearchProduct_TextChanged;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Anchor = AnchorStyles.None;
            buttonRemoveProduct.Location = new Point(112, 449);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(112, 34);
            buttonRemoveProduct.TabIndex = 5;
            buttonRemoveProduct.Text = "Eltávolít";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += buttonRemoveProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Anchor = AnchorStyles.None;
            buttonAddProduct.Location = new Point(274, 449);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(112, 34);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Hozzáad";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(299, 123);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 3;
            label2.Text = "Összes termék";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(38, 123);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 2;
            label1.Text = "Kiválasztott termékek";
            // 
            // listBoxAllProducts
            // 
            listBoxAllProducts.Anchor = AnchorStyles.None;
            listBoxAllProducts.FormattingEnabled = true;
            listBoxAllProducts.Location = new Point(274, 151);
            listBoxAllProducts.Name = "listBoxAllProducts";
            listBoxAllProducts.Size = new Size(180, 279);
            listBoxAllProducts.TabIndex = 1;
            // 
            // listBoxSelectedProducts
            // 
            listBoxSelectedProducts.Anchor = AnchorStyles.None;
            listBoxSelectedProducts.FormattingEnabled = true;
            listBoxSelectedProducts.Location = new Point(37, 151);
            listBoxSelectedProducts.Name = "listBoxSelectedProducts";
            listBoxSelectedProducts.Size = new Size(187, 279);
            listBoxSelectedProducts.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(buttonAddNewIngredient);
            panel4.Controls.Add(textBoxNewIngredienName);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(741, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 606);
            panel4.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSearchIngredient);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 40);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 55);
            label3.Name = "label3";
            label3.Size = new Size(209, 25);
            label3.TabIndex = 2;
            label3.Text = "Új hozzávaló hozzáadása";
            // 
            // UserControlIngredients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "UserControlIngredients";
            Size = new Size(991, 606);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private ListBox listBoxAllIngredients;
        private TextBox textBoxSearchIngredient;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private ListBox listBoxAllProducts;
        private ListBox listBoxSelectedProducts;
        private Button buttonRemoveProduct;
        private Button buttonAddProduct;
        private TextBox textBoxSearchProduct;
        private TextBox textBoxSearchSelectedProduct;
        private Button buttonAddNewIngredient;
        private TextBox textBoxNewIngredienName;
        private ComboBox comboBoxCategoryFilter;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
    }
}
