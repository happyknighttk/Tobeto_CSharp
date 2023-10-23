//C# Dersleri 16-27

Add();
var result = Add2(30, 50);
var result2 = Add2(30);
var result3 = Add2(5);

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);

Console.WriteLine();

int number1;
//int number1 = 20;
int number2 = 100;
var result4 = Add3(out number1, number2); //(ref number1, number2)

Console.WriteLine(result4); // result4 = 130
Console.WriteLine(number1); // number1=20 | out&ref int number1=30

Console.WriteLine();

Console.WriteLine(Multiply(number1, number2));
//Console.WriteLine(Multiply(number1, number2, 2));
Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));


static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int x, int n1=20, int n2=30)
{
    return x + n1 + n2;
}

static int Add3(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int n1, int n2)
{ return n1 * n2; }

//static int Multiply(int n1, int n2, int n3)
//{ return n1 * n2 * n3; }

static int Add4(params int[] numbers)
{
    return numbers.Sum();
}