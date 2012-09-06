using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using System.Web.Routing;
using Lektion9.Models.Repositories.Abstract;
using Lektion9.Models.Repositories;

namespace Lektion9.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext,
                                                                Type controllerType)
        {
            return controllerType == null
                                        ? null
                                        : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IProductRepository>().ToConstant(new ProductRepository());
        }
    }
}