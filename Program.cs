using System.Security.Cryptography.X509Certificates;

class Cal
{
    public double input1, input2;

    public Cal(double input3, double input4)
    {
        input1 = input3;   
        input2 = input4;    
    }

    public double Mul()
    {
        return input1 * input2;
    }

    public void Display()
    {
        Console.WriteLine("The answer is :" + Mul());
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Value");
        double input5=Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter Second Value");
        double input6=Convert.ToDouble(Console.ReadLine());
        Cal cal = new Cal(input5, input6);
    }
}
