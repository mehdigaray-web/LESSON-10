////Общий интерфейс и класс Array (1 2 2 задания)
//public interface IOutput
//{
//    void Show();
//    void Show(string info);
//}

//public interface IMath
//{
//    int Max();
//    int Min();
//    float Avg();
//    bool Search(int valueToSearch);
//}

//public interface ISort
//{
//    void SortAsc();
//    void SortDesc();
//    void SortByParam(bool isAsc);
//}

//public class Array : IOutput, IMath, ISort
//{
//    public int[] Elements;

//    public Array(int[] elements)
//    {
//        Elements = elements;
//    }

//    public void Show()
//    {
//        Console.WriteLine(string.Join(" ", Elements));
//    }

//    public void Show(string info)
//    {
//        Console.WriteLine($"{info}: {string.Join(" ", Elements)}");
//    }

//    public int Max()
//    {
//        int max = Elements[0];
//        for (int i = 1; i < Elements.Length; i++)
//        {
//            if (Elements[i] > max)
//                max = Elements[i];
//        }
//        return max;
//    }

//    public int Min()
//    {
//        int min = Elements[0];
//        for (int i = 1; i < Elements.Length; i++)
//        {
//            if (Elements[i] < min)
//                min = Elements[i];
//        }
//        return min;
//    }

//    public float Avg()
//    {
//        float sum = 0;
//        for (int i = 0; i < Elements.Length; i++)
//        {
//            sum += Elements[i];
//        }
//        return sum / Elements.Length;
//    }

//    public bool Search(int valueToSearch)
//    {
//        for (int i = 0; i < Elements.Length; i++)
//        {
//            if (Elements[i] == valueToSearch)
//                return true;
//        }
//        return false;
//    }

//    public void SortAsc()
//    {
//        for (int i = 0; i < Elements.Length - 1; i++)
//        {
//            for (int j = 0; j < Elements.Length - i - 1; j++)
//            {
//                if (Elements[j] > Elements[j + 1])
//                {
//                    int temp = Elements[j];
//                    Elements[j] = Elements[j + 1];
//                    Elements[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public void SortDesc()
//    {
//        for (int i = 0; i < Elements.Length - 1; i++)
//        {
//            for (int j = 0; j < Elements.Length - i - 1; j++)
//            {
//                if (Elements[j] < Elements[j + 1])
//                {
//                    int temp = Elements[j];
//                    Elements[j] = Elements[j + 1];
//                    Elements[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public void SortByParam(bool isAsc)
//    {
//        if (isAsc)
//        {
//            SortAsc();
//        }
//        else
//        {
//            SortDesc();
//        }
//    }
//}





// Task 1 demonstration:

//class Program
//{
//    static void Main()
//    {
//        

//        Array myArr = new Array(new int[] { 5, 2, 9, 1, 7 });

//        myArr.Show();
//        myArr.Show("Array elements");

//        Console.ReadLine();
//    }
//}







// Task 2 demonstration:

//class Program
//{
//    static void Main()
//    {
//        

//        Array myArr = new Array(new int[] { 10, 4, 8, 2, 5 });

//        Console.WriteLine($"Max value: {myArr.Max()}");
//        Console.WriteLine($"Min value: {myArr.Min()}");
//        Console.WriteLine($"Average: {myArr.Avg()}");

//        bool found = myArr.Search(8);
//        Console.WriteLine($"Is 8 in array? {found}");

//        Console.ReadLine();
//    }
//}







// Task 3 demonstration:
//class Program
//{
//    static void Main()
//    {
//        

//        Array myArr = new Array(new int[] { 8, 3, 1, 9, 4 });

//        myArr.Show("Original");

//        myArr.SortAsc();
//        myArr.Show("Ascending");

//        myArr.SortDesc();
//        myArr.Show("Descending");

//        myArr.SortByParam(true);
//        myArr.Show("Sorted by Param (True)");

//        Console.ReadLine();
//    }
//}







//Task 4:
//public interface IShape
//{
//    double CalculateArea();
//    double CalculatePerimeter();
//}

//public class Circle : IShape
//{
//    public double Radius;

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double CalculateArea()
//    {
//        return 3.14159 * Radius * Radius;
//    }

//    public double CalculatePerimeter()
//    {
//        return 2 * 3.14159 * Radius;
//    }
//}

//public class Rectangle : IShape
//{
//    public double Width;
//    public double Height;

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double CalculateArea()
//    {
//        return Width * Height;
//    }

//    public double CalculatePerimeter()
//    {
//        return 2 * (Width + Height);
//    }
//}

//public class Triangle : IShape
//{
//    public double SideA;
//    public double SideB;
//    public double SideC;

//    public Triangle(double sideA, double sideB, double sideC)
//    {
//        SideA = sideA;
//        SideB = sideB;
//        SideC = sideC;
//    }

//    public double CalculateArea()
//    {
//        double p = CalculatePerimeter() / 2;
//        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
//    }

//    public double CalculatePerimeter()
//    {
//        return SideA + SideB + SideC;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        

//        IShape circle = new Circle(5);
//        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
//        Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

//        IShape rect = new Rectangle(4, 6);
//        Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
//        Console.WriteLine($"Rectangle Perimeter: {rect.CalculatePerimeter()}");

//        IShape triangle = new Triangle(3, 4, 5);
//        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
//        Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()}");

//        Console.ReadLine();
//    }
//}







//Task 5:
//public interface IDrivable
//{
//    void StartEngine();
//    void StopEngine();
//    void Drive();
//}

//public class Car : IDrivable
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Car engine started: Vroom!");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Car engine stopped.");
//    }

//    public void Drive()
//    {
//        Console.WriteLine("Car is driving on the road.");
//    }
//}

//public class Motorcycle : IDrivable
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Motorcycle engine started: Wub-wub-wub!");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Motorcycle engine stopped.");
//    }

//    public void Drive()
//    {
//        Console.WriteLine("Motorcycle is driving fast.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        

//        IDrivable myCar = new Car();
//        myCar.StartEngine();
//        myCar.Drive();
//        myCar.StopEngine();

//        Console.WriteLine();

//        IDrivable myMoto = new Motorcycle();
//        myMoto.StartEngine();
//        myMoto.Drive();
//        myMoto.StopEngine();

//        Console.ReadLine();
//    }
//}