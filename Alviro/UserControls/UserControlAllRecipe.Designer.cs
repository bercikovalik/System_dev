namespace Alviro
{
    partial class UserControlAllRecipe
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
            listBoxAllRecipe = new ListBox();
            textBoxSearch = new TextBox();
            buttonDeleteRecipe = new Button();
            buttonAddRecipe = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAllRecipe
            // 
            listBoxAllRecipe.Anchor = AnchorStyles.None;
            listBoxAllRecipe.FormattingEnabled = true;
            listBoxAllRecipe.Location = new Point(16, 16);
            listBoxAllRecipe.Name = "listBoxAllRecipe";
            listBoxAllRecipe.Size = new Size(221, 529);
            listBoxAllRecipe.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(32, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(191, 31);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(276, 551);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(112, 34);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Törlés";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(407, 551);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(112, 34);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Új recept";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 606);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxAllRecipe);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 566);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 40);
            panel2.TabIndex = 2;
            // 
            // UserControlAllRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Name = "UserControlAllRecipe";
            Size = new Size(991, 606);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAllRecipe;
        private TextBox textBoxSearch;
        private Button buttonDeleteRecipe;
        private Button buttonAddRecipe;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}
