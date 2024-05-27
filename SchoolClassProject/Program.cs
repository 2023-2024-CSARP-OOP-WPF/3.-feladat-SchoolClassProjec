using SchoolClassProject;

SchoolClass aClass = new SchoolClass(9, ".a", 7000, 29);
SchoolClass bClass = new SchoolClass(9, ".b", 6000, 27);
Console.WriteLine(aClass);
Console.WriteLine(bClass);
if (SchoolClass.EqualTo(aClass, bClass))
{
    Console.WriteLine("9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.");
}
else
{
    if (aClass.MonthlyPay > bClass.MonthlyPay)
    {
        int extra = 0;
        extra=aClass.MonthlyPay - bClass.MonthlyPay;
        Console.WriteLine($"{aClass.Grade}{aClass.Id} osztály diákjai  havonta {extra} forinttal többet fizetnek osztálypénzbe, mint {bClass.Grade}{bClass.Id} osztály tanulói\n");
    }
    else
    {
        int extra = 0;
        extra = bClass.MonthlyPay - aClass.MonthlyPay;
        Console.WriteLine($"{bClass.Grade}{bClass.Id} osztály diákjai  havonta {extra} forinttal többet fizetnek osztálypénzbe, mint {aClass.Grade}{aClass.Id} osztály tanulói\n");
    }
}
Console.WriteLine($"Az {aClass.Grade}{aClass.Id} osztály 10 hónap alatt 30 diákkal {aClass.MonthlyPay*30*10}Ft-ot gyüjtött össze!");
Console.WriteLine($"Az {bClass.Grade}{bClass.Id} osztály 10 hónap alatt 30 diákkal {bClass.MonthlyPay * 30 * 10}Ft-ot gyüjtött össze!");