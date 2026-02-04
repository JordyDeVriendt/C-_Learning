// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

List<string> friends = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter friend {i + 1} name: ");
    friends.Add(Console.ReadLine());
}

Console.WriteLine("\nYour friends are:");
for (int i = 0;i < 10; i++)
{
    Console.WriteLine($"{i + 1}. {friends[i]}");
}
