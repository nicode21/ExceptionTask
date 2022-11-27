using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IMyListService<T>
    {
        void Add(T item);
        void Clear();
        void AddRange(T[] arr);
        string? Find(Predicate<T> predicate);
        T[] FindAll(Predicate<T> predicate);
    }
}
