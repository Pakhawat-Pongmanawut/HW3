using System;

class Program {
    static void Main(string[] args) {
        int maxCoordinates = 20;
        double[] x = new double[maxCoordinates];
        double[] y = new double[maxCoordinates];

        int i;
        for (i = 0; i < maxCoordinates; i++) {
            double enteredX = double.Parse(Console.ReadLine());
            double enteredY = double.Parse(Console.ReadLine());


            if (enteredX != 0 || enteredY != 0) 
            {
                x[i] = enteredX;
                y[i] = enteredY;
            } 
            else 
            {
                break; 
            }
        }

        double Kx = double.Parse(Console.ReadLine());
        double Ky = double.Parse(Console.ReadLine());

        int j = i - 1; 
        bool inside = true;
        for (i = 0; i < j; i++) {
            if (((y[i] > Ky) != (y[j] > Ky)) && (Kx < (x[j] - x[i]) * (Ky - y[i]) / (y[j] - y[i]) + x[i]) || (Kx == 0) && (Ky == 0)) {
                inside = !inside;
            }
            j = i;

            if (inside) 
            {
            Console.WriteLine("inside");
            } 
            else 
            {
            Console.WriteLine("outside");
            }

    }
}
}