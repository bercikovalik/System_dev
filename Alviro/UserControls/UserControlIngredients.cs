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
    public partial class UserControlIngredients : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();

        public UserControlIngredients()
        {
            InitializeComponent();

            loadIngredients();
            loadProducts();
        }

        private async void loadIngredients()
        {
            try
            {
                var AllIngredients = from k in dbContext.Ingredients
                                     where k.Name.Contains(textBoxSearchIngredient.Text)
                                     select k;
                listBoxAllIngredients.DataSource = AllIngredients.ToList();
                listBoxAllIngredients.DisplayMember = "Name";
            }
            catch (System.Exception)
            {
                MessageBox.Show("Nem sikerült betölteni az adatokat", "Betöltés sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            loadIngredients();
        }

        private void loadProducts()
        {
            try
            {
                var allProducts = from k in dbContext.HccProductTranslations
                                  where k.ProductName.Contains(textBoxSearchProduct.Text)
                                  select new
                                  {
                                      ProductName = k.ProductName,
                                      RewriteUrl = k.Product.RewriteUrl,
                                      ProductId = (int)k.Product.Id
                                  };
                listBoxAllProducts.DataSource = allProducts.ToList();
                listBoxAllProducts.DisplayMember = "ProductName";
            }
            catch (System.Exception)
            {
                MessageBox.Show("Nem sikerült betölteni az adatokat.", "Sikertelen adatbetöltés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = listBoxAllProducts.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Kérlek válassz ki egy terméket!", "Nincs kiválasztott termék", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxAllIngredients.SelectedItem == null)
            {
                MessageBox.Show("Kérlek válassz ki egy hozzávalót!", "Nincs kiválasztott hozzávaló", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            var newIngredientProduct = new Ingredientproduct();
            newIngredientProduct.Productid = ((dynamic)selectedProduct).ProductId;
            newIngredientProduct.RewriteUrl = ((dynamic)selectedProduct).RewriteUrl;
            newIngredientProduct.Ingredientid = ((Ingredient)listBoxAllIngredients.SelectedItem).Ingredientid;


            //Check if the product already exists for the selected ingredient
            if (dbContext.Ingredientproducts.Any(x => x.Productid == newIngredientProduct.Productid && x.Ingredientid == newIngredientProduct.Ingredientid))
            {
                MessageBox.Show("Ez a termék már hozzá van adva ehhez a hozzávalóhoz!", "Termék létezik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dbContext.Ingredientproducts.Add(newIngredientProduct);


            try
            {
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                MessageBox.Show("A terméket nem sikerült hozzáadni", "Sikertelen hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadSelectedProducts();

        }

        private void loadSelectedProducts()
        {
            var selectedIngredient = (Ingredient)listBoxAllIngredients.SelectedItem;
            var selectedProducts = from k in dbContext.Ingredientproducts
                                   where k.Ingredientid == selectedIngredient.Ingredientid
                                   select new
                                   {
                                       ProductName = (from i in dbContext.HccProductTranslations
                                                      where i.Product.Id == k.Productid
                                                      select i.ProductName).FirstOrDefault(),
                                       ingredientProductId = k.Ingredientproductid,
                                   };
            listBoxSelectedProducts.DataSource = selectedProducts.ToList();
            listBoxSelectedProducts.DisplayMember = "ProductName";
        }

        private void listBoxAllIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSelectedProducts();
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void textBoxSearchSelectedProduct_TextChanged(object sender, EventArgs e)
        {
            loadSelectedProducts();
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            var productToDelete = listBoxSelectedProducts.SelectedItem;
            if (productToDelete == null)
            {
                MessageBox.Show("Kérlek válassz ki egy terméket!", "Nincs kiválasztott termék", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedIngredient = (Ingredient)listBoxAllIngredients.SelectedItem;

            //var ingredientProductId = ((dynamic)productToDelete).ingredientProductId;
            //var ingredientProductToDelete = (from k in dbContext.Ingredientproducts
            //                                where k.Ingredientproductid == ingredientProductId
            //                                select k).FirstOrDefault();
        }

        private void buttonAddNewIngredient_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNewIngredienName.Text))
            {
                MessageBox.Show("Kérlek add meg a hozzávaló nevét!", "Hozzávaló név megadása", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dbContext.Ingredients.Any(x => x.Name == textBoxNewIngredienName.Text))
            {
                MessageBox.Show("Ez a hozzávaló már létezik!", "Hozzávaló létezése", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ingredientToAdd = new Ingredient();
            ingredientToAdd.Name = textBoxNewIngredienName.Text;
            dbContext.Ingredients.Add(ingredientToAdd);
            try
            {
                dbContext.SaveChanges();

            }
            catch (System.Exception)
            {
                MessageBox.Show("A hozzávalót nem sikkerült hozzáadni. Kérlek próbáld újra", "Sikertelen hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadIngredients();
            textBoxNewIngredienName.Text = string.Empty;
            //Select last ingredient
            listBoxAllIngredients.SelectedIndex = listBoxAllIngredients.Items.Count -1;            

        }
    }

   
}
