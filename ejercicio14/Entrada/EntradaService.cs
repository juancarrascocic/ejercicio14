using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public class EntradaService : IEntradaService
    {
        private IEntradaRepository entradaRepository;

        public EntradaService(IEntradaRepository entradaRepository)
        {
            this.entradaRepository = entradaRepository;
        }
        public void Create(Entrada entrada)
        {
            entradaRepository.Create(entrada);
        }

        public void Delete(long id)
        {
            entradaRepository.Delete(id);
        }

        public Entrada Read(long id)
        {
            return entradaRepository.Read(id);
        }

        public IList<Entrada> ReadAll()
        {
            return entradaRepository.ReadAll();
        }

        public void Update(Entrada entrada)
        {
            entradaRepository.Update(entrada);
        }
    }
}
