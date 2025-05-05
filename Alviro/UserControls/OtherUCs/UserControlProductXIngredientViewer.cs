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
    public partial class UserControlProductXIngredientViewer : UserControl
    {
        //Esemény a checkboxnak
        public event EventHandler<bool> CheckBoxCheckedChanged;
        public UserControlProductXIngredientViewer(Ingredient selectedIngredient, ProductIngredientDTO productIngredientDTO)
        {
            InitializeComponent();

            //Termék nevének kirakása
            label1.Text = productIngredientDTO.ProductName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Esemény ha a checboxot jelölik
            CheckBoxCheckedChanged?.Invoke(this, checkBox1.Checked);

        }
    }
}
