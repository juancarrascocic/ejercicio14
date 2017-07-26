using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public interface IEntradaRepository
    {
        void Create(Entrada entrada);
        Entrada Read(long id);
        IList<Entrada> ReadAll();
        void Update(Entrada entrada);
        void Delete(long id);

    }
}
