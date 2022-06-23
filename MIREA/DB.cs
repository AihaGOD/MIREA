using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MIREA
{
    class DB
    {
        //Подключим нашу базу данных к Visual Studio
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-DFJPISN\SQLEXPRESS; Initial Catalog = МИРЭА; User ID = userSQL; Password = 12345");

        //Напишем код для открытия подключения
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //Напишем код для закрытия подключения
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //Напишем код для подключения к бд
        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
