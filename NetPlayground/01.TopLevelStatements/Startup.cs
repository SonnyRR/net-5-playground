// Magic 8 Ball
// Run with dotnet CLI. Example: dotnet run -- Az li sam Lil Wayne ti li si Rick Ross ?
// Ask it a Yes/No question and receive an answer by the fortune-telling console application.

using System;

if (args is null || args.Length == 0)
{
    throw new ArgumentNullException(nameof(args));
}

var possibleAnswers = new[] 
{
    "As I see it, yes.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don't count on it.",
    "It is certain.",
    "It is decidedly so."
};

var seed = DateTime.UtcNow.Millisecond + args[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine(possibleAnswers[new Random(seed).Next(possibleAnswers.Length - 1)]);