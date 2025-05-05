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
            panelHeader = new Panel();
            labelIngredientName = new Label();
            panelContentHeader = new Panel();
            panelAside = new Panel();
            panelLinkToHotcakesAdmin = new Panel();
            pictureBoxHotcakes = new PictureBox();
            button1 = new Button();
            panelWebShopLink = new Panel();
            pictureBoxWebShop = new PictureBox();
            buttonOpenWebShop = new Button();
            panelContent = new Panel();
            panelCheckConnection = new Panel();
            panelHeader.SuspendLayout();
            panelAside.SuspendLayout();
            panelLinkToHotcakesAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHotcakes).BeginInit();
            panelWebShopLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebShop).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelIngredientName);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(915, 52);
            panelHeader.TabIndex = 0;
            // 
            // labelIngredientName
            // 
            labelIngredientName.Anchor = AnchorStyles.None;
            labelIngredientName.AutoSize = true;
            labelIngredientName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelIngredientName.ForeColor = Color.White;
            labelIngredientName.Location = new Point(381, 8);
            labelIngredientName.Name = "labelIngredientName";
            labelIngredientName.Size = new Size(153, 38);
            labelIngredientName.TabIndex = 3;
            labelIngredientName.Text = "Áttekintés";
            labelIngredientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(51, 51, 51);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 52);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(915, 74);
            panelContentHeader.TabIndex = 3;
            // 
            // panelAside
            // 
            panelAside.Controls.Add(panelLinkToHotcakesAdmin);
            panelAside.Controls.Add(panelWebShopLink);
            panelAside.Dock = DockStyle.Right;
            panelAside.Location = new Point(642, 0);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(273, 415);
            panelAside.TabIndex = 0;
            // 
            // panelLinkToHotcakesAdmin
            // 
            panelLinkToHotcakesAdmin.Controls.Add(pictureBoxHotcakes);
            panelLinkToHotcakesAdmin.Controls.Add(button1);
            panelLinkToHotcakesAdmin.Dock = DockStyle.Top;
            panelLinkToHotcakesAdmin.Location = new Point(0, 206);
            panelLinkToHotcakesAdmin.Name = "panelLinkToHotcakesAdmin";
            panelLinkToHotcakesAdmin.Size = new Size(273, 206);
            panelLinkToHotcakesAdmin.TabIndex = 1;
            // 
            // pictureBoxHotcakes
            // 
            pictureBoxHotcakes.Image = (Image)resources.GetObject("pictureBoxHotcakes.Image");
            pictureBoxHotcakes.Location = new Point(21, 15);
            pictureBoxHotcakes.Name = "pictureBoxHotcakes";
            pictureBoxHotcakes.Size = new Size(237, 117);
            pictureBoxHotcakes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHotcakes.TabIndex = 6;
            pictureBoxHotcakes.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(86, 99, 111);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 138);
            button1.Name = "button1";
            button1.Size = new Size(237, 57);
            button1.TabIndex = 5;
            button1.Text = "Admin felület";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelWebShopLink
            // 
            panelWebShopLink.Controls.Add(pictureBoxWebShop);
            panelWebShopLink.Controls.Add(buttonOpenWebShop);
            panelWebShopLink.Dock = DockStyle.Top;
            panelWebShopLink.Location = new Point(0, 0);
            panelWebShopLink.Name = "panelWebShopLink";
            panelWebShopLink.Size = new Size(273, 206);
            panelWebShopLink.TabIndex = 0;
            // 
            // pictureBoxWebShop
            // 
            pictureBoxWebShop.Image = (Image)resources.GetObject("pictureBoxWebShop.Image");
            pictureBoxWebShop.Location = new Point(21, 19);
            pictureBoxWebShop.Name = "pictureBoxWebShop";
            pictureBoxWebShop.Size = new Size(237, 117);
            pictureBoxWebShop.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWebShop.TabIndex = 5;
            pictureBoxWebShop.TabStop = false;
            // 
            // buttonOpenWebShop
            // 
            buttonOpenWebShop.Anchor = AnchorStyles.Bottom;
            buttonOpenWebShop.BackColor = Color.FromArgb(86, 99, 111);
            buttonOpenWebShop.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 99, 111);
            buttonOpenWebShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 51, 51);
            buttonOpenWebShop.FlatStyle = FlatStyle.Flat;
            buttonOpenWebShop.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonOpenWebShop.ForeColor = Color.White;
            buttonOpenWebShop.Location = new Point(21, 142);
            buttonOpenWebShop.Name = "buttonOpenWebShop";
            buttonOpenWebShop.Size = new Size(237, 57);
            buttonOpenWebShop.TabIndex = 4;
            buttonOpenWebShop.Text = "WebShop megnyitása";
            buttonOpenWebShop.UseVisualStyleBackColor = false;
            buttonOpenWebShop.Click += buttonOpenWebShop_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelCheckConnection);
            panelContent.Controls.Add(panelAside);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 126);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(915, 415);
            panelContent.TabIndex = 4;
            // 
            // panelCheckConnection
            // 
            panelCheckConnection.Dock = DockStyle.Fill;
            panelCheckConnection.Location = new Point(0, 0);
            panelCheckConnection.Name = "panelCheckConnection";
            panelCheckConnection.Size = new Size(642, 415);
            panelCheckConnection.TabIndex = 1;
            // 
            // UserControlOverview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 123, 82);
            Controls.Add(panelContent);
            Controls.Add(panelContentHeader);
            Controls.Add(panelHeader);
            MinimumSize = new Size(638, 455);
            Name = "UserControlOverview";
            Size = new Size(915, 541);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelAside.ResumeLayout(false);
            panelLinkToHotcakesAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHotcakes).EndInit();
            panelWebShopLink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebShop).EndInit();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelContentHeader;
        private Label labelIngredientName;
        private Panel panelAside;
        private Panel panelContent;
        private Panel panelCheckConnection;
        private Panel panelLinkToHotcakesAdmin;
        private Panel panelWebShopLink;
        private Button button1;
        private Button buttonOpenWebShop;
        private PictureBox pictureBoxHotcakes;
        private PictureBox pictureBoxWebShop;
    }
}
