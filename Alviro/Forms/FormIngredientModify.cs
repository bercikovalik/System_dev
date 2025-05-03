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
    public partial class FormIngredientModify : Form
    {
        Dnn972Context dbContext = new Dnn972Context();
        Ingredient ingredientDTO = new Ingredient();
        public FormIngredientModify(Ingredient ingredient)
        {
            InitializeComponent();


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Modify the ingredient
            ingredientDTO.Name = textBox1.Text;
            try
            {
                dbContext.Ingredients.Update(ingredientDTO);
                dbContext.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("A hozzávalót nem sikerült szerkeszteni", "Sikertelen módosítás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
