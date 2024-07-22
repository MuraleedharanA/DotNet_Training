namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            String newString = Console.ReadLine();
            if (newString.Length > 3)
            {
                string firstLetter = newString.Substring(0, 3);
                newString = String.Concat(firstLetter, newString, firstLetter);
                
            }
            else
            {
                newString = newString + newString + newString;
            }
            Console.WriteLine($"New string : {newString}");

        }
    }
}