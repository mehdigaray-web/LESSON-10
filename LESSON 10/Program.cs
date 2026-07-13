interface IOutput
{
    void Show();
    void Show(string info);
}
interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}
interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}
class IntArray : IOutput, IMath, ISort
{
    private int[] data;
    private int count;

    public IntArray(int[] values)
    {
        count = values.Length;
        data = new int[count];
        for (int i = 0; i < count; i++)
            data[i] = values[i];
    }

    public void Show()
    {
        Console.Write("Array: ");
        for (int i = 0; i < count; i++)
            Console.Write(data[i] + " ");
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine("Info: " + info);
        Show();
    }

    public int Max()
    {
        int max = data[0];
        for (int i = 1; i < count; i++)
            if (data[i] > max)
                max = data[i];
        return max;
    }

    public int Min()
    {
        int min = data[0];
        for (int i = 1; i < count; i++)
            if (data[i] < min)
                min = data[i];
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        for (int i = 0; i < count; i++)
            sum += data[i];
        return (float)sum / count;
    }

    public bool Search(int valueToSearch)
    {
        for (int i = 0; i < count; i++)
            if (data[i] == valueToSearch)
                return true;
        return false;
    }

    public void SortAsc()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - 1 - i; j++)
            {
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    public void SortDesc()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - 1 - i; j++)
            {
                if (data[j] < data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }
}
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : IShape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Triangle : IShape
{
    public double A;
    public double B;
    public double C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public double CalculatePerimeter()
    {
        return A + B + C;
    }
}
interface IDrivable
{
    void StartEngine();
    void StopEngine();
    void Drive();
}

class Car : IDrivable
{
    public string Brand;
    public int Year;

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine(Brand + ": engine started. Vroom!");
    }

    public void StopEngine()
    {
        Console.WriteLine(Brand + ": engine stopped.");
    }

    public void Drive()
    {
        Console.WriteLine(Brand + " (" + Year + "): driving on the road.");
    }
}

class Motorcycle : IDrivable
{
    public string Brand;
    public string Type;

    public Motorcycle(string brand, string type)
    {
        Brand = brand;
        Type = type;
    }

    public void StartEngine()
    {
        Console.WriteLine(Brand + " motorcycle: engine started. Roar!");
    }

    public void StopEngine()
    {
        Console.WriteLine(Brand + " motorcycle: engine stopped.");
    }

    public void Drive()
    {
        Console.WriteLine(Brand + " (" + Type + "): riding on the road.");
    }
}
// Task 1, 2, 3 
IntArray arr = new IntArray(new int[] { 5, 2, 9, 1, 7, 3, 8 });

arr.Show();
arr.Show("My test array");

Console.WriteLine("Max: " + arr.Max());
Console.WriteLine("Min: " + arr.Min());
Console.WriteLine("Avg: " + arr.Avg());
Console.WriteLine("Search 7: " + arr.Search(7));
Console.WriteLine("Search 99: " + arr.Search(99));

arr.SortAsc();
arr.Show("Sorted ascending");

arr.SortDesc();
arr.Show("Sorted descending");

arr.SortByParam(true);
arr.Show("SortByParam(true)");

Console.WriteLine();

// Test 4 — IShape
Circle circle = new Circle(5);
Rectangle rect = new Rectangle(4, 6);
Triangle triangle = new Triangle(3, 4, 5);

Console.WriteLine("Circle — Area: " + circle.CalculateArea().ToString("F2") + ", Perimeter: " + circle.CalculatePerimeter().ToString("F2"));
Console.WriteLine("Rectangle — Area: " + rect.CalculateArea() + ", Perimeter: " + rect.CalculatePerimeter());
Console.WriteLine("Triangle — Area: " + triangle.CalculateArea().ToString("F2") + ", Perimeter: " + triangle.CalculatePerimeter());

Console.WriteLine();

// Test 5 — IDrivable
Car car = new Car("Toyota", 2021);
Motorcycle moto = new Motorcycle("Honda", "Sport");

car.StartEngine();
car.Drive();
car.StopEngine();

Console.WriteLine();

moto.StartEngine();
moto.Drive();
moto.StopEngine();
