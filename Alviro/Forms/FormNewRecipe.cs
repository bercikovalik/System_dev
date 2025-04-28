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

namespace Alviro
{
    public partial class FormNewRecipe : Form
    {
        Dnn972Context dbContext = new Dnn972Context();
        public FormNewRecipe()
        {
            InitializeComponent();

            loadIngredients();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            Recipe newRecipe = new Recipe();
            newRecipe.Name = textBoxName.Text;
            newRecipe.Description = textBoxDescription.Text;
            newRecipe.Instructions = textBoxInstructions.Text;
            newRecipe.Imageurl = textBoxImageUrl.Text;

            if (string.IsNullOrEmpty(newRecipe.Name))
            {
                MessageBox.Show("Kérlek töltsd ki a név mezőt!");
                return;
            }
            dbContext.Recipes.Add(newRecipe);

            try
            {
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                MessageBox.Show(
                    "Hiba történt a mentés során. Kérlek, próbáld meg újra!",
                    "Mentési hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            foreach (Ingredient ingredient in listBoxSelectedIngredients.Items)
            {
                Recipeingredient recipeIngredient = new Recipeingredient();
                recipeIngredient.Recipeid = (from k in dbContext.Recipes
                                             where k.Name == newRecipe.Name
                                             select k.Recipeid).FirstOrDefault();
                recipeIngredient.Ingredientid = ingredient.Ingredientid;
                dbContext.Recipeingredients.Add(recipeIngredient);
            }

            try
            {
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                MessageBox.Show(
                    "Hiba történt a mentés során. Kérlek, próbáld meg újra!",
                    "Mentési hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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

        private void textBoxSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            loadIngredients();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            var selectedIngredient = listBoxAllIngredients.SelectedItem as Ingredient;
            if (selectedIngredient == null)
            {
                MessageBox.Show("Kérlek válassz ki egy hozzávalót!");
                return;
            }
            if (listBoxSelectedIngredients.Items.Contains(selectedIngredient))
            {
                MessageBox.Show("Ez a hozzávaló már hozzá van adva a recepthez!");
                return;
            }

            listBoxSelectedIngredients.Items.Add(selectedIngredient);
            listBoxSelectedIngredients.DisplayMember = "Name";
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            var selectedIngredient = listBoxSelectedIngredients.SelectedItem as Ingredient;
            if (selectedIngredient == null)
            {
                MessageBox.Show("Kérlek válassz ki egy hozzávalót a receptből!");
                return;
            }
            listBoxSelectedIngredients.Items.Remove(selectedIngredient);
        }

        private void listBoxSelectedIngredients_Click(object sender, EventArgs e)
        {
            listBoxAllIngredients.ClearSelected();
        }

        private void listBoxAllIngredients_Click(object sender, EventArgs e)
        {
            listBoxSelectedIngredients.ClearSelected();
        }
    }
}
