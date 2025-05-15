using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class Assento
    {
        public int Id { get; set; } 
        //public int VooId { get; set; }  
        public Voo Voo { get; set; } 
        public int Fila { get; set; } 
        public int Coluna { get; set; }  
        public bool Ocupado { get; set; }

        //public List<Bilhete> Bilhetes { get; set; } = new List<Bilhete>();

    }
}
