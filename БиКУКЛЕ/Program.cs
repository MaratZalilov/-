using БиКУКЛЕ;

Figure figure1 = new Circle();
Figure figure2 = new Square();
Figure figure3 = new Rectangle();
while (true)
{
    void GetMenu()
    {
        Console.WriteLine("Веберете фигуру для расчёта площади");
        Console.WriteLine("1. Круг");
        Console.WriteLine("2. Квадрат");
        Console.WriteLine("3. Прямоугольник");
    }
    GetMenu();

    void Menu()
    {
        string a = Console.ReadLine();
        int b = int.Parse(a);
        if (b == 1)
        {
            Console.WriteLine("Веедите радиус");
            figure1.SetNumber();
            figure1.GetArea();

        }
        else if (b == 2)
        {
            Console.WriteLine("Веедите сторону квадрата");
            figure2.SetNumber();
            figure2.GetArea();
        }
        else if (b == 3)
        {
            Console.WriteLine("Введите стороны прямоугольника");

            figure3.SetNumber();
            figure3.GetArea();
        }
        else
        {
            Console.WriteLine("Свободен");
            
        }
    }
    Menu();
}