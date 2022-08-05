using System.Collections;
using FengfengQ.ObjExtensibleStorage.Abstract;

namespace FengfengQ.ObjExtensibleStorage
{
    [Serializable]
    public class ESSchema : IESSchema, IEnumerable<IESClass>, INamed
    {
        private string m_name;
        private int m_major;
        private int m_minor;
        private List<IESClass> m_classes = new List<IESClass>();

        public ESSchema(string schemaName, int major, int minor)
        {
            this.m_name = schemaName;
            this.m_major = major;
            this.m_minor = minor;
        }

        public IESClass this[string className] => GetClass(className) ?? throw new KeyNotFoundException($"{className} not found.");

        public int Major => m_major;

        public int Minor => m_minor;

        public int ClassCount => m_classes.Count;

        public string Name => m_name;

        public string FullName => $"{Name}.{Major}.{Minor}";

        public void AddClass(IESClass classToAdd)
        {
            m_classes.Add(classToAdd);
        }

        public void Clear()
        {
            m_classes.Clear();
        }

        public IEnumerator<IESClass> GetEnumerator()
        {
            return m_classes.GetEnumerator();
        }

        public IESSchema[] GetReferencedSchemas()
        {
            throw new NotImplementedException();
        }

        public void RemoveClass(IESClass classToRemove)
        {
            m_classes.Remove(classToRemove);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IESClass? GetClass(string className)
        {
            return m_classes.FirstOrDefault(e => e.Name == className);
        }
    }
}