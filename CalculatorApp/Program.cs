/* Calculator app requirements
 1. Welcome Message
 2. What is your name
 3. Menu (Calculator, Calculation History, Quit)
 4. Ask user to input two numbers and operation he wants to do (if calculator selected)
 5. Give operation result on screen + save it to calculation history
 6. Give option to return to ask to input numbers step or quit
 */

Console.WriteLine("Write Username: ");
var username = Console.ReadLine();

var menu = @$"Hi! Welcome to the Calculator App, {username}!

Select one option:

    1 - Calculator
    2 - Calculation History
    Q - Quit
";

bool keepOpen = true;

while (keepOpen)
{


    Console.WriteLine(menu);

    var input = Console.ReadLine();

    switch (input)
    {
        case "1": Calculator();
        break;
        case "2": Console.WriteLine("Calculation History selected");
        break;
        case "Q":
        case "q": Console.WriteLine("Thank you for playing! Goodbye!");
            keepOpen = false;
        break;
    }

}
void Calculator()
{
    Console.WriteLine("Enter calculation (example: 2+2):");
    var input = Console.ReadLine().Replace(" ", "");

    char[] operators = { '+', '-', '*', '/' };
    char op = input.FirstOrDefault(c => operators.Contains(c));

        if (op == '\0')
        {
            Console.WriteLine("No valid operator found.");
            return;
        }

        var parts = input.Split(op);

        if (parts.Length != 2 ||
            !double.TryParse(parts[0], out double a) ||
            !double.TryParse(parts[1], out double b))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        double result;

        switch (op)
        {
            case '+':
                result = a + b;
                break;

            case '-':
                result = a - b;
                break;

            case '*':
                result = a * b;
                break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return;
                }
                result = a / b;
                break;

            default:
                Console.WriteLine("Unknown operator.");
                return;
        }

        Console.WriteLine($"Result: {result:F2}. \nPress any key to start new calculation or press 'R' to return to menu");

    var keepPlaying = Console.ReadLine();
    if (keepPlaying == "R" || keepPlaying == "r")
    {
        return;
    }

    else Console.Clear(); Calculator();
        
   
}


