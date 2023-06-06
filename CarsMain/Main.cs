using System.Windows.Forms;
using System;
using CarsDynamicLinkLibrary;
using CarsDynamicLinkLibrary.IO;
using CarsDynamicLinkLibrary.Core;
using CarsDynamicLinkLibrary.ExceptionClass;
using System.IO;

namespace CarsMain
{
    public partial class Main : Form
    {
        private readonly string _filepath = @"save\savegame.bin";
        private readonly string _directory = @"save";
        private ICar _car;
        private Garage _garage;
        private Random _random;
        public static Player player;
        public static Main main;
        public Main()
        {
            InitializeComponent();
            _car = new Car();
            _garage = new Garage();
            _random = new Random();
            player = new Player();
            main = this;
        }

        private void GarageClick(object sender, MouseEventArgs e)
        {
            _garage.ShowDialog();
        }

        private void StoleClick(object sender, MouseEventArgs e)
        {
            if (_car.IsStolen(player.Chance, player))
            {
                var price = _random.Next(2000, 50001);
                var damage = _random.Next(10, 61);
                Type type = typeof(CarBrands);
                Array values = type.GetEnumValues();
                int index = _random.Next(values.Length);
                CarBrands carbrand = (CarBrands)values.GetValue(index);

                if (player.Health <= 0)
                {
                    MessageBox.Show("You died.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    player = FileManager.NewGame();

                    try
                    {
                        if (!Directory.Exists(_directory))
                        {
                            Directory.CreateDirectory(_directory);
                        }

                        FileManager.SaveGame(_filepath, player);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error has occurted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    InitComponents();
                }
                else
                {
                    var car = new Car(carbrand.ToString(), price, damage);

                    MessageBox.Show("Car is stollen.", "Stole car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    player.Cars.Add(car);
                    _garage.CarGarage.Items.Add(car.Brand);
                    InitComponents();
                }
            }
            else
            {
                MessageBox.Show("Car is not stollen.", "Stole car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewClick(object sender, EventArgs e)
        {
            player = FileManager.NewGame();

            try
            {
                if (!Directory.Exists(_directory))
                {
                    Directory.CreateDirectory(_directory);
                }

                FileManager.SaveGame(_filepath, player);
            }
            catch (Exception)
            {
                MessageBox.Show("Error has occurted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitComponents();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(_directory))
                {
                    Directory.CreateDirectory(_directory);
                }

                FileManager.SaveGame(_filepath, player);
            }
            catch (Exception)
            { 
                MessageBox.Show("Error has occurted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainLoad(object sender, EventArgs e)
        {
            try
            {
                player = FileManager.LoadGame(_filepath);
                InitComponents();
            }
            catch (FileNotFoundException)
            {
                player = FileManager.NewGame();
                InitComponents();
            }
            catch (Exception)
            {
                player = FileManager.NewGame();
                InitComponents();
            }
        }

        private void HealClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (player.Health == 100)
                {
                    MessageBox.Show("You are fully healed.", "Heal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    player.Heal();
                    InitComponents();
                }      
            }
            catch (NoMoneyException ex)
            {
                ex.NoEnoughMoney("No enough money to heal.");
            }
        }

        private void InitComponents()
        {
            MoneyL.Text = player.Money.ToString() + " $";
            PointsL.Text = player.Points.ToString();
            LevelL.Text = player.Level.ToString();
            LevelProgress.Value = player.LevelPoints;
            Health.Value = player.Health;
            ChanceL.Text = player.Chance.ToString() + " %";
        }
    }
}
