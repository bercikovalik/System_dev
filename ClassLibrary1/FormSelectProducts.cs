using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Alviro.Models;
using Microsoft.EntityFrameworkCore; // Add this namespace for DbSet<>
using Alviro;



namespace ClassLibrary1
{
    [TestClass]
    public class FormSelectProductsTests
    {
        private Mock<Dnn972Context> _mockDbContext;
        private Mock<DbSet<HccProductTranslation>> _mockProductTranslations;
        private Mock<DbSet<HccProductXcategory>> _mockProductXcategories;
        private Mock<DbSet<Ingredientproduct>> _mockIngredientProducts;
        private Ingredient _testIngredient;
        private FormSelectProducts _form;

        [TestInitialize]
        public void Setup()
        {
            // Mock DbContext and DbSets
            _mockDbContext = new Mock<Dnn972Context>();
            _mockProductTranslations = new Mock<DbSet<HccProductTranslation>>();
            _mockProductXcategories = new Mock<DbSet<HccProductXcategory>>();
            _mockIngredientProducts = new Mock<DbSet<Ingredientproduct>>();

            // Setup DbContext behavior
            _mockDbContext.Setup(c => c.HccProductTranslations).Returns(_mockProductTranslations.Object);
            _mockDbContext.Setup(c => c.HccProductXcategories).Returns(_mockProductXcategories.Object);
            _mockDbContext.Setup(c => c.Ingredientproducts).Returns(_mockIngredientProducts.Object);

            // Create a test ingredient
            _testIngredient = new Ingredient { Ingredientid = 1, Name = "Test Ingredient" };

            // Initialize the form
            _form = new FormSelectProducts(_testIngredient)
            {
                dbContext = _mockDbContext.Object
            };
        }
        private Mock<DbSet<T>> CreateMockDbSet<T>(IQueryable<T> data) where T : class
        {
            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            return mockSet;
        }

        [TestMethod]
        public void AddIngredientProduct_ShouldAddProductToDbContext()
        {
            // Arrange
            var product = new ProductIngredientDTO { ProductId = 1 };

            // Act
            _form.addIngredientProduct(product);

            // Assert
            _mockDbContext.Verify(c => c.Ingredientproducts.Add(It.Is<Ingredientproduct>(i => i.Productid == product.ProductId)), Times.Once);
        }

        

        [TestMethod]
        public void LoadCategories_ShouldPopulateComboBox()
        {
            // Arrange
            var categories = new List<HccCategoryTranslation>
            {
                new HccCategoryTranslation { Name = "Category 1", CategoryId = Guid.NewGuid() },
                new HccCategoryTranslation { Name = "Category 2", CategoryId = Guid.NewGuid() }
            }.AsQueryable();

            _mockDbContext.Setup(c => c.HccCategoryTranslations).Returns(MockDbSet(categories).Object);

            // Act
            _form.loadCategories();

            // Assert
            Assert.IsTrue(_form.comboBoxCategorySelector.Items.Count > 0);
        }

        private Mock<DbSet<T>> MockDbSet<T>(IQueryable<T> data) where T : class
        {
            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            return mockSet;
        }
      

        [TestMethod]
        public void AddIngredientProduct_ShouldNotAddDuplicateProduct()
        {
            // Arrange
            var product = new ProductIngredientDTO { ProductId = 1 };
            _form.addIngredientProduct(product);

            // Act
            _form.addIngredientProduct(product);

            // Assert
            _mockDbContext.Verify(c => c.Ingredientproducts.Add(It.IsAny<Ingredientproduct>()), Times.Once);
        }

        [TestMethod]
        public void LoadProducts_ShouldNotThrow_WhenNoProductsExist()
        {
            // Arrange
            var emptyData = Enumerable.Empty<HccProductTranslation>().AsQueryable();
            var mockEmptyDbSet = CreateMockDbSet(emptyData);
            _mockDbContext.Setup(c => c.HccProductTranslations).Returns(mockEmptyDbSet.Object);

            // Act & Assert
            try
            {
                _form.loadProducts();
            }
            catch
            {
                Assert.Fail("loadProducts threw an exception when no products exist.");
            }
        }



        [TestMethod]
        public void LoadCategories_ShouldNotThrow_WhenNoCategoriesExist()
        {
            // Arrange
            _mockDbContext.Setup(c => c.HccCategoryTranslations).Returns(MockDbSet(Enumerable.Empty<HccCategoryTranslation>().AsQueryable()).Object);

            // Act & Assert
            try
            {
                _form.loadCategories();
            }
            catch
            {
                Assert.Fail("PASSED: loadCategories threw an exception when no categories exist.");
            }
        }
    }
}
