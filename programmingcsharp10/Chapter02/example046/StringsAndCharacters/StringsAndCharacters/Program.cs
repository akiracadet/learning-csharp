using System.Globalization;

decimal v = 1234567.654m;
string i = string.Create(CultureInfo.InvariantCulture, $"Quantity {v:N}");
string f = string.Create(new CultureInfo("fr"), $"Quantity {v:N}");
string frc = string.Create(new CultureInfo("fr-FR"), $"Quantity {v:C}");
string cac = string.Create(new CultureInfo("fr-CA"), $"Quantity {v:C}");

Console.WriteLine(i);
Console.WriteLine(f);
Console.WriteLine(frc);
Console.WriteLine(cac);