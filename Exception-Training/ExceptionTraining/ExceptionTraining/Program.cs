
#region HomeTask
//using ExceptionTraining.Controller;

//LibraryController.GetAll();

// var result = LibraryController.GetAllBooksByLibrary(m=>m.LibraryId==1);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name + "-" + item.Author);
//}

//Console.WriteLine(result);
#endregion


//GetNameById(null);

//static void GetNameById(int? id)
//{
//	try
//	{
//		if (id == null)
//		{
//			throw new ArgumentNullException();
//		}
//		Console.WriteLine("Name id :" + id);
//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}
//}

//static void Test()
//{
//	throw new NotImplementedException();
//}



using ExceptionTraining.Controllers;

//AccountController account = new AccountController();

//account.Register();



AccountController account = new AccountController();

account.GetUserById();



#region Try Catch
//bool isParse = true;


//try
//{
//    //string name = null;

//    //Console.WriteLine(name.ToString());

//    //int index = int.Parse(Console.ReadLine());

//    int[] arr = new int[2];

//    arr[0] = 5;

//    string? name = "Qoshqar";

//    if (name is null)
//    {
//        throw new IndexOutOfRangeException("Kefim bele istedi");
//    }

//    isParse = true;

//    Console.WriteLine(arr[0]);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);

//    isParse = false;

//}
//finally
//{
//    if (isParse)
//    {
//        Console.WriteLine("Welcome");
//    }
//    else
//    {
//        Console.WriteLine("Failed");
//    }
//}


//catch (IndexOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message);

//}
//catch (ArgumentNullException ex)
//{

//    Console.WriteLine(ex.Message);

//}
#endregion





