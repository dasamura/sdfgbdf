using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LAB_WORK_3._2_VADIM_PETRENKO
{
    internal class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "комерційна_ветеринарна_лікарня";
            string username = "monty";
            string password = "some_pass";

            return DB2.GetDBConnection(host, port, database, username, password);
        }
    }
}
