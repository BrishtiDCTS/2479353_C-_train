using System;

class Student {
    public string Name;
    public int Id;

    public Student(string name, int id) {
        Name = name;
        Id = id;
    }

    public void Display() {
        Console.WriteLine($"Student ID: {Id}, Name: {Name}");
    }
}

class Program {
    static void Main() {
        Student s1 = new Student("Brishti", 2479353);
        s1.Display();
    }
}