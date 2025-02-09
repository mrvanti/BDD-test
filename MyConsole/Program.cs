﻿Console.WriteLine("Välkommen hit!");
while (true)
{
    Console.WriteLine("Vad heter du?");

    var name = Console.ReadLine();


    var rövarspråket = ConvertNameToRövarspråket(name ?? "");

    Console.WriteLine("Ditt namn på rövarspråket:");
    Console.WriteLine(rövarspråket);

    Console.WriteLine("Avsluta eller köra igen? 'Esc' för att avsluta applikationen, valfri tangent för att mata in igen.");

    // Wait for a key press
    var key = Console.ReadKey(intercept: true);

    // Check if the key pressed is 'Enter'
    if (key.Key == ConsoleKey.Escape)
    {
        Console.WriteLine("\nAvslutar");
        break; // Exit the loop
    }
}

static string ConvertNameToRövarspråket(string name)
{
    var namnPåRövarspråket = "";
    foreach (char c in name)
    {
        if (IsVowel(c))
        {
            namnPåRövarspråket += c;
        }
        else
        {
            namnPåRövarspråket = namnPåRövarspråket + c + "o" + c;
        }
    }
    return namnPåRövarspråket;
}

static bool IsVowel(char c)
{
    // Convert the character to lowercase for simplicity
    char lowerChar = char.ToLower(c);

    // Check if the character is in the set of vowels
    return "aeiouåäö".IndexOf(lowerChar) >= 0;
}