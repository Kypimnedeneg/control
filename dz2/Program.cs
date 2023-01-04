Console.Write("N:");
int m = Convert.ToInt32(Console.ReadLine());
int n = 1;
void NaturalNumbers(int num, int num2)
{
    if (num>num2) 
    {
        
        Console.Write($"{num} ");
        NaturalNumbers(num-1,num2);
    }
    else Console.Write($"{num} ");
}

NaturalNumbers(m,n);