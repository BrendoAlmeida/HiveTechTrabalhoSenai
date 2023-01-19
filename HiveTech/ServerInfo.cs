using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class ServerInfo
    {
        public MySqlConnection conexao { get; set; }

        public void StartServer()
        {
            conexao = new MySqlConnection("Server=localhost;Database=HiveTechDB;Uid=root;Pwd=;");
            conexao.Open();
        }
    }
}
