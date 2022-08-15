Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number[0] == number[4])
{
   if(number[1] == number[3]);
   {
    Console.WriteLine($"Является палиндромом {number}");
   }
}
else Console.WriteLine($"Не является палиндромом {number}");