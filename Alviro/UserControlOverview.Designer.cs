namespace Alviro
{
    partial class UserControlOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOverview));
            pictureBoxRightArrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRightArrow
            // 
            pictureBoxRightArrow.BackColor = Color.Transparent;
            pictureBoxRightArrow.Cursor = Cursors.Hand;
            pictureBoxRightArrow.Enabled = false;
            pictureBoxRightArrow.Image = (Image)resources.GetObject("pictureBoxRightArrow.Image");
            pictureBoxRightArrow.Location = new Point(3, 5);
            pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            pictureBoxRightArrow.Size = new Size(45, 45);
            pictureBoxRightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRightArrow.TabIndex = 2;
            pictureBoxRightArrow.TabStop = false;
            pictureBoxRightArrow.Visible = false;
            // 
            // UserControlOverview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxRightArrow);
            Name = "UserControlOverview";
            Size = new Size(938, 656);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightArrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxRightArrow;
    }
}
