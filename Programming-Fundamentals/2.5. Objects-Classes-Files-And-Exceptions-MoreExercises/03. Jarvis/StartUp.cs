using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Jarvis
{
    internal class Arms
    {
        public int EnergyConsumption { get; set; }
        public int ArmReachDistance { get; set; }
        public int FingersCount { get; set; }
    }

    internal class Legs
    {
        public int EnergyConsumption { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }

    internal class Torso
    {
        public int EnergyConsumption { get; set; }
        public decimal ProcessorSizeSM { get; set; }
        public string HousingMaterial { get; set; }
    }

    internal class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }

    internal class Robot
    {
        public List<Arms> Arms { get; set; }
        public List<Legs> Legs { get; set; }
        public List<Torso> Torso { get; set; }
        public List<Head> Head { get; set; }
    }

    internal class StartUp
    {
        public static void Main()
        {
            var maxEnergyCapacity = long.Parse(Console.ReadLine());

            var robot = new Robot();
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "Assemble!")
                    break;

                var energyConsumption = int.Parse(input[1]);

                if (input[0] == "Head")
                {
                    var IQ = int.Parse(input[2]);
                    var currHead = new Head();
                    currHead.EnergyConsumption = energyConsumption;
                    currHead.IQ = IQ;
                    currHead.SkinMaterial = input[3];
                    if (robot.Head == null)
                        robot.Head = new List<Head>();
                    robot.Head.Add(currHead);
                }
                else if (input[0] == "Arm")
                {
                    var currentArm = new Arms();
                    currentArm.EnergyConsumption = energyConsumption;
                    currentArm.ArmReachDistance = int.Parse(input[2]);
                    currentArm.FingersCount = int.Parse(input[3]);
                    if (robot.Arms == null)
                        robot.Arms = new List<Arms>();
                    robot.Arms.Add(currentArm);
                }
                else if (input[0] == "Leg")
                {
                    var currLeg = new Legs();
                    currLeg.EnergyConsumption = energyConsumption;
                    currLeg.Strength = int.Parse(input[2]);
                    currLeg.Speed = int.Parse(input[3]);
                    if (robot.Legs == null)
                        robot.Legs = new List<Legs>();
                    robot.Legs.Add(currLeg);
                }
                else if (input[0] == "Torso")
                {
                    var torso = new Torso();
                    torso.EnergyConsumption = energyConsumption;
                    torso.ProcessorSizeSM = decimal.Parse(input[2]);
                    torso.HousingMaterial = input[3];
                    if (robot.Torso == null)
                        robot.Torso = new List<Torso>();
                    robot.Torso.Add(torso);
                }
            }
            if (robot.Head == null) robot.Head = new List<Head>();
            if (robot.Arms == null) robot.Arms = new List<Arms>();
            if (robot.Legs == null) robot.Legs = new List<Legs>();
            if (robot.Torso == null) robot.Torso = new List<Torso>();

            if (robot.Head.Count > 0 && robot.Arms.Count > 1 && robot.Legs.Count > 1 && robot.Torso.Count > 0)
            {
                long totalEnergyConsumed = robot.Head.OrderBy(h => h.EnergyConsumption).First().EnergyConsumption +
                                           robot.Arms.OrderBy(a => a.EnergyConsumption).First().EnergyConsumption +
                                           robot.Arms.OrderBy(a => a.EnergyConsumption).Skip(1).Take(1).First()
                                               .EnergyConsumption +
                                           robot.Legs.OrderBy(l => l.EnergyConsumption).First().EnergyConsumption +
                                           robot.Legs.OrderBy(l => l.EnergyConsumption).Skip(1).Take(1).First()
                                               .EnergyConsumption +
                                           robot.Torso.OrderBy(t => t.EnergyConsumption).First().EnergyConsumption;
                if (totalEnergyConsumed > maxEnergyCapacity)
                {
                    Console.WriteLine("We need more power!");
                }
                else
                {
                    Console.WriteLine("Jarvis:\n#Head:");
                    foreach (var head in robot.Head.OrderBy(h => h.EnergyConsumption).Take(1))
                    {
                        Console.WriteLine($"###Energy consumption: {head.EnergyConsumption}");
                        Console.WriteLine($"###IQ: {head.IQ}");
                        Console.WriteLine($"###Skin material: {head.SkinMaterial}");
                    }
                    Console.WriteLine("#Torso:");
                    foreach (var torso in robot.Torso.OrderBy(t => t.EnergyConsumption).Take(1))
                    {
                        Console.WriteLine($"###Energy consumption: {torso.EnergyConsumption}");
                        Console.WriteLine($"###Processor size: {torso.ProcessorSizeSM:f1}");
                        Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
                    }
                    foreach (var arm in robot.Arms.OrderBy(a => a.EnergyConsumption).Take(2))
                    {
                        Console.WriteLine("#Arm:");
                        Console.WriteLine($"###Energy consumption: {arm.EnergyConsumption}");
                        Console.WriteLine($"###Reach: {arm.ArmReachDistance}");
                        Console.WriteLine($"###Fingers: {arm.FingersCount}");
                    }
                    foreach (var leg in robot.Legs.OrderBy(l => l.EnergyConsumption).Take(2))
                    {
                        Console.WriteLine("#Leg:");
                        Console.WriteLine($"###Energy consumption: {leg.EnergyConsumption}");
                        Console.WriteLine($"###Strength: {leg.Strength}");
                        Console.WriteLine($"###Speed: {leg.Speed}");
                    }
                }
            }
            else
            {
                Console.WriteLine("We need more parts!");
            }
        }
    }
}