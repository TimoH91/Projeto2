using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaAeronautica.Entities;

namespace BibliotecaAeronautica.DTOs
{
    public class AssentoResumoDto
    {
        public int Id { get; set; }
        public int VooId { get; set; }
        public int Fila { get; set; }
        public int Coluna { get; set; }
        public bool Ocupado { get; set; }
    }
}
