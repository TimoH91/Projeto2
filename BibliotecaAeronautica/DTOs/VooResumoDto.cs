using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.DTOs
{
    public class VooResumoDto
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }


        public string VooInfo
        {
            get
            {
                return $"{Origem} á {Destino}: no dia {Data:dd/MM/yyyy} às {Hora:hh\\:mm}";
            }

        }

    }
}
