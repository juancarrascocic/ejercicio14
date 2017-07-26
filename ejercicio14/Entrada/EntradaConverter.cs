using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public class EntradaConverter : IEntradaConverter
    {
        public Entrada DTOToEntity(EntradaDTO entradaDTO)
        {
            Entrada entrada = new Entrada();
            entrada.Id = entradaDTO.Id;
            return entrada;
        }

        public EntradaDTO EntityToDTO(Entrada entrada)
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.Id = entrada.Id;
            return entradaDTO;
        }
    }
}
