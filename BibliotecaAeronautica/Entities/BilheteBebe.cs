using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class BilheteBebe : Bilhete
    {
        public int ResponsavelId { get; set; }
        
        //public BilheteAdulto Responsavel;

        public override string Tipo { get; set; }

        public BilheteBebe(int id, string nome, string apelido, Voo voo, Tarifa tarifa, Assento assento, Aeroporto origem, Aeroporto destino, Pagamento pagamento, decimal preco, int responsavelId)
            : base(id, nome, apelido, voo, tarifa, assento, origem, destino, pagamento, preco)
        {
            //Responsavel = responsavel;

            ResponsavelId = responsavelId;

            Tipo = "Bebe";
        }
        public override string Info
        {
            get
            {             
                return $"Bebe: {Nome} {Apelido}";
            }
        }
        public override string ToString()
        {
            return "";
            //return $"{Id},{Nome},{Apelido},{Responsavel.Assento.Fila}{Responsavel.Assento.Coluna},{Tarifa},{Tipo},{Responsavel.Id}";
        }

        public override decimal PrecoMetodo()
        {
            if (Tarifa == Tarifa.Economica)
            {
                return 0;
            }

            if (Tarifa == Tarifa.Executiva)
            {
                return Voo.PrecoAssentoBase * 0.10m;
            }

            return Voo.PrecoAssentoBase;
        }

    }
}
