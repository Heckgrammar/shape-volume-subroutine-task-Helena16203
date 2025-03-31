namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
            static void Main(string[] args)
                {
                    //Write subroutines to calculate the areas of
                    // Circle
                    // Triangle
                    // Rectangle
                    // Pentagon     
                    // Octagon

                    Console.WriteLine("What would you like to find the area of? Circle[0], Triangle[1], Rectangle[2], Pentagon[3], Octagon[4]");
                    string UserShape = Console.ReadLine();
                    if (UserShape == "0")
                    {
                        Console.WriteLine("What is the radius??");
                        int Radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area is " + areaOfCircle(Radius));
                    }
                    else if (UserShape == "1")
                    {
                        Console.WriteLine("What is the height?");
                        int Height = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the base/width?");
                        int Width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area is " + areaOfTriangle(Height, Width));
                    }
                    else if (UserShape == "2")
                    {
                        Console.WriteLine("What is the length?");
                        int Length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the width?");
                        int Width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(areaOfRectangle(Length, Width));
                    }
                    else if (UserShape == "3")
                    {
                        Console.WriteLine("What is the length of one side?");
                        int Length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area is " + areaOfPentagon(Length));
                    }
                    else if (UserShape == "4")
                    {
                        Console.WriteLine("What is the length of one side?");
                        int Length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area is " + areaOfOctagon(Length));
                    }
                    else
                    {
                        Console.WriteLine("Invalid, start again please :)");
                    }
                }

                static int areaOfRectangle(int height, int width)//Add the parameters
                {
                     return height * width;
                }
                static int areaOfCircle(int radius)//Add the parameters
                {
                    double pi = Math.PI;
                    double area = (radius * radius * pi);
                    return (int)area;
                }
                static int areaOfTriangle(int length, int width)//Add the parameters
                {
                    return (length * width) / 2;
                }
                static int areaOfOctagon(int lengthOfSide)//Add the parameters
                {
                    return (int)(2 * (1 + Math.Sqrt(2)) * (lengthOfSide * lengthOfSide));
                }
                static int areaOfPentagon(int lengthOfSide)//Add the parameters
                {
                    double area = Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * (lengthOfSide * lengthOfSide) / 4;
                    return (int)area;
                }
            
    }
}
