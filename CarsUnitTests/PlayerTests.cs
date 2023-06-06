using CarsDynamicLinkLibrary;
using CarsDynamicLinkLibrary.ExceptionClass;
using NUnit.Framework;

namespace CarsUnitTests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerLevelShouldNotBeBiggerThanOneHundred()
        {
            var player = new Player
            {
                Level = 100
            };

            player.Level += 1;

            Assert.That(player.Level, Is.EqualTo(100));
        }

        [Test]
        public void PlayerChanceShouldNotBeBiggerThanOneHundred()
        {
            var player = new Player
            {
                Chance = 100
            };

            player.Chance += 1;

            Assert.That(player.Chance, Is.EqualTo(100));
        }

        [Test]
        public void Heal_ShouldThrowNoMoneyExceptionIfPlayerHaveNotMoney()
        {
            var player = new Player
            {
                Health = 90,
                Money = 0
            };

            Assert.Throws<NoMoneyException>(() => player.Heal());
        }

        [Test]
        public void Heal_PlayerHealthShouldBeSetToOneHundred()
        {
            var player = new Player
            {
                Health = 90,
                Money = 200
            };

            player.Heal();

            Assert.Multiple(() =>
            {
                Assert.That(player.Health, Is.EqualTo(100));
                Assert.That(player.Money, Is.EqualTo(100));   
            });
        }

        [Test]
        public void LevelUpIfLevelPointsIsOneHundred()
        {
            var player = new Player
            {
                LevelPoints = 99,
                Level = 1
            };

            player.LevelPoints += 1;

            Assert.Multiple(() =>
            {
                Assert.That(player.LevelPoints, Is.EqualTo(0));
                Assert.That(player.Level, Is.EqualTo(2));
            });
        }

        [Test]
        public void PointsIsOneHundredIfLevelIsOneHoundred()
        {
            var player = new Player
            {
                LevelPoints = 99,
                Level = 100
            };

            player.LevelPoints += 1;

            Assert.Multiple(() =>
            {
                Assert.That(player.LevelPoints, Is.EqualTo(100));
                Assert.That(player.Level, Is.EqualTo(100));
            });
        }
    }
}
