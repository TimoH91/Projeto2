namespace BibliotecaAeronautica.Entities
{
    public enum Estado
    {
        ativo,
        inativo
    };

    public class Aviao
    {
      
        public int Id {  get; set; }
        public string Nome { get; set; }

        public string Marca { get; set; }

        public int Filas { get; set; }

        public int AssentosPorFila { get; set; }

        public Estado Estado { get; set; }

        
        //public List<Voo> Voos { get; set; } = new List<Voo>();
        
        public string Info
        {
            get
            {
                return $"{Id}: {Marca} {Nome} - {Estado}";
            }
        }


        public override string ToString()
        {
            string vooIds = "";

            //foreach (Voo voo in Voos)
            //{
            //    vooIds += $"{voo.Id}";
            //}
            return $"{Id},{Nome},{Marca},{Filas},{AssentosPorFila},{Estado}";
        }

        public int LugaresMetodo()
        {
            return Filas * AssentosPorFila;
        }
    }
}
