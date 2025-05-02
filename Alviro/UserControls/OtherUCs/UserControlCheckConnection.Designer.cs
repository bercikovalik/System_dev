namespace Alviro
{
    partial class UserControlCheckConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCheckConnection));
            label = new Label();
            pictureBoxConnecting = new PictureBox();
            pictureBoxError = new PictureBox();
            pictureBoxOkay = new PictureBox();
            buttonCheckConnectionAgain = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConnecting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOkay).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label.ForeColor = Color.White;
            label.Location = new Point(516, 271);
            label.Name = "label";
            label.Size = new Size(316, 32);
            label.TabIndex = 9;
            label.Text = "Csatlakozás a szerverhez...";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxConnecting
            // 
            pictureBoxConnecting.Anchor = AnchorStyles.None;
            pictureBoxConnecting.Image = (Image)resources.GetObject("pictureBoxConnecting.Image");
            pictureBoxConnecting.Location = new Point(609, 170);
            pictureBoxConnecting.Name = "pictureBoxConnecting";
            pictureBoxConnecting.Size = new Size(98, 87);
            pictureBoxConnecting.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConnecting.TabIndex = 10;
            pictureBoxConnecting.TabStop = false;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Anchor = AnchorStyles.None;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(609, 170);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(98, 87);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 11;
            pictureBoxError.TabStop = false;
            pictureBoxError.Visible = false;
            // 
            // pictureBoxOkay
            // 
            pictureBoxOkay.Anchor = AnchorStyles.None;
            pictureBoxOkay.Image = (Image)resources.GetObject("pictureBoxOkay.Image");
            pictureBoxOkay.Location = new Point(609, 170);
            pictureBoxOkay.Name = "pictureBoxOkay";
            pictureBoxOkay.Size = new Size(98, 87);
            pictureBoxOkay.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOkay.TabIndex = 12;
            pictureBoxOkay.TabStop = false;
            pictureBoxOkay.Visible = false;
            // 
            // buttonCheckConnectionAgain
            // 
            buttonCheckConnectionAgain.Anchor = AnchorStyles.None;
            buttonCheckConnectionAgain.BackColor = Color.FromArgb(86, 99, 111);
            buttonCheckConnectionAgain.BackgroundImageLayout = ImageLayout.None;
            buttonCheckConnectionAgain.Cursor = Cursors.Hand;
            buttonCheckConnectionAgain.Enabled = false;
            buttonCheckConnectionAgain.FlatAppearance.BorderColor = Color.White;
            buttonCheckConnectionAgain.FlatAppearance.MouseDownBackColor = Color.FromArgb(104, 123, 82);
            buttonCheckConnectionAgain.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 99, 111);
            buttonCheckConnectionAgain.FlatStyle = FlatStyle.Flat;
            buttonCheckConnectionAgain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonCheckConnectionAgain.ForeColor = Color.White;
            buttonCheckConnectionAgain.Location = new Point(592, 425);
            buttonCheckConnectionAgain.Name = "buttonCheckConnectionAgain";
            buttonCheckConnectionAgain.Size = new Size(127, 52);
            buttonCheckConnectionAgain.TabIndex = 13;
            buttonCheckConnectionAgain.Text = "Újra";
            buttonCheckConnectionAgain.UseVisualStyleBackColor = false;
            buttonCheckConnectionAgain.Visible = false;
            buttonCheckConnectionAgain.Click += buttonCheckConnectionAgain_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(478, 315);
            label2.Name = "label2";
            label2.Size = new Size(386, 32);
            label2.TabIndex = 14;
            label2.Text = "Kérem ellenőrizze a kapcsolatot!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // UserControlCheckConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 123, 82);
            Controls.Add(label2);
            Controls.Add(buttonCheckConnectionAgain);
            Controls.Add(pictureBoxOkay);
            Controls.Add(pictureBoxError);
            Controls.Add(pictureBoxConnecting);
            Controls.Add(label);
            Name = "UserControlCheckConnection";
            Size = new Size(1314, 546);
            Load += UserControlCheckConnection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxConnecting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOkay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLoading;
        private Label label;
        private PictureBox pictureBoxConnecting;
        private PictureBox pictureBoxError;
        private PictureBox pictureBoxOkay;
        private Button buttonCheckConnectionAgain;
        private Label label2;
    }
}
