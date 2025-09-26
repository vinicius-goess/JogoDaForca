using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace JogoDaForca
{
    public static class Database
    {
        // ATENÇÃO: Verifique se sua senha do MySQL é "" (vazia).
        // Se você configurou uma senha, coloque-a em "Pwd=".
        public static string ConnectionString =
            "Server=localhost;" +
            "Database=jogodafortuna;" +
            "Uid=root;" +
            "Pwd=;"; // Senha aqui, se houver.
    }
}

