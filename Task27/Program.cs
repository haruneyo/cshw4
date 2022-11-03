int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (num < 0) num = -num;
for (int i = 1; num >= 1; i++)
{
    int digit = num % 10;
    sum += digit;
    num /= 10;
}
System.Console.WriteLine(sum);