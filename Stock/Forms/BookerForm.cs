using System;
using System.Data.SqlClient;
using Stock.Forms.Dialogs;
using Stock.Models;
using System.Windows.Forms;

namespace Stock.Forms
{
    public partial class BookerForm : Form
    {
        ApplicationContext context;
        public BookerForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void buttonChangeOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [MyStock].[dbo].[BookerOrder] WHERE CONVERT(VARCHAR, Id)='" + textBox1.Text + "'", context.sqlConnection);
            SqlDataReader reader = null;
            BookerOrder order = new BookerOrder();
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                order.OrderName = reader["OrderName"].ToString();
                order.Id = Convert.ToInt32(reader["Id"].ToString());
                order.PhoneNum = reader["PhoneNum"].ToString();
                order.AllName = reader["AllName"].ToString();
                order.PayStatus = Convert.ToBoolean(reader["PayStatus"].ToString());
                order.Sum = reader["Sum"].ToString();
                order.NDS = reader["NDS"].ToString();
                order.Total = reader["Total"].ToString();
                order.Creating = Convert.ToDateTime(reader["Creating"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            var frm = new ChangeBookerOrd(context, order);
            frm.ShowDialog();
        }

        private void buttonCreateOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new CreateBookerOrder(context);
            frm.ShowDialog();
        }
    }
}
