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
    public partial class FormSelectProducts : Form
    {
        Dnn972Context dbContext = new Dnn972Context();

        Ingredient selectedIngredient = new Ingredient();
        public FormSelectProducts(Ingredient selectedIngredient)
        {
            this.selectedIngredient = selectedIngredient;
            InitializeComponent();

            loadProducts();


        }

        private void loadProducts()
        {


            var products = from k in dbContext.HccProductTranslations
                           where k.ProductName.Contains(textBoxSearchProduct.Text)
                           select new
                           {
                               ProductName = k.ProductName,
                               ProductId = k.Product.Id,
                               RewriteUrl = k.Product.RewriteUrl,
                               ProductBvin = k.Product.Bvin,
                               //A new linq for category
                               CategoryId = (from c in dbContext.HccProductXcategories
                                             where c.ProductId == k.Product.Bvin
                                             select c.CategoryId).FirstOrDefault(),
                               //CategoryName = (from c in dbContext.HccCategoryTranslations
                               //                where c.CategoryId == (from c2 in dbContext.HccProductXcategories
                               //                                       where c2.ProductId == k.Product.Bvin
                               //                                       select c2.CategoryId).FirstOrDefault()
                           };

            //Clear all usercontrols but left the panel
            panelProductsTable.Controls.Clear();



            List<ProductIngredientDTO> productIngredientDTOs = new List<ProductIngredientDTO>();
            foreach (var product in products)
            {
                ProductIngredientDTO productIngredientDTO = new ProductIngredientDTO();
                productIngredientDTO.ProductName = product.ProductName;

                //ID converted to int
                productIngredientDTO.ProductId = (int)product.ProductId;
                productIngredientDTO.RewriteUrl = product.RewriteUrl;
                productIngredientDTO.ProductBvin = product.ProductBvin;
                productIngredientDTO.CategoryId = product.CategoryId;

                productIngredientDTOs.Add(productIngredientDTO);

                //Load only the first 10 products
                if (productIngredientDTOs.Count == 1000)
                {
                    break;
                }
                UserControlProductXIngredientViewer productXIngredientViewer = new UserControlProductXIngredientViewer(selectedIngredient, productIngredientDTO);
                productXIngredientViewer.Dock = DockStyle.Top;
                panelProductsTable.Controls.Add(productXIngredientViewer);


            }
        }
    }
}
