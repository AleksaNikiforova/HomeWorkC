Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber > secondnumber)  
{
    Console.Write("max = ");
    Console.WriteLine(firstnumber);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(secondnumber);
}
