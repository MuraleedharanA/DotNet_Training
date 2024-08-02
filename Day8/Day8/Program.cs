namespace Day8
{
    internal class Program
    { 
        public abstract class Animal
         {

            public abstract string sound { get;  }
            public virtual  void Move() {
                Console.WriteLine("move1");
            }
        }
        public class Cat : Animal
        {
            public override string sound => "meow";
            public override void Move()
            {
                Console.WriteLine("Cat move");
            }

        }


        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Cat cat = new Cat();
            cat.Move();
        }
    }
}