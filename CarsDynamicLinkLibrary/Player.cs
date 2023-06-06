using System.Collections.Generic;
using System;
using CarsDynamicLinkLibrary.Core;
using CarsDynamicLinkLibrary.ExceptionClass;

namespace CarsDynamicLinkLibrary
{
    [Serializable]
    public class Player
    {
        private int _levelpoints;
        private int _level;
        private double _chance;
        private int _health;
        private readonly int _healprice = 10;
        public double Money { get; set; }
        public int Points { get; set; }
        public List<Car> Cars { get; set; }
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                if (_level < 100 || _level + value <= 100)
                {
                    _level = value;
                }
            }
        }

        public int LevelPoints
        {
            get
            {
                return _levelpoints;
            }
            set
            {
                if (_levelpoints < 100)
                {
                    if (_levelpoints + value > 99)
                    {
                        if (Level < 100)
                        {
                            _levelpoints = 0;
                            Level++;
                        }
                        else
                        {
                            _levelpoints = 100;
                        }
                    }
                    else
                    {
                        _levelpoints = value;
                    }
                }
            }
        }

        public double Chance
        {
            get
            {
                return _chance;
            }
            set
            {
                if (_chance < 100 || _chance + value <= 100)
                {
                    _chance = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (_health <= 100)
                {
                    _health = value;
                }
            }
        }
        
        public void Heal()
        {
            if (Money < _healprice * (100 - Health))
            {
                throw new NoMoneyException();
            }
            else
            {
                Money -= _healprice * (100 - Health);
                Health = Health + 100 - Health;
            }
        }

        public Player()
        {
            Money = 1000;
            Points = 0;
            Level = 1;
            LevelPoints = 0;
            Chance = 15;
            Health = 100;
            Cars = new List<Car>();
        }
    }
}
