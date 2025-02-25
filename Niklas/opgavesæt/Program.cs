// See https://aka.ms/new-console-template for more information
using opgavesæt;

string name = "Niklas";
int age = 19;
double hourlyPay = 15.5;

Console.WriteLine($"Name is {name}, age is {age}, hourly pay is {hourlyPay}");

Console.WriteLine($"25 degrees celcius is {celciusToFahrenheit(25)}");

Console.WriteLine($"Bmi på person der vejer 70kg og er 175 høj: {calculateBMI(70, 1.75)}");

int a = 5;
int b = 7;

Console.WriteLine($"Values: {a} and {b}. \nSum: {sum(a, b)} \nDifference: {difference(a, b)} \nproduct: {product(a, b)} \nkvotient: {kvotient(a, b)} \nmodulus: {modulus(a, b)}");

int radius = 5;
Console.WriteLine($"Areal er {circleArea(radius)}\nOmkreds er {circleCircumference(radius)}");

int værdi1 = 20;
int værdi2 = 15;

if (værdi1 > værdi2)
{
    Console.WriteLine($"{værdi1} er større end {værdi2}");
} else if (værdi1 < værdi2)
{
    Console.WriteLine($"{værdi1} er mindre end {værdi2}");
} else if (værdi1 == værdi2)
{
    Console.WriteLine($"{værdi1} er lig med {værdi2}");
}

//Check on værdi er positivt, negativt eller 0

int value = -1;

if (value > 0)
{
    Console.WriteLine($"{value} er positivt");
} else if (value < 0)
{
    Console.WriteLine($"{value} er negativt");
} else if (value == 0)
{
    Console.WriteLine($"{value} er 0");
}

char grade = 'B';

PassedOrNot student = new PassedOrNot(grade);
if (student.hasPassed())
{
    Console.WriteLine($"Student has passed with grade {grade}");
}
else
{
    Console.WriteLine($"Student has not passed with grade {grade}");
}

int year = 2024;

if (isLeapYear(year))
{
    Console.WriteLine($"{year} is a leap year");
}
else
{
    Console.WriteLine($"{year} is not a leap year");
}

int weekDay = 1;

switch (weekDay)
{
    case 1:
        Console.WriteLine($"{weekDay} is Monday");
        break;
    case 2:
        Console.WriteLine($"{weekDay} is Tuesday");
        break;
    case 3:
        Console.WriteLine($"{weekDay} is Wednesday");
        break;
    case 4:
        Console.WriteLine($"{weekDay} is Thursday");
        break;
    case 5:
        Console.WriteLine($"{weekDay} is Friday");
        break;
    case 6:
        Console.WriteLine($"{weekDay} is Saturday");
        break;
    case 7:
        Console.WriteLine($"{weekDay} is Sunday");
        break;
}

int monthNumber = 4;
switch (monthNumber)
{
    case 1:
        Console.WriteLine("Januar: Årets første måned, ofte kold og med sne i mange lande. " +
                          "Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
        break;
    case 2:
        Console.WriteLine("Februar: Den korteste måned, kendt for fastelavn og valentinsdag. " +
                          "Navnet kommer fra det latinske ord 'februa', der betyder renselse.");
        break;
    case 3:
        Console.WriteLine("Marts: Forårets komme begynder så småt. " +
                          "Navnet kommer fra den romerske krigsgud Mars.");
        break;
    case 4:
        Console.WriteLine("April: Kendt for påske og for at være en måned med omskifteligt vejr. " +
                          "Navnet kommer fra det latinske ord 'aperire', der betyder at åbne (blomsterne springer ud).");
        break;
    case 5:
        Console.WriteLine("Maj: Foråret er i fuld gang, og naturen blomstrer. " +
                          "Navnet kommer fra den romerske gudinde Maia.");
        break;
    case 6:
        Console.WriteLine("Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage. " +
                          "Navnet kommer fra den romerske gudinde Juno.");
        break;
    case 7:
        Console.WriteLine("Juli: Højsommer, mange holder ferie. " +
                          "Navnet kommer fra Julius Cæsar.");
        break;
    case 8:
        Console.WriteLine("August: Stadig sommer, men dagene begynder at blive kortere. " +
                          "Navnet kommer fra kejser Augustus.");
        break;
    case 9:
        Console.WriteLine("September: Efterårets begyndelse, bladene begynder at skifte farve. " +
                          "Navnet kommer fra det latinske ord 'septem', der betyder syv (september var den syvende måned i den gamle romerske kalender).");
        break;
    case 10:
        Console.WriteLine("Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. " +
                          "Navnet kommer fra det latinske ord 'octo', der betyder otte.");
        break;
    case 11:
        Console.WriteLine("November: En mørk og ofte trist måned, hvor mange tænker på de døde. " +
                          "Navnet kommer fra det latinske ord 'novem', der betyder ni.");
        break;
    case 12:
        Console.WriteLine("December: Årets sidste måned, kendt for jul og nytår. " +
                          "Navnet kommer fra det latinske ord 'decem', der betyder ti.");
        break;
    default:
        Console.WriteLine("Ugyldigt månedstal. Indtast et tal mellem 1 og 12.");
        break;
}

for (int i = 1; i <= 10; i++)
{
    //Console.WriteLine(i);
}

int j = 1;
while (j <= 10)
{
    //Console.WriteLine(j);
    j++;
}

int k = 1;
do
{
    Console.WriteLine(k);
    k++;
} while (k <= 10);

int range = 100;
int fullSum = 0;
for (int step = 0; step <= range; step++)
{
    fullSum += step;
}
Console.WriteLine(fullSum);

int factRange = 5;
int factSum = 1;
for (int step = 1; step <= factRange; step++)
{
    factSum = factSum * step;
}
Console.WriteLine(factSum);

string stringToReverse = "Hello, my name is Niklas";
Console.WriteLine($"'{stringToReverse}' in reverse is '{reverseString(stringToReverse)}'");

string stringToFindVovels = "Hello there";
Console.WriteLine($"'{stringToFindVovels}' has {numVokaler(stringToFindVovels)} vovels");

double celciusToFahrenheit(double degreeC)
{
    double fahrenheit = degreeC * 9 / 5 + 32;
    return fahrenheit;
}

double calculateBMI(double weight, double height)
{
    double bmi = weight / (height * height);
    return bmi;
}

//Sum, difference, produkt, kvotient og modulus
double sum(double a, double b)
{
    return a + b;
}

double difference(double a, double b)
{
    return a - b;
}

double product(double a, double b)
{
    return a * b;
}

double kvotient(double a, double b)
{
    return a / b;
}

double modulus(double a, double b)
{
    return a % b;
}

double circleArea(double radius)
{
    return Math.PI * radius * radius;
}

double circleCircumference(double radius)
{
    return 2 * Math.PI * radius;
}

bool isLeapYear(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}


string reverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

int numVokaler(string stringToUse)
{
    char[] stringArray = stringToUse.ToCharArray();
    char[] vokaler = {'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å'};
    int numVokaler = 0;

    for (int i = 0; i < stringArray.Length; i++)
    {
        for (int j = 0; j < vokaler.Length; j++)
        {
            if (stringArray[i] == vokaler[j])
            {
                numVokaler++;
            }
        }
    }
    
    return numVokaler;
}
