string value = "abc123";

char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

// string result = new string(valueArray);
string result = String.Join(",", valueArray);

Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

// Challenge Code
string pangram = "The quick brown fox jumps over the lazy dog";
string[] sentence = pangram.Split(' ');
string[] newSentence = new string[sentence.Length];

for (int i = 0; i < sentence.Length; i++)
{
    char[] letters = sentence[i].ToCharArray();
    Array.Reverse(letters);
    newSentence[i] = new string(letters);
}

string pangramResult = String.Join(" ", newSentence);
Console.WriteLine(pangramResult);

// Challenge Code 2
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderStreamItems = orderStream.Split(',');
Array.Sort(orderStreamItems);

foreach (var orderItem in orderStreamItems)
{
    if (orderItem.Length == 4)
    {
        Console.WriteLine(orderItem);
    }
    else
    {
        Console.WriteLine(orderItem + "\t- Error");
    }
}