using System;

namespace CAU1
{
    class Program
    {
        static void Main(string[] args)
        {
            Input(out int[] a);
            Console.WriteLine("Tong lon hon phan tu la: " + SumOfElements(CountFrequency(a)));
        }

        static void Input(out int[] a)
        {
            Console.WriteLine("Nhap vao so phan tu trong day A: ");
            int n = int.Parse(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap vao phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static int[] CountFrequency(int[] a)
        {
            var countFrequency = new int[500];
            for (int i = 0; i < a.Length; i++)
            {
                countFrequency[a[i]]++;
            }

            return countFrequency;
        }

        static int SumOfElements(int[] count)
        {
            int result = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] >=i)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
