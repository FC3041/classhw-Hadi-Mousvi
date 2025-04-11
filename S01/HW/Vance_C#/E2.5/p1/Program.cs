void F_to_C(double F)
{
    double C = (F-32.0) * (5.0/9.0);
    C = Math.Round(C,2);
    Console.WriteLine(F + " is " + C + " in Celsius");
}