using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengfengQ.ObjExtensibleStorage.ESValueTypes.Internal
{
    [Serializable]
    internal class ESCLRPrimitiveType<T> : ESCLRPrimitiveType
    {
        private static ESCLRPrimitiveType<T> s_instance = new ESCLRPrimitiveType<T>();
        protected ESCLRPrimitiveType() : base(nameof(T)) { }
        public static ESCLRPrimitiveType<T> Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new ESCLRPrimitiveType<T>();
                }
                return s_instance;
            }
        }

        public override Type CLRType => typeof(T);
    }

    [Serializable]
    internal class ESBinaryType : ESCLRPrimitiveType<byte[]> { }

    [Serializable]
    internal class ESBooleanType : ESCLRPrimitiveType<bool> { }

    [Serializable]
    internal class ESDateTimeType : ESCLRPrimitiveType<DateTime> { }

    [Serializable]
    internal class ESDoubleType : ESCLRPrimitiveType<double> { }

    [Serializable]
    internal class ESStringType : ESCLRPrimitiveType<string> { }
}
