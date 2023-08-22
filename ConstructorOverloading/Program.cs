namespace ConstructorOverloading
{
     class Program
    {
        public Program()
        {
            Console.WriteLine("this is first constructor!!");
        }

        public Program(int a,int b)
        {
            Console.WriteLine("this is second constructor !! {0}", (a+b));

        }
        public Program(int a, int b ,int c)
        {
            Console.WriteLine("this is third constructor !! {0}", (a +b+c));

        }
        static void Main (String[] args)
        {
            Program p = new Program(20,10,5); //constructor overloading
            Console.ReadLine();
        }

    }
}