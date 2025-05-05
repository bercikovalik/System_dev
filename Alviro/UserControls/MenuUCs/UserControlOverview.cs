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
            string url = "http://rendfejl10004.northeurope.cloudapp.azure.com/";
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült megnyitni a linket: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://rendfejl10004.northeurope.cloudapp.azure.com/DesktopModules/Hotcakes/Core/Admin/Default.aspx";
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült megnyitni a linket: " + ex.Message);

            }
        }
    }
}
