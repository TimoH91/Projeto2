using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class Aeroporto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public string InfoGeral
        {
            get
            {
                return $"{Id}: {Nome} ({Cidade})";
            }
        }

        public override string ToString()
        {
            return $"{Id},{Nome},{Cidade}";
        }
    }
}
