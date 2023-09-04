using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Plateau'nun sağ üst koordinatlarını okuyoruz
        Console.WriteLine("Plateau'nun boyutlarını giriniz (Örnek: 5 5)");
        string[] plateauSize = Console.ReadLine().Split();
        int maxX = int.Parse(plateauSize[0]);
        int maxY = int.Parse(plateauSize[1]);

        List<Rover> rovers = new List<Rover>();

        Console.WriteLine("Rover'ların başlangıç pozisyonlarını ve talimatlarını giriniz (Örnek: 1 2 N, LMLMLMLMM):");
        string roverInput;


        while (!string.IsNullOrEmpty(roverInput = Console.ReadLine()))
        {
            string[] roverData = roverInput.Split();
            int startX = int.Parse(roverData[0]);
            int startY = int.Parse(roverData[1]);
            char startDirection = char.Parse(roverData[2]);

            Rover rover = new Rover(startX, startY, startDirection);
            string instructions = roverData[3];

            rover.ExecuteInstructions(instructions);
            rovers.Add(rover);
        }

        Console.WriteLine("Sonuçlar:");
        foreach (Rover rover in rovers)
        {
            Console.WriteLine(rover);
        }
    }
}
