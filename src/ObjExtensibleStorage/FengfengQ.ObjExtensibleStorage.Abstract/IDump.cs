using System;
using System.IO;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IDump
    {
        void Dump(TextWriter output, string linePrefix);
    }

    public interface INamed
    {
        string Name { get; }
    }
}
