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