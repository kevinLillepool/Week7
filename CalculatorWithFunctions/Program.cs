int a = 10;
int b = 2;

Add(a, b);
Add(10, 100);
Add(56583, 658686);

Multiply(a, b);
Multiply(10, 100);
Multiply(56583, 658686);

Subtract(a, b);
Subtract(10, 100);
Subtract(56583, 658686);

Divide(a, b);
Divide(100, 10);
Divide(658686, 56583);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Subtract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

static void Divide(int x, int y)
{
    if (y != 0)
    {
        Console.WriteLine($"{x} / {y} = {x / y}");
    }
}  