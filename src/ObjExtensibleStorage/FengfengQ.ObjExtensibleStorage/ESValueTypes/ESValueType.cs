using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract;

namespace FengfengQ.ObjExtensibleStorage.ESValueTypes
{
    [Serializable]
    public abstract class ESValueType : IESValueType, INamed
    {
        private string m_typeName;

        public ESValueType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                throw new ArgumentNullException(nameof(typeName));
            }
            m_typeName = typeName;
        }

        public string Name => m_typeName;
    }
}
