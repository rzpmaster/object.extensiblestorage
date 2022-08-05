using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract
{
    public interface IESClass : IEnumerable<IESProperty>, INamed
    {
        IESSchema Schema { get; }

        int PropertyCount { get; }
        IESProperty this[string propertyName] { get; }
        void Add(IESProperty property);
        void Remove(string propertyName);
        void Clear();

        bool HasBaseClasses { get; }
        IESClass BaseClass { get; }

        bool IsStruct { get; set; }
        bool IsDomainClass { get; set; }
        bool IsCustomAttribute { get; set; }

        /// <summary>
        /// 当前class是否给定class的子类
        /// </summary>
        /// <param name="testClass"></param>
        /// <returns></returns>
        bool Is(IESClass testClass);

        /// <summary>
        /// 创建当前class的实例
        /// </summary>
        /// <returns></returns>
        IESInstance CreateInstance();
    }
}
