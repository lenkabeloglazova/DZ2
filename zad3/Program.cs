
Console.WriteLine("Введите номер недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5) ;
{
    Console.Write(" это не выходной");

 if (num >= 6 && num <= 7)
{
    Console.Write(" Да, это выходной");
}
else
 Console.Write(" Не существует такого дня недели");
}