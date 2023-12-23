using System;
using Stock.Forms.Dialogs;
using Stock.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock.Forms
{
    public partial class ClientForm : Form
    {
        ApplicationContext context;
        public ClientForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void buttonCreateOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new CreateClientOrder(context);
            frm.ShowDialog();
        }

        private void buttonChangeOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [MyStock].[dbo].[ClientOrder] WHERE CONVERT(VARCHAR, Id)='" + textBox1.Text + "'", context.sqlConnection);
            SqlDataReader reader = null;
            var order = new ClientOrder();
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                order.NameOfOrder = reader["NameOfOrder"].ToString();
                order.Id = Convert.ToInt32(reader["Id"].ToString());
                order.PhoneNum = reader["PhoneNum"].ToString();
                order.AllName = reader["AllName"].ToString();
                order.StatusOfPay = Convert.ToBoolean(reader["StatusOfPay"].ToString());
                order.Sum = reader["Sum"].ToString();
                order.LastChanched = Convert.ToDateTime(reader["LastChanched"].ToString());
                order.Creating = Convert.ToDateTime(reader["DateOfOrder"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            var frm = new ChangeClientOrd(context, order);
            frm.ShowDialog();
        }
    }
}
