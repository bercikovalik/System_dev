namespace Alviro
{
    partial class UserControlProductXIngredientViewer
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
            panel = new Panel();
            panelIngredientName = new Panel();
            label1 = new Label();
            panelCheckbox = new Panel();
            checkBox1 = new CheckBox();
            panel.SuspendLayout();
            panelIngredientName.SuspendLayout();
            panelCheckbox.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = Color.FromArgb(86, 99, 111);
            panel.Controls.Add(panelIngredientName);
            panel.Controls.Add(panelCheckbox);
            panel.Location = new Point(6, 4);
            panel.Name = "panel";
            panel.Size = new Size(361, 83);
            panel.TabIndex = 1;
            // 
            // panelIngredientName
            // 
            panelIngredientName.Controls.Add(label1);
            panelIngredientName.Dock = DockStyle.Fill;
            panelIngredientName.Location = new Point(47, 0);
            panelIngredientName.Name = "panelIngredientName";
            panelIngredientName.Size = new Size(314, 83);
            panelIngredientName.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "Hozzávaló";
            // 
            // panelCheckbox
            // 
            panelCheckbox.Controls.Add(checkBox1);
            panelCheckbox.Dock = DockStyle.Left;
            panelCheckbox.Location = new Point(0, 0);
            panelCheckbox.Name = "panelCheckbox";
            panelCheckbox.Size = new Size(47, 83);
            panelCheckbox.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(104, 123, 82);
            checkBox1.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            checkBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 123, 82);
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(35, 35);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserControlProductXIngredientViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Name = "UserControlProductXIngredientViewer";
            Size = new Size(374, 90);
            panel.ResumeLayout(false);
            panelIngredientName.ResumeLayout(false);
            panelIngredientName.PerformLayout();
            panelCheckbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Panel panelIngredientName;
        private Label label1;
        private Panel panelCheckbox;
        public CheckBox checkBox1;
    }
}
