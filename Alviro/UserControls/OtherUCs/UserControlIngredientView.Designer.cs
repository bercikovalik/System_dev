namespace Alviro
{
    partial class UserControlIngredientView
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
            panelControls = new Panel();
            buttonSelect = new Button();
            buttonDelete = new Button();
            buttonModify = new Button();
            panelCheckbox = new Panel();
            checkBox1 = new CheckBox();
            panel.SuspendLayout();
            panelIngredientName.SuspendLayout();
            panelControls.SuspendLayout();
            panelCheckbox.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = Color.FromArgb(86, 99, 111);
            panel.Controls.Add(panelIngredientName);
            panel.Controls.Add(panelControls);
            panel.Controls.Add(panelCheckbox);
            panel.Location = new Point(2, 4);
            panel.Name = "panel";
            panel.Size = new Size(627, 83);
            panel.TabIndex = 0;
            // 
            // panelIngredientName
            // 
            panelIngredientName.Controls.Add(label1);
            panelIngredientName.Dock = DockStyle.Fill;
            panelIngredientName.Location = new Point(47, 0);
            panelIngredientName.Name = "panelIngredientName";
            panelIngredientName.Size = new Size(189, 83);
            panelIngredientName.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "Hozzávaló";
            // 
            // panelControls
            // 
            panelControls.Controls.Add(buttonSelect);
            panelControls.Controls.Add(buttonDelete);
            panelControls.Controls.Add(buttonModify);
            panelControls.Dock = DockStyle.Right;
            panelControls.Location = new Point(236, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(391, 83);
            panelControls.TabIndex = 2;
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.None;
            buttonSelect.BackColor = Color.FromArgb(104, 123, 82);
            buttonSelect.FlatStyle = FlatStyle.Flat;
            buttonSelect.Font = new Font("Segoe UI", 10F);
            buttonSelect.ForeColor = Color.White;
            buttonSelect.Location = new Point(9, 22);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(126, 38);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "Kiválaszt";
            buttonSelect.UseVisualStyleBackColor = false;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.Location = new Point(274, 22);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 38);
            buttonDelete.TabIndex = 3;
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
            buttonModify.Location = new Point(142, 22);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(126, 38);
            buttonModify.TabIndex = 4;
            buttonModify.Text = "Szerkesztés";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Click += buttonModify_Click;
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
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(35, 35);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // UserControlIngredientView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Name = "UserControlIngredientView";
            Size = new Size(632, 90);
            panel.ResumeLayout(false);
            panelIngredientName.ResumeLayout(false);
            panelIngredientName.PerformLayout();
            panelControls.ResumeLayout(false);
            panelCheckbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Panel panelCheckbox;
        private Label labelIngredientName;
        private CheckBox checkBox1;
        private Panel panelControls;
        private Panel panelIngredientName;
        private Label label1;
        private Button buttonDelete;
        private Button buttonModify;
        private Button buttonSelect;
    }
}
