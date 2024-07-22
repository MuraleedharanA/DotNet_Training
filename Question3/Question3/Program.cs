namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new String");
            String newString=Console.ReadLine();

            if (newString.Length > 1)
            {
                String first = newString.Substring(0, 1);
                String second = newString.Substring(newString.Length - 1, 1);
                String mid = newString.Substring(1,newString.Length - 2);
                newString = second + mid + first;
                
            }
            Console.WriteLine($"New String :{newString}");
        }
    }
}