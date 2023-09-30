string[] fraudulentOrderIDs = { "B123", "C234","A345","C15", "B177","G3003", "C235", "B179" };

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

foreach (string fraudulentOrders in fraudulentOrderIDs)
{
    Console.WriteLine( fraudulentOrders );
}

Console.WriteLine("\nOrder ID's which start with B");
foreach (string fraudulentOrders in fraudulentOrderIDs)
{
    
    if (fraudulentOrders.StartsWith("B"))
    {
        Console.WriteLine(fraudulentOrders);
    }
}

