long number = 5488265555;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

int number0 = 0;
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;

foreach (char c in letters)
{
    if (c == '0')
    { number0++; }
    else if (c == '1')
    { number1++; }
    else if (c == '2')
    { number2++; }
    else if (c == '3')
    { number3++; }
    else if (c == '4')
    { number4++; }
    else if (c == '5')
    { number5++; }
    else if (c == '6')
    { number6++; }
    else if (c == '7')
    { number7++; }
    else if (c == '8')
    { number8++; }
    else if (c == '9')
    { number9++; }
}
Console.WriteLine(number);
Console.WriteLine("0 => "+ number0);
Console.WriteLine("1 => "+ number1);
Console.WriteLine("2 => " +number2);
Console.WriteLine("3 => " +number3);
Console.WriteLine("4 => " +number4);
Console.WriteLine("5 => " +number5);
Console.WriteLine("6 => " +number6);
Console.WriteLine("7 => " +number7);
Console.WriteLine("8 => " +number8);
Console.WriteLine("9 => " +number9);





    