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

            //try
            {
                //Load categories to catgeoryy filter
                var allCategories = from k in dbContext.HccCategoryTranslations
                                    select new
                                    {
                                        CategoryName = k.Name,
                                        CategoryId = k.CategoryId
                                    };
                comboBoxCategoryFilter.DataSource = allCategories.ToList();
                comboBoxCategoryFilter.DisplayMember = "CategoryName";

                var allProducts = from k in dbContext.HccProductTranslations
                                  where k.ProductName.Contains(textBoxSearchProduct.Text)
                                  select new
                                  {
                                      ProductName = k.ProductName,
                                      RewriteUrl = k.Product.RewriteUrl,
                                      ProductId = (int)k.Product.Id,
                                      CategoryId = (from i in dbContext.HccProductXcategories
                                                    where i.ProductId == k.Product.Bvin
                                                    select i.CategoryId).FirstOrDefault()
                                  };
                // Filter by category if selected
                if (comboBoxCategoryFilter.SelectedItem != null)
                {
                    var selectedCategory = (dynamic)comboBoxCategoryFilter.SelectedItem;
                    Guid selectedCategoryId = selectedCategory.CategoryId;
                    allProducts = from j in allProducts
                                  where j.CategoryId.ToString() == selectedCategoryId.ToString()
                                  select j;
                }
                // Create a new list of ProductDTO objects
                var productDTOs = new List<ProductDTO>();
                foreach (var item in allProducts)
                {
                    productDTOs.Add(new ProductDTO
                    {
                        ProductName = item.ProductName,
                        RewriteUrl = item.RewriteUrl,
                        ProductId = item.ProductId
                    });
                }
                listBoxAllProducts.DataSource = productDTOs;
                listBoxAllProducts.DisplayMember = "ProductName";
            }
            //catch (System.Exception)
            //{
            //    MessageBox.Show("Nem sikerült betölteni az adatokat.", "Sikertelen adatbetöltés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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
                                       RewriteUrl = k.RewriteUrl,
                                       ProductId = k.Productid
                                   };
            // Create a new list of ProductDTO objects
            var selectedProductDTOs = new List<ProductDTO>();
            foreach (var item in selectedProducts)
            {
                selectedProductDTOs.Add(new ProductDTO
                {
                    ProductName = item.ProductName,
                    RewriteUrl = item.RewriteUrl,
                    ProductId = item.ProductId
                });
            }
            listBoxSelectedProducts.DataSource = selectedProductDTOs;
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
            var productToDelete = (ProductDTO)listBoxSelectedProducts.SelectedItem;
            if (productToDelete == null)
            {
                MessageBox.Show("Kérlek válassz ki egy terméket!", "Nincs kiválasztott termék", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Dialog to the user
            DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd a terméket?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            var selectedIngredient = (Ingredient)listBoxAllIngredients.SelectedItem;
            var ingredientProductToDelete = dbContext.Ingredientproducts.FirstOrDefault(x => x.Productid == productToDelete.ProductId && x.Ingredientid == selectedIngredient.Ingredientid);
            dbContext.Ingredientproducts.Remove(ingredientProductToDelete);
            try
            {
                dbContext.SaveChanges();
                loadSelectedProducts();

            }
            catch (System.Exception)
            {
                MessageBox.Show("A terméket nem sikerült eltávolítani", "Sikertelen eltávolítás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            listBoxAllIngredients.SelectedIndex = listBoxAllIngredients.Items.Count - 1;

        }

        private void comboBoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProducts();
        }
    }

    public class ProductDTO
    {
        public string ProductName { get; set; }
        public string RewriteUrl { get; set; }
        public int ProductId { get; set; }
    }

}
