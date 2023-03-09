// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter operation");
string op =(Console.ReadLine());
Console.WriteLine("number");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("number");
float y = float.Parse(Console.ReadLine());


double res;
switch (op)
{
    case "+":
        res = x + y;
        break;
    case "-":
        res = x - y;
        break;
    case "*":
        res = x * y;
        break;
    case "/":
        res = x / y;
        break;
    case "%":
        res = x / y;
        break;
    default:
        throw new Exception("please enter valid input");
}
Console.WriteLine(res); 
