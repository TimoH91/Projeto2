using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class BilheteCrianca : Bilhete
    {
        public override string Tipo { get; set; }
        public BilheteCrianca(int id, string nome, string apelido, Voo voo, Tarifa tarifa, Assento assento, Aeroporto origem, Aeroporto destino, Pagamento pagamento, decimal preco)
            : base(id, nome, apelido, voo, tarifa, assento, origem, destino, pagamento, preco)
        {
            Tipo = "Criança";
        }

        public override string Info
        {
            get
            {
                return $"Criança: {Nome} {Apelido} - {Assento.Fila}{Assento.Coluna}";
            }
        }
        //public string InfoPreco
        //{
        //    get
        //    {
        //        return $"Bilhete crianca (2-11 anos) com lugar {Assento.Fila}{Assento.Coluna} no voo {Voo.BilheteInfo} tem o preco {Preco()}.";
        //    }
        //}

        public override decimal PrecoMetodo()
        {
            if (Tarifa == Tarifa.Economica)
            {
                return Voo.PrecoAssentoBase * 0.75m;
            }

            if (Tarifa == Tarifa.Executiva)
            {
                return Voo.PrecoAssentoBase * 1.5m;
            }

            return Voo.PrecoAssentoBase;
        }
    }
}
