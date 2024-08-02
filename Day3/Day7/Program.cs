namespace Day7
{
    class overloading
    {
        public void sum()
        {
            Console.WriteLine("hi");
        }
        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }

    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            overloading overloading = new overloading();
            overloading.sum();
            overloading.sum(1,2);
            overloading.sum("2","3");
        }
    }
}