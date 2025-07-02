namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Array
            //Rectangular Array Column Equal   //Like SQL Sever
            //Juded Array the Column not Equal //like Mongo DB

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

            #endregion
        }
    }
}
