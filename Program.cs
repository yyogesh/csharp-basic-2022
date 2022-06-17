// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine('b');

Console.WriteLine(123);

Console.WriteLine(12.3m);

Console.WriteLine(true);

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

string firstName = "Yogesh";
string lastName = "Yadav";

char userOption;

int gameScore = 10;


decimal partialPayment = 12.3m;

bool processedCustomer;

userOption = 'A';

string firstName1;
firstName1 = "Bob";


string firstName2;
// "Bob" = firstName1; // Wrong way to assign a value to a variable

Console.WriteLine(firstName1);

// Class means first letter always capitalized

// Variable nama start with small letter and next word  start with capitalized

Console.WriteLine("**************** Variable Reassign ******************");

string firstName3;
firstName3 = "Bob";
Console.WriteLine(firstName3);
firstName3 = "Beth";
Console.WriteLine(firstName3);
firstName3 = "Conrad";
Console.WriteLine(firstName3);
firstName3 = "Grant";
Console.WriteLine(firstName3);

Console.WriteLine("**************** Variable Reassign End ******************");

string firstName4;
//Console.WriteLine(firstName4); // Use of unassigned local variable 'firstName4' [dotnetconsolebasic]

string city = "Delhi";

city = "Mumbai";

// city = 100; // Wrong way to assign a value to a variable

var message = "Hello World";

// message = 10.0m; // Cannot implicitly convert type 'decimal' to 'string'

var message1 = 123;

// string abc = 133;

// var msg; // Implicitly-typed variables must be initialized before use


Console.WriteLine("**************** Assginement ******************");
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");


Console.WriteLine("**************** Assginement End ******************");

Console.WriteLine("Hello\nWorld!"); // new line
Console.WriteLine("Hello\tWorld!"); // 8 space keyword

// Console.WriteLine("Hello "World"!");

// (1,27): error CS1003: Syntax error, ',' expected
// (1,27): error CS0103: The name 'World' does not exist in the current context
// (1,32): error CS1003: Syntax error, ',' expected

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("D:\\Ysquare\\DOTNET 2022\\dotnetconsolebasic>");


Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"D:\Ysquare\DOTNET 2022\dotnetconsolebasic>"); // Verbatim String Literal

Console.WriteLine(@"   c:\source\repos   
      (this is where your code goes)");

//  Nihon no seikyū-sho o seisei suru ni wa: // 日本の請求書を生成するには：
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Other than English language

// Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
// Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
// Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
// Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
// Unicode characters may not print out correctly depending on the application.

string firstName6 = "Bob";
string message2 = " Hello";
Console.WriteLine(firstName6 + message2);

string firstName7 = "Bob";
string greeting = "Hello";
string message3 = greeting + " " + firstName7 + "!";
Console.WriteLine(message3);
// Console.WriteLine(greeting + " " + firstName7 + "!");

// string interpolation  ==> String interpolation combines multiple values into a single literal string 
string message4 = $"Hey {greeting} {firstName7}! Today is awesome day";
Console.WriteLine(message4);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName1 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName1}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");


Console.WriteLine("**************** 17-06-2022 ******************");

int firstNumber = 12;
int secondNumber = 3;

Console.WriteLine(firstNumber + secondNumber);


string userName = "Bob";
int widgetsSold = 7;
Console.WriteLine(userName + " sold " + widgetsSold + 7 + " widgets.");

string userName1 = "Bob";
int widgetsSold1 = 7;
Console.WriteLine(userName1 + " sold " + (widgetsSold1 + 7) + " widgets.");


// + is the addition operator
// - is the subtraction operator
// * is the multiplication operator
// / is the division operator

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);


decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;

//won't work (or give inaccurate results)
// int decimalQuotient = 7 / 5.0m;
// int decimalQuotient = 7.0m / 5;
// int decimalQuotient = 7.0m / 5.0m;
// decimal decimalQuotient = 7 / 5;

int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1);

int first1 = 7;
int second1 = 5;
decimal quotient2 = first1 / second1;
Console.WriteLine(quotient2);


Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5)); // Modulus 
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));


// Order of Operations

// PEMDAS - Parenthesis, Exponents, Multiplication, Division, Addition, Subtraction

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


int val = 0;
val = val + 5;
val += 5;
val++;
Console.WriteLine(val);

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


int value3 = 1;
value3++;
Console.WriteLine("First: " + value3);
Console.WriteLine("Second: " + value3++);
Console.WriteLine("Third: " + value3);
Console.WriteLine("Fourth: " + (++value3));


int fahrenheit = 86;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

// Random class to create a new object called dice:
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine("You rolled a " + roll);


Random dice1 = new Random();
int roll1 = dice1.Next(1, 7);
Console.WriteLine("You rolled a " + roll1);

// It first requests an address in the computer's memory large enough to store a new object based on the Random class.
// It creates the new object, and stores it at the memory address.
// It returns the memory address so that it can be saved in the dice variable.

// Random obj = new Random();
// Console.WriteLine(); // static function
// Random.Next(1, 2); // An object reference is required for the non-static field, method, or property 'Random.Next(int, int)'

// Overloaded methods/ function

// An overloaded method is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);


Random dice2 = new Random();
int roll4 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll4}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($"The larger value is {largerValue}");

Random dice5 = new Random();

int roll5 = dice5.Next(1, 7);
int roll6 = dice5.Next(1, 7);
int roll7 = dice5.Next(1, 7);

int total = roll5 + roll6 + roll7;

Console.WriteLine($"Dice roll: {roll5} + {roll6} + {roll7} = {total}");

// if total > 15 you win
if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose!");
}

// || or 
if ((roll5 == roll6) || (roll6 == roll7) || (roll5 == roll7))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

Console.WriteLine($"Dice roll: {roll5} + {roll6} + {roll7} = {total}");

if (total >= 15)
{
    Console.WriteLine("You win!");
}


if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}


string msg = "The quick brown fox jumps over the lazy dog.";
bool result = msg.Contains("fox");
Console.WriteLine($"The string '{msg}' contains 'dog': {result}");

if (msg.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

