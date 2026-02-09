using System;

class Car {
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }
}

class Program {
    static void Main() {
        Car c1 = new Car { Brand = "Toyota", Model = "Camry", Price = 25000 };
        Car c2 = new Car { Brand = "Tesla", Model = "Model 3", Price = 40000 };
        Car c3 = new Car { Brand = "Ford", Model = "Mustang", Price = 35000 };

        Console.WriteLine($"{c1.Brand} {c1.Model} costs ${c1.Price}");
        Console.WriteLine($"{c2.Brand} {c2.Model} costs ${c2.Price}");
        Console.WriteLine($"{c3.Brand} {c3.Model} costs ${c3.Price}");
    }
}