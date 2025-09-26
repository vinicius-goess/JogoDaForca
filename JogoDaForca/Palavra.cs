using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
        public class Palavra
        {
            public int Id { get; set; }
            public string Texto { get; set; } = string.Empty;

            public Palavra(int id, string texto)
            {
                Id = id;
                Texto = texto.ToUpper(); // Garante que a palavra sempre seja maiúscula.
            }
        }

    }

