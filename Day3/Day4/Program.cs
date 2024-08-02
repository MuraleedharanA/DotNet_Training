namespace Day4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            String a = "Athira";
            String b = "12";
            int convertedA;

            bool isInt= int.TryParse(a,out convertedA);
            int convertedB= int.Parse(b);
            if( isInt )
            {
                Console.WriteLine("A is an integer with val : " + convertedA);
                Console.WriteLine("B is converted to int : " + convertedB);
            }
            else
            {
                Console.WriteLine("Unable to convert A");
                Console.WriteLine("B is converted to int : " + convertedB);
            }
        }
    }
}