namespace Alviro
{
    partial class FormNewRecipe
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxInstructions = new TextBox();
            textBoxImageUrl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonAddRecipe = new Button();
            buttonCancel = new Button();
            listBoxAllIngredients = new ListBox();
            listBoxSelectedIngredients = new ListBox();
            buttonAddIngredient = new Button();
            buttonRemoveIngredient = new Button();
            textBoxSearchIngredient = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(184, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(229, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(184, 101);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(229, 31);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(184, 170);
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(229, 31);
            textBoxInstructions.TabIndex = 2;
            // 
            // textBoxImageUrl
            // 
            textBoxImageUrl.Location = new Point(184, 238);
            textBoxImageUrl.Name = "textBoxImageUrl";
            textBoxImageUrl.Size = new Size(229, 31);
            textBoxImageUrl.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 43);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 4;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 104);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 5;
            label2.Text = "Leírás";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 173);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "Instrukciók:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 241);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Image URL:";
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(580, 443);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(112, 34);
            buttonAddRecipe.TabIndex = 8;
            buttonAddRecipe.Text = "Mentés";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(301, 443);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // listBoxAllIngredients
            // 
            listBoxAllIngredients.FormattingEnabled = true;
            listBoxAllIngredients.Location = new Point(824, 94);
            listBoxAllIngredients.Name = "listBoxAllIngredients";
            listBoxAllIngredients.Size = new Size(190, 254);
            listBoxAllIngredients.TabIndex = 10;
            listBoxAllIngredients.Click += listBoxAllIngredients_Click;
            // 
            // listBoxSelectedIngredients
            // 
            listBoxSelectedIngredients.FormattingEnabled = true;
            listBoxSelectedIngredients.Location = new Point(597, 94);
            listBoxSelectedIngredients.Name = "listBoxSelectedIngredients";
            listBoxSelectedIngredients.Size = new Size(190, 254);
            listBoxSelectedIngredients.TabIndex = 11;
            listBoxSelectedIngredients.Click += listBoxSelectedIngredients_Click;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(824, 375);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(112, 34);
            buttonAddIngredient.TabIndex = 12;
            buttonAddIngredient.Text = "Hozzáad";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            buttonAddIngredient.Click += buttonAddIngredient_Click;
            // 
            // buttonRemoveIngredient
            // 
            buttonRemoveIngredient.Location = new Point(675, 375);
            buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            buttonRemoveIngredient.Size = new Size(112, 34);
            buttonRemoveIngredient.TabIndex = 13;
            buttonRemoveIngredient.Text = "Eltávolít";
            buttonRemoveIngredient.UseVisualStyleBackColor = true;
            buttonRemoveIngredient.Click += buttonRemoveIngredient_Click;
            // 
            // textBoxSearchIngredient
            // 
            textBoxSearchIngredient.Location = new Point(824, 43);
            textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            textBoxSearchIngredient.Size = new Size(190, 31);
            textBoxSearchIngredient.TabIndex = 14;
            textBoxSearchIngredient.TextChanged += textBoxSearchIngredient_TextChanged;
            // 
            // FormNewRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 493);
            Controls.Add(textBoxSearchIngredient);
            Controls.Add(buttonRemoveIngredient);
            Controls.Add(buttonAddIngredient);
            Controls.Add(listBoxSelectedIngredients);
            Controls.Add(listBoxAllIngredients);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddRecipe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxImageUrl);
            Controls.Add(textBoxInstructions);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "FormNewRecipe";
            Text = "FormNewRecipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxInstructions;
        private TextBox textBoxImageUrl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAddRecipe;
        private Button buttonCancel;
        private ListBox listBoxAllIngredients;
        private ListBox listBoxSelectedIngredients;
        private Button buttonAddIngredient;
        private Button buttonRemoveIngredient;
        private TextBox textBoxSearchIngredient;
    }
}