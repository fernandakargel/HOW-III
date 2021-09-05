using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pagina_inicio
{
    public class Conexao
    {
        MySqlConnection conecte = new MySqlConnection();

        public Conexao()
        {
            conecte.ConnectionString = "server = localhost; user id = root; Database = lojahow3; SslMode = none";
        }
        public MySqlConnection Conectar()
        {
            if(conecte.State == System.Data.ConnectionState.Closed)
            {
                conecte.Open();
            }
            return conecte;
        }
        public MySqlConnection Desconectar()
        {
            if (conecte.State == System.Data.ConnectionState.Open)
            {
                conecte.Close();
            }
            return conecte;
        }
    }
}
