using Injection_DatabaseConnection;

namespace Injection_Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Hämta data från textfält
            string user = txtUser.Text;
            string pass = txtPass.Text;

            DatabaseConnection databaseConnection = new DatabaseConnection();



            lblQuery.Text = $"SELECT * FROM users WHERE username = @username AND password = @password";

            lblStatus.Text = databaseConnection.Inloggning(user, pass);
        }

    
    }
}
