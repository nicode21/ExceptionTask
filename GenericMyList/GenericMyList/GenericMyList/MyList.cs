using Service.Service;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyList
{
    public class MyList<T>
    {
        MyListService<T> service = new MyListService<T>();

        public void GetInfo()
        {
            service.GetInfo();
        }

        public void Add(T item)
        {
            service.Add(item);
        }

        public void AddRange(T[] arr)
        {
            service.AddRange(arr);
        }

        public void Clear()
        {
            service.Clear();
        }

        public string? Find(Predicate<T> predicate)
        {
            return service.Find(predicate);
        }

        public T[] FindAll(Predicate<T> predicate)
        {
            return service.FindAll(predicate);
        }

    }
}
