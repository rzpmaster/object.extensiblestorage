using System;
using System.Collections.Generic;
using System.Text;

namespace FengfengQ.ObjExtensibleStorage.Abstract.Locater
{
    public enum SchemaMatchType
    {
        /// <summary>
        /// 精确匹配 majar minor
        /// </summary>
        Exact,

        /// <summary>
        /// 匹配最后一个 majar
        /// </summary>
        LatestCompatible,

        /// <summary>
        /// 匹配最后一个版本
        /// </summary>
        Latest
    }
}
