namespace Constructor
{
    class Employees    //variables
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees(int EmpId, string EmpName, int EmpAge)  //parameterise constructor
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;

        }

        public int getId()
        {
            return this.EmpId;
        }

        public string getName()
        {
            return this.EmpName;
        }
        public int  getAge()
        {
            return this.EmpAge;

        }
        static void Main(string[] args)
        {
            Employees Mayur = new Employees(11,"Mayur B",26);
            Employees Ali = new Employees(12, "Ali K", 22);


            Console.WriteLine(Mayur.getId());
            Console.WriteLine(Mayur.getName());
            Console.WriteLine(Mayur.getAge());
            Console.ReadLine();
        }
    }
}