using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSysHomew
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            using (StreamReader stream = new StreamReader("D:\\7\\Fibonachi.txt"))
            {
                string FiboNumbers = stream.ReadLine();
                var numbers = FiboNumbers.Split(' ').ToList();
                int NumbersCount = numbers.Count;
                for (int i = 0; i < NumbersCount; i++)
                {
                    int num = int.Parse(numbers[numbers.Count - 2]) + int.Parse(numbers[numbers.Count - 1]);
                    numbers.Add(num.ToString());
                }
                for(int i = 0; i < numbers.Count; i ++)
                {
                    Console.Write( numbers[i] + " ");
                }
            }
            //задание 2
            int sum = 0;
            using (StreamReader stream = new StreamReader("D:\\7\\Input.txt"))
            {
                string twoNumbers = stream.ReadLine();
                var numbers = twoNumbers.Split(' ').ToList();
                sum = int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }
            using (StreamWriter stream = new StreamWriter("D:\\7\\Output.txt"))
            {
                stream.Write(sum);
            }
        }
    }
}

