namespace Alviro
{
    partial class UserControlRecipeView
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
            label1 = new Label();
            buttonDelete = new Button();
            buttonModify = new Button();
            labelLastModified = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.Location = new Point(504, 19);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonModify
            // 
            buttonModify.Anchor = AnchorStyles.None;
            buttonModify.Location = new Point(718, 19);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(112, 34);
            buttonModify.TabIndex = 2;
            buttonModify.Text = "Szerkesztés";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Click += buttonModify_Click;
            // 
            // labelLastModified
            // 
            labelLastModified.Anchor = AnchorStyles.None;
            labelLastModified.AutoSize = true;
            labelLastModified.Location = new Point(229, 24);
            labelLastModified.Name = "labelLastModified";
            labelLastModified.Size = new Size(59, 25);
            labelLastModified.TabIndex = 3;
            labelLastModified.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonModify);
            panel1.Controls.Add(labelLastModified);
            panel1.Controls.Add(buttonDelete);
            panel1.Location = new Point(15, 8);
            panel1.MinimumSize = new Size(830, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 74);
            panel1.TabIndex = 4;
            // 
            // UserControlRecipeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            MinimumSize = new Size(933, 91);
            Name = "UserControlRecipeView";
            Size = new Size(933, 91);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonDelete;
        private Button buttonModify;
        private Label labelLastModified;
        private Panel panel1;
    }
}
