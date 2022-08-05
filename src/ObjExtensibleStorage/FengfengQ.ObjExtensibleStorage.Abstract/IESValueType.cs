using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IESValueType : INamed
    {

    }

    public interface IESPrimitiveType : IESValueType, INamed
    {
        Type CLRType { get; }
    }

    public interface IESArrayType : IESValueType, INamed
    {
        IESValueType ElementType { get; }
    }

}
