using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IESSchema : IEnumerable<IESClass>, INamed
    {
        /// <summary>
        /// "{Name}.{Major}.{Minor}"
        /// </summary>
        string FullName { get; }
        int Major { get; }
        int Minor { get; }

        int ClassCount { get; }
        IESClass this[string className] { get; }
        void AddClass(IESClass classToAdd);
        void RemoveClass(IESClass classToRemove);
        void Clear();

        /// <summary>
        /// 获取ReferencedSchemas(类似程序集引用，获取引用的其他Schemas)
        /// </summary>
        /// <returns></returns>
        IESSchema[] GetReferencedSchemas();
    }
}
