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
            textBoxModifyName = new TextBox();
            label1 = new Label();
            panelControls = new Panel();
            buttonCancelModify = new Button();
            buttonSave = new Button();
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
            panel.Location = new Point(4, 4);
            panel.Name = "panel";
            panel.Size = new Size(630, 83);
            panel.TabIndex = 0;
            // 
            // panelIngredientName
            // 
            panelIngredientName.Controls.Add(textBoxModifyName);
            panelIngredientName.Controls.Add(label1);
            panelIngredientName.Dock = DockStyle.Fill;
            panelIngredientName.Location = new Point(47, 0);
            panelIngredientName.Name = "panelIngredientName";
            panelIngredientName.Size = new Size(192, 83);
            panelIngredientName.TabIndex = 3;
            // 
            // textBoxModifyName
            // 
            textBoxModifyName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxModifyName.BackColor = Color.Silver;
            textBoxModifyName.BorderStyle = BorderStyle.FixedSingle;
            textBoxModifyName.Enabled = false;
            textBoxModifyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxModifyName.ForeColor = Color.White;
            textBoxModifyName.Location = new Point(8, 22);
            textBoxModifyName.Name = "textBoxModifyName";
            textBoxModifyName.Size = new Size(178, 39);
            textBoxModifyName.TabIndex = 2;
            textBoxModifyName.Visible = false;
            textBoxModifyName.KeyDown += textBoxModifyName_KeyDown;
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
            panelControls.Controls.Add(buttonCancelModify);
            panelControls.Controls.Add(buttonSave);
            panelControls.Controls.Add(buttonSelect);
            panelControls.Controls.Add(buttonDelete);
            panelControls.Controls.Add(buttonModify);
            panelControls.Dock = DockStyle.Right;
            panelControls.Location = new Point(239, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(391, 83);
            panelControls.TabIndex = 2;
            // 
            // buttonCancelModify
            // 
            buttonCancelModify.Anchor = AnchorStyles.None;
            buttonCancelModify.BackColor = Color.FromArgb(255, 128, 128);
            buttonCancelModify.Enabled = false;
            buttonCancelModify.FlatStyle = FlatStyle.Flat;
            buttonCancelModify.Font = new Font("Segoe UI", 10F);
            buttonCancelModify.Location = new Point(274, 22);
            buttonCancelModify.Name = "buttonCancelModify";
            buttonCancelModify.Size = new Size(112, 38);
            buttonCancelModify.TabIndex = 7;
            buttonCancelModify.Text = "Mégse";
            buttonCancelModify.UseVisualStyleBackColor = false;
            buttonCancelModify.Visible = false;
            buttonCancelModify.Click += buttonCancelModify_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.BackColor = Color.FromArgb(104, 123, 82);
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(142, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(126, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
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
            checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(104, 123, 82);
            checkBox1.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            checkBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 123, 82);
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
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panel);
            Name = "UserControlIngredientView";
            Size = new Size(638, 90);
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
        private Panel panelControls;
        private Panel panelIngredientName;
        private Label label1;
        public TextBox textBoxModifyName;
        public Button buttonDelete;
        public Button buttonModify;
        public Button buttonSelect;
        public Button buttonCancelModify;
        public Button buttonSave;
        public CheckBox checkBox1;
    }
}
