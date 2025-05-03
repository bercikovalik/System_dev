using Alviro.Models;
using Microsoft.EntityFrameworkCore;
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

            comboBoxOrder.Items.AddRange(new string[] {
                "Alapértelmezett",
                "Név (Z_A)",
                "Név (A-Z)"
            });

            // Set the default selected index

            LoadIngredientsAsync();
            //comboBoxOrder.SelectedIndex = 0;

        }

        public void LoadIngredientsSync()
        {
            // Clear existing controls
            panelIngredientsTable.Controls.Clear();
            // Fetch all ingredients from the database
            List<Ingredient> ingredients = (from k in dbContext.Ingredients
                                            where k.Name.Contains(textBoxSearch.Text)
                                            select k).ToList();

            //Sort the ingredients based on the selected order
            switch (comboBoxOrder.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Nincs kiválasztott rendezési mód!", "Figyelmeztetés");
                    break;
                case 0:
                    ingredients = ingredients.OrderBy(i => i.Ingredientid).ToList();
                    break;
                case 1:
                    ingredients = ingredients.OrderBy(i => (i.Name ?? "").ToLower()).ToList();
                    break;
                case 2:
                    ingredients = ingredients.OrderByDescending(i => (i.Name ?? "").ToLower()).ToList();
                    break;

            }



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
                    LoadIngredientsAsync();
                };
                ingredientView.CheckBoxClick += (s, e) =>
                {
                    // Handle checkbox click event
                    // You can access the selected ingredient here if needed
                    // For example: MessageBox.Show($"Checkbox clicked for {ingredient.Name}");
                };
            }

        }



        private List<Ingredient> loadIngredients()
        {

            try
            {
                List<Ingredient> ingredients = (from k in dbContext.Ingredients
                                                where k.Name.Contains(textBoxSearch.Text)
                                                select k).ToList();


                return ingredients;

            }
            catch (System.Exception)
            {
                MessageBox.Show("A hozzávalókat nem sikerült betölteni", "Sikertelen betöltés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Ingredient>();
            }

        }

        private void populateUi(List<Ingredient> data)
        {
            panelIngredientsTable.Controls.Clear();
            int i = 0;
            foreach (var ingredient in data)
            {
                string ucName = $"userControlIngredientView{i + 1}";
                var userControlIngredientView = new UserControlIngredientView(ingredient);
                userControlIngredientView.Name = ucName;
                userControlIngredientView.Top = i * (userControlIngredientView.Height + 10);
                userControlIngredientView.Left = 0;
                userControlIngredientView.Dock = DockStyle.Top;
                // Feliratkozás az eseményre
                userControlIngredientView.ButtonSelectClick += (s, e) =>
                {
                    selectedIngredient = ingredient;
                    labelTempSelectedIngredient.Text = selectedIngredient.Name;
                };
                userControlIngredientView.ButtonModifyClick += (s, e) =>
                {
                    LoadIngredientsAsync();
                };
                userControlIngredientView.CheckBoxClick += (s, e) =>
                {
                    // Handle checkbox click event
                    // You can access the selected ingredient here if needed
                    // For example: MessageBox.Show($"Checkbox clicked for {ingredient.Name}");
                };
                panelIngredientsTable.Controls.Add(userControlIngredientView);
                i++;
            }
        }


        public async Task LoadIngredientsAsync()
        {
            pictureBoxLoading.Visible = true;

            await Task.Delay(50); // UI refresh


            var data = await Task.Run(() => loadIngredients());

            populateUi(data);


            pictureBoxLoading.Visible = false;

        }



        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadIngredientsAsync();
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIngredientsSync();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadIngredientsSync();

        }
    }
}
