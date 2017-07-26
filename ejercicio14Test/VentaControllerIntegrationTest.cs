using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejercicio14;

namespace ejercicio14Test
{
    [TestClass]
    public class VentaControllerIntegrationTest
    {
        private IVentaController ventaController;
        [TestInitialize]
        public void Init()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IVentaRepository, VentaRepository>();
            container.RegisterType<IVentaService, VentaService>();
            container.RegisterType<IVentaConverter, VentaConverter>();

            container.RegisterType<IVentaController, VentaController>();

            ventaController = container.Resolve<IVentaController>();


        }
        // [Ignore] Podemos poner esto para que ignore el test cuando damos a Run All.
        [Ignore]
        [TestMethod]
        public void CreateTest()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);
        }
    }
}
