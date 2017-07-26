using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public interface IEntradaService
    {
        void Create(Entrada entrada);
        Entrada Read(long id);
        void Update(Entrada entrada);
        IList<Entrada> ReadAll();
        void Delete(long id);
    }
}
