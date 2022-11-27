using Domain.Models;
using GenericMyList;
using Service.Service;
using Service.Service.Interface;


MyList<int> nums = new MyList<int>();

int[] arr = { 1, 1, 1, 1, 1 };

nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(4);


//nums.GetInfo();

//Console.WriteLine(nums.Find(x => x %2== 0));

//nums.Clear();



nums.AddRange(arr);
nums.GetInfo();




//foreach (var item in nums.FindAll(x => x % 2 == 0))
//{
//    Console.WriteLine(item);
//}


//MyList<string> names = new MyList<string>();

//string[] arr = { "asdasd","asdasd", "Asdasd", "asd", "ASd","frg" };

//names.Add("Nicat");
//names.Add("Hesen");
//names.Add("Mahmud");
//names.Add("Nihad");


//names.AddRange(arr);

//names.GetInfo();