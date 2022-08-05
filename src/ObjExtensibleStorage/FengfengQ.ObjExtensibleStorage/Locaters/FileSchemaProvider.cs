using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract.Locater;

namespace FengfengQ.ObjExtensibleStorage.Locaters
{
    public class FileSchemaProvider : ISchemaProvider
    {
        public FileSchemaProvider(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; set; }

        public virtual void LoadFile(TextReader reader)
        {

        }
    }

    public class XmlFileSchemaProvider : FileSchemaProvider
    {
        public XmlFileSchemaProvider(string filePath) : base(filePath)
        {
        }
    }
}
