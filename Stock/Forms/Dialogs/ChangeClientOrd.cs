using System;
using Stock.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock.Forms.Dialogs
{
    public partial class ChangeClientOrd : Form
    {
        ApplicationContext context;
        ClientOrder Order;
        public ChangeClientOrd(ApplicationContext context,ClientOrder order)
        {
            InitializeComponent();
            this.Order=order;
            this.context = context;
            PhoneNum.Text = order.PhoneNum;
            AllName.Text = order.AllName;
            OrderName.Text = order.NameOfOrder;
            Sum.Text = order.Sum.ToString();
            if (order.StatusOfPay)
            {
                PayStatus.Text = PayStatus.Items[0].ToString();
            }
            else
            {
                PayStatus.Text = PayStatus.Items[1].ToString();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (OrderName.Text != null && AllName.Text != null && Sum.Text != null && PhoneNum.Text != null && PayStatus.Text != null)
            {
                context.OpenConnection();
                bool Status =false;
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
                string command = $"DECLARE @B BIT " +
                    $"IF '{PayStatus.Text}'='Оплачено' SET @B=1 ELSE SET @B=0 " +
                    $"UPDATE [MyStock].[dbo].[ClientOrder] " +
                    $"SET AllName='{order.AllName}', NameOfOrder='{order.NameOfOrder}', Sum='{order.Sum}', PhoneNum='{order.PhoneNum}', StatusOfPay='{order.StatusOfPay}', DateOfOrder='{order.Creating}', LastChanched='{order.LastChanched}' " +
                    $"WHERE Id ='{Order.Id}'";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                this.Hide();
                var frm = new ClientForm(context);
                frm.ShowDialog();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new ClientForm(context);
            frm.ShowDialog();
        }
    }
}
