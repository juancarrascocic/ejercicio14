using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class VentaConverter : IVentaConverter
    {
        public Venta DTOToEntity(VentaDTO ventaDTO)
        {
            Venta resultado = new Venta();
            resultado.id = ventaDTO.id;
            return resultado;
        }

        public VentaDTO EntityToDTO(Venta venta)
        {
            VentaDTO resultado = new VentaDTO();
            resultado.id = venta.id;
            return resultado;
        }
    }
}
