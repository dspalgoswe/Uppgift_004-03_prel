using System;
using System.Collections.Generic;

class Program
{
    // Hoppas att jag tolkade uppgiften rätt. Blev magsjuk i fredags så jag sänder vad jag har.
    static void Main(string[] args)
    {
        Console.WriteLine("Simulering av kö:");
        SimuleraKo();

        Console.WriteLine("\nSimulering av stack:");
        SimuleraStack();

        Console.WriteLine("\nVänd strusing System;\r\nusing System.Collections.Generic;\r\n\r\nclass Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        Console.WriteLine(\"Simulering av kö:\");\r\n        SimuleraKo();\r\n\r\n        Console.WriteLine(\"\\nSimulering av stack:\");\r\n        SimuleraStack();\r\n\r\n        Console.WriteLine(\"\\nVänd sträng med stack:\");\r\n        string reversedText = ReverseText();\r\n        Console.WriteLine($\"Den omvända strängen är: {reversedText}\");\r\n    }\r\n\r\n    static void SimuleraKo()\r\n    {\r\n        Queue<string> ko = new Queue<string>();\r\n\r\n        Console.WriteLine(\"Kön är tom: []\");\r\n\r\n        // Steg a - Kalle ställer sig i kön\r\n        ko.Enqueue(\"Kalle\");\r\n        Console.WriteLine(\"Kalle ställer sig i kön: [\" + string.Join(\", \", ko) + \"]\");\r\n\r\n        // Steg b - Greta ställer sig i kön\r\n        ko.Enqueue(\"Greta\");\r\n        Console.WriteLine(\"Greta ställer sig i kön: [\" + string.Join(\", \", ko) + \"]\");\r\n\r\n        // Steg c - Kalle blir expedierad\r\n        string expedierad1 = ko.Dequeue();\r\n        Console.WriteLine($\"{expedierad1} blir expedierad: [\" + string.Join(\", \", ko) + \"]\");\r\n\r\n        // Steg d - Stina ställer sig i kön\r\n        ko.Enqueue(\"Stina\");\r\n        Console.WriteLine(\"Stina ställer sig i kön: [\" + string.Join(\", \", ko) + \"]\");\r\n\r\n        // Steg e - Greta blir expedierad\r\n        string expedierad2 = ko.Dequeue();\r\n        Console.WriteLine($\"{expedierad2} blir expedierad: [\" + string.Join(\", \", ko) + \"]\");\r\n\r\n        // Steg f - Olle ställer sig i kön\r\n        ko.Enqueue(\"Olle\");\r\n        Console.WriteLine(\"Olle ställer sig i kön: [\" + string.Join(\", \", ko) + \"]\");\r\n    }\r\n\r\n    static void SimuleraStack()\r\n    {\r\n        Stack<string> stack = new Stack<string>();\r\n\r\n        Console.WriteLine(\"Kön är tom: []\");\r\n\r\n        // Steg a - Kalle ställer sig i kön (push)\r\n        stack.Push(\"Kalle\");\r\n        Console.WriteLine(\"Kalle ställer sig i kön: [\" + string.Join(\", \", stack) + \"]\");\r\n\r\n        // Steg b - Greta ställer sig i kön (push)\r\n        stack.Push(\"Greta\");\r\n        Console.WriteLine(\"Greta ställer sig i kön: [\" + string.Join(\", \", stack) + \"]\");\r\n\r\n        // Steg c - Kalle blir expedierad (pop)\r\n        string expedierad1 = stack.Pop();\r\n        Console.WriteLine($\"{expedierad1} blir expedierad: [\" + string.Join(\", \", stack) + \"]\");\r\n\r\n        // Steg d - Stina ställer sig i kön (push)\r\n        stack.Push(\"Stina\");\r\n        Console.WriteLine(\"Stina ställer sig i kön: [\" + string.Join(\", \", stack) + \"]\");\r\n\r\n        // Steg e - Greta blir expedierad (pop)\r\n        string expedierad2 = stack.Pop();\r\n        Console.WriteLine($\"{expedierad2} blir expedierad: [\" + string.Join(\", \", stack) + \"]\");\r\n\r\n        // Steg f - Olle ställer sig i kön (push)\r\n        stack.Push(\"Olle\");\r\n        Console.WriteLine(\"Olle ställer sig i kön: [\" + string.Join(\", \", stack) + \"]\");\r\n    }\r\n\r\n    static string ReverseText()\r\n    {\r\n        Console.WriteLine(\"Ange en sträng att vända:\");\r\n        string input = Console.ReadLine();\r\n\r\n        // Skapa en stack för att hålla tecken\r\n        Stack<char> stack = new Stack<char>();\r\n\r\n        // Lägg alla tecken i stacken\r\n        foreach (char c in input)\r\n        {\r\n            stack.Push(c);\r\n        }\r\n\r\n        // Bygg tillbaka strängen i omvänd ordning\r\n        char[] reversedArray = new char[stack.Count];\r\n        int index = 0;\r\n\r\n        while (stack.Count > 0)\r\n        {\r\n            reversedArray[index++] = stack.Pop();\r\n        }\r\n\r\n        return new string(reversedArray);\r\n    }\r\n}ng med stack:");
        string reversedText = ReverseText();
        Console.WriteLine($"Den omvända strängen är: {reversedText}");
    }

    static void SimuleraKo()
    {
        Queue<string> ko = new Queue<string>();

        Console.WriteLine("Kön är tom: []");

        // Steg a - Kalle ställer sig i kön
        ko.Enqueue("Kalle");
        Console.WriteLine("Kalle ställer sig i kön: [" + string.Join(", ", ko) + "]");

        // Steg b - Greta ställer sig i kön
        ko.Enqueue("Greta");
        Console.WriteLine("Greta ställer sig i kön: [" + string.Join(", ", ko) + "]");

        // Steg c - Kalle blir expedierad
        string expedierad1 = ko.Dequeue();
        Console.WriteLine($"{expedierad1} blir expedierad: [" + string.Join(", ", ko) + "]");

        // Steg d - Stina ställer sig i kön
        ko.Enqueue("Stina");
        Console.WriteLine("Stina ställer sig i kön: [" + string.Join(", ", ko) + "]");

        // Steg e - Greta blir expedierad
        string expedierad2 = ko.Dequeue();
        Console.WriteLine($"{expedierad2} blir expedierad: [" + string.Join(", ", ko) + "]");

        // Steg f - Olle ställer sig i kön
        ko.Enqueue("Olle");
        Console.WriteLine("Olle ställer sig i kön: [" + string.Join(", ", ko) + "]");
    }

    static void SimuleraStack()
    {
        Stack<string> stack = new Stack<string>();

        Console.WriteLine("Kön är tom: []");

        // Steg a - Kalle ställer sig i kön (push)
        stack.Push("Kalle");
        Console.WriteLine("Kalle ställer sig i kön: [" + string.Join(", ", stack) + "]");

        // Steg b - Greta ställer sig i kön (push)
        stack.Push("Greta");
        Console.WriteLine("Greta ställer sig i kön: [" + string.Join(", ", stack) + "]");

        // Steg c - Kalle blir expedierad (pop)
        string expedierad1 = stack.Pop();
        Console.WriteLine($"{expedierad1} blir expedierad: [" + string.Join(", ", stack) + "]");

        // Steg d - Stina ställer sig i kön (push)
        stack.Push("Stina");
        Console.WriteLine("Stina ställer sig i kön: [" + string.Join(", ", stack) + "]");

        // Steg e - Greta blir expedierad (pop)
        string expedierad2 = stack.Pop();
        Console.WriteLine($"{expedierad2} blir expedierad: [" + string.Join(", ", stack) + "]");

        // Steg f - Olle ställer sig i kön (push)
        stack.Push("Olle");
        Console.WriteLine("Olle ställer sig i kön: [" + string.Join(", ", stack) + "]");
    }

    static string ReverseText()
    {
        Console.WriteLine("Ange en sträng att vända:");
        string input = Console.ReadLine();

        // Skapa en stack för att hålla tecken
        Stack<char> stack = new Stack<char>();

        // Lägg alla tecken i stacken
        foreach (char c in input)
        {
            stack.Push(c);
        }

        // Bygg tillbaka strängen i omvänd ordning
        char[] reversedArray = new char[stack.Count];
        int index = 0;

        while (stack.Count > 0)
        {
            reversedArray[index++] = stack.Pop();
        }

        return new string(reversedArray);
    }
}