Console.WriteLine("Yield");

var messagesEnumerator = GenerateMessages().GetEnumerator();

Console.WriteLine("Com foreach...");

foreach (var message in GenerateMessages())
    Console.WriteLine($"FOREACH -> {message}");

Console.WriteLine("Com for...");

for (int i = 0; i < 3; i++)
{
    messagesEnumerator.MoveNext();
    Console.WriteLine($"FOR - vez {i} -> {messagesEnumerator.Current}");
}

IEnumerable<string> GenerateMessages()
{
    var message = "Message 01";
    Console.WriteLine($"GenerateMessages gerou: {message}");
    yield return message;

    message = "Message 02";
    Console.WriteLine($"GenerateMessages gerou: {message}");
    yield return message;

    message = "Message 03";
    Console.WriteLine($"GenerateMessages gerou: {message}");
    yield return message;

    message = "Message 04";
    Console.WriteLine($"GenerateMessages gerou: {message}");
    yield return message;
}