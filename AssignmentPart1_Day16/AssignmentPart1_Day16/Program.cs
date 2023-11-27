using System;

namespace AssignmentPart1_Day16
{
    public delegate int ArithmeticOperation(int a, int b);
    public class Program
    {
        static int Add(int a, int b)
        {
           int result = a + b;
            return result;
        }
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
        static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        static int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }



        static void Main(string[] args)
        {
            ArithmeticOperation addDel = new ArithmeticOperation(Add);
            ArithmeticOperation subtractDel = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplyDel = new ArithmeticOperation(Multiply);
            ArithmeticOperation divideDel = new ArithmeticOperation(Divide);

            Console.WriteLine("Enter first integer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");

            int choice = int.Parse(Console.ReadLine());

            int result = 0;

            switch (choice)
            {
                case 1:
                    result = addDel(num1, num2);
                    break;
                case 2:
                    result = subtractDel(num1, num2);
                    break;
                case 3:
                    result = multiplyDel(num1, num2);
                    break;
                case 4:
                    result = divideDel(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }

}
    
