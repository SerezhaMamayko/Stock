using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock.Forms
{
    public partial class RegisterForm : Form
    {
        private ApplicationContext context;
        public RegisterForm(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null && textBox2.Text != null && textBox4.Text != null && textBox5!= null && BoxWithRoles !=null) {
                context.OpenConnection();
                var pass = textBox5.Text.GetHashCode();
                User user = new User() { Email = textBox3.Text, AllName = textBox2.Text, Role = BoxWithRoles.Text, Login = textBox4.Text
                    , Password = pass };
                string command = $"INSERT INTO [MyStock].[dbo].[User] ( AllName, Role, Email, Login, Password) VALUES ('{user.AllName}','{user.Role}','{user.Email}','{user.Login}','{user.Password}')";
                SqlCommand cmd = new SqlCommand(command, context.sqlConnection);
                cmd.ExecuteNonQuery();
                this.Hide();
                var frm = new StartForm();
                frm.ShowDialog(); 
            }
        }

    }
}
