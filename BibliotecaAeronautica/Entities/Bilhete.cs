using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BibliotecaAeronautica.Entities
{
    public enum Tarifa
    {
        Economica,
        Executiva
    };

    public enum Pagamento
    {
        Pago,
        SemPagamento,
        Devolvido
    };

    public abstract class Bilhete
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public Voo Voo { get; set; }
        public Tarifa Tarifa { get; set; }
        public Assento Assento { get; set; }

        [JsonProperty("Aeroporto1")]
        public Aeroporto AeroportoOrigem { get; set; }

        [JsonProperty("Aeroporto")]
        public Aeroporto AeroportoDestino { get; set; }
        public Pagamento Pagamento { get; set; }
        public decimal Preco { get; set; }

        public abstract string Tipo { get; set; }

        public abstract string Info { get; }

        public Bilhete(
            int id,
            string nome,
            string apelido,
            Voo voo,
            Tarifa tarifa,
            Assento assento,
            Aeroporto aeroportoOrigem,
            Aeroporto aeroportoDestino,
            Pagamento pagamento,
            decimal preco)
        {
            Id = id;
            Nome = nome;
            Apelido = apelido;
            Voo = voo;
            Tarifa = tarifa;
            Assento = assento;
            AeroportoOrigem = aeroportoOrigem;
            AeroportoDestino = aeroportoDestino;
            Pagamento = pagamento;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Id},{Nome},{Apelido},{Assento},{Tarifa},{Tipo}";
        }

        public abstract decimal PrecoMetodo();
    }

}
