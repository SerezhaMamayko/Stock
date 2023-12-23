using System;
using Stock.Forms;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Data.SqlClient;

namespace Stock
{
    public partial class StartForm: Form
    {
        private Connection constr;
        private ApplicationContext context;
        public StartForm()
        {
            InitializeComponent();
            string path = "D:/project/Stock/Stock/appsettings.json";
            string jsonString = File.ReadAllText(path);
            constr = JsonSerializer.Deserialize<Connection>(jsonString);
            SqlConnection conn = new SqlConnection(constr.DefaultConnection);
            this.context =new ApplicationContext(conn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginText.Text != null && textBox2.Text != null) {
                context.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [MyStock].[dbo].[User] WHERE CONVERT(VARCHAR, Login)='" + LoginText.Text + "'", context.sqlConnection);
                SqlDataReader reader = null;
                User user = new User();
                try
                {
                    reader = await cmd.ExecuteReaderAsync();
                    reader.Read();
                    user.Id = Convert.ToInt32(reader["Id"].ToString());
                    user.AllName = reader["AllName"].ToString();
                    user.Role = reader["Role"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Login = reader["Login"].ToString();
                    user.Password = Convert.ToInt32(reader["Password"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null) reader.Close();
                }
                if (LoginText.Text==user.Login && user.Password==textBox2.Text.GetHashCode())
                {
                    this.Hide();
                    if (user.Role== "Booker")
                    {
                        BookerForm frm = new BookerForm(context);
                        frm.Show();
                    }
                    if (user.Role =="ClientManager")
                    {
                        ClientForm frm = new ClientForm(context);
                        frm.Show();
                    }
                    if (user.Role =="Courier")
                    {
                        CourierForm frm = new CourierForm(context);
                        frm.Show();
                    }
                    if (user.Role =="StoreKeeper")
                    {
                        StoreKeeperForm frm = new StoreKeeperForm(context);
                        frm.Show();
                    }
                } 
            }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm frm = new RegisterForm(context);
            frm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
