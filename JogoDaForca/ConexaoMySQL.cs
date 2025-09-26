using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace JogoDaForca
{
    class ConexaoMySQL
    {
        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conexao = new MySqlConnection(Database.ConnectionString);
            conexao.Open();
            return conexao;
        }
    }
}
