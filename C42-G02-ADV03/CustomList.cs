using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV03
{
    using System;
    using System.Collections.Generic;

    public class CustomList<T>
    {
        private List<T> _internalList;

        public CustomList()
        {
            _internalList = new List<T>();
        }

        public void Add(T item)
        {
            _internalList.Add(item);
        }

        public bool Exists(Predicate<T> match)
        {
            foreach (T item in _internalList)
            {
                if (match(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in _internalList)
            {
                if (match(item))
                    return item;
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in _internalList)
            {
                if (match(item))
                    result.Add(item);
            }
            return result;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < _internalList.Count; i++)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public int FindIndex(int startIndex, Predicate<T> match)
        {
            for (int i = startIndex; i < _internalList.Count; i++)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            for (int i = startIndex; i < startIndex + count && i < _internalList.Count; i++)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = _internalList.Count - 1; i >= 0; i--)
            {
                if (match(_internalList[i]))
                    return _internalList[i];
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = _internalList.Count - 1; i >= 0; i--)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            for (int i = startIndex; i >= 0; i--)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            for (int i = startIndex; i > startIndex - count && i >= 0; i--)
            {
                if (match(_internalList[i]))
                    return i;
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (T item in _internalList)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in _internalList)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }
    }
}
