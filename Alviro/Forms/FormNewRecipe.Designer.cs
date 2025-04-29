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
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            textBoxSearchSelectedIngredient = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(125, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(351, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(125, 137);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(351, 106);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(125, 249);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(351, 99);
            textBoxInstructions.TabIndex = 2;
            // 
            // textBoxImageUrl
            // 
            textBoxImageUrl.Location = new Point(125, 378);
            textBoxImageUrl.Name = "textBoxImageUrl";
            textBoxImageUrl.Size = new Size(351, 31);
            textBoxImageUrl.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 79);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 4;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Leírás:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 252);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "Instrukciók:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 381);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Image URL:";
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(518, 436);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(112, 34);
            buttonAddRecipe.TabIndex = 8;
            buttonAddRecipe.Text = "Mentés";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(364, 436);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // listBoxAllIngredients
            // 
            listBoxAllIngredients.FormattingEnabled = true;
            listBoxAllIngredients.Location = new Point(824, 124);
            listBoxAllIngredients.Name = "listBoxAllIngredients";
            listBoxAllIngredients.Size = new Size(190, 254);
            listBoxAllIngredients.TabIndex = 10;
            listBoxAllIngredients.Click += listBoxAllIngredients_Click;
            // 
            // listBoxSelectedIngredients
            // 
            listBoxSelectedIngredients.FormattingEnabled = true;
            listBoxSelectedIngredients.Location = new Point(597, 124);
            listBoxSelectedIngredients.Name = "listBoxSelectedIngredients";
            listBoxSelectedIngredients.Size = new Size(190, 254);
            listBoxSelectedIngredients.TabIndex = 11;
            listBoxSelectedIngredients.Click += listBoxSelectedIngredients_Click;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(824, 389);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(112, 34);
            buttonAddIngredient.TabIndex = 12;
            buttonAddIngredient.Text = "Hozzáad";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            buttonAddIngredient.Click += buttonAddIngredient_Click;
            // 
            // buttonRemoveIngredient
            // 
            buttonRemoveIngredient.Location = new Point(675, 389);
            buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            buttonRemoveIngredient.Size = new Size(112, 34);
            buttonRemoveIngredient.TabIndex = 13;
            buttonRemoveIngredient.Text = "Eltávolít";
            buttonRemoveIngredient.UseVisualStyleBackColor = true;
            buttonRemoveIngredient.Click += buttonRemoveIngredient_Click;
            // 
            // textBoxSearchIngredient
            // 
            textBoxSearchIngredient.Location = new Point(824, 86);
            textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            textBoxSearchIngredient.Size = new Size(190, 31);
            textBoxSearchIngredient.TabIndex = 14;
            textBoxSearchIngredient.TextChanged += textBoxSearchIngredient_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxImageUrl);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(textBoxInstructions);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 493);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(163, 18);
            label5.Name = "label5";
            label5.Size = new Size(168, 32);
            label5.TabIndex = 10;
            label5.Text = "Recept adatai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(734, 18);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 11;
            label6.Text = "Hozzávalók";
            // 
            // textBoxSearchSelectedIngredient
            // 
            textBoxSearchSelectedIngredient.Location = new Point(597, 86);
            textBoxSearchSelectedIngredient.Name = "textBoxSearchSelectedIngredient";
            textBoxSearchSelectedIngredient.Size = new Size(190, 31);
            textBoxSearchSelectedIngredient.TabIndex = 16;
            textBoxSearchSelectedIngredient.TextChanged += textBoxSearchSelectedIngredient_TextChanged;
            // 
            // FormNewRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 493);
            Controls.Add(textBoxSearchSelectedIngredient);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(textBoxSearchIngredient);
            Controls.Add(buttonRemoveIngredient);
            Controls.Add(buttonAddIngredient);
            Controls.Add(listBoxSelectedIngredients);
            Controls.Add(listBoxAllIngredients);
            Controls.Add(buttonAddRecipe);
            Name = "FormNewRecipe";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Új recept hozzáadása";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label5;
        private Label label6;
        private TextBox textBoxSearchSelectedIngredient;
    }
}