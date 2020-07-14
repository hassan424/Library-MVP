using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LipraryMVP.Logic.Services
{
    static class DBHelper
    {
        public static SqlCommand command;
        // this method to git connection String from SQL Server
        private static SqlConnection getconnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;
            return new SqlConnection (builder.ConnectionString);
        }

        public static bool excuteData(string spName ,Action methoud)
        {
            using (SqlConnection connection = getconnectionString())
            {
                try
                {
                    command = new SqlCommand(spName ,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    //تنفيد دالة لعمل البرميترات وتنفيده عبر الكوماند
                    //ممكن في طريقة ثانية انه اعمل مالدالة متغير من نوع اريه من البرميترات واعمل لوب ينفد البرميترات كل واحد لحاله
                    methoud.Invoke();

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                    
                }

            }
            return false;
        }
    }
}
