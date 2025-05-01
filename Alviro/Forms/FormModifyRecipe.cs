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
        public Recipe RecipeDTO = new Recipe();
        public List<Recipeingredient> addedIngredients = new List<Recipeingredient>();
        public List<Recipeingredient> removedIngredients = new List<Recipeingredient>();

        public FormModifyRecipe(Recipe RecipeToModify)
        {
            RecipeDTO = RecipeToModify;
            InitializeComponent();

            loadIngredients();

            textBoxName.Text = RecipeToModify.Name;
            textBoxDescription.Text = RecipeToModify.Description;
            textBoxInstructions.Text = RecipeToModify.Instructions;
            textBoxImageUrl.Text = RecipeToModify.Imageurl;
            loadSelectedIngredients();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            List<string> removedIngredientsName = new List<string>();
            foreach (var ingredient in removedIngredients)
            {
                removedIngredientsName.Add(ingredient.Ingredient.Name);
            }

            List<string> addedIngredientsName = new List<string>();
            foreach (var ingredient in addedIngredients)
            {
                addedIngredientsName.Add(ingredient.Ingredient.Name);
            }

            string removedText = removedIngredientsName.Count > 0
                ? "Eltávolított hozzávalók:\n" + string.Join("\n", removedIngredientsName)
                : "Nincs eltávolított hozzávaló.";

            string addedText = addedIngredientsName.Count > 0
                ? "Hozzáadott hozzávalók:\n" + string.Join("\n", addedIngredientsName)
                : "Nincs hozzáadott hozzávaló.";

            // Szöveges változtatások listázása
            List<string> changedFields = new List<string>();
            if (textBoxName.Text != RecipeDTO.Name) changedFields.Add("Név");
            if (textBoxDescription.Text != RecipeDTO.Description) changedFields.Add("Leírás");
            if (textBoxInstructions.Text != RecipeDTO.Instructions) changedFields.Add("Instrukciók");
            if (textBoxImageUrl.Text != RecipeDTO.Imageurl) changedFields.Add("Kép URL");

            string changedText = changedFields.Count > 0
                ? "Módosított mezők:\n" + string.Join("\n", changedFields)
                : "Nincs módosított szöveges mező.";

            // Összesítés
            string message =
                "Az alábbi változtatások nem lesznek mentve:\n\n" +
                changedText + "\n\n" +
                removedText + "\n\n" +
                addedText + "\n\n" +
                "Biztosan kilép a módosítások elvégzése nélkül?";

            FormConfrimDialog formConfrimDialog = new FormConfrimDialog();
            formConfrimDialog.Text = "Módosítások visszavonása";
            formConfrimDialog.labelText.Text = message;
            var result = formConfrimDialog.ShowDialog(this);



            if (result == DialogResult.No)
            {
                return;
            }
            //Rollback changes
            //Delete addedIngredients
            foreach (var ingredient in addedIngredients)
            {
                dbContext.Recipeingredients.Remove(ingredient);
            }
            //Add back removedIngredients
            foreach (var ingredient in removedIngredients)
            {
                Recipeingredient recipeIngredient = new Recipeingredient
                {
                    Recipeid = ingredient.Recipeid,
                    Ingredientid = ingredient.Ingredientid
                };
                dbContext.Recipeingredients.Add(recipeIngredient);
            }
            dbContext.SaveChanges();

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
        private void loadSelectedIngredients()
        {
            var selectedIngredients = from k in dbContext.Recipeingredients
                                      where k.Recipeid == RecipeDTO.Recipeid && k.Ingredient.Name.Contains(textBoxSearchSelectedIngredient.Text)
                                      select k.Ingredient;



            listBoxSelectedIngredients.DataSource = selectedIngredients.ToList();
            listBoxSelectedIngredients.DisplayMember = "Name";
        }

        private void textBoxSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            loadIngredients();
        }


        private void textBoxSearchSelectedIngredient_TextChanged(object sender, EventArgs e)
        {
            loadSelectedIngredients();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            var selectedIngredient = listBoxAllIngredients.SelectedItem as Ingredient;
            if (selectedIngredient != null)
            {
                Recipeingredient recipeIngredient = new Recipeingredient
                {
                    Recipeid = RecipeDTO.Recipeid,
                    Ingredientid = selectedIngredient.Ingredientid
                };
                // Check if the ingredient is already added
                var allIngredients = from k in dbContext.Recipeingredients
                                     where k.Recipeid == RecipeDTO.Recipeid
                                     select k.Ingredientid;
                if (allIngredients.Contains(selectedIngredient.Ingredientid))
                {
                    MessageBox.Show(
                        "Ez az összetevő már hozzá van adva a recepthez.",
                        "Összetevő már hozzáadva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                addedIngredients.Add(recipeIngredient);

                dbContext.Recipeingredients.Add(recipeIngredient);
                dbContext.SaveChanges();
                loadSelectedIngredients();


            }

        }



        private void buttonAddRecipe_Click_1(object sender, EventArgs e)
        {
            RecipeDTO.Name = textBoxName.Text;
            RecipeDTO.Description = textBoxDescription.Text;
            RecipeDTO.Instructions = textBoxInstructions.Text;
            RecipeDTO.Imageurl = textBoxImageUrl.Text;
            RecipeDTO.Lastmodified = DateTime.UtcNow;
            dbContext.Entry(RecipeDTO).State = EntityState.Modified;
            dbContext.Update(RecipeDTO);



            try
            {
                dbContext.SaveChanges();
                MessageBox.Show(
                "A recept módosítása sikeresen megtörtént.",
                "Sikeres módosítás",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            }
            catch (System.Exception)
            {
                MessageBox.Show(
                    "Hiba történt a recept mentésekor.",
                    "Sikertelen mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            var selectedIngredient = listBoxSelectedIngredients.SelectedItem as Ingredient;
            if (selectedIngredient != null)
            {
                var recipeIngredient = dbContext.Recipeingredients
                    .FirstOrDefault(ri => ri.Recipeid == RecipeDTO.Recipeid && ri.Ingredientid == selectedIngredient.Ingredientid);
                if (recipeIngredient != null)
                {
                    removedIngredients.Add(recipeIngredient);
                    dbContext.Recipeingredients.Remove(recipeIngredient);
                    dbContext.SaveChanges();
                    loadSelectedIngredients();
                }
            }
        }
    }
}
