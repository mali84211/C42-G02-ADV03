namespace C42_G02_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            // List<int> Numbers = Enumerable.Range(1,100).ToList();
            //List<int>Oddnumbers= Helper.GetOddnumbers(Numbers);

            // Console.WriteLine("ODD Numbers");
            // foreach (int number in Oddnumbers)
            // {
            //     Console.WriteLine($"{number}");
            // }

            // List<int> Evennumbers = Helper.GetEvennumbers(Numbers);

            // Console.WriteLine("\nEven Numbers");
            // foreach (int number in Evennumbers)
            // {
            //     Console.WriteLine($"{number}");
            // }

            // List<int> GetNumbersDivisibleBy7 = Helper.GetNumbersDivisibleBy7(Numbers);

            // Console.WriteLine("\nGetNumbersDivisibleBy7");
            // foreach (int number in GetNumbersDivisibleBy7)
            // {
            //     Console.WriteLine($"{number}");
            // }
            #endregion

            #region V2
            //predicate<int> predicate;
            //predicate = testingFunction.Test01;
            //predicate.Invoke(10);
            //Console.WriteLine(predicate(10));
            //Func<int, string> Func;
            //Func = TestingFunctions.Test02;
            //Console.WriteLine(Func.Invoke(5));
             
            //Action action;
            //action = TestingFunctions.test03;
            //Console.WriteLine(action);

            #endregion
        }
    }
    //class testingFunction
    //{
    //    public static bool Test01(int x)
    //    {
    //        return x > 0;
    //    }
    //}
}
