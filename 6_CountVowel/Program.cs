using System;
class Program{
    public static void Main(){
        Console.Write("enter a string : ");
        string inp=Console.ReadLine().ToLower();
        int count=0;
        foreach (char c in inp) {
            
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
                count++;
            }
        }
        Console.WriteLine("Total vowels found: "+count);
    }
}