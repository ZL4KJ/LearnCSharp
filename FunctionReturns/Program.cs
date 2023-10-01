// Returning values from a function.

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };
double usd = 23.73;
double nzd = UsdToNzd(usd);

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}


//Console.WriteLine($"Total: ${total}");
Console.WriteLine($"Total: ${FormatDecimal(total)}");
Console.WriteLine($"Total in NZD $:  {FormatDecimal(UsdToNzd(total))}");
double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}

double UsdToNzd(double usd)
{
    double rate = 1.70; // Implement this to be pulled from KiwiBanks API!
    return (rate * usd);
}
