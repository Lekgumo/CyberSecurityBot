using System;
using System.Media;
using System.Threading;

class CyberSecurityBot
{
    static string userName;

    static void Main(string[] args)
    {
        PlayVoiceGreeting();
        ShowAsciiArt();
        GetUserName();
        ChatLoop();
    }

    // 🎧 Voice Greeting
    static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\chatBot\\chatBot\\greeting.wav");
            player.PlaySync(); // waits until finished
        }
        catch
        {
            Console.WriteLine("⚠ Voice file not found.");
        }
    }

    // 🖼 ASCII ART
    static void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================================");
        Console.WriteLine("  CYBERSECURITY AWARENESS BOT 🤖");
        Console.WriteLine("=======================================");
        Console.WriteLine(@"
        [ 🔐 Stay Safe Online 🔐 ]
           _____
          |  _  |
          | |_| |  <-- Humo's Security Bot
          |_____|
        ");
        Console.ResetColor();
    }

    // 👤 Get User Name
    static void GetUserName()
    {
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }

        Console.WriteLine($"\nHello, {userName}! 👋");
    }

    // 💬 Chat System
    static void ChatLoop()
    {
        string input;

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAsk me something (type 'exit' to quit): ");
            Console.ResetColor();

            input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠ I didn’t quite understand that. Please try again.");
                continue;
            }

            if (input == "exit")
            {
                Console.WriteLine("Goodbye! Stay safe online 🔐");
                break;
            }

            Respond(input);
        }
    }

    // 🧠 Responses
    static void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        if (input.Contains("how are you"))
        {
            Console.WriteLine($"I'm just code, but I'm doing great, {userName}! 😊");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to help you stay safe online.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Use strong passwords with letters, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is when scammers trick you into giving personal info.");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Only visit secure websites (https) and avoid suspicious links.");
        }
        else
        {
            Console.WriteLine("🤔 I didn’t understand that. Can you rephrase?");
        }

        Console.ResetColor();
    }
}