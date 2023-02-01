using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame;

public static class Messages
{
    public static void Welcome()
    {
        Console.WriteLine("Welcome to ClickerGame!");
    }
    public static void AskName()
    {
        Console.WriteLine();
        Console.WriteLine("What is your name?");

    }

    public static void MessageLoop()
    {
        Console.Clear();
        CommandsDescription();
        Console.WriteLine("Trykk tast for ønsket kommando.");
    }

    public static void CommandsDescription()
    {
        Console.WriteLine();
        Console.WriteLine(@"Kommandoer:
- SPACE for å klikke
- O for å oppgradere, dette gir deg flere poeng per 'klikk'
- S for superoppgradering, dette gjør hver oppgradering bedre
- A for å åpne AutoKlikker-Butikken
- X for å lagre og avslutte spillet
");
    }

    public static void NotEnoughPoints()
    {
        Console.WriteLine("Du hadde ikke nok poeng til å kjøpe dette");
    }
}

