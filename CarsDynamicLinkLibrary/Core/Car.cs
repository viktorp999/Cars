using System;
using System.Collections.Generic;
using CarsDynamicLinkLibrary.ExceptionClass;
using System.Windows.Forms;

namespace CarsDynamicLinkLibrary.Core
{
    [Serializable]
    public class Car : ICar
    {
        private double _repairPrice;
        private double _price;
        private readonly double _chancepoints = 0.5;
        private Random _random = new Random();
        public string Brand { get; private set; }
        public int Damage { get; private set; }
        public double Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value;
            }
        }

        public double RepairPrice
        {
            get
            {
                return _repairPrice;
            }
            private set
            {
                _repairPrice = value;
            }
        }

        public bool IsStolen(double chance, Player player)
        {
            var ch = (int)Math.Round(chance);
            var range = _random.Next(1, 101);
            
            if (range < ch)
            {
                var levelpoints = _random.Next(1, 6);
                var points = _random.Next(1, 51);
                var healthminus = _random.Next(10, 21);
                player.Chance += _chancepoints;
                player.LevelPoints += levelpoints;
                player.Points += points;
                player.Health -= healthminus;

                return true;
            }

            return false;
        }

        public void Sell(int index, List<Car> cars, Player player)
        {
            player.Money += cars[index].Price;
            cars.RemoveAt(index);
        }

        public void Repair(int index, List<Car> cars, Player player)
        {
            if (player.Money < cars[index].RepairPrice)
            {
                throw new NoMoneyException();
            }
            else if (cars[index].Damage == 0)
            {
                MessageBox.Show("Car is alredy reparied.", "Repair", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cars[index].Price += cars[index].RepairPrice;
                player.Money -= cars[index].RepairPrice;
                cars[index].Damage = 0;
                cars[index].RepairPrice = 0;
            }
        }

        public Car()
        {

        }

        public Car(string brand, int price, int damage)
        {
            Brand = brand;
            Damage = damage;
            _price = price - (price * Damage / 100);
            _repairPrice = (_price * Damage / 100);
        }
    }
}
