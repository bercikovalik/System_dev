using Alviro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alviro
{
    public partial class UserControlAllRecipe : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();
        public UserControlAllRecipe()
        {
            InitializeComponent();

            loadRecipes();


        }

        private void loadRecipes()
        {
            var AllRecipe = from k in dbContext.Recipes
                            where k.Name.Contains(textBoxSearch.Text)
                            select k;
            listBoxAllRecipe.DataSource = AllRecipe.ToList();
            listBoxAllRecipe.DisplayMember = "Name";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadRecipes();
        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            var recipeToDelete = listBoxAllRecipe.SelectedItem as Recipe;
            var selectedIndex = listBoxAllRecipe.SelectedIndex;
            if (recipeToDelete != null)
            {
                DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd a receptet?", "Törlés megerősítése", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dbContext.Recipes.Remove(recipeToDelete);
                    dbContext.SaveChanges();
                    loadRecipes();
                    if (selectedIndex > 0)
                    {
                        listBoxAllRecipe.SelectedIndex = selectedIndex - 1;
                    }
                    else if (listBoxAllRecipe.Items.Count > 0)
                    {
                        listBoxAllRecipe.SelectedIndex = 0;
                    }

                }
                else
                {
                    MessageBox.Show(
                        "Kérlek, válassz ki egy receptet a törléshez!",
                        "Nincs kiválasztott recept",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                }
            }
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            FormNewRecipe formNewRecipe = new FormNewRecipe();
            formNewRecipe.ShowDialog();
            loadRecipes();
            listBoxAllRecipe.SelectedIndex = listBoxAllRecipe.Items.Count - 1;
        }
    }
}
