// Лабраторная:5.1 Уровень:средний Лукьянов Глеб 


    class Program
    {
        static int Euclid(int a, int b)
        {
            if (a > b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            int c;
            Console.Write("Ведите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            c = Euclid(a, b);
            Console.WriteLine(c);
        }
    }
