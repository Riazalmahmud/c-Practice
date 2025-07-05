using System;
namespace TestRectangle
{


    class TestRectangle
    {
        public double length;
        public double Width;

        public double GetArea()
        {
            return Width * length;
        }

        public void GetDisplayRectangle()
        {
            Console.WriteLine("TestRectangle: " + GetArea());
        }
    }


    class ExecutiveArea
    {

        public static void MainRect(string[] args)
        {
            TestRectangle testRectangle = new TestRectangle();
            testRectangle.length = 4.5;
            testRectangle.Width = 3.5;
            testRectangle.GetDisplayRectangle();

        }
    }
    
}
