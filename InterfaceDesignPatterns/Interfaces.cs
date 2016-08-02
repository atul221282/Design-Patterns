using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesignPatterns
{

    
    #region "Interfaces"
    public interface IBase
    {
        string Base();
    }
    public interface ISave : IBase
    {
        string Save();
    }
    public interface ISaveVoid : IBase
    {
        IEnumerable<string> SaveVoidable();
    }
    public interface ICatalog : ISave, ISaveVoid, IBase
    {


    }
    public interface IDelete
    {
        bool Delete();
    }
    #endregion

    public class Catalog : ICatalog
    {
        readonly IDelete _delete;
        public Catalog(IDelete delete)
        {
            _delete = delete;
        }

        public string Base()
        {
            return "Catalog base" + _delete.Delete().ToString();
        }

        public string Save()
        {
            return "Save from catalog";
        }

        public IEnumerable<string> SaveVoidable()
        {
            return new string[] { "Save catalog", "Void catalog" };
        }
    }
    public class CatalogStuff : ICatalog
    {

        public string Base()
        {
            return "Catalog base stuff";
        }

        public string Save()
        {
            return "Save from catalog stuff";
        }

        public IEnumerable<string> SaveVoidable()
        {
            return new string[] { "Save catalog stuff", "Void catalog stuff" };
        }
    }
    public class Delete : IDelete
    {
        bool IDelete.Delete()
        {
            return true;
        }
    }

}
