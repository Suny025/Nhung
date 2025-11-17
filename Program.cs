using System;

class LinearEquation
{
    protected double a;
    protected double b;

    public LinearEquation(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual string Solve()
    {
        if (a == 0)
        {
            if (b == 0)
                return "Phương trình vô số nghiệm.";
            else
                return "Phương trình vô nghiệm.";
        }

        double x = -b / a;
        return $"Phương trình có nghiệm x = {x}";
    }
}


class QuadraticEquation : LinearEquation
{
    private double c;

    public QuadraticEquation(double a, double b, double c)
        : base(a, b)   // gọi constructor lớp cha để gán a, b
    {
        this.c = c;
    }

    public override string Solve()
    {
        if (a == 0)
        {
            // ax^2 + bx + c = 0 ==> bx + c = 0
            Console.WriteLine("a = 0, chuyển về phương trình bậc 1:");
            return base.Solve();
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return "Phương trình vô nghiệm.";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return $"Phương trình có nghiệm kép x = {x}";
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b + sqrtDelta) / (2 * a);
            double x2 = (-b - sqrtDelta) / (2 * a);
            return $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquation qe = new QuadraticEquation(a, b, c);

        Console.WriteLine(qe.Solve());
    }
}
