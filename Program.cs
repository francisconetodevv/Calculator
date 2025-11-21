List<string> history = new List<string>();

while (true)
{
    double result;

    Console.WriteLine("Enter two numbers to make your calculations:");
    double numberOne = double.Parse(Console.ReadLine());
    double numberTwo = double.Parse(Console.ReadLine());

    Console.WriteLine("--------------------------------");
    Console.WriteLine("Choose an operation: ");
    Console.WriteLine(" 1- Addition (+)");
    Console.WriteLine(" 2- Subtraction (-)");
    Console.WriteLine(" 3- Multiplication (*)");
    Console.WriteLine(" 4- Division (/)");
    Console.WriteLine("--------------------------------");

    int operation = int.Parse(Console.ReadLine());

    switch (operation)
    {
        case 1:
            result = numberOne + numberTwo;
            Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
            history.Add($"{numberOne} + {numberTwo} = {result}");
            break;
        case 2:
            result = numberOne - numberTwo;
            Console.WriteLine($"{numberOne} - {numberTwo} = {result}");
            history.Add($"{numberOne} - {numberTwo} = {result}");
            break;
        case 3:
            result = numberOne * numberTwo;
            Console.WriteLine($"{numberOne} * {numberTwo} = {result}");
            history.Add($"{numberOne} * {numberTwo} = {result}");
            break;
        case 4:
            if (numberTwo != 0)
            {
                result = numberOne / numberTwo;
                Console.WriteLine($"{numberOne} / {numberTwo} = {result}");
                history.Add($"{numberOne} / {numberTwo} = {result}");
                break;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                continue;
            }
        default:
            Console.WriteLine("Invalid operation selected.");
            continue;
    }

    Console.WriteLine("Do you want to perform another calculation or see the calculation historian? (Y/N/H)");
    string continueCalc = Console.ReadLine();

    if (continueCalc.ToUpper() == "N")
    {
        Console.WriteLine("Turning off the calculator. Goodbye!");
        break;
    }
    
    if (continueCalc.ToUpper() == "H") {
        Console.Clear();
        Console.WriteLine("Calculation History:");
        foreach (var record in history)
        {
            Console.WriteLine(record);
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    Console.Clear();
}