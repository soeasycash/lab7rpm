using System;
using System.Collections.Generic;

class Computer
{
    public string Name { get; set; }
    public int RAM { get; set; }

    public Computer(string name, int ram)
    {
        Name = name;
        RAM = ram;
    }
}

class Program
{
    static void Main()
    {
        Queue<Computer> computerQueue = new Queue<Computer>();
        int totalRAM = 0;

        // добавляем компьютеры в очередь
        computerQueue.Enqueue(new Computer("Computer1", 8));
        computerQueue.Enqueue(new Computer("Computer2", 16));
        computerQueue.Enqueue(new Computer("Computer3", 4));

        // выводим информацию о компбютерах
        Console.WriteLine("Информация о компьютерах в очереди:");
        foreach (var computer in computerQueue)
        {
            Console.WriteLine($"Компьютер: {computer.Name}, RAM: {computer.RAM} ГБ");
            totalRAM += computer.RAM;
        }

        Console.WriteLine($"Общий объем оперативной памяти: {totalRAM} ГБ");

        // удаляем первый компьютер из очереди
        Computer removedComputer = computerQueue.Dequeue();
        Console.WriteLine($"Удален компьютер: {removedComputer.Name}");

        // выводим новую информацию о компьютерах
        Console.WriteLine("Информация о компьютерах в очереди после удаления:");
        foreach (var computer in computerQueue)
        {
            Console.WriteLine($"Компьютер: {computer.Name}, RAM: {computer.RAM} ГБ");
        }

        totalRAM -= removedComputer.RAM;
        Console.WriteLine($"Общий объем оперативной памяти после удаления: {totalRAM} ГБ");
    }
}
