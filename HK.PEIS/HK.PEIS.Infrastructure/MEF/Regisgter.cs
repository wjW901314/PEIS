using System;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace HK.PEIS.Infrastructure.MEF
{
    public class Regisgter
    {
        private static object obj = new object();
        private static CompositionContainer _container;
        public static CompositionContainer regisgter()
        {
            lock (obj)
            {
                try
                {
                    AggregateCatalog aggregateCatalog = new AggregateCatalog();
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    var thisAssembly = new DirectoryCatalog(path, "*.dll");
                    if (thisAssembly.Count() == 0)
                    {
                        path = path + "bin\\";
                        thisAssembly = new DirectoryCatalog(path, "*.dll");
                    }
                    aggregateCatalog.Catalogs.Add(thisAssembly);
                    _container = new CompositionContainer(aggregateCatalog);
                    return _container;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
