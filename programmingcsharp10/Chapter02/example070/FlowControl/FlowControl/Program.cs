switch (x)
{
    case "One":
        Console.WriteLine("One");
    case "Two":     // This will not compile
        Console.WriteLine("One or two");
        break;
}
