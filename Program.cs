namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        GetDiscriminantChild number = new GetDiscriminantChild();

    }
}


class GetDiscriminant
{
    private int _a, _b, _c;

    // SET_GET A
    public void SetA()
    {
        int _a = 0;
        do
        {
            Console.Write("First Number For A: ");
            string a = Console.ReadLine();
            _a = Convert.ToInt32(a);
        } while (_a == 0);
        this._a = _a;
    }
    public int GetA()
    {
        return _a;
    }
    //END

    //SET_GET B
    public void SetB()
    {
        Console.Write("Second Number For B: ");
        string b = Console.ReadLine();
        int _b = Convert.ToInt32(b);
        this._b = _b;
    }
    public int GetB()
    {
        return _b;
    }
    // END

    // SET_GET C
    public void SetC()
    {
        Console.Write("Third Number For B: ");
        string c = Console.ReadLine();
        int _c = Convert.ToInt32(c);
        this._c = _c;
    }
    public int GetC()
    {
        return _c;
    }
    // END

    //Get X1 X2
    public void Discriminant_And_Roots()
    {
        double x1, x2;
        double d = Math.Pow(_b, 2) - (4 * _a * _c);
        if (d == 0)
        {
            x1 = -_b / (2 * _a);
            Console.Write($"Root X1 = {x1}");
        }
        else if (d > 0)
        {
            x1 = (-_b + Math.Sqrt(d)) / (2 * _a);
            x2 = (-_b - Math.Sqrt(d)) / (2 * _a);
            Console.Write($"Roots X1 = {x1} X2 = {x2}");
        }
        else
        {
            Console.WriteLine("No Roots");
        }
    }
    //END
    // Constructor
/*    public GetDiscriminant1()
    {
        SetA();
        SetB();
        SetC();
        Console.WriteLine($"A = {GetA()} B = {GetB()} C = {GetC()}");
        Discriminant_And_Roots();
    }*/
    //Constructor
}
class GetDiscriminantChild : GetDiscriminant
{
    // Constructor
    public GetDiscriminantChild()
    {
        SetA(); SetB(); SetC();
        Console.WriteLine($"A = {GetA()} B = {GetB()} C = {GetC()}");
        Discriminant_And_Roots();
    }
    // END Constructor
}
