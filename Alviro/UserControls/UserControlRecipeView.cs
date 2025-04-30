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
    public partial class UserControlRecipeView : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();

        public Recipe RecipeDTO = new Recipe();

        public event EventHandler ButtonDeleteClicked;



        public UserControlRecipeView(Recipe RecipeUsed)
        {
            InitializeComponent();

            RecipeDTO = RecipeUsed;



            label1.Text = RecipeDTO.Name;
            labelLastModified.Text = RecipeDTO.Lastmodified.ToString();

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormModifyRecipe formModifyRecipe = new FormModifyRecipe(RecipeDTO);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //dbContext.Remove(RecipeDTO);
            try
            {
                //dbContext.SaveChanges();
                ButtonDeleteClicked?.Invoke(this, EventArgs.Empty);

            }
            catch (System.Exception)
            {
                MessageBox.Show("A termékk törlése nem sikerült", "Sikertelen törlés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
}
