using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class VentaController : IVentaController
    {
        private IVentaService ventaService;
        private IVentaConverter ventaConverter;

        public VentaController(IVentaService ventaService, IVentaConverter ventaConverter)
        {
            this.ventaConverter = ventaConverter;
            this.ventaService = ventaService;

        }
        public void Create(VentaDTO ventaDTO)
        {
            Venta venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Create(venta);
            
        }

        public void Delete(long id)
        {
            ventaService.Delete(id);
            
        }

        public VentaDTO Read(long id)
        {
            Venta venta = ventaService.Read(id);
            return ventaConverter.EntityToDTO(venta);
        }

        public IList<VentaDTO> ReadAll()
        {
            IList<VentaDTO> listaResultado = new List<VentaDTO>();

            IList<Venta> listaVenta = ventaService.ReadAll();

            foreach(Venta v in listaVenta)
            {
                listaResultado.Add(ventaConverter.EntityToDTO(v));
            }
            return listaResultado;
        }

        public void Update(VentaDTO ventaDTO)
        {
            Venta venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Update(venta);
        }
    }
}
