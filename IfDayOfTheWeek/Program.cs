int weekDay  = Convert.ToInt32(DateTime.Now.DayOfWeek); //pühapäev - 0
Console.WriteLine(weekDay);
if (weekDay == 0)
{
    Console.WriteLine("Pühapäev");
}
else if (weekDay == 1)
{
    Console.WriteLine("Esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("Teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("Kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("Neljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("Reede");
}
else
{
    Console.WriteLine("Laupäev");
}
Console.WriteLine("Ilusat päeva!");
