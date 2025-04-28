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
            SuspendLayout();
            // 
            // listBoxAllRecipe
            // 
            listBoxAllRecipe.FormattingEnabled = true;
            listBoxAllRecipe.Location = new Point(27, 54);
            listBoxAllRecipe.Name = "listBoxAllRecipe";
            listBoxAllRecipe.Size = new Size(191, 529);
            listBoxAllRecipe.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(27, 17);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(191, 31);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(254, 549);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(112, 34);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Törlés";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(393, 549);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(112, 34);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Új recept";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // UserControlAllRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(textBoxSearch);
            Controls.Add(listBoxAllRecipe);
            Name = "UserControlAllRecipe";
            Size = new Size(991, 606);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAllRecipe;
        private TextBox textBoxSearch;
        private Button buttonDeleteRecipe;
        private Button buttonAddRecipe;
    }
}
