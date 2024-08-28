namespace Injection_DatabaseConnection
{
    public class DatabaseConnection
    {


        public string Inloggning(string user, string pass)
        {


            string username = "test", password = "test";

            if (password == pass && username == user)
            {
                return "Du har loggat in";
            }
            else
            {
                return "Du är utloggad";
            }

        }
      
    }
}
