using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace JogoDaForca
{
    class JogoDaForca
    {
        public Palavra PalavraSorteada { get; private set; }
        public string PalavraEscondida { get; private set; }
        public List<char> LetrasTentadas { get; private set; }
        public int TentativasRestantes { get; private set; }
        private const int MAX_TENTATIVAS = 6;

        public JogoDaForca()
        {
            LetrasTentadas = new List<char>();
            TentativasRestantes = MAX_TENTATIVAS;
            PalavraSorteada = new Palavra(0, "");
            PalavraEscondida = "";
        }

        // Sorteia uma palavra do banco de dados.
        public void SortearPalavra()
        {
            using (var conexao = ConexaoMySQL.ObterConexao())
            {
                // Descobre quantas palavras existem na tabela.
                string sql = "SELECT id, palavra FROM palavras ORDER BY RAND() LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PalavraSorteada = new Palavra(reader.GetInt32("id"), reader.GetString("palavra"));
                    }
                    else
                    {
                        throw new Exception("Nenhuma palavra encontrada no banco de dados!");
                    }
                }
            }
            AtualizarPalavraEscondida();
        }

        // Atualiza a palavra com underlines e letras corretas.
        private void AtualizarPalavraEscondida()
        {
            string escondida = "";
            foreach (char letra in PalavraSorteada.Texto)
            {
                if (LetrasTentadas.Contains(letra))
                {
                    escondida += letra + " ";
                }
                else
                {
                    escondida += "_ ";
                }
            }
            PalavraEscondida = escondida.Trim();
        }

        // Processa a tentativa de uma letra.
        public bool TentarLetra(char letra)
        {
            letra = char.ToUpper(letra);
            if (LetrasTentadas.Contains(letra)) return true; // Já tentou, não penaliza.

            LetrasTentadas.Add(letra);
            bool acertou = PalavraSorteada.Texto.Contains(letra);
            if (!acertou)
            {
                TentativasRestantes--;
            }
            AtualizarPalavraEscondida();
            return acertou;
        }

        public bool VerificarVitoria() => !PalavraEscondida.Contains('_');
        public bool VerificarDerrota() => TentativasRestantes <= 0;
    }
}

