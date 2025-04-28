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

        private void loadIngredients()
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
            var selectedProduct = listBoxSelectedProducts.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Kérlek válassz ki egy terméket!", "Nincs kiválasztott termék", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedIngredient = (Ingredient)listBoxAllIngredients.SelectedItem;
            var ingredientProductId = ((dynamic)selectedProduct).ingredientProductId;
            //var ingredientProduct = from k in dbContext.Ingredientproducts
            //                        where k.Ingredientproductid == ingredientProductId
            //                        select k;

        }
    }
}
