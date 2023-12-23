using System;
using System.Data.SqlClient;
using Stock.Models;
using System.Windows.Forms;

namespace Stock.Forms
{
    public partial class CourierForm : Form
    {
        ApplicationContext context;
        public CourierForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private async void Check_Click(object sender, EventArgs e)
        {
            if (Id.Text != null)
            {
                context.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [MyStock].[dbo].[Courier] WHERE CONVERT(VARCHAR, Id)='" + Id.Text + "'", context.sqlConnection);
                SqlDataReader reader = null;
                var courier = new Courier();
                try
                {
                    reader = await cmd.ExecuteReaderAsync();
                    reader.Read();
                    courier.Id = Convert.ToInt32(reader["Id"].ToString());
                    courier.Status = reader["Status"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null) reader.Close();
                }
                if (courier.Status == Status.Items[0].ToString()) {
                    Status.Text = Status.Items[0].ToString();
                }
                else
                {
                    if (courier.Status == Status.Items[1].ToString())
                    {
                        Status.Text = Status.Items[1].ToString();
                    }
                    else
                    {
                        if (courier.Status == Status.Items[2].ToString())
                        {
                            Status.Text = Status.Items[2].ToString();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id.Text != null && Status.Text != null)
            {
                context.OpenConnection();
                var courier = new Courier()
                {
                    Id = Convert.ToInt32(Id.Text),
                    Status = Status.Text
                };
                string command = $"INSERT INTO [MyStock].[dbo].[Courier] ( Status, Id) VALUES ('{courier.Status}','{courier.Id}') ";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes", "Строка в базе данных создана", MessageBoxButtons.OK);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (Id.Text != null && Status.Text != null)
            {
                context.OpenConnection();
                var courier = new Courier()
                {
                    Id = Convert.ToInt32(Id.Text),
                    Status = Status.Text
                };
                string command = $"UPDATE [MyStock].[dbo].[Courier] " +
                    $"SET Status='{courier.Status}' " +
                    $"WHERE Id ='{courier.Id}'";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes", "Строка в базе данных изменена", MessageBoxButtons.OK);
            }
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            Status.Text = "";
        }
    }
}
