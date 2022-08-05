using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract.Locater;

namespace FengfengQ.ObjExtensibleStorage.Locaters
{
    public class SearchPathSchemaFileLocater : SchemaFileLocater, ISchemaLocater
    {
        public SearchPathSchemaFileLocater(string searchPath)
        {
            m_searchPath = searchPath;
        }

        public string SearchPath { get => m_searchPath; set => m_searchPath = value; }

        private string m_searchPath;

    }
}
