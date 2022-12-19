// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1: ");
int firstKoef = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b1: ");
int firstFreeKoef = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k2: ");
int secondKoef = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b2: ");
int secondFreeKoef = int.Parse(Console.ReadLine()!);

double[] arr = InterectionPointSearch(firstKoef, firstFreeKoef, secondKoef, secondFreeKoef);

Console.WriteLine("Координаты точки пересечения заданных прямых: ");

Console.WriteLine("(" + arr[0] + " " + arr[1] + ")");

double[] InterectionPointSearch (int A, int B, int C, int D)
{
    double[] array = new double[2];

    array[0] = Math.Round((double)(B - D) * (-1) / (A - C),1);
    array[1] = Math.Round((C * array[0] + D), 1);
    
    return array;
}
