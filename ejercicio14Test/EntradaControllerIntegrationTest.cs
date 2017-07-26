using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejercicio14.Entrada;
using System.Collections.Generic;

namespace ejercicio14Test
{
    [TestClass]
    public class EntradaControllerIntegrationTest
    {
        private IEntradaController entradaController;
        [TestInitialize]
        public void init()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IEntradaController, EntradaController>();
            container.RegisterType<IEntradaService, EntradaService>();
            container.RegisterType<IEntradaRepository, EntradaRepository>();
            container.RegisterType<IEntradaConverter, EntradaConverter>();

            entradaController = container.Resolve<IEntradaController>();


        }
        [TestMethod]
        public void CreateTest()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }
        [TestMethod]
        public void ReadTest()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
            long id = 0;
            entradaController.Read(id);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            IList<EntradaDTO> listEntradaDTO;
            listEntradaDTO = entradaController.ReadAll();
        }
        [TestMethod]
        public void DeleteTest()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
            long id = 0;
            entradaController.Delete(id);
        }
        [TestMethod]
        public void UpdateTest()
        {
            EntradaDTO entradaDTO1 = new EntradaDTO();
            EntradaDTO entradaDTO2 = new EntradaDTO();
            entradaDTO2.Id = 1;
            entradaController.Create(entradaDTO1);
            entradaController.Update(entradaDTO2);

        }
    }
}
