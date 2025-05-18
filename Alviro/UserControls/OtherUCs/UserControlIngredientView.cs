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
    public partial class UserControlIngredientView : UserControl
    {
        Dnn972Context dbContext = new Dnn972Context();

        public Ingredient ingredientDTO = new Ingredient();

        //Event for buttonSelect click
        public event EventHandler ButtonSelectClick;

        //Event for buttonModify click
        public event EventHandler ButtonModifyClick;

        //Event for checkBoc click
        public event EventHandler CheckBoxClick;

        public event EventHandler ButtonCancelModifyClick;

        public UserControlIngredientView(Ingredient ingredient)
        {
            InitializeComponent();

            ingredientDTO = ingredient;

            label1.Text = ingredient.Name;


        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

            //FormIngredientModify formIngredientModify = new FormIngredientModify(ingredientDTO);
            //formIngredientModify.ShowDialog();
            //if (formIngredientModify.DialogResult == DialogResult.OK)
            //{
            //    ButtonModifyClick?.Invoke(this, EventArgs.Empty);

            //}

            textBoxModifyName.Text = ingredientDTO.Name;
            textBoxModifyName.Visible = true;
            textBoxModifyName.Enabled = true;

            buttonSave.Visible = true;
            buttonSave.Enabled = true;
            buttonModify.Visible = false;
            buttonModify.Enabled = false;
            buttonDelete.Visible = false;
            buttonDelete.Enabled = false;
            buttonCancelModify.Visible = true;
            buttonCancelModify.Enabled = true;
            buttonSelect.Enabled = false;

            //Focus on the text box
            textBoxModifyName.Focus();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormConfrimDialog confirmDialog = new FormConfrimDialog();
            confirmDialog.Text = "Hozzávaló eltávolítása";
            confirmDialog.labelText.Text = "Biztosan el szeretnéd távolítani a(z) " + ingredientDTO.Name + " hozzávalót?";
            confirmDialog.ShowDialog();
            if (confirmDialog.DialogResult == DialogResult.Yes)
            {
                dbContext.Ingredients.Remove(ingredientDTO);

                try
                {
                    dbContext.SaveChanges();

                }
                catch (System.Exception)
                {
                    MessageBox.Show("A hozzávalót nem sikerült eltávolítani", "Sikertelen eltávolítás", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Parent.Controls.Remove(this);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ButtonSelectClick?.Invoke(this, EventArgs.Empty);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxClick?.Invoke(this, EventArgs.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Modify the ingredient
            ingredientDTO.Name = textBoxModifyName.Text;
            try
            {
                //Check if the ingredient already exists
                var existingIngredient = dbContext.Ingredients.FirstOrDefault(i => i.Name == ingredientDTO.Name);
                if (existingIngredient != null)
                {
                    MessageBox.Show("Ez a hozzávaló már létezik! Kérlek adj meg egy másik nevet.", "Hozzávaló már létezik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dbContext.Ingredients.Update(ingredientDTO);
                dbContext.SaveChanges();
                ButtonModifyClick?.Invoke(this, EventArgs.Empty);
                textBoxModifyName.Visible = false;
                textBoxModifyName.Enabled = false;
                buttonSave.Visible = false;
                buttonSave.Enabled = false;
                buttonModify.Visible = true;
                buttonModify.Enabled = true;
                buttonDelete.Visible = true;
                buttonDelete.Enabled = true;
                buttonCancelModify.Visible = false;
                buttonCancelModify.Enabled = false;
                buttonSelect.Enabled = true;
                label1.Text = ingredientDTO.Name;


            }
            catch (System.Exception)
            {
                MessageBox.Show("A hozzávalót nem sikerült szerkeszteni", "Sikertelen módosítás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void buttonCancelModify_Click(object sender, EventArgs e)
        {
            textBoxModifyName.Visible = false;
            textBoxModifyName.Enabled = false;

            buttonSave.Visible = false;
            buttonSave.Enabled = false;
            buttonModify.Visible = true;
            buttonModify.Enabled = true;
            buttonDelete.Visible = true;
            buttonDelete.Enabled = true;
            buttonCancelModify.Visible = false;
            buttonCancelModify.Enabled = false;
            buttonSelect.Enabled = true;
            ButtonCancelModifyClick?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxModifyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
            }
        }
    }
}
