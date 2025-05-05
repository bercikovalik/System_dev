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
    public partial class UserControlOverview : UserControl
    {
        public UserControlOverview()
        {
            InitializeComponent();

            UserControlCheckConnection userControlCheckConnection = new UserControlCheckConnection();
            userControlCheckConnection.Dock = DockStyle.Fill;
            panelCheckConnection.Controls.Add(userControlCheckConnection);
        }

        private void buttonOpenWebShop_Click(object sender, EventArgs e)
        {
            //Megynitja a webshop linkjét
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Megnyitja a hotcakes admint
        }
    }
}
