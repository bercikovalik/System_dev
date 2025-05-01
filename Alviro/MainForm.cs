using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alviro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loadTime();
        }





        private void loadIngredientsUC()
        {
            foreach (Control ctrl in panelMain.Controls.OfType<UserControl>().ToList())
            {
                panelMain.Controls.Remove(ctrl); // csak a régi UC-t távolítja el
            }
            panelMenuItem2.BackColor = Color.FromArgb(104, 123, 82);
            panelMenuItem1.BackColor = Color.Transparent;

            //Wait 50 sec so the ui can load
            Task.Delay(300).Wait();


            UserControlIngredients userControlIngredients = new UserControlIngredients();
            userControlIngredients.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControlIngredients);

            pictureBoxArrowLeft.BringToFront();
            pictureBoxRightArrow.BringToFront();
        }


        private void menuCLosing()
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
                
                pictureBoxArrowLeft.Visible = true;
                pictureBoxArrowLeft.Enabled = true;
                pictureBoxRightArrow.Visible = false;
                pictureBoxRightArrow.Enabled = false;

            }
            else
            {
                panelMenu.Visible = false;
                
                pictureBoxArrowLeft.Visible = false;
                pictureBoxArrowLeft.Enabled = false;
                pictureBoxRightArrow.Visible = true;
                pictureBoxRightArrow.Enabled = true;
            }
        }

        private void loadTime()
        {
            labelDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }





        private void panelMenuItem1_Click(object sender, EventArgs e)
        {
            loadAllRecipeUC();

        }

        private void loadAllRecipeUC()
        {
            foreach (Control ctrl in panelMain.Controls.OfType<UserControl>().ToList())
            {
                panelMain.Controls.Remove(ctrl); // csak a régi UC-t távolítja el
            }
            panelMenuItem1.BackColor = Color.FromArgb(104, 123, 82);
            panelMenuItem2.BackColor = Color.Transparent;




            UserControlRecipeAllNew userControlAllRecipe = new UserControlRecipeAllNew();
            userControlAllRecipe.Dock = DockStyle.Fill;


            panelMain.Controls.Add(userControlAllRecipe);
            pictureBoxArrowLeft.BringToFront();
            pictureBoxRightArrow.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadAllRecipeUC();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadAllRecipeUC();
        }

        private void panelMenuItem2_Click(object sender, EventArgs e)
        {
            loadIngredientsUC();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadIngredientsUC();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadIngredientsUC();
        }

        private void pictureBoxRightArrow_Click(object sender, EventArgs e)
        {
            menuCLosing();
        }

        private void pictureBoxArrowLeft_Click(object sender, EventArgs e)
        {
            menuCLosing();
        }
    }
}
