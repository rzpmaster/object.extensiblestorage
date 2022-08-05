using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengfengQ.ObjExtensibleStorage.Abstract;
using FengfengQ.ObjExtensibleStorage.Config.Internal;

namespace FengfengQ.ObjExtensibleStorage.ESValueTypes
{
    [Serializable]
    public class ESArrayType : ESValueType, IESArrayType
    {
        private IESValueType m_elementType;

        public ESArrayType(IESValueType elementType) : base(ESTypeStrings.ESArray)
        {
            if (elementType == null)
            {
                throw new ArgumentNullException(nameof(elementType));
            }
            this.m_elementType = elementType;
        }

        public IESValueType ElementType => m_elementType;
    }
}
