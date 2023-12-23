using System;
using System.Data.SqlClient;
using Stock.Models;
using System.Windows.Forms;

namespace Stock.Forms
{
    public partial class StoreKeeperForm : Form
    {
        ApplicationContext context;
        public StoreKeeperForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private async void Check_Click(object sender, EventArgs e)
        {
            if (Id.Text != null)
            {
                context.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [MyStock].[dbo].[StoreKeeper] WHERE CONVERT(VARCHAR, Id)='" + Id.Text + "'", context.sqlConnection);
                SqlDataReader reader = null;
                var courier = new StoreKeeper();
                try
                {
                    reader = await cmd.ExecuteReaderAsync();
                    reader.Read();
                    courier.Id = Convert.ToInt32(reader["Id"].ToString());
                    courier.StatusStock = reader["StatusStock"].ToString();
                    courier.StatusBuy = reader["StatusBuy"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null) reader.Close();
                }
                StatusStock.Text = courier.StatusStock;
                StatusBuy.Text = courier.StatusBuy;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Id.Text != null && StatusStock.Text != null && StatusBuy.Text != null)
            {
                context.OpenConnection();
                var courier = new StoreKeeper()
                {
                    Id = Convert.ToInt32(Id.Text),
                    StatusStock = StatusStock.Text,
                    StatusBuy = StatusBuy.Text,
                };
                string command = $"SET IDENTITY_INSERT [MyStock].[dbo].[StoreKeeper] ON " +
                    $"INSERT INTO [MyStock].[dbo].[StoreKeeper] ( StatusStock, Id, StatusBuy) VALUES ('{courier.StatusStock}','{courier.Id}','{courier.StatusBuy}') " +
                    $"SET IDENTITY_INSERT [MyStock].[dbo].[StoreKeeper] OFF";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes","Строка в базе данных создана", MessageBoxButtons.OK);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (Id.Text != null && StatusStock.Text != null && StatusBuy.Text != null)
            {
                context.OpenConnection();
                var courier = new StoreKeeper()
                {
                    Id = Convert.ToInt32(Id.Text),
                    StatusStock = StatusStock.Text,
                    StatusBuy = StatusBuy.Text
                };
                string command = $"UPDATE [MyStock].[dbo].[StoreKeeper] " +
                    $"SET StatusStock='{courier.StatusStock}', StatusBuy='{courier.StatusBuy}' " +
                    $"WHERE Id ='{courier.Id}'";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes", "Строка в базе данных изменена", MessageBoxButtons.OK);
            }
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            StatusStock.Text = "";
            StatusBuy.Text = "";
        }
    }
}
