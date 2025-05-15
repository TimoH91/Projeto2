using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class BilheteAdulto : Bilhete
    {
        public override string Tipo { get; set; }

        public BilheteAdulto(int id, string nome, string apelido, Voo voo, Tarifa tarifa, Assento assento, Aeroporto origem, Aeroporto destino,Pagamento pagamento, decimal preco) 
            : base(id, nome, apelido, voo, tarifa, assento, origem, destino, pagamento, preco) 
        {
            Tipo = "Adulto";
        }

        public override string Info
        {
            get
            {
                return $"Adulto: {Nome} {Apelido} - {Assento.Fila}{Assento.Coluna}";
            }
        }

        //public string InfoPreco
        //{
        //    //get
        //    {
        //        //return $"Adulto: {Nome} {Apelido} {Assento.Fila}{Assento.Coluna} no voo {Voo.BilheteInfo} tem o preco {Preco()}.";
        //    }
        //}

        public override decimal PrecoMetodo()
        {
                if (Tarifa == Tarifa.Economica)
                {
                    return Voo.PrecoAssentoBase;
                }

                if (Tarifa == Tarifa.Executiva)
                {
                    return Voo.PrecoAssentoBase * 2;
                }

            return Voo.PrecoAssentoBase;
        }      
    }
}
