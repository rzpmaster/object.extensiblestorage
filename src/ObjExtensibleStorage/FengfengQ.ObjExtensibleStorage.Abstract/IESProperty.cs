using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IESProperty : INamed
    {
        IESClass ClassDefinition { get; set; }
        IESValueType Type { get; }
        IESValue Value { get; set; }

        bool IsReadOnly { get; set; }
    }
}
