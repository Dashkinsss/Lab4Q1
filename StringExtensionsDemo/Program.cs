// See https://aka.ms/new-console-template for more information
using StringExtensionsLib;

string[] samples =
{
    "Hello",
    "world",
    "",
    "Apple",
    "banana"
};

foreach (var item in samples)
{
    Console.WriteLine($"\"{item}\" -> {item.StartsWithUppercase()}");
}
