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
    Console.WriteLine("Input two numbers and the operation that you want to do! (Example input: 2 + 2)");
    var calculation = Console.ReadLine();
}

