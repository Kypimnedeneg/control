Console.WriteLine("M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N:");
int n = Convert.ToInt32(Console.ReadLine());
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
      Console.WriteLine($"Сумма: {sum}");
        return;          
    }
    sum = sum + (numberM++); GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(m, n, 0);