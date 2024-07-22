namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            String newString = Console.ReadLine();
            string firstLetter = newString.Substring(0, 1);
            newString = String.Concat(firstLetter, newString, firstLetter);
            Console.WriteLine($"New string : {newString}");

        }
    }
}