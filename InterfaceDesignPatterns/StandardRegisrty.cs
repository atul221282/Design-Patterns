using StructureMap;
using StructureMap.Graph;

namespace InterfaceDesignPatterns
{
    public class StandardRegisrty:Registry
    {
        public StandardRegisrty()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}