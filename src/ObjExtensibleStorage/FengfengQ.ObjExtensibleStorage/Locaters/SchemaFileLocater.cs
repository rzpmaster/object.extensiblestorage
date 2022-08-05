using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract;
using FengfengQ.ObjExtensibleStorage.Abstract.Locater;

namespace FengfengQ.ObjExtensibleStorage.Locaters
{
    public class SchemaFileLocater : ISchemaLocater
    {
        public SchemaFileLocater() : this(null)
        {

        }

        public SchemaFileLocater(SchemaLocateOptions? options)
        {
            m_internalSchemaCache = new SchemaCache();
            m_options = options ?? new SchemaLocateOptions();
        }

        protected SchemaCache InternalSchemaCache => m_internalSchemaCache;
        public SchemaLocateOptions Options => m_options;

        public IESSchema LocaterSchema()
        {
            throw new NotImplementedException();
        }

        private void LoadSchemaFromFiles(IESSchema schema, string[] filePaths)
        {
            lock (m_schemaLock)
            {
                if (filePaths == null || !filePaths.Any())
                {
                    return;
                }


            }
        }

        private object m_schemaLock = new object();
        private SchemaCache m_internalSchemaCache;
        private SchemaLocateOptions m_options;

        public class SchemaLocateOptions
        {
            public bool MyProperty { get; set; }
        }

        protected class SchemaCache
        {
            private List<string> m_schemaDirectoriesCached = new List<string>();

            private Dictionary<string, IESSchema> m_exactMatchCache = new Dictionary<string, IESSchema>();

            private Dictionary<string, IESSchema> m_latestCompatibleCache = new Dictionary<string, IESSchema>();

            private Dictionary<string, IESSchema> m_latestCache = new Dictionary<string, IESSchema>();

            public Dictionary<string, IESSchema> this[SchemaMatchType matchType]
            {
                get
                {
                    switch (matchType)
                    {
                        case SchemaMatchType.Exact:
                            return m_exactMatchCache;
                        case SchemaMatchType.LatestCompatible:
                            return m_latestCompatibleCache;
                        case SchemaMatchType.Latest:
                        default:
                            return m_latestCache;
                    }
                }
            }

            public Dictionary<string, IESSchema> GetCacheFromMatchType(SchemaMatchType matchType) => this[matchType];

            public List<string> DirectoriesCached => m_schemaDirectoriesCached;
        }
    }
}
