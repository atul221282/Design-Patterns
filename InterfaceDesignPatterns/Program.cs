using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesignPatterns
{
    public class Program
    {
        static void Register()
        {

        }
        
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Configure(c =>
            {
                c.AddRegistry<StandardRegisrty>();
                c.AddRegistry<CatalogRegistry>();
            });

            var catalogs = container.GetInstance<IEnumerable<ICatalog>>();

            var data = container.GetInstance<IDelete>();
            var pp = data.Delete();
            foreach (var catalog in catalogs)
            {
                var ss = catalog.Save();
                var p = string.Join(", ", catalog.SaveVoidable());
                Console.WriteLine($"Savable {ss} ==== Voidable {p} ==== Base  {catalog.Base()}");
            }

            Console.ReadKey();
        }
    }
}
