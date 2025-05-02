namespace Alviro
{
    partial class FormIngredientModify
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
            panelHeader = new Panel();
            panelControls = new Panel();
            panelModifyContent = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            label2 = new Label();
            panelHeader.SuspendLayout();
            panelControls.SuspendLayout();
            panelModifyContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(471, 50);
            panelHeader.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(buttonSave);
            panelControls.Controls.Add(buttonCancel);
            panelControls.Dock = DockStyle.Bottom;
            panelControls.Location = new Point(0, 121);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(471, 39);
            panelControls.TabIndex = 1;
            // 
            // panelModifyContent
            // 
            panelModifyContent.Controls.Add(label1);
            panelModifyContent.Controls.Add(textBox1);
            panelModifyContent.Dock = DockStyle.Fill;
            panelModifyContent.Location = new Point(0, 50);
            panelModifyContent.Name = "panelModifyContent";
            panelModifyContent.Size = new Size(471, 71);
            panelModifyContent.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 1;
            label1.Text = "Név:";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(62, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(258, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 9);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 2;
            label2.Text = "Hozzávaló szerkesztése";
            // 
            // FormIngredientModify
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 160);
            Controls.Add(panelModifyContent);
            Controls.Add(panelControls);
            Controls.Add(panelHeader);
            Name = "FormIngredientModify";
            Text = "FormIngredientModify";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelControls.ResumeLayout(false);
            panelModifyContent.ResumeLayout(false);
            panelModifyContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelControls;
        private Panel panelModifyContent;
        private TextBox textBox1;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
    }
}