using System;
using Stock.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock.Forms.Dialogs
{
    
    public partial class ChangeBookerOrd : Form
    {
        ApplicationContext context;
        BookerOrder Order;
        public ChangeBookerOrd(ApplicationContext context, BookerOrder order)
        {
            InitializeComponent();
            this.Order = order;
            this.context = context;
            PhoneNum.Text = order.PhoneNum;
            AllName.Text = order.AllName;
            OrderName.Text = order.OrderName;
            SumOfOrder.Text = order.Sum.ToString();
            NDS.Text = order.NDS.ToString();
            Total.Text = order.Total.ToString();
            if (order.PayStatus) {
                StatusOfPay.Text = StatusOfPay.Items[0].ToString();
            }
            else
            {
                StatusOfPay.Text = StatusOfPay.Items[1].ToString();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (OrderName.Text != null && AllName.Text != null && SumOfOrder.Text != null && PhoneNum.Text != null && StatusOfPay.Text != null && NDS.Text != null && Total.Text != null)
            {
                context.OpenConnection();
                bool Status = false;
                if (StatusOfPay.Text == "Оплачено")
                {
                    Status = true;
                }
                var order = new BookerOrder()
                {
                    OrderName = OrderName.Text,
                    AllName = AllName.Text,
                    Sum = SumOfOrder.Text,
                    PhoneNum = PhoneNum.Text,
                    PayStatus = Status,
                    NDS = NDS.Text,
                    Total = Total.Text,
                    Creating = DateTime.Now
                };
                string command = $"UPDATE [MyStock].[dbo].[BookerOrder] " +
                    $"SET AllName='{order.AllName}', OrderName='{order.OrderName}', Sum='{order.Sum}', PhoneNum='{order.PhoneNum}', PayStatus='{order.PayStatus}', NDS='{order.NDS}', Total='{order.Total}', Creating='{order.Creating}' " +
                    $"WHERE Id ='{Order.Id}' ";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                this.Hide();
                var frm = new BookerForm(context);
                frm.ShowDialog();
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new BookerForm(context);
            frm.ShowDialog();
        }
    }
}
