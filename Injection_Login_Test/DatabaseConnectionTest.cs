using Injection_DatabaseConnection;

namespace Injection_Login_Test
{
    public class DatabaseConnectionTest
    {
        [Theory]
        [InlineData("test", "test", "Du har loggat in")]
        [InlineData("test", "test1", "Du är utloggad")]
        public void Login_Test(string user, string pass, string expected)
        {
            DatabaseConnection connection = new DatabaseConnection();

            var result = connection.Inloggning(user, pass);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("test", "test", "Du har loggat in")]
        [InlineData("test); -- ", "", "Du är utloggad")]
        public void Injection_Test(string user, string pass, string expected)
        {
            DatabaseConnection connection = new DatabaseConnection();

            var result = connection.Inloggning(user, pass);

            Assert.Equal(expected, result);
        }

    }
}