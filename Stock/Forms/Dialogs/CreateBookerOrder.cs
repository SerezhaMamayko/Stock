using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Stock.Models;

namespace Stock.Forms.Dialogs
{
    public partial class CreateBookerOrder : Form
    {
        public ApplicationContext context;
        public CreateBookerOrder(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (Id.Text!= null && OrderName.Text != null && AllName.Text != null && SumOfOrder.Text != null && PhoneNum.Text != null && StatusOfPay.Text != null && NDS.Text!=null && Total.Text!=null)
            {
                context.OpenConnection();
                int id = 0;
                try
                {
                    id = Int32.Parse(Id.Text);
                }
                catch
                {
                    MessageBox.Show("Error!!! Wrong type of number(may be have not number) in any Box!!! Try again", "Enter anothor type of number",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool Status=false;
                if (StatusOfPay.Text == "Оплачено")
                {
                    Status = true;
                }
                var order = new BookerOrder()
                {
                    Id = id,
                    OrderName = OrderName.Text,
                    AllName = AllName.Text,
                    Sum = SumOfOrder.Text,
                    PhoneNum = PhoneNum.Text,
                    PayStatus = Status,
                    NDS = NDS.Text,
                    Total = Total.Text,
                    Creating = DateTime.Now
                };
                string command = $"SET IDENTITY_INSERT [MyStock].[dbo].[BookerOrder] ON " +
                    $"INSERT INTO [MyStock].[dbo].[BookerOrder] ( AllName, OrderName, Sum, PhoneNum, PayStatus, NDS, Total, Creating, Id) VALUES ('{order.AllName}','{order.OrderName}','{order.Sum}','{order.PhoneNum}','{order.PayStatus}','{order.NDS}','{order.Total}','{order.Creating}','{order.Id}') " +
                    $"SET IDENTITY_INSERT [MyStock].[dbo].[BookerOrder] OFF";
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
