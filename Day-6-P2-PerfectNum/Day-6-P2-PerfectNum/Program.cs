Console.WriteLine("Enter the Number");
double num = Convert.ToDouble(Console.ReadLine());
int sum = 0;
for (int i = 1; i < num; i++)
{
    if (num % i == 0)
    {
        int[] arr = { i };
        foreach (int x in arr)
        {
            sum += i;

        }

    }
}
Console.WriteLine($"Sum of its factors are " + sum);
if (sum == num)
{
    Console.WriteLine("It is a perfect Number");
}
else
{
    Console.WriteLine("It is not a Perfect Number");
}
