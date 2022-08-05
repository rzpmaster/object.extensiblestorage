using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IESValue
    {
        IESInstance Instance { get; }
        IESProperty Property { get; }

        IESValueType Type { get; }
        object Value { get; }

        bool IsPrimitive { get; }
        bool IsStruct { get; }
        bool IsArray { get; }
        bool IsNull { get; }
    }
}
