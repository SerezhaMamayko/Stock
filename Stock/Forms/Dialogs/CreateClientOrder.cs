using System;
using System.Data.SqlClient;
using Stock.Models;
using System.Windows.Forms;

namespace Stock.Forms.Dialogs
{
    public partial class CreateClientOrder : Form
    {
        ApplicationContext context;
        public CreateClientOrder(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context; 
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new ClientForm(context);
            frm.ShowDialog();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (OrderName.Text != null && AllName.Text != null && Sum.Text != null && PhoneNum.Text != null && PayStatus.Text != null)
            {
                if (context.sqlConnection.State== System.Data.ConnectionState.Closed) {
                    context.OpenConnection();
                }
                bool Status = false;
                if (PayStatus.Text == "Оплачено")
                {
                    Status = true;
                }
                var order = new ClientOrder()
                {
                    NameOfOrder = OrderName.Text,
                    AllName = AllName.Text,
                    Sum = Sum.Text,
                    PhoneNum = PhoneNum.Text,
                    StatusOfPay = Status,
                    Creating = DateTime.Now,
                    LastChanched = DateTime.Now
                };
                string command = $"INSERT INTO [MyStock].[dbo].[ClientOrder] ( AllName, NameOfOrder, Sum, PhoneNum, StatusOfPay, DateOfOrder, LastChanched) VALUES ('{order.AllName}','{order.NameOfOrder}','{order.Sum}','{order.PhoneNum}','{order.StatusOfPay}','{order.Creating}','{order.LastChanched}')";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                this.Hide();
                var frm = new ClientForm(context);
                frm.ShowDialog();
            }
        }
    }
}