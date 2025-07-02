using System.Diagnostics;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Array

            #region One D Array

            // Array is a Class [Reference Type]

            //int[] Numbers;
            // Declare for Reference Of Type "Array of Integers".
            // This Reference 'Numbers' is Refering to the Default Value of the ReferenceType = NULL.
            // This Reference 'Numbers' Can Refer to an Object of Type "Array of Integers".
            // CLR Will Allocate 4 Bytes in STACK for This Reference [UnInitialized]
            // CLR Will Allocate 0 Bytes in HEAP

            // Numbers = new int[3]; // new_step1 => CLR Will Allocate the Requard Numbers of bytes of the Object in HEAP
            //new_step1 => CLR will Allocate 12 Bytes in HEAP
            //new_step2 => Will Initialized with the Default Value of "int" = 0
            //New_step3 => new will Call User Define Constructor
            //New_step4 => new Will Return the Address of First byte in Array (video1 min => 10)
            //Numbers[0] = 8;
            // 0*CountOfBytes + Base Address

            // Console.WriteLine($"Number of Dimentsions = {Numbers.Rank}");
            // Good in
            //          I can Go to any Elment in array just in One step
            // Bad in
            //          Fixed Size
            //Numbers[3] = 2; // May Will Throw Exception

            //List<int> numbers = new List<int>();

            #endregion

            #region Two D Array

            //Rectangular Array Column Equal   //Like SQL Sever
            //Judged Array the Column not Equal //like Mongo DB

            #region Rectangular Array
            //uint[,] Grades = new uint[3, 5];// CLR Will Allocate 60 Bytes in HEAP (15*4)
            // Initialized with the Default Value = 0.

            //Console.WriteLine($"The Size of the Array = {Grades.Length}, Number of Dimension = {Grades.Rank}");

            //Stopwatch sw = Stopwatch.StartNew();

            //for (int r = 0; r < Grades.GetLength(0); r++)
            //{
            //    Console.WriteLine($"Please Insert The Grades for Student Number: ({r + 1})");

            //    for (int c = 0; c < Grades.GetLength(1); /*c++*/)
            //    {
            //        Console.Write($"The Grades for The Subject Number ({c + 1}): ");
            //        c = uint.TryParse(Console.ReadLine(), out Grades[r, c]) ? ++c : c;
            //    }
            //    Console.WriteLine("***************************************");
            //} 

            //Console.Clear();
            //for (int r = 0; r < Grades.GetLength(0); r++)
            //{
            //    Console.WriteLine($"These are Grades for Student Number : ({r + 1})");
            //    for (int c = 0; c < Grades.GetLength(1); c++)
            //    {
            //        Console.WriteLine($"The Grade for Subject Number is = {Grades[r, c]}");
            //    }
            //    Console.WriteLine("******************************************************");
            //}// O (r * c)

            //sw.Stop();
            //Console.WriteLine($"//***************//***********// => {sw.ToString()}");
            //sw.Restart();
            //sw.Start();

            //for (int i = 0; i < Grades.Length; i++)
            //{
            //    Console.WriteLine(Grades[i / 5, i % 5]);
            //} //O (n)

            //sw.Stop();
            //Console.WriteLine($"//***************//***********// => {sw.ToString()}");


            //for (int r = 0; r < 3; r++)
            //{
            //    Console.WriteLine($"Please Insert The Grades for Student Number: ({r + 1})");

            //    for (int c = 0; c < 5; c++)
            //    {
            //        Console.WriteLine($"The Grades for The Subject Number: ({c + 1})");
            //        c = int.TryParse(Console.ReadLine(), out Grades[r, c]) ? ++c : c;
            //    }
            //} 
            #endregion

            #region Judged Array

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[3] { 43, 50, 2 };
            //Marks[1] = new int[2] { 1, 99 };
            //Marks[2] = new int[1] { 3 };

            //Console.WriteLine(Marks[0][0]);
            //Console.WriteLine(Marks[0][1]);
            //Console.WriteLine(Marks[0][2]);

            //Console.WriteLine(Marks[1][0]);
            //Console.WriteLine(Marks[1][1]);

            //Console.WriteLine(Marks[2][0]);

            //Console.WriteLine(Marks.GetLength(0));

            //Console.WriteLine("*********************************************");

            #endregion

            #endregion

            #region 1. Class Member Methods [Static Method]
            // 1. Class Member Methods [Static Method]

            //int[] Numbers = { 55, 8, 53, 55, 4, 64, 78, 8, 5 };
            //Array.Sort(Numbers);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[5];
            //Array.Copy(Arr01, Arr02, 2);
            //Array.Clear(Numbers);
            //Array.ConstrainedCopy(Arr01, 1, Arr02, 0, 2);
            // Arr02 = (int[])Array.CreateInstance(typeof(int), 10); //new int[2];
            //int[,] Arr03 = (int[,]) Array.CreateInstance(typeof(int), 2,4);
            //Console.WriteLine(Array.LastIndexOf(Numbers, 55));


            //foreach (int num in Arr02)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region 2. Object Membor Methods [Non-Static Methods]
            //Arr01.CopyTo(Arr02, 1);
            //Arr01.GetValue(2);
            //Arr01.SetValue(100, 2);

            //foreach (int num in Arr02)
            //{ Console.WriteLine(num); } 
            #endregion

            #endregion
        
        
        }
    }
}
