int someValue = GetValue();

if (someValue > 100)
{
    int willNotWork = someValue - 100;
}

// will not work as the willNotWork variable is out of scope
Console.WriteLine(willNotWork);