// Лабораторная работа 2.1, номер: 21, сложность: средняя;
Console.Write("Введите стаж: ");
double s = double.Parse(Console.ReadLine());
Console.WriteLine((s <= 2) ? "Коэффициент = 11" : "Коэффициент != 11");
Console.WriteLine(((s >= 2) && (s <= 5)) ? "Коэффициент = 12" : "Коэффициент != 12");
Console.WriteLine((s >= 5) ? "Коэффициент = 13" : "Коэффициент != 13");