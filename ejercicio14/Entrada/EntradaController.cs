using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14.Entrada
{
    public class EntradaController : IEntradaController
    {
        private IEntradaService entradaService;
        private IEntradaConverter entradaConverter;

        public EntradaController(IEntradaService entradaService, IEntradaConverter entradaConverter)
        {
            this.entradaService = entradaService;
            this.entradaConverter = entradaConverter;
        }
        public void Create(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Create(entrada);
        }

        public void Delete(long id)
        {
            entradaService.Delete(id);
        }

        public EntradaDTO Read(long id)
        {
            Entrada entrada = entradaService.Read(id);
            return entradaConverter.EntityToDTO(entrada);
        }

        public IList<EntradaDTO> ReadAll()
        {
            IList<Entrada> resultado = entradaService.ReadAll();
            IList<EntradaDTO> retorno = new List<EntradaDTO>();
            foreach(Entrada entrada in resultado)
            {
                retorno.Add(entradaConverter.EntityToDTO(entrada));
            }
            return retorno;
        }

        public void Update(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Update(entrada);
        }
    }
}
