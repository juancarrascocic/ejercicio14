using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class VentaService : IVentaService
    {
        private IVentaRepository ventaRepository;

        public VentaService(IVentaRepository ventaRepository)
        {
            this.ventaRepository = ventaRepository;
        }
        public void Create(Venta venta)
        {
            this.ventaRepository.Create(venta);
        }

        public void Delete(long id)
        {
            this.ventaRepository.Delete(id);
        }

        public Venta Read(long id)
        {
            return this.ventaRepository.Read(id);
        }

        public IList<Venta> ReadAll()
        {
            return this.ventaRepository.ReadAll();
        }

        public void Update(Venta venta)
        {
            this.ventaRepository.Update(venta);
        }
    }
}
