using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BibliotecaAeronautica.Entities
{
    public class Voo
    {
        public int Id {  get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }

        public int Duracao { get; set; }
        public decimal PrecoAssentoBase { get; set; }

        //[JsonProperty("AviaoId")]
        //public int AviaoId { get; set; }
        public Aviao Aviao { get; set; }

        //[JsonProperty("AeroportoOrigemId")]
        //public int OrigemId { get; set; }
        public Aeroporto Origem { get; set; }

        //[JsonProperty("AeroportoDestinoId")]
        //public int DestinoId { get; set; }      
        public Aeroporto Destino { get; set; }

        //[JsonProperty("AeroportoEscalaId")]
        //public int? EscalaId { get; set; }
        public Aeroporto? Escala { get; set; }

        //public List<Bilhete> BilhetesVendidos { get; set; } = new List<Bilhete>();
        //public List<Assento> Assentos { get; set; } = new List<Assento>();

        //public int TotalLugaresDisponiveis()
        //{
        //    return Aviao.LugaresMetodo() - BilhetesVendidos.Count;
        //}

        public override string ToString()
        {
            if(Escala == null)
            {
                return $"{Id},{Data},{Hora},{Duracao},{PrecoAssentoBase},{Origem.Id},{Destino.Id},";
            }
            else
            {
                return $"{Id},{Data},{Hora},{Duracao},{PrecoAssentoBase},{Origem.Id},{Destino.Id},{Escala.Id}";
            }
  
        }

        public string VooInfo
        {
            get
            {
                return $"{Origem.Nome} á {Destino.Nome}: no dia {Data:dd/MM/yyyy} às {Hora:hh\\:mm}";
            }
            
        }
    }
}
