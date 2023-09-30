Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 2;

while (count < n+1)
{
    Console.WriteLine(count);
    count = count+2;
}