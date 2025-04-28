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
        }

        private void buttonMenuItem2_Click(object sender, EventArgs e)
        {
            UserControlIngredients userControlIngredients = new UserControlIngredients();
            userControlIngredients.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlIngredients);
        }
    }
}
