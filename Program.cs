namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Calculator"); 
            Console.WriteLine("-----------------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtraction");
            Console.WriteLine("\t3 - Multiplication");
            Console.WriteLine("\t4 - Division");
            Console.WriteLine("\t5 - Exit");
            Console.WriteLine("-----------------");
            
            var option = Int32.Parse(Console.ReadLine());

            switch(option){
                case 1:
                    double num1, num2;
                    try {
                        Console.WriteLine("Input first number:");
                        num1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Input second number:");
                        num2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {num1 + num2}");
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    break;
                case 2:
                    try {
                        Console.WriteLine("Input first number:");
                        num1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Input second number:");
                        num2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {num1 - num2}");
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    break;
                case 3:
                    try {
                        Console.WriteLine("Input first number:");
                        num1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Input second number:");
                        num2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {num1 * num2}");
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    break;
                case 4:
                    try {
                        Console.WriteLine("Input first number:");
                        num1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Input second number:");
                        num2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {num1 / num2}");
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

    }
}
