
// circumference of the circle
Console.WriteLine("Circumference of the Circle");
double radius = 0;
double cf = 0;

Console.WriteLine("Please Enter The radius:");
radius = Convert.ToDouble(Console.ReadLine());

cf = 2 * Math.PI * radius;
Console.WriteLine($"Circumference of the Circle = {cf}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");
// speed in meters per hour and kilometers per hour.
Console.WriteLine("Speed in km/hr and in m/hr");
double distance = 0;
double time = 0;

double speedKH = 0;
double speedMH = 0;
Console.WriteLine("Please Enter the distance in Meters: ");
distance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter the time in Hours: ");
time = Convert.ToDouble(Console.ReadLine());

speedMH=distance/time;
speedKH = distance/(time*1000);
Console.WriteLine($"Speed K/H = {speedKH} \n Speed M/H = {speedMH}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

//differences between Post Increment and Pre-Increment operators?
Console.WriteLine("Post Increment and Pre-Increment operators");
Console.WriteLine("post-increment: uses the current value and increments afterward");
Console.WriteLine("pre-increment: increments first and then uses the updated value.");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

// round a double number to the nearest integer

Console.WriteLine("Round a double number");
double num = 0;
int roundedNum = 0;

Console.WriteLine("Please Enter a Numirec number");
num = Convert.ToDouble(Console.ReadLine());

roundedNum = Convert.ToInt32(Math.Round(num));
Console.WriteLine($"The Rounded Number = {roundedNum}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");


// Result of baseNumberraised to the power of exponent
Console.WriteLine("Result of baseNumberraised to the power of exponent");
double basenum = 0;
double exponent = 0;
double result = 0;

Console.WriteLine("Please Enter a Basenumber");
basenum=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter the Exponent");
exponent = Convert.ToDouble(Console.ReadLine());

result= Math.Pow(basenum, exponent);
Console.WriteLine($"The result = {result}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

//check whether a year is a leap or not
Console.WriteLine("Check if Leap year or not");
int year = 0;


Console.WriteLine("Please Enter a year (EX:1972):");
year =Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    Console.WriteLine($"{year} is a leap year");
else Console.WriteLine($"{year} is not a leap year");


Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

// Check whether an alphabet is lowercase or uppercase

Console.WriteLine("Check if Lowercase or Uppercase");
char letter='a';


    Console.WriteLine("Please Enter a Letter:");
    letter = Convert.ToChar(Console.ReadLine());
    

    if (char.IsUpper(letter) )
        Console.WriteLine($"{letter} is Upper Case");
    else if (char.IsLower(letter))
        Console.WriteLine($"{letter} is Lower Case");

    else Console.WriteLine("Not Correct Format Entered ");


Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");


// simple calculator (*/+-) using switch statement.

Console.WriteLine("Calculator");
double num1 = 0;
double num2 = 0;
double calcResult = 0;
char symbol = '+';

Console.WriteLine("Please Enter first Number: ");
num1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter Second Number: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter the Operation Symbol : ");
symbol = Convert.ToChar(Console.ReadLine());


switch (symbol)
{
    case '+':
        calcResult = num1 + num2;
        Console.WriteLine($"The Result = {calcResult}");
        break;
    case '-':
        calcResult = num1 - num2;
        Console.WriteLine($"The Result = {calcResult}");
        break;
    case '*':
        calcResult = num1 * num2;
        Console.WriteLine($"The Result = {calcResult}");
        break;
    case '/':
        calcResult = num1 / num2;
        Console.WriteLine($"The Result = {calcResult}");
        break;
    default:
        Console.WriteLine("Not Applicable Operation");
        break;
}


Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");


// find the maximum number 

Console.WriteLine("Maximum Number");
double mnum1 = 0;
double mnum2 = 0;
double mnum3 = 0;
double maxnum = 0;

//condition? value_if_true : value_if_false;

Console.WriteLine("Please Enter num 1 :");
mnum1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter num 2 :");
mnum2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter num 3 :");
mnum3 = Convert.ToDouble(Console.ReadLine());

maxnum = mnum1 > mnum2 ? mnum1 :  mnum2;
maxnum = mnum3 > maxnum ? mnum3 : maxnum;

Console.WriteLine($"The Maximum Number between ({mnum1},{mnum2},{mnum3}) is: {maxnum}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

// Check if Even or Odd

Console.WriteLine("Even or Odd");
int eonum = 0;
bool isodd=false;

Console.WriteLine("Please enter a number:");
eonum = Convert.ToInt32(Console.ReadLine());

isodd = eonum%2 != 0 ? true : false ;

if(isodd)
    Console.WriteLine($"The Number {eonum} is ODD");
else
    Console.WriteLine($"The Number {eonum} is EVEN");

Console.WriteLine("-------------------------------------");
Console.WriteLine("Task 1 DONE");