using MySql.Data.MySqlClient;
using System;
namespace automail
{
    class InsertUserInfo
    {
        Boolean boolean;
        public InsertUserInfo(string strUser)
        {
            string strConnection = "Server=localhost;User=pujing;Password=123456;Database=automail;Charset=utf8";
            MySqlConnection mySqlConnection = new MySqlConnection(strConnection);
            string strMySql = "INSERT INTO UserInfo (`strUser`) VALUES ('" + strUser + "')";
            MySqlCommand mySqlCommand = new MySqlCommand(strMySql, mySqlConnection);
            mySqlConnection.Open();
            mySqlCommand.Prepare();
            int intResultSetRow = mySqlCommand.ExecuteNonQuery();
            if (intResultSetRow == 1)
            {
                boolean = true;
                Console.WriteLine("insert sucecess");
            }
            else
            {
                boolean = false;
                Console.WriteLine("insert failed");
            }
            mySqlConnection.Close();
        }
    }
}
