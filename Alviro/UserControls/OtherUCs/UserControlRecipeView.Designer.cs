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
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "ReceptNév";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.Location = new Point(145, 19);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 38);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonModify
            // 
            buttonModify.Anchor = AnchorStyles.None;
            buttonModify.BackColor = Color.FromArgb(104, 123, 82);
            buttonModify.FlatStyle = FlatStyle.Flat;
            buttonModify.Font = new Font("Segoe UI", 10F);
            buttonModify.ForeColor = Color.White;
            buttonModify.Location = new Point(8, 19);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(126, 38);
            buttonModify.TabIndex = 2;
            buttonModify.Text = "Szerkesztés";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Click += buttonModify_Click;
            // 
            // labelLastModified
            // 
            labelLastModified.Anchor = AnchorStyles.None;
            labelLastModified.AutoSize = true;
            labelLastModified.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelLastModified.ForeColor = Color.White;
            labelLastModified.Location = new Point(14, 23);
            labelLastModified.MaximumSize = new Size(220, 40);
            labelLastModified.Name = "labelLastModified";
            labelLastModified.Size = new Size(178, 30);
            labelLastModified.TabIndex = 3;
            labelLastModified.Text = "2000.00.00 15:30";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(104, 123, 82);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 6);
            panel1.MinimumSize = new Size(830, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 80);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(86, 99, 111);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(374, 80);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(86, 99, 111);
            panel3.Controls.Add(labelLastModified);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(374, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 80);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(86, 99, 111);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonModify);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(657, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 80);
            panel2.TabIndex = 4;
            // 
            // UserControlRecipeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panel1);
            MinimumSize = new Size(700, 91);
            Name = "UserControlRecipeView";
            Size = new Size(933, 91);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonDelete;
        private Button buttonModify;
        private Label labelLastModified;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
    }
}
