using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract;

namespace FengfengQ.ObjExtensibleStorage.ESValueTypes
{
    [Serializable]
    public abstract class ESCLRPrimitiveType : ESValueType, IESPrimitiveType, INamed
    {
        protected ESCLRPrimitiveType(string typeName) : base(typeName)
        {
        }

        public abstract Type CLRType { get; }
    }
}
