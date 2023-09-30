Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());

int max = firstnumber;

if (firstnumber > max ) max = firstnumber;
if (secondnumber > max ) max = secondnumber;
if (thirdnumber > max ) max = thirdnumber;

Console.Write("max = ");
Console.WriteLine(max);
