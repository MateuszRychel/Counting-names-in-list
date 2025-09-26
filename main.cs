List<string> names = new() { "Ania", "Kasia", "Jacek", "Ania", "Andrzej", "Ania", "Jacek" };
Dictionary<string, int> nameCounts = new();

foreach (var name in names)
{
    if (nameCounts.TryGetValue(name, out int val))
    {
        nameCounts[name]++;
    }
    else
    {
        nameCounts[name] = 1;
    }
}

foreach (var kvp in nameCounts)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
