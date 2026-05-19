namespace ConsoleApp3;

class student
{
    public string _name = null;
    private int _age;

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value > 100 || value < 0)
            {
                throw new ArgumentOutOfRangeException("too large");
                
            }

            _age = value;
        }
    }

    public void print()
    {
        Console.WriteLine($"Name: {_name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        student student = new student();
        student.Age= int.Parse(Console.ReadLine());
        student._name = Console.ReadLine();
        student.print();
        
       


    }
}
    