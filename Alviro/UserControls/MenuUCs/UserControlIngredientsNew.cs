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
    public partial class UserControlIngredientsNew : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();

        Ingredient selectedIngredient = new Ingredient();
        public UserControlIngredientsNew()
        {
            InitializeComponent();

            LoadIngredients();
        }

        public void LoadIngredients()
        {
            // Clear existing controls
            panelIngredientsTable.Controls.Clear();
            // Fetch all ingredients from the database
            List<Ingredient> ingredients = dbContext.Ingredients.ToList();
            // Create a new UserControl for each ingredient and add it to the main control
            foreach (var ingredient in ingredients)
            {
                UserControlIngredientView ingredientView = new UserControlIngredientView(ingredient);
                panelIngredientsTable.Controls.Add(ingredientView);
                ingredientView.Dock = DockStyle.Top; // Optional: Set the docking style

                //Event listener
                ingredientView.ButtonSelectClick += (s, e) =>
                {
                    selectedIngredient = ingredient;
                    labelTempSelectedIngredient.Text = selectedIngredient.Name;
                };
                ingredientView.ButtonModifyClick += (s, e) =>
                {
                    LoadIngredients();
                };
            }
        }
    }
}
