// Написать программу масштабирования фигуры
Console.WriteLine("Задайте количество вершин произвольной фигуры: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] xarray = new int[n];
int[] yarray = new int[n];
Console.Write("В заданной фигуре имеем следующие координаты вершин: ");
    for(int i=0; i<n; i++)
    {
        xarray[i] = new Random().Next(1, 10);
        yarray[i] = new Random().Next(1, 10);
        Console.Write($"({xarray[i]};{yarray[i]}) ");        
    }
Console.WriteLine();
Console.WriteLine("Задайте коэффициент k для масштабирования данной фигуры: ");//при вводе в консоле дробного числа, например 0,5, необхожимо ставить запятую, а не точку
double k = Convert.ToDouble(Console.ReadLine() ?? "0");       
Console.Write("Координаты вершин фигуры после масштабирования: ");
    for(int i=0; i<n; i++)
    {
       Console.Write($"({k*(double)xarray[i]};{k*(double)yarray[i]}) ");        
    }
Console.WriteLine();

