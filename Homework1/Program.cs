internal class Program
{
    private static void Main(string[] args)
    { 
        // Второе задание
        Console.WriteLine("   ЗАПОЛНЕНИЕ АНКЕТЫ");
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите ваш рост (в метрах, например 1.75): ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("\n   ВАША КАРТОЧКА");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Рост: {height}");
        Console.WriteLine($"Примерный год рождения: {2026 - age}");

        // Третье задание
        int addVar;
        Console.WriteLine("\n   ЗАДАНИЕ С ДВУМЯ ПЕРЕМННЫМИ");
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());
        addVar = a;
        a = b;
        b = addVar;

        Console.WriteLine("Обмен значенями");
        Console.WriteLine($"Число a: {a}");
        Console.WriteLine($"Число b: {b}");

        // Четвёртое задание
        Console.WriteLine("\n   КАЛЬКУЛЯТОР ПЛОЩАДИ");
        Console.Write("Введите длину: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Введите ширину: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Введите высоту: ");
        double heightSquare = double.Parse(Console.ReadLine());

        Console.WriteLine($"Результат(площадь): {length * width * heightSquare}");
        Console.WriteLine($"Результат(периметр): {length + width + heightSquare}");

        Console.WriteLine("Результат работы");
    }
}