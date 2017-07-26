using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public class EntradaRepository : IEntradaRepository
    {
        private static IList<Entrada> listEntrada = new List<Entrada>();
        public void Create(Entrada entrada)
        {
            listEntrada.Add(entrada);
        }

        public void Delete(long id)
        {
            // listEntrada.Remove()
            // No se hacer este metodo
        }

        public Entrada Read(long id)
        {
            foreach(Entrada entrada in listEntrada)
            {
                if(entrada.Id == id)
                {
                    return entrada;
                }
            }
            return null;
        }

        public IList<Entrada> ReadAll()
        {
            return listEntrada;
        }

        public void Update(Entrada entrada)
        {
            /*
            if (listEntrada.Contains(entrada))
            {
                listEntrada.
            }
            */
            // No se hacer este metodo.
        }
    }
}
