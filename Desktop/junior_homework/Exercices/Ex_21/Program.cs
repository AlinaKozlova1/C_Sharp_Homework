double distance(double xb, double xa, double yb, double ya, double zb, double za)
{
    double S = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
    Console.WriteLine("Distance = " + S);
    return S;
}
distance(15,13,6,3,8,2);