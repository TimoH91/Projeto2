using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAeronautica.Entities
{
    public class Validacoes
    {
        //Classe para garantir existencia dos objetos
        public static Aeroporto ValidarAeroporto(Aeroporto aeroporto, List<Aeroporto> Aeroportos)
        {
            Aeroporto aeroAValidar = aeroporto;

            Aeroporto valido = null;

            if (aeroAValidar != null)
            {
                foreach (Aeroporto aero in Aeroportos)
                {
                    if (aeroAValidar.Id == aero.Id)
                    {
                        valido = aero;
                    }
                }
            }
            if (valido != null)
            {
                return valido;
            }
            else
            {
                return null;
            }
        }

        public static Aviao ValidarAviao(Aviao aviao, List<Aviao> avioes)
        {
            Aviao aviaoAValidar = aviao;

            Aviao valido = null;

            if (aviaoAValidar != null)
            {
                foreach (Aviao av in avioes)
                {
                    if (aviaoAValidar.Id == av.Id)
                    {
                        valido = av;
                    }
                }
            }

            if (valido != null)
            {
                return valido;
            }
            else
            {
                return null;
            }
        }

        public static BilheteAdulto ValidarBilheteResponsavel(BilheteAdulto bil, List<BilheteAdulto> bilhetes)
        {
            BilheteAdulto bilAValidar = bil;

            BilheteAdulto valido = null;

            if (bil != null)
            {
                foreach (BilheteAdulto bilhete in bilhetes)
                {
                    if (bilAValidar.Id == bilhete.Id)
                    {
                        valido = bilhete;
                    }
                }
            }

            if (valido != null)
            {
                return valido;
            }
            else
            {
                return null;
            }
        }

        public static Bilhete ValidarBilhete(Bilhete bil, List<Bilhete> bilhetes)
        {
            Bilhete bilAValidar = bil;

            Bilhete valido = null;

            if (bil != null)
            {
                foreach (Bilhete bilhete in bilhetes)
                {
                    if (bilAValidar.Id == bilhete.Id)
                    {
                        valido = bilhete;
                    }
                }
            }

            if (valido != null)
            {
                return valido;
            }
            else
            {
                return null;
            }
        }

        public static Voo ValidarVoo(Voo voo, List<Voo> voos)
        {
            Voo vooAValidar = voo;

            Voo valido = null;

            if (vooAValidar != null)
            {
                foreach (Voo v in voos)
                {
                    if (vooAValidar.Id == v.Id)
                    {
                        valido = v;
                    }
                }
            }

            if (valido != null)
            {
                return valido;
            }
            else
            {
                return null;
            }
        }
    }


}

