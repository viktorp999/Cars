using CarsDynamicLinkLibrary;
using CarsDynamicLinkLibrary.Core;
using CarsDynamicLinkLibrary.ExceptionClass;
using NUnit.Framework;
using System.Collections.Generic;

namespace CarsUnitTests
{
    [TestFixture]
    public class CarTests
    {
        private ICar _car;
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _car = new Car();
            _player = new Player();
        }

        [Test]
        public void IsStolen_Succeed_ReturnsTrue()
        {
            var stole = _car.IsStolen(100, _player);

            Assert.Multiple(() =>
            {
                Assert.That(stole, Is.EqualTo(true));
                Assert.That(_player.Chance, Is.EqualTo(15.5));
                Assert.That(_player.LevelPoints, Is.InRange(1, 5));
                Assert.That(_player.Points, Is.InRange(1, 50));
                Assert.That(_player.Health, Is.InRange(80, 90));
            });
        }

        [Test]
        public void IsStolen_NotSucceed_ReturnsFalse()
        {
            var stole = _car.IsStolen(0, _player);

            Assert.That(stole, Is.EqualTo(false));
        }

        [Test]
        public void Sell_ShouldRemoveCarFromPlayerCarsAndGivePlayerCarMoneyNoDamageOnCar()
        {
            var player = new Player
            {
                Cars = new List<Car>()
                {
                    new Car("A", 100, 0)
                },

                Money = 100
            };

            _car.Sell(0, player.Cars, player);

            Assert.Multiple(() =>
            {
                Assert.That(player.Cars, Is.Empty);
                Assert.That(player.Money, Is.EqualTo(200));
            });
        }

        [Test]
        public void Sell_ShouldRemoveCarFromPlayerCarsAndGivePlayerCarMoneyWithDamageOnCar()
        {
            var player = new Player
            {
                Cars = new List<Car>()
                {
                    new Car("A", 100, 10)
                },

                Money = 100
            };

            _car.Sell(0, player.Cars, player);

            Assert.Multiple(() =>
            {
                Assert.That(player.Cars, Is.Empty);
                Assert.That(player.Money, Is.EqualTo(190));
            });
        }

        [Test]
        public void Repair_IfPlayerDoesNotHaveMoneyShouldThrowNoMoneyException()
        {
            var player = new Player
            {
                Cars = new List<Car>()
                {
                    new Car("A", 100, 10)
                },

                Money = 0
            };

            Assert.Throws<NoMoneyException>(() => _car.Repair(0, player.Cars, player));
        }

        [Test]
        public void Repair_ShouldRepaiCar()
        {
            var player = new Player
            {
                Cars = new List<Car>()
                {
                    new Car("A", 100, 10)
                },

                Money = 100
            };

            _car.Repair(0, player.Cars, player);

            Assert.Multiple(() =>
            {
                Assert.That(player.Cars[0].Damage, Is.EqualTo(0));
                Assert.That(player.Cars[0].RepairPrice, Is.EqualTo(0));
                Assert.That(player.Cars[0].Price, Is.EqualTo(100));
                Assert.That(player.Money, Is.EqualTo(90));
            });
        }
    }
}
