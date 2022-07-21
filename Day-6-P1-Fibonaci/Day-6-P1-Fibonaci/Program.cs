Console.WriteLine("Enter the Number");
double num = Convert.ToDouble(Console.ReadLine());
int sum = 0;
Console.WriteLine("Series are as follows");
for (int i = 0; i <= num; i++)
{
    int[] number = { i };
    sum += i;
    Console.WriteLine(sum);
}