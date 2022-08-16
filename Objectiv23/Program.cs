Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int cof = 1; cof <= number; cof++)
{
    Console.WriteLine($"Возведение в куб {cof}: {Math.Pow(cof,3)}");
}