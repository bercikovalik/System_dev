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

        List<Ingredient> selectedIngredients = new List<Ingredient>();
        public UserControlIngredientsNew()
        {
            InitializeComponent();

            comboBoxOrder.Items.AddRange(new string[] {
                "Alapértelmezett",
                "Név (Z-A)",
                "Név (A-Z)"
            });

            // Set the default selected index

            LoadIngredientsAsync();
            //comboBoxOrder.SelectedIndex = 0;

        }

        public void LoadIngredientsSync()
        {
            selectedIngredients.Clear();
            // Clear existing controls
            panelIngredientsTable.Controls.Clear();
            // Fetch all ingredients from the database
            List<Ingredient> ingredients = (from k in dbContext.Ingredients
                                            where k.Name.Contains(textBoxSearch.Text)
                                            select k).ToList();

            if (ingredients.Count == 0)
            {
                UserControlNoResult userControlNoResult = new UserControlNoResult();
                userControlNoResult.Dock = DockStyle.Top;
                panelIngredientsTable.Controls.Add(userControlNoResult);
                return;
            }

            //Sort the ingredients based on the selected order
            switch (comboBoxOrder.SelectedIndex)
            {
                case -1:

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
                    ingredientSelected(ingredient);
                };
                ingredientView.ButtonModifyClick += (s, e) =>
                {
                    LoadIngredientsAsync();
                };
                ingredientView.CheckBoxClick += (s, e) =>
                {
                    if (ingredientView.checkBox1.Checked)
                    {
                        selectedIngredients.Add(ingredient);
                    }
                    else
                    {
                        selectedIngredients.Remove(ingredient);
                    }
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
                    ingredientSelected(selectedIngredient);

                };
                userControlIngredientView.ButtonModifyClick += (s, e) =>
                {
                    LoadIngredientsAsync();
                };
                userControlIngredientView.CheckBoxClick += (s, e) =>
                {
                    if (userControlIngredientView.checkBox1.Checked)
                    {
                        selectedIngredients.Add(ingredient);
                    }
                    else
                    {
                        selectedIngredients.Remove(ingredient);
                    }
                };
                panelIngredientsTable.Controls.Add(userControlIngredientView);
                i++;
            }
        }


        public async Task LoadIngredientsAsync()
        {
            selectedIngredients.Clear();

            buttonAddNewIngredients.Enabled = false;
            buttonRefresh.Enabled = false;
            buttonDeselectAll.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            textBoxSearch.Enabled = false;
            pictureBoxLoading.Visible = true;

            await Task.Delay(50); // UI refresh


            var data = await Task.Run(() => loadIngredients());

            populateUi(data);


            pictureBoxLoading.Visible = false;
            textBoxSearch.Enabled = true;

            buttonAddNewIngredients.Enabled = true;
            buttonRefresh.Enabled = true;
            buttonDeselectAll.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

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

        private void buttonAddNewIngredients_Click(object sender, EventArgs e)
        {
            Ingredient newIngredient = new Ingredient();
            UserControlIngredientView userControlIngredientView = new UserControlIngredientView(newIngredient);
            userControlIngredientView.Name = "userControlIngredientViewNewIngredient";

            userControlIngredientView.textBoxModifyName.Text = "Új hozzávaló neve";
            newIngredient.Name = userControlIngredientView.textBoxModifyName.Text;

            dbContext.Ingredients.Add(newIngredient);

            dbContext.SaveChanges(); 

            userControlIngredientView.Dock = DockStyle.Top;
            userControlIngredientView.ButtonModifyClick += (s, e) =>
            {
                LoadIngredientsAsync();
            };
            userControlIngredientView.ButtonSelectClick += (s, e) =>
            {
                selectedIngredient = newIngredient;
                ingredientSelected(selectedIngredient);

            };
            userControlIngredientView.CheckBoxClick += (s, e) =>
            {
                if (userControlIngredientView.checkBox1.Checked)
                {
                    selectedIngredients.Add(newIngredient);
                }
                else
                {
                    selectedIngredients.Remove(newIngredient);
                }
            };
            userControlIngredientView.ButtonCancelModifyClick += (s, e) =>
            {
                LoadIngredientsSync();
                // Remove the new ingredient from the database if it was not saved
                try
                {
                    dbContext.Ingredients.Remove(newIngredient);
                    dbContext.SaveChanges();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Nem sikerült az új hozzávalót eltávolítani.", "Sikertelen eltávolítás", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            };
            
            //try
            //{
            //    dbContext.SaveChanges();
            //}
            //catch (System.Exception)
            //{
            //    MessageBox.Show("Nem sikerült az új hozzávalót hozzáadni.", "Sikertelen hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            userControlIngredientView.textBoxModifyName.Visible = true;
            userControlIngredientView.textBoxModifyName.Enabled = true;
            userControlIngredientView.buttonSave.Visible = true;
            userControlIngredientView.buttonSave.Enabled = true;
            userControlIngredientView.buttonModify.Visible = false;
            userControlIngredientView.buttonModify.Enabled = false;
            userControlIngredientView.buttonDelete.Visible = false;
            userControlIngredientView.buttonDelete.Enabled = false;
            userControlIngredientView.buttonCancelModify.Visible = true;
            userControlIngredientView.buttonCancelModify.Enabled = true;
            userControlIngredientView.buttonSelect.Enabled = false;

            panelIngredientsTable.Controls.Add(userControlIngredientView);

            //Focus on the new ingredient name textbox
            userControlIngredientView.textBoxModifyName.Focus();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedIngredients.Count == 0)
            {
                MessageBox.Show("Kérlek válassz ki legalább egy hozzávalót a törléshez", "Nincs kiválasztott hozzávaló", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormConfrimDialog confirmDialog = new FormConfrimDialog();
            var ingredientNames = selectedIngredients.Select(i => i.Name).ToList();
            var formattedList = new List<string>();

            for (int i = 0; i < ingredientNames.Count; i += 3)
            {
                var group = ingredientNames.Skip(i).Take(3);
                formattedList.Add(string.Join(", ", group));
            }

            string message = $"Biztosan törölni szeretnéd a kijelölt hozzávalókat?\n{string.Join("\n", formattedList)}";
            confirmDialog.labelText.Text = message;
            confirmDialog.Text = "Hozzávalók törlése";
            confirmDialog.ShowDialog();
            if (confirmDialog.DialogResult == DialogResult.Yes)
            {
                foreach (var ingredient in selectedIngredients)
                {
                    dbContext.Ingredients.Remove(ingredient);
                }
                try
                {
                    dbContext.SaveChanges();
                    LoadIngredientsAsync();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Nem sikerült eltávolítani a hozzávalókat, kérlek próbáld újra", "Sikertelen törlés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Select all ingredients
            foreach (Control control in panelIngredientsTable.Controls)
            {

                if (control is UserControlIngredientView ingredientView)
                {
                    // Check if the ingredient is already selected
                    if (selectedIngredients.Contains(ingredientView.ingredientDTO))
                    {
                        ingredientView.checkBox1.Checked = false;
                        selectedIngredients.Remove(ingredientView.ingredientDTO);
                    }
                    else
                    {
                        ingredientView.checkBox1.Checked = true;
                        selectedIngredients.Add(ingredientView.ingredientDTO);
                    }

                }
            }
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            //Deselect all ingredients
            foreach (Control control in panelIngredientsTable.Controls)
            {
                if (control is UserControlIngredientView ingredientView)
                {
                    ingredientView.checkBox1.Checked = false;
                    selectedIngredients.Remove(ingredientView.ingredientDTO);
                }
            }
        }

        private void ingredientSelected(Ingredient selectedIngredient)
        {
            FormSelectProducts formSelectProducts = new FormSelectProducts(selectedIngredient);
            formSelectProducts.ShowDialog();
            if (formSelectProducts.DialogResult == DialogResult.OK)
            {
                // Handle the selected ingredient
                // You can access the selected ingredient from the formSelectProducts object
                // For example: var selectedIngredient = formSelectProducts.SelectedIngredient;
            }
        }
        


    }
}
