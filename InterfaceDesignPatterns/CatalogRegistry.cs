using StructureMap;
using StructureMap.Graph;
using System.Collections.Generic;

namespace InterfaceDesignPatterns
{
    public class CatalogRegistry : Registry
    {
        public CatalogRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.AddAllTypesOf<ICatalog>();
            });
            For<IEnumerable<ICatalog>>().Use(x => x.GetAllInstances<ICatalog>());
        }

    }
}