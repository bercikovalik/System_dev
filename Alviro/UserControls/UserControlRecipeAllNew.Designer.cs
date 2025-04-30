namespace Alviro
{
    partial class UserControlRecipeAllNew
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
            panelHeader = new Panel();
            textBoxSearch = new TextBox();
            panelRecipeViewer = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(textBoxSearch);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(933, 55);
            panelHeader.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(112, 13);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(150, 31);
            textBoxSearch.TabIndex = 0;
            // 
            // panelRecipeViewer
            // 
            panelRecipeViewer.AutoScroll = true;
            panelRecipeViewer.Dock = DockStyle.Fill;
            panelRecipeViewer.Location = new Point(0, 55);
            panelRecipeViewer.Name = "panelRecipeViewer";
            panelRecipeViewer.Size = new Size(933, 546);
            panelRecipeViewer.TabIndex = 1;
            // 
            // UserControlRecipeAllNew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRecipeViewer);
            Controls.Add(panelHeader);
            Name = "UserControlRecipeAllNew";
            Size = new Size(933, 601);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private TextBox textBoxSearch;
        private Panel panelRecipeViewer;
    }
}
