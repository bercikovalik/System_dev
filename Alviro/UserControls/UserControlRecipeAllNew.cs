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
    
    public partial class UserControlRecipeAllNew : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();


        public UserControlRecipeAllNew()
        {
            InitializeComponent();


            loadRecipes();

            
        }

        private void loadRecipes()
        {
            //var AllRecipes = from k in dbContext.Recipes
            //                 select k;

            List<Recipe> allRecipes = new List<Recipe>();
            for (int k = 0; k < 10; k++)
            {
                Recipe recipe = new Recipe();
                recipe.Name = k.ToString();
                recipe.Lastmodified = DateTime.Now;
                allRecipes.Add(recipe);
            }

            panelRecipeViewer.Controls.Clear();
            int i = 0;
            foreach (var allRecipe in allRecipes)
            {
                string ucName = $"userControlRecipeView{i + 1}";

                var userControlRecipeView = new UserControlRecipeView(allRecipe);
                userControlRecipeView.Name = ucName;
                userControlRecipeView.Top = i * (userControlRecipeView.Height + 10);
                userControlRecipeView.Left = 0;

                // Feliratkozás az eseményre
                userControlRecipeView.ButtonDeleteClicked += UserControlRecipeView_ButtonDeleteClicked;

                panelRecipeViewer.Controls.Add(userControlRecipeView);
                i++;
            }



        }
        private void UserControlRecipeView_ButtonDeleteClicked(object sender, EventArgs e)
        {
            var clickedUC = sender as UserControlRecipeView;
            if (clickedUC != null)
            {
                MessageBox.Show($"Törlés kérése: {clickedUC.Name}");

                // Példa: eltávolítás a panelről
                panelRecipeViewer.Controls.Remove(clickedUC);

                loadRecipes();
            }
        }
    }
}
