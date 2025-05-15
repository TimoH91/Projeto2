using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.DTOs
{
    public class BilheteResumoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int VooId { get; set; }
        public int Tarifa { get; set; }
        public int AssentoId { get; set; }
        public string Tipo { get; set; }
        public int? ResponsavelId { get; set; }
        public double Preco { get; set; }
        public int AeroportoOrigemId { get; set; }
        public int AeroportoDestinoId { get; set; }
        public int Pagamento { get; set; }

        public string Info
        {
            get
            {
                return $"{Nome} {Apelido} ({Tarifa}) {Tipo}";
            }

        }
    }
}
