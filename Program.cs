namespace FastPowOnMod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ОСНОВАНИЕ СТЕПЕНЬ МОДУЛЬ");
            var str = Console.ReadLine().Split();

            FastPowOnMod method = new FastPowOnMod(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]));

            int res = method.CalcD();
            
            Console.WriteLine(res);
        }
    }
    class FastPowOnMod
    {
        private int a, n, m;
        private const int max_sqrt = 46340;
        public FastPowOnMod(int a, int n, int m)
        {
            this.a = a;
            this.n = n;
            this.m = m;
        }
        public int CalcD()
        {
            char[] bin = Convert.ToString(n, 2).Reverse().ToArray();
            int max_mult = int.MaxValue / a;

            int res = a * a, N = bin.Length - 1;
            
            for (int i = N - 1; i >= 0; i--)
            {
                if (bin[i] == '1')
                    res *= a;

                if (res > max_sqrt)
                 res %= m;

                if (i != 0 && res != 1)
                    res *= res;
            }
            return res % m;
        }
    }
}