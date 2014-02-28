using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Units : IList<Unit>
    {
        [XmlElement("img")]
        public Img Image { get; set; }

        [XmlElement("unit")]
        public List<Unit> UnitList { get; set; }

        public IEnumerator<Unit> GetEnumerator()
        {
            return UnitList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Unit item)
        {
            UnitList.Add(item);
        }

        public void Clear()
        {
            UnitList.Clear();
        }

        public bool Contains(Unit item)
        {
            return UnitList.Contains(item);
        }

        public void CopyTo(Unit[] array, int arrayIndex)
        {
            UnitList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Unit item)
        {
            return UnitList.Remove(item);
        }

        public int Count { get { return UnitList.Count; } }
        public bool IsReadOnly { get { return false; } }
        public int IndexOf(Unit item)
        {
            return UnitList.IndexOf(item);
        }

        public void Insert(int index, Unit item)
        {
            UnitList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            UnitList.RemoveAt(index);
        }

        public Unit this[int index]
        {
            get { return UnitList[index]; }
            set { UnitList[index] = value; }
        }
    }
}