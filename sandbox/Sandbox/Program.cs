using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var letters = new List<char>(4); 
        Console.WriteLine("Step 1: Start with capacity 4");
        PrintList(letters);

        letters.Add('A');
        letters.Add('B');
        letters.Add('C');
        letters.Add('D');
        Console.WriteLine("\nStep 2: Insert A, B, C, D");
        PrintList(letters);

        letters.Add('E');
        Console.WriteLine("\nStep 3: Insert E (capacity grows to 8)");
        PrintList(letters);

        letters.RemoveAt(1);
        Console.WriteLine("\nStep 4: Remove B");
        PrintList(letters);

        letters.Add('B');
        Console.WriteLine("\nStep 5: Add B at the end");
        PrintList(letters);
    }

    static void PrintList(List<char> list)
    {
        Console.Write("Array: ");
        foreach (var item in list)
        {
            Console.Write("[" + item + "] ");
        }
        Console.WriteLine($"\nSize = {list.Count}, Capacity = {list.Capacity}");
    }
