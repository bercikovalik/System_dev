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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Alviro
{

    public partial class UserControlRecipeAllNew : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();


        public UserControlRecipeAllNew()
        {
            InitializeComponent();


            loadRecipesAsync();


        }
        private List<Recipe> loadRecipes()
        {

            var AllRecipe = from k in dbContext.Recipes
                            where k.Name.Contains(textBoxSearch.Text)
                            select k;
            return AllRecipe.ToList();

        }

        private void loadRecipesSync()
        {
            panelRecipeViewer.Controls.Clear();

            var AllRecipe = from k in dbContext.Recipes
                            where k.Name.Contains(textBoxSearch.Text)
                            select k;
            if(AllRecipe.Count() == 0)
            {
                
                UserControlNoResult userControlNoResult = new UserControlNoResult();
                userControlNoResult.Dock = DockStyle.Top;
                panelRecipeViewer.Controls.Add(userControlNoResult);
                return;
            }
            int i = 0;
            foreach (var recipe in AllRecipe)
            {
                string ucName = $"userControlRecipeView{i + 1}";

                var userControlRecipeView = new UserControlRecipeView(recipe);
                userControlRecipeView.Name = ucName;
                userControlRecipeView.Top = i * (userControlRecipeView.Height + 10);
                userControlRecipeView.Left = 0;
                userControlRecipeView.Dock = DockStyle.Top;

                // Feliratkozás az eseményre
                userControlRecipeView.ButtonDeleteClicked += UserControlRecipeView_ButtonDeleteClicked;
                userControlRecipeView.ButtonModifyClicked += UserControlRecipeView_ButtonModifyClicked;


                panelRecipeViewer.Controls.Add(userControlRecipeView);
                i++;
            }
        }

        private void populateUi(List<Recipe> data)
        {
            


            panelRecipeViewer.Controls.Clear();
            int i = 0;
            foreach (var recipe in data)
            {
                string ucName = $"userControlRecipeView{i + 1}";

                var userControlRecipeView = new UserControlRecipeView(recipe);
                userControlRecipeView.Name = ucName;
                userControlRecipeView.Top = i * (userControlRecipeView.Height + 10);
                userControlRecipeView.Left = 0;
                userControlRecipeView.Dock = DockStyle.Top;

                // Feliratkozás az eseményre
                userControlRecipeView.ButtonDeleteClicked += UserControlRecipeView_ButtonDeleteClicked;

                panelRecipeViewer.Controls.Add(userControlRecipeView);
                i++;
            }



        }

        private async void loadRecipesAsync()
        {
            pictureBoxLoading.Visible = true;
            
            await Task.Delay(50); // UI refresh


            var data = await Task.Run(() => loadRecipes());

            populateUi(data);

            pictureBoxLoading.Visible = false;
            
        }

        private void UserControlRecipeView_ButtonDeleteClicked(object sender, EventArgs e)
        {
            var clickedUC = sender as UserControlRecipeView;
            if (clickedUC != null)
            {

                panelRecipeViewer.Controls.Remove(clickedUC);

            }
        }
        private void UserControlRecipeView_ButtonModifyClicked(object sender, EventArgs e)
        {
            loadRecipesSync();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadRecipesSync();
        }
    }
}
