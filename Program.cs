using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleFirst = new Circle();
            Circle circleSecond = new Circle();
            Circle circleThird = new Circle();

          
            circleFirst.setCircleRadius(6);
            Console.WriteLine(circleFirst.getCircleRadius());
            Console.WriteLine(circleFirst.ToString());
        
        }
    }
}