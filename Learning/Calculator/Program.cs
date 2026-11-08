using Mathshelper;

System.Console.WriteLine("Calculator");
System.Console.WriteLine(new string('=', 20));

System.Console.WriteLine("First Number: ");
string firstNumber = System.Console.ReadLine();
System.Console.WriteLine("Choose either (+,-,/,*): ");
string symbol = System.Console.ReadLine();
System.Console.WriteLine("Second Number: ");
string secondNumber = System.Console.ReadLine();

System.Console.WriteLine(new string('=', 20));

switch (symbol)
{
    case "+": System.Console.WriteLine($"{firstNumber} + {secondNumber} = {Calc.add(firstNumber,secondNumber)}");
            break;
    case "-": System.Console.WriteLine($"{firstNumber} - {secondNumber} = {Calc.sub(firstNumber,secondNumber)}");
            break;
    case "*": System.Console.WriteLine($"{firstNumber} * {secondNumber} = {Calc.multi(firstNumber,secondNumber)}");
            break;
    case "/": System.Console.WriteLine($"{firstNumber} / {secondNumber} = {Calc.div(firstNumber,secondNumber)}");
            break;
    
}
