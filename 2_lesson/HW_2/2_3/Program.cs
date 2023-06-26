Console.WriteLine("Введите номер дня");
int date = int.Parse(Console.ReadLine()!);

if(date < 1 || date > 7) 
{
    Console.WriteLine("Дня с таким номером нет в неделе");
}
else 
{   if(date >= 6 && date <= 7)
       {
            Console.WriteLine("Это выходной");
       }
    if (date >= 1 && date <= 5)
       {
        Console.WriteLine("Это будний день");
       }
}