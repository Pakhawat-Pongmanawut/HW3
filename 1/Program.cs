using System;

class Program {
    static void Main(string[] args) {
        // หาจุด
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        // (x-h)² + (y-k)² = r², สมการวงกลม
        double h, k;
        h = ((y2 - y1) * (y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1) + (y3 - y1) * (y1 * y1 - y2 * y2 + x1 * x1 - x2 * x2)) / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));
        k = ((x2 - x1) * (x3 * x3 - x1 * x1 + y3 * y3 - y1 * y1) + (x3 - x1) * (x1 * x1 - x2 * x2 + y1 * y1 - y2 * y2)) / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));

        // r² = (x1 - h)² + (y1 - k)² คำนวน
        double r = Math.Sqrt((x1 - h) * (x1 - h) + (y1 - k) * (y1 - k));
       
        Console.WriteLine("Center: ({0}, {1})", h, k);
        Console.WriteLine("Radius: {0}", r);

        
        Console.ReadKey();
    }
}