namespace Alviro
{
    partial class FormConfrimDialog
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
            buttonCancel = new Button();
            button2 = new Button();
            labelText = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BackColor = Color.FromArgb(255, 128, 128);
            buttonCancel.DialogResult = DialogResult.No;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(34, 6);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(134, 41);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Nem";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(104, 123, 82);
            button2.DialogResult = DialogResult.Yes;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(294, 6);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(134, 41);
            button2.TabIndex = 1;
            button2.Text = "Igen";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Fill;
            labelText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelText.Location = new Point(0, 0);
            labelText.Margin = new Padding(12);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(18);
            labelText.Size = new Size(95, 61);
            labelText.TabIndex = 2;
            labelText.Text = "label1";
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 173);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 54);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelText);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 173);
            panel2.TabIndex = 4;
            // 
            // FormConfrimDialog
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(461, 227);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximumSize = new Size(836, 829);
            Name = "FormConfrimDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfrimDialog";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        public Label labelText;
    }
}