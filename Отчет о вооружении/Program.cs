using System;
using System.Collections.Generic;
using System.Linq;

namespace Отчет_о_вооружении
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit militaryUnit = new MilitaryUnit();

            militaryUnit.CreateRequest();
        }
    }

    class Soldier
    {
        public Soldier(string name, string weapon, string militaryRank, int serviceLife) 
        { 
            Name = name;
            Weapon = weapon;
            MilitaryRank = militaryRank;
            ServiceLife = serviceLife;
        }

        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string MilitaryRank { get; private set; }
        public int ServiceLife { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}, Оружие: {Weapon}, " +
                              $"Звание: {MilitaryRank}, Срок службы: {ServiceLife}");
        }
    }

    class MilitaryUnit
    {
        private List<Soldier> _soldiers;

        public MilitaryUnit() 
        {
            _soldiers = Create();
        }

        public void CreateRequest()
        {
            ShowAllInfoSoldiers();

            var showSpecificInformation = _soldiers.Select(soldier => new { Name = soldier.Name, MilitaryRank = soldier.MilitaryRank});

            Console.WriteLine("Конкретная информация\n");

            foreach(var soldier in showSpecificInformation)
            {
                Console.WriteLine($"Имя: {soldier.Name}, Звание: {soldier.MilitaryRank}");
            }
        }

        private List<Soldier> Create()
        {
            List<Soldier> soldiers = new List<Soldier>() 
            { 
                new Soldier("Аркадий", "Саперка", "Ефрейтер", 8),
                new Soldier("Григорий", "Базука", "Младший Сержант", 12),
                new Soldier("Степан", "Пистолет", "Прапорщик", 56),
                new Soldier("Алексей", "СВД", "Старший Сержант", 23),
                new Soldier("Николай", "Пулемет", "Младший Лейтенант", 36),
            };

            return soldiers;
        }

        private void ShowAllInfoSoldiers()
        {
            Console.WriteLine("Полная информация о солдатах");

            foreach (Soldier soldier in _soldiers)
            {
                soldier.ShowInfo();
            }
        }
    }
}
