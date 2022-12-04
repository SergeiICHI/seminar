// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int A);
{
    Console.WriteLine();
    Console.WriteLine("Кубы чисел");
    for(int index = 1; index <= numb; index ++)
    {
    double numbers = Math.Pow(index, 3);
    Console.WriteLine(numbers);
    }
}
Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb<=0) Console.WriteLine("Нужно ввести числа от 1 до N");
else 
Cube(numb);

