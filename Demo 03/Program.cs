namespace Demo_03
{
    #region Delegate EX01
    //// Step 01 : Create a new Datatype (Delegate)
    public delegate int StringFuncDelegate(string s);
    //// Deleage (Class) => Reference Can Refer to a Function or More 
    ////                 => These Functions Should have Same Signature of the Delegate int(string)
    ////                 => Regardless of Function Name, Parameters Name, Access Modifiers 
    #endregion

    #region Delegate EX03
    //public delegate bool ConditionFuncDelegate(int x);      
    //public delegate bool ConditionFuncDelegateString(string x);      
    public delegate bool ConditionFuncDelegate<T>(T x); 
    #endregion
    internal class Program
    {
        #region Delegate EX02
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Delegate EX03
        public static List<T> FindNumbers<T>(List<T> list, Predicate<T> reference)
        {
            List<T> result = new List<T>();
            if (list?.Count > 0)
            {
                foreach (T item in list)
                {
                    if (reference.Invoke(item))
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }
        //public static List<string> FindNumbers(List<string> list, ConditionFuncDelegateString reference)
        //{
        //    List<string> result = new List<string>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (string item in list)
        //        {
        //            if (reference.Invoke(item))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (ConditionFunctions.IsOdd(item))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}
        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (ConditionFunctions.IsEven(item))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}
        //public static List<int> FindDivisibleBy4Numbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (ConditionFunctions.IsDivisibleBy4(item))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (item % 2 != 0)
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}
        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (item % 2 == 0)
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}
        //public static List<int> FindDivisibleBy4Numbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        foreach (int item in list)
        //        {
        //            if (item % 4 == 0)
        //            {
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}
        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Delegate Overview
            // Delegate : C# Feature

            // C# is Pure OOP

            // Functional Programming
            // 1. Function as a parameter
            // 2. Function as a return 
            // 3. Function as a variable

            // Event-Driven Programming

            // Java : Pure OOP doesn't support Functional Programming
            // Design Pattern 
            #endregion

            #region Delegate EX01
            ////StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetUpperCaseCount);
            //// Step 02 : Use Delegate
            //StringFuncDelegate X;
            //X = StringFunctions.GetUpperCaseCount;
            //X += StringFunctions.GetLowerCaseCount;

            //int count = X.Invoke("Hello World");
            //Console.WriteLine(count); 
            #endregion

            #region Delegate EX02
            //int[] numbers = { 5, 3, 8, 4, 2, 1, 9, 7, 6 };

            //PrintArray(numbers);

            ////SortingAlgorithms.BubbleSortDescending(numbers); 

            ////SortingAlgorithms.BubbleSort(numbers, SortingConditions.CompareAscending);
            //SortingAlgorithms.BubbleSort(numbers, SortingConditions.CompareDescending);

            //PrintArray(numbers);

            ////string[] names = { "Ali", "Ahmed", "Mohamed", "Sara", "Haerin", "Chaeyoung", "Ziad" };

            ////PrintArray(names);
            ////SortingAlgorithms.BubbleSort(names, SortingConditions.CompareAscending);
            ////PrintArray(names);
            #endregion

            #region Delegate EX03
            ////List<int> numbers = Enumerable.Range(1, 100).ToList();
            ////List<int> oddNumbers = FindNumbers(numbers, ConditionFunctions.IsOdd);
            ////List<int> evenNumbers = FindNumbers(numbers, ConditionFunctions.IsEven);   
            ////List<int> divisibleBy4Numbers = FindNumbers(numbers, ConditionFunctions.IsDivisibleBy4);


            //////PrintList(numbers);
            //////PrintList(oddNumbers);
            //////PrintList(evenNumbers);
            ////PrintList(divisibleBy4Numbers);

            //List<string> names = new List<string>
            //{
            //    "Ali",
            //    "Ahmed",
            //    "Mohamed",
            //    "Sara",
            //    "Haerin",
            //    "Chaeyoung",
            //    "Ziad"
            //};

            //List<string> namesLengthGreaterThan5 = FindNumbers(names, ConditionFunctions.LengthGreaterThan5);
            //List<string> namesLengthEquals5 = FindNumbers(names, ConditionFunctions.LengthEquals5);
            //List<string> namesLengthLessThan5 = FindNumbers(names, ConditionFunctions.LengthLessThan5);

            //PrintList(namesLengthLessThan5); 
            #endregion

            #region Built-in Delegates
            //// Built-in Delegates

            //// Predicate
            //// Func
            //// Action

            //// Predicate : bool(T)

            //Predicate<int> predicate = ConditionFunctions.IsOdd;

            //bool result = predicate.Invoke(5);
            //Console.WriteLine(result);

            //// Func : T(T)

            //Func<int, bool> func = ConditionFunctions.IsOdd;
            //Func<int> func01 = Fun01;
            //Func<int, string> func02 = Fun02;

            //// Action : void(T)

            ////Action action = Print;
            //////action.Invoke();
            ////action();

            //Action<string> action = Print;
            //action("The Revolution will not be televised"); 
            #endregion

            #region Anonymous Method & Lambda Expression
            ////Func<int, bool> func = ConditionFunctions.IsOdd;
            ////func(1);


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////// Anonyomous Method
            ////// C# 2.0 2005
            ////Func<int, bool> func = delegate(int x) { return x % 2 != 0; }; // Anonyomous Method

            //// Lambda Expression (Recommended)
            //// C# 3.0 2007
            ////Func<int, bool> func = x => x % 2 != 0;

            //FindNumbers(numbers, n => n % 2 != 0);
            //FindNumbers(numbers, n => n % 2 == 0);

            //Enumerable.Where(numbers, n => n % 2 != 0); 
            #endregion

            #region var
            //// var => C# 3.0 Keyword
            //var x = 5;
            //var y = "Hello World";
            //var z = new List<int> { 1, 2, 3, 4, 5 };

            //var predicate = ConditionFunctions.IsOdd; 
            #endregion

            #region Function Returns Function
            //var action = Fun03();
            //action.Invoke();

            //Fun03()(); 
            #endregion
        }

        #region Function Returns Function
        public static Action Fun03()
        {
            Action action = Print;
            return action;
        } 
        #endregion

        #region Built-in Delegates
        public static void Print()
        {
            Console.WriteLine("Hello World");
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static int Fun01()
        {
            return 5;
        }

        public static string Fun02(int x)
        {
            return $"{x}";
        } 
        #endregion
    }
}

