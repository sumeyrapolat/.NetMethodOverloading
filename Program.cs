using System;

// --------------------- METHOD OVERLOADING ----------------------
public class ShapeCalculator
{
    // Dikdörtgenin alanını hesaplayan metot
    public double CalculateArea(double length, double width)
    {
        return length * width;
    }

    // Üçgenin alanını hesaplayan metot
    public double CalculateArea(int  baseLength, int height)
    {
        return (baseLength * height) /2;
    }

    // Dairenin alanını hesaplayan metot
    public double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ShapeCalculator calculator = new ShapeCalculator();

        // Dikdörtgenin alanı
        double rectangleArea = calculator.CalculateArea(5.0, 4.0);
        Console.WriteLine("Dikdörtgenin Alanı: " + rectangleArea);

        // Üçgenin alanı
        double triangleArea = calculator.CalculateArea(3.0, 6.0);
        Console.WriteLine("Üçgenin Alanı: " + triangleArea);

        // Dairenin alanı
        double circleArea = calculator.CalculateArea(2.5);
        Console.WriteLine("Dairenin Alanı: " + circleArea);



        //-------------- OUT PARAMETRE KULLANIMI ----------------------------


        int num1 = 10;
        int num2 = 5;
        int sum;

        // Toplama işlemi gerçekleştiren metot
        AddNumbers(num1, num2, out sum);

        Console.WriteLine("Toplam: " + sum); // Çıktı: Toplam: 15
    }


    static void AddNumbers(int x, int y, out int result)
    {
        // Toplama işlemi
        result = x + y;
    }
}




