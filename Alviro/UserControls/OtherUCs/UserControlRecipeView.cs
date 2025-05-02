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
        public event EventHandler ButtonModifyClicked;




        public UserControlRecipeView(Recipe RecipeUsed)
        {
            InitializeComponent();

            RecipeDTO = RecipeUsed;

            

            label1.Text = RecipeDTO.Name;
            TimeZoneInfo cetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            DateTime utcTime = RecipeDTO.Lastmodified;
            DateTime cetTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, cetZone);
            labelLastModified.Text = cetTime.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormModifyRecipe formModifyRecipe = new FormModifyRecipe(RecipeDTO);
            if (formModifyRecipe.ShowDialog() == DialogResult.OK)
            {
                // A módosítás sikeres volt, frissítsd a RecipeDTO-t
                RecipeDTO = formModifyRecipe.RecipeDTO;
                label1.Text = RecipeDTO.Name;
                TimeZoneInfo cetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                DateTime utcTime = RecipeDTO.Lastmodified;
                DateTime cetTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, cetZone);
                labelLastModified.Text = cetTime.ToString("yyyy-MM-dd HH:mm:ss");
                ButtonModifyClicked?.Invoke(this, EventArgs.Empty);

            }



        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormConfrimDialog formConfrimDialog = new FormConfrimDialog();
            formConfrimDialog.Text = "Recept törlése";
            formConfrimDialog.labelText.Text = $"Biztosan törölni szeretnéd a(z) {RecipeDTO.Name} receptet?";
            DialogResult dialogResult = formConfrimDialog.ShowDialog(this);
            if (dialogResult == DialogResult.Yes)
            {
                dbContext.Remove(RecipeDTO);
                try
                {
                    dbContext.SaveChanges();
                    ButtonDeleteClicked?.Invoke(this, EventArgs.Empty);

                }
                catch (System.Exception)
                {
                    MessageBox.Show("A termék törlése nem sikerült", "Sikertelen törlés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }


    }
}
