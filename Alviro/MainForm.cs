using System.Threading.Tasks;

namespace Alviro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loadTime();
        }

        private void buttonMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            buttonMenuItem2.BackColor = Color.FromArgb(104, 123, 82);
            buttonMenuItem1.BackColor = Color.FromArgb(37, 173, 82);
            


            UserControlAllRecipe userControlAllRecipe = new UserControlAllRecipe();
            userControlAllRecipe.Dock = DockStyle.Fill;


            panelMain.Controls.Add(userControlAllRecipe);
            
        }

        private void buttonMenuItem2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            buttonMenuItem1.BackColor = Color.FromArgb(104, 123, 82);
            buttonMenuItem2.BackColor = Color.FromArgb(37, 173, 82);
            

            UserControlIngredients userControlIngredients = new UserControlIngredients();
            userControlIngredients.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControlIngredients);

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
        private void loadTime()
        {
            labelDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        
    }
}
