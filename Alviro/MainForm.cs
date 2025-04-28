namespace Alviro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void buttonMenuItem1_Click(object sender, EventArgs e)
        {
            UserControlAllRecipe userControlAllRecipe = new UserControlAllRecipe();
            userControlAllRecipe.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlAllRecipe);
            buttonHideMenu.BringToFront();
        }

        private void buttonMenuItem2_Click(object sender, EventArgs e)
        {
            UserControlIngredients userControlIngredients = new UserControlIngredients();
            userControlIngredients.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlIngredients);
            buttonHideMenu.BringToFront();
        }

        private void buttonHideMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
                buttonHideMenu.Location = new Point(5, 9);
                buttonHideMenu.Text = "<";

            }
            else
            {
                panelMenu.Visible = false;
                buttonHideMenu.Location = new Point(5, 9);
                buttonHideMenu.Text = ">";
            }
        }
    }
}
