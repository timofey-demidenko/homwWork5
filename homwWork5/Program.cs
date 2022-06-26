using static System.Console;

namespace SimpleProject
{
    class Shop
    {
        private string name = "Mar";
        private string firstYear = "2004";
        private string description = "...";
        private string phoneNumber = "000000000";
        private string email = "aaaaaaa@";
        public int s = 0;

    
        

        public static int operator -(Shop s1, int i)
        {
            return s1.s - i;
        }
        public static int operator +(Shop s2, int j)
        {
            return s2.s + j;
        }
        public static bool operator >(Shop s3, int n)
        {
            return s3.s > n;
        }
        public static bool operator <(Shop s3, int n)
        {
            return s3.s < n;
        }
        public static bool operator ==(Shop s3, int n)
        {
            return s3.s != n;
        }
        public static bool operator !=(Shop s3, int n)
        {
            return s3.s == n;
        }


    }   
    
    
    class Program
    {
        static void Main()
        {
            int i = int.Parse(ReadLine());
            Shop s1 = new Shop{ s = 70};
            WriteLine($"S - {i} = {s1 - i}");
            int j = int.Parse(ReadLine());
            Shop s2 = new Shop {s = s1.s };
            WriteLine($"S + {j} = {s2 + j}");
            int n = int.Parse(ReadLine());
            Shop s3 = new Shop {s = s2.s };
            WriteLine($"S > {n} = {s3 > n}");
            WriteLine($"S < {n} = {s3 < n}");
            WriteLine($"if S == {n} = {s3 == n}");
            WriteLine($"if S != {n} = {s3 != n}");
            
        }
    }
}