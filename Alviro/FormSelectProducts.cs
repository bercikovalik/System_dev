using Alviro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alviro
{
    public partial class FormSelectProducts : Form
    {
        Dnn972Context dbContext = new Dnn972Context();

        Ingredient SelectedIngredient = new Ingredient();

        int SelectedChunkIndex = 0;

        List<ProductIngredientDTO> addedProduct = new List<ProductIngredientDTO>();

        List<ProductIngredientDTO> removedProducts = new List<ProductIngredientDTO>();

        bool isSaved = true;
        public FormSelectProducts(Ingredient selectedIngredient)
        {
            this.SelectedIngredient = selectedIngredient;
            //labelIngredientName.Text = SelectedIngredient.Name;
            //comboBoxSortProducts.Items.AddRange(new string[] {
            //    "Alapértelmezett",
            //    "Név (Z-A)",
            //    "Név (A-Z)"
            //});
            InitializeComponent();


            loadCategories();
            loadProducts();


        }

        private void loadProducts()
        {

            panelProductsTable.Controls.Clear();

            var products = from k in dbContext.HccProductTranslations
                           where k.ProductName.Contains(textBoxSearchProduct.Text)
                           select new
                           {
                               ProductName = k.ProductName,
                               ProductId = k.Product.Id,
                               RewriteUrl = k.Product.RewriteUrl,
                               ProductBvin = k.Product.Bvin,
                               CategoryIds = (from c in dbContext.HccProductXcategories
                                             where c.ProductId == k.Product.Bvin
                                             select c.CategoryId).ToList(),
                               //CategoryName = (from c in dbContext.HccCategoryTranslations
                               //                where c.CategoryId == (from c2 in dbContext.HccProductXcategories
                               //                                       where c2.ProductId == k.Product.Bvin
                               //                                       select c2.CategoryId).FirstOrDefault()
                           };
            if (products.Count() == 0)
            {
                UserControlNoResult userControlNoResult = new UserControlNoResult();
                userControlNoResult.Dock = DockStyle.Top;
                panelProductsTable.Controls.Add(userControlNoResult);
                return;
            }
            
            
                Category selectedCategory = comboBoxCategorySelector.SelectedValue as Category;
                Guid selectedCategoryId = selectedCategory.CategoryId;



                var productsInCategory = products
                                        .AsEnumerable()
                                        .Where(p => p.CategoryIds.Contains(selectedCategoryId)).ToList();
                
                

            
            
            List<ProductIngredientDTO> productIngredientDTOs = new List<ProductIngredientDTO>();
            
            foreach (var product in productsInCategory)
            {
                ProductIngredientDTO productIngredientDTO = new ProductIngredientDTO();
                productIngredientDTO.ProductName = product.ProductName;

                //Id-t konvertálni kell long-ról
                productIngredientDTO.ProductId = (int)product.ProductId;
                productIngredientDTO.RewriteUrl = product.RewriteUrl;
                productIngredientDTO.ProductBvin = product.ProductBvin;
                productIngredientDTO.CategoryIds = product.CategoryIds;

                productIngredientDTOs.Add(productIngredientDTO);


            }


            List<List<ProductIngredientDTO>> chunkedLists = new List<List<ProductIngredientDTO>>();

            //Túl sok termék, ezért oldalas megjelenítés szükséges
            //A chunkSize alapján felosztja a termékeket és annyit jelenít meg egy oldalon
            int chunkSize = 50;
            for (int i = 0; i < productIngredientDTOs.Count; i += chunkSize)
            {
                var chunk = productIngredientDTOs
                    .Skip(i)
                    .Take(chunkSize)
                    .ToList();
                chunkedLists.Add(chunk);
            }

            int selectedChunkIndex = SelectedChunkIndex;
            if (selectedChunkIndex >= chunkedLists.Count)
            {
                selectedChunkIndex = chunkedLists.Count - 1;
            }
            if (selectedChunkIndex < 0)
            {
                selectedChunkIndex = 0;
            }

            switch (comboBoxSortProducts.SelectedIndex)
            {
                case -1:

                    break;
                case 0:
                    break;
                case 1:
                    chunkedLists[selectedChunkIndex] = chunkedLists[selectedChunkIndex].OrderByDescending(i => (i.ProductName ?? "").ToLower()).ToList();
                    break;
                case 2:
                    chunkedLists[selectedChunkIndex] = chunkedLists[selectedChunkIndex].OrderBy(i => (i.ProductName ?? "").ToLower()).ToList();

                    break;

            }


            // Termék UC-k megjelenítése
            foreach (var product in chunkedLists[selectedChunkIndex])
            {
                UserControlProductXIngredientViewer productXIngredientViewer = new UserControlProductXIngredientViewer(SelectedIngredient, product);
                productXIngredientViewer.Dock = DockStyle.Top;

                //Bejelöli a checboxot ahol van ingredientProduct
                var selectedProducts = from i in dbContext.Ingredientproducts
                                       where i.Ingredientid == SelectedIngredient.Ingredientid && i.Productid == product.ProductId
                                       select i;
                if (selectedProducts.Count() > 0)
                {
                    productXIngredientViewer.checkBox1.Checked = true;
                }


                //Figyeli a checkbox checked eseményt
                productXIngredientViewer.CheckBoxCheckedChanged += (s, e) =>
                {
                    if (e)
                    {
                        // Hozzáadja a kiválasztott termékekhez
                        addedProduct.Add(product);
                        isSaved = false;
                    }
                    else
                    {
                        // Hozzáadja az eltávolított termékekhez
                        removedProducts.Add(product);
                        isSaved = false;

                    }
                };

                panelProductsTable.Controls.Add(productXIngredientViewer);
            }



        }

        private void addIngredientProduct(ProductIngredientDTO product)
        {
            Ingredientproduct ingredientproductToAdd = new Ingredientproduct();
            ingredientproductToAdd.Ingredientid = SelectedIngredient.Ingredientid;
            ingredientproductToAdd.Productid = product.ProductId;
            dbContext.Ingredientproducts.Add(ingredientproductToAdd);
        }

        private void removeIngredientProduct(ProductIngredientDTO product)
        {
            removedProducts.Add(product);
            int ingredientId = SelectedIngredient.Ingredientid;
            int productId = product.ProductId;
            //Kikeressük az adott ingredientProductot
            var ingredientProductToRemove = (from k in dbContext.Ingredientproducts
                                             where k.Ingredientid == ingredientId && k.Productid == productId
                                             select k).FirstOrDefault();

            dbContext.Ingredientproducts.Remove(ingredientProductToRemove);
        }

        private void loadCategories()
        {
            //Kategóriák betöltése a comboboxba
            var categories = from k in dbContext.HccCategoryTranslations
                             select new
                             {
                                 CategoryName = k.Name,
                                 CategoryId = k.CategoryId,
                             };
            List<Category> categoriesList = new List<Category>();
            foreach (var category in categories)
            {
                Category categoryL = new Category();
                categoryL.CategoryId = category.CategoryId;
                categoryL.CategoryName = category.CategoryName;
                categoriesList.Add(categoryL);
            }
            comboBoxCategorySelector.DataSource = categoriesList.ToList();
            comboBoxCategorySelector.DisplayMember = "CategoryName";
        }

        private void buttonPreviousChunk_Click(object sender, EventArgs e)
        {
            //Visszalép az előző oldalra
            SelectedChunkIndex--;
            labelPage.Text = (SelectedChunkIndex + 1).ToString();
            loadProducts();

        }

        private void buttonNextChunk_Click(object sender, EventArgs e)
        {
            //Következő oldalra lép
            SelectedChunkIndex++;
            labelPage.Text = (SelectedChunkIndex + 1).ToString();
            loadProducts();

        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {

            loadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mégse gomb megnyomására megerősítő ablak
            FormConfrimDialog formConfrimDialog = new FormConfrimDialog();
            formConfrimDialog.labelText.Text = "Az elvégzett módosítások nem lesznek elmentve, biztosan ki akarsz képni?";
            formConfrimDialog.Text = "Kilépés megerősítése";
            if (formConfrimDialog.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //A hozzáadott termékek tényleges hozzáadása
            foreach (var product in addedProduct)
            {
                addIngredientProduct(product);
            }

            //Az eltávolított termékek tényleges eltávolítása
            foreach (var product in removedProducts)
            {
                removeIngredientProduct(product);
            }

            dbContext.SaveChanges();
            isSaved = false;


        }

        private void buttonRefreshProducts_Click(object sender, EventArgs e)
        {
            loadProducts();

        }

        private void comboBoxSortProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void comboBoxCategorySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProducts();
        }

        private class Category()
        {
            public  string CategoryName { get; set; }
            public Guid CategoryId { get; set; }


        }
    }
}
