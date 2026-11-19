using System;

namespace scan3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // Comprehensive Execution & Test Validation Harness
            // ==========================================

            Console.WriteLine("--- Testing scan3 Methods (With Positive & Negative Cases) ---");

            // 1. Test IsDomino
            Node<int> dominoTrue = Arr2List(new int[] { 1, 2, 2, 4, 4, 3, 3, 5 });
            Node<int> dominoFalse = Arr2List(new int[] { 1, 2, 3, 4, 4, 5 });
            Console.WriteLine($"\n1. IsDomino (Valid Chain): Expected = True, Actual = {IsDomino(dominoTrue)}");
            Console.WriteLine($"   IsDomino (Invalid Chain): Expected = False, Actual = {IsDomino(dominoFalse)}");

            // 2. Test IsAlternatingEvenOdd
            Node<int> altTrue = Arr2List(new int[] { 2, 5, 4, 9, 8, 1 });
            Node<int> altFalse = Arr2List(new int[] { 2, 4, 5, 9, 8, 1 });
            Console.WriteLine($"2. IsAlternatingEvenOdd (Perfect Alternation): Expected = True, Actual = {IsAlternatingEvenOdd(altTrue)}");
            Console.WriteLine($"   IsAlternatingEvenOdd (Consecutive Evens): Expected = False, Actual = {IsAlternatingEvenOdd(altFalse)}");

            // 3. Test AreConnected
            Node<int> connList = Arr2List(new int[] { 1, 5, 4, 9, 2 });
            Console.WriteLine($"3. AreConnected (5 and 4 - Adjacent): Expected = True, Actual = {AreConnected(connList, 5, 4)}");
            Console.WriteLine($"   AreConnected (5 and 9 - Separated): Expected = False, Actual = {AreConnected(connList, 5, 9)}");

            // 4. Test LongestSeq
            Node<int> seqLong = Arr2List(new int[] { 2, 2, 7, 5, 5, 5, 4, 8, 2, 9, 9, 9, 9 });
            Node<int> seqShort = Arr2List(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"4. LongestSeq (Has Duplicate Runs): Expected = 4, Actual = {LongestSeq(seqLong)}");
            Console.WriteLine($"   LongestSeq (No Duplicates): Expected = 1, Actual = {LongestSeq(seqShort)}");

            // 5. Test MaxAscending
            Node<int> runTrue = Arr2List(new int[] { 1, 4, 2, 5, 6, 7, 3, 4 });
            Node<int> runFalse = Arr2List(new int[] { 9, 8, 7, 6, 5 });
            Console.WriteLine($"5. MaxAscending (Has Increasing Run): Expected = 4, Actual = {MaxAscending(runTrue)}");
            Console.WriteLine($"   MaxAscending (Strictly Decreasing): Expected = 1, Actual = {MaxAscending(runFalse)}");
        }

        // Array to List
        public static Node<T> Arr2List<T>(T[] arr)
        {
            if (arr == null || arr.Length == 0) return null;

            Node<T> head = new Node<T>(arr[0]);
            Node<T> last = head;

            for (int i = 1; i < arr.Length; i++)
            {
                last.SetNext(new Node<T>(arr[i]));
                last = last.GetNext();
            }

            return head;
        }

        // 1
        // check if list is a valid domino chain (each adjacent pair of nodes shares matching ends)
        // param : Node<int>
        // return : bool
        // examples:
        // param : ->1,2,2,4,4,3,3,5   => return: true
        // param : ->1,2,3,4,4,5       => return: false
        public static bool IsDomino(Node<int> lst)
        {
            return true;
        }

        // 2
        // check if list elements perfectly alternate between even and odd integers
        // param : Node<int>
        // return : bool
        // examples:
        // param : ->2,5,4,9,8,1   => return: true
        // param : ->2,4,5,9,8,1   => return: false
        public static bool IsAlternatingEvenOdd(Node<int> lst)
        {

            return true;
        }

        // 3
        // check if 2 values are connected in a list
        // param1  : Node<int>
        // param2  : int
        // param3  : int
        // return  : bool
        // examples:
        // param1 : ->1,5,4,9,2  param2: 5   param3: 4   => return: true
        // param1 : ->1,5,4,9,2  param2: 9   param3: 4   => return: true
        // param1 : ->1,5,4,9,2  param2: 9   param3: 5   => return: false
        // יש לעבור על הרשימה רק פעם אחת
        // אין להשתמש במבני נתונים נוספים
        // אין לשנות את הרשימה המקורית ולא ליצור רשימה חדשה
        public static bool AreConnected(Node<int> head, int value1, int value2)
        {

            return false;
        }

        // 4
        // מציאת הרצף הארוך ביותר ברשימה מקושרת
        // param : Node<int>
        // return : int
        // examples:
        // param : ->2,2,7,5,5,5,4,8,2,9,9,9,9 ==> return: 4
        // param : ->null ==> return: 0
        // param : ->3    ==> return: 1
        // אין להשתמש במבני נתונים נוספים פרט לרשימה המקושרת
        public static int LongestSeq(Node<int> head)
        {
            return 0;
        }

        // 5
        // find the length of the longest strictly ascending continuous sequence segment
        // param : Node<int>
        // return : int
        // examples:
        // param : ->1,4,2,5,6,7,3,4   => return: 4
        // param : ->9,8,7,6,5         => return: 1
        // param : ->null              => return: 0
        public static int MaxAscending(Node<int> l)
        {
            return 0;
        }
    }
}