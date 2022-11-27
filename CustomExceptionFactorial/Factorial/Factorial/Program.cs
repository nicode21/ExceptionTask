using static Factorial.FactorialCalculator;



try
{
    //int num = -5;

    Console.WriteLine(GetFactorial(-5));
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

