using Domain.Models;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using Domain.Models.MyListModel<object>;

namespace Service.Service
{
    public class MyListService<T> : IMyListService<T>
    {
        MyListModel<T> model = new MyListModel<T>();

        public void GetInfo()
        {
            foreach (var item in model.array)
            {
                Console.WriteLine(item);
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref model.array , model.array.Length+1);
            model.array[model.array.Length-1] = item;
        }

        public void AddRange(T[] arr)
        {
            foreach (T? item in arr)
            {
                Array.Resize(ref model.array, model.array.Length+1);
                model.array[model.array.Length -1] = item;
            }
        }

        public void Clear()
        {
            Array.Clear(model.array);
        }


        public string? Find(Predicate<T> predicate)
        {
            foreach (T item in model.array)
            {
                if (predicate(item))
                {
                    return $"{item}";
                    break;
                }
               
            }
            return null;
        }

        public T[] FindAll(Predicate<T> predicate)
        {
            T[] arr = new T[0];

            foreach (T item in model.array)
            {
                if (predicate(item))
                {
                    Array.Resize(ref arr,arr.Length+1);
                    arr[arr.Length-1] = item;
                }
            }
            return arr;

        }


    }
}
