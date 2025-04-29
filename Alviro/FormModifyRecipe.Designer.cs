namespace Alviro
{
    partial class FormModifyRecipe
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
            panelBorderMiddle = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            buttonAddRecipe = new Button();
            panel4 = new Panel();
            label6 = new Label();
            label8 = new Label();
            listBoxAllIngredients = new ListBox();
            label7 = new Label();
            listBoxSelectedIngredients = new ListBox();
            textBoxSearchSelectedIngredient = new TextBox();
            buttonAddIngredient = new Button();
            buttonRemoveIngredient = new Button();
            textBoxSearchIngredient = new TextBox();
            panel1 = new Panel();
            panel5 = new Panel();
            buttonCancel = new Button();
            panel3 = new Panel();
            label5 = new Label();
            textBoxImageUrl = new TextBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxInstructions = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelBorderMiddle
            // 
            panelBorderMiddle.BackColor = Color.Black;
            panelBorderMiddle.Dock = DockStyle.Left;
            panelBorderMiddle.ForeColor = SystemColors.ControlLightLight;
            panelBorderMiddle.Location = new Point(495, 0);
            panelBorderMiddle.Name = "panelBorderMiddle";
            panelBorderMiddle.Size = new Size(1, 510);
            panelBorderMiddle.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(listBoxAllIngredients);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(listBoxSelectedIngredients);
            panel2.Controls.Add(textBoxSearchSelectedIngredient);
            panel2.Controls.Add(buttonAddIngredient);
            panel2.Controls.Add(buttonRemoveIngredient);
            panel2.Controls.Add(textBoxSearchIngredient);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(495, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 510);
            panel2.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonAddRecipe);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 452);
            panel6.Name = "panel6";
            panel6.Size = new Size(573, 58);
            panel6.TabIndex = 20;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(21, 12);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(112, 34);
            buttonAddRecipe.TabIndex = 8;
            buttonAddRecipe.Text = "Mentés";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 54, 46);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(573, 60);
            panel4.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(231, 16);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 11;
            label6.Text = "Hozzávalók";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(376, 64);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 18;
            label8.Text = "Összes";
            // 
            // listBoxAllIngredients
            // 
            listBoxAllIngredients.FormattingEnabled = true;
            listBoxAllIngredients.Location = new Point(327, 135);
            listBoxAllIngredients.Name = "listBoxAllIngredients";
            listBoxAllIngredients.Size = new Size(190, 254);
            listBoxAllIngredients.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(137, 64);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 17;
            label7.Text = "Kiválasztott";
            // 
            // listBoxSelectedIngredients
            // 
            listBoxSelectedIngredients.FormattingEnabled = true;
            listBoxSelectedIngredients.Location = new Point(100, 135);
            listBoxSelectedIngredients.Name = "listBoxSelectedIngredients";
            listBoxSelectedIngredients.Size = new Size(190, 254);
            listBoxSelectedIngredients.TabIndex = 11;
            // 
            // textBoxSearchSelectedIngredient
            // 
            textBoxSearchSelectedIngredient.Location = new Point(100, 97);
            textBoxSearchSelectedIngredient.Name = "textBoxSearchSelectedIngredient";
            textBoxSearchSelectedIngredient.Size = new Size(190, 31);
            textBoxSearchSelectedIngredient.TabIndex = 16;
            textBoxSearchSelectedIngredient.Visible = false;
            textBoxSearchSelectedIngredient.TextChanged += textBoxSearchSelectedIngredient_TextChanged;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(327, 400);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(112, 34);
            buttonAddIngredient.TabIndex = 12;
            buttonAddIngredient.Text = "Hozzáad";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveIngredient
            // 
            buttonRemoveIngredient.Location = new Point(178, 400);
            buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            buttonRemoveIngredient.Size = new Size(112, 34);
            buttonRemoveIngredient.TabIndex = 13;
            buttonRemoveIngredient.Text = "Eltávolít";
            buttonRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchIngredient
            // 
            textBoxSearchIngredient.Location = new Point(327, 97);
            textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            textBoxSearchIngredient.Size = new Size(190, 31);
            textBoxSearchIngredient.TabIndex = 14;
            textBoxSearchIngredient.TextChanged += textBoxSearchIngredient_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBoxImageUrl);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(textBoxInstructions);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 510);
            panel1.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonCancel);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 452);
            panel5.Name = "panel5";
            panel5.Size = new Size(495, 58);
            panel5.TabIndex = 12;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(364, 12);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 54, 46);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 60);
            panel3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(156, 16);
            label5.Name = "label5";
            label5.Size = new Size(168, 32);
            label5.TabIndex = 10;
            label5.Text = "Recept adatai";
            // 
            // textBoxImageUrl
            // 
            textBoxImageUrl.Location = new Point(125, 378);
            textBoxImageUrl.Name = "textBoxImageUrl";
            textBoxImageUrl.Size = new Size(351, 31);
            textBoxImageUrl.TabIndex = 3;
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
            // FormModifyRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 510);
            Controls.Add(panelBorderMiddle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormModifyRecipe";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recept szerkesztése";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBorderMiddle;
        private Panel panel2;
        private Panel panel6;
        private Button buttonAddRecipe;
        private Panel panel4;
        private Label label6;
        private Label label8;
        private ListBox listBoxAllIngredients;
        private Label label7;
        private ListBox listBoxSelectedIngredients;
        private TextBox textBoxSearchSelectedIngredient;
        private Button buttonAddIngredient;
        private Button buttonRemoveIngredient;
        private TextBox textBoxSearchIngredient;
        private Panel panel1;
        private Panel panel5;
        private Button buttonCancel;
        private Panel panel3;
        private Label label5;
        private TextBox textBoxImageUrl;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxInstructions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}