void C_to_F(double C)
{
    double F = (C * 9.0/5.0) + 32;
    F = Math.Round(F,2);
    Console.Write(C + " , " + F);
}