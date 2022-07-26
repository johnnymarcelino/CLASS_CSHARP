using Class.src;
using System;

namespace Class {
    internal class Program {
        static void Main(string[] args) {
            Celular samsung = new Celular("Samsung", "S Galaxy 21+", 2021, 4800.00);
            Celular apple = new Celular("Apple", "Iphone 13 Pro", 2021, 6500.00);
            Celular motorolla = new Celular("Lenovo", "Moto Edge 30 Pro", 2022, 3999.00);
            Celular xiomi = new Celular("Xiomi", "Mi 11 Ultra", 2021, 7890.00);

            Console.WriteLine(samsung.ToString());
            Console.WriteLine(apple.ToString());
            Console.WriteLine(motorolla.ToString());
            Console.WriteLine(xiomi.ToString());
            Console.WriteLine(apple.Toque());
        }
    }
}
