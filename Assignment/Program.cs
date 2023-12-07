using Assignment;


class Program
{

    static void Main()
    {
    // Car
        Car myCar = new Car("Toyota", 2022, 25000.50f);
        Console.WriteLine("1. Car Details:");
        Console.WriteLine($"Brand: {myCar.GetBrand()}");
        Console.WriteLine($"Year: {myCar.GetYear()}");
        Console.WriteLine($"Price: ${myCar.GetPrice()}");


        // BankAccount
        Console.WriteLine("\n2. Bank Details:");
        BankAccount myAccount = new BankAccount("123456789");
        myAccount.Deposit(1000m);
        myAccount.Withdraw(500m);
        Console.WriteLine($"Final Balance is: ${myAccount.GetBalance()}");


        // Rectangle
        Console.WriteLine("\n3. Rectangle:");
        Rectangle myRectangle = new Rectangle(4.5f, 3.2f);
        float area = myRectangle.CalculateArea();
        Console.WriteLine($"Area of the rectangle: {area}");


        //Shape
        Console.WriteLine("\n4. Shape:");
        Circle myCircle = new Circle { Radius = 5 };
        float customAreaVariable = myCircle.CalculateArea();
        Console.WriteLine($"Area of the circle: {customAreaVariable}");


        // Student
        Console.WriteLine("\n5. Student:");
        Student johnDoe = new Student("John Doe", 20, "Computer Science");
        johnDoe.Introduce();
        

        // Stack
        Console.WriteLine("\n6. Stack:");
 

        // DaysOfWeek
        Console.WriteLine("\n7. DaysOfWeek:");
        Calendar myCalendar = new Calendar();
        myCalendar.PrintWeekdays();


        // Point2D
        Console.WriteLine("\n8. Point2D:");
        Point2D pointA = new Point2D { X = 1.0f, Y = 2.0f };
        Point2D pointB = new Point2D { X = 4.0f, Y = 6.0f };
        DistanceCalculator distanceCalculator = new DistanceCalculator();
        float distance = distanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between the points: {distance}");


        Console.ReadLine();

    }
}