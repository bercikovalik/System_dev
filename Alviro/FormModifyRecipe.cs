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
using Alviro.Models;
using Microsoft.EntityFrameworkCore;

namespace Alviro
{
    public partial class FormModifyRecipe : Form
    {
        Dnn972Context dbContext = new Dnn972Context();
        public FormModifyRecipe(Recipe RecipeToModify)
        {
            InitializeComponent();

            loadIngredients();

            textBoxName.Text = RecipeToModify.Name;
            textBoxDescription.Text = RecipeToModify.Description;
            textBoxInstructions.Text = RecipeToModify.Instructions;
            textBoxImageUrl.Text = RecipeToModify.Imageurl;
            loadSelectedIngredients(RecipeToModify);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadIngredients()
        {
            var AllIngredients = from k in dbContext.Ingredients
                                 where k.Name.Contains(textBoxSearchIngredient.Text)
                                 select k;
            listBoxAllIngredients.DataSource = AllIngredients.ToList();
            listBoxAllIngredients.DisplayMember = "Name";
        }
        private void loadSelectedIngredients(Recipe RecipeToModify)
        {
            var selectedIngredients = from k in dbContext.Recipeingredients
                                      where k.Recipeid == RecipeToModify.Recipeid
                                      select k.Ingredient;

            listBoxSelectedIngredients.DataSource = selectedIngredients.ToList();
            listBoxSelectedIngredients.DisplayMember = "Name";
        }

        private void textBoxSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            loadIngredients();
        }
        private void searchSelectedIngredients(List<Ingredient> ingredientsList)
        {
            var searchedIngredients = from k in ingredientsList
                                      where k.Name.Contains(textBoxSearchSelectedIngredient.Text)
                                      select k;
            listBoxSelectedIngredients.DataSource = searchedIngredients.ToList();

        }

        private void textBoxSearchSelectedIngredient_TextChanged(object sender, EventArgs e)
        {
            searchSelectedIngredients(listBoxSelectedIngredients.DataSource as List<Ingredient>);
        }
    }
}
