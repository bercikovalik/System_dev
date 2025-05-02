using Microsoft.Data.SqlClient;
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
    public partial class UserControlCheckConnection : UserControl
    {
        public UserControlCheckConnection()
        {
            InitializeComponent();



        }

        public static async Task<bool> CheckSqlConnectionAsync(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        private async void UserControlCheckConnection_Load(object sender, EventArgs e)
        {
            await CheckConnectionStatusAsync();
        }

        private async Task CheckConnectionStatusAsync()
        {
            label.Text = "Kapcsolat ellenőrzése...";


            //await Task.Delay(50); // UI refresh

            string connectionString = "Data Source=rendfejl10004.northeurope.cloudapp.azure.com,1433;Initial Catalog=Dnn972;User ID=tkvSql;Password=Kifli123;Trust Server Certificate=True";

            bool canConnect = await CheckSqlConnectionAsync(connectionString);

            if (!canConnect)
            {
                label2.Visible = true;

                label.Text = "Kapcsolódás sikertelen!";
                label2.Text =  "Kérem ellenőrizze a kapcsolatot!";
                label.TextAlign = ContentAlignment.MiddleCenter;

                pictureBoxConnecting.Visible = false;
                pictureBoxError.Visible = true;
                buttonCheckConnectionAgain.Visible = true;
                buttonCheckConnectionAgain.Enabled = true;


            }
            else
            {
                
                label.Text = "Kapcsolódás sikeres!";
                label.TextAlign = ContentAlignment.MiddleCenter;
                pictureBoxConnecting.Visible = false;
                pictureBoxOkay.Visible = true;
            }
        }

        private void buttonCheckConnectionAgain_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            pictureBoxError.Visible = false;
            pictureBoxOkay.Visible = false;
            pictureBoxConnecting.Visible = true;
            buttonCheckConnectionAgain.Visible = false;
            buttonCheckConnectionAgain.Enabled = false;
            CheckConnectionStatusAsync();
        }
    }
}
