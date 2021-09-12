using System.Data.SqlClient;


namespace Game
{
    public class DBConnection
    {
        public static SqlConnection connection =
            new SqlConnection("Server=DESKTOP-7V3E6TS\\SQLEXPRESS;Database=1KKGame_DB;Trusted_Connection=True;");
    }
}
