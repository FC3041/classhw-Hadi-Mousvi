void roots(double a, double b , double c)
{
    double b2 = b * b;
    double cond = b2 - (4 * c * a);
    if(cond<0)
        Console.Write("None");
    else
    {
        double root1 = (-b + Math.Sqrt(cond))/(2*a);
        double root2 = (-b - Math.Sqrt(cond))/(2*a);
        Console.Write(root1 + " " + root2);
    }
}
