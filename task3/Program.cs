// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите 5значное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb<=99999 && numb>9999)
{
    int firstnumb = numb/1000;
int numb1 = numb % 100;
int numb2 = numb1 % 10;
int numb3 = numb1/10;
int numb4 = numb2*10 + numb3; 
if (firstnumb == numb4) Console.WriteLine($"число {numb} является палиндромом ");
else Console.WriteLine($"число {numb} не является палиндромом ");

}
else Console.WriteLine($"Введите пятизначное число");




