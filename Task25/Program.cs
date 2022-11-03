int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
if (numA == 0 && numB == 0) System.Console.WriteLine("Undefined");
else if (numB == 0) System.Console.WriteLine(1);
else System.Console.WriteLine(AToPowOfB(numA, numB));

double AToPowOfB(int a, int b)
{
    bool neg = false;
    double result = 1;
    if (b < 0)
    {
        b = -b;
        neg = true;
    }
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    if (neg) result = 1 / result;
    return result;
}