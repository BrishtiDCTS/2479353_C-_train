using System;
using System.IO; 

class Program {
    static void Main() {
        string fileName = "sample.txt";
        string contentToWrite = "Doing C# in Codespaces!";

     
        File.WriteAllText(fileName, contentToWrite);
        Console.WriteLine("File created and text written.");

        string readContent = File.ReadAllText(fileName);
        Console.WriteLine("Content read from file: " + readContent);
    }
}