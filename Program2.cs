namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        GetDiscriminant1 number = new GetDiscriminant1();
    }
}


class GetDiscriminant1
{
    public int SetGetA { get; set; }
    public int SetGetB { get; set; }
    public int SetGetC { get; set; }
    

    public void SetNumbers()
    {
        int num_a = 0;
        do
        {
            Console.Write("First Number For A: ");
            string num = Console.ReadLine();
            num_a = Convert.ToInt32(num);
        }
        while (num_a == 0);
        SetGetA = num_a;
        //END FOR A

        Console.Write("Second Number For B: ");
        string b = Console.ReadLine();
        int num_b = Convert.ToInt32(b);
        SetGetB = num_b;
        //END FOR B

        Console.Write("Second Number For C: ");
        string c = Console.ReadLine();
        int num_c = Convert.ToInt32(c);
        SetGetC = num_c;
        //END FOR C
    }




    //Get X1 X2
    public void Discriminant_And_Roots()
    {
        double x1, x2;
        double d = Math.Pow(SetGetB, 2) - (4 * SetGetA * SetGetC);
        if (d == 0)
        {
            x1 = -SetGetB / (2 * SetGetA);
            Console.Write($"Root X1 = {x1}");
        }
        else if (d > 0)
        {
            x1 = (-SetGetB + Math.Sqrt(d)) / (2 * SetGetA);
            x2 = (-SetGetB - Math.Sqrt(d)) / (2 * SetGetA);
            Console.Write($"Roots X1 = {x1} X2 = {x2}");
        }
        else
        {
            Console.WriteLine("No Roots");
        }
    }
    //END
    // Constructor
    public GetDiscriminant1()
    {
        SetNumbers();
        Console.WriteLine($"A = {SetGetA} B = {SetGetB} C = {SetGetC}");
        Discriminant_And_Roots();
    }
    //Constructor
}
