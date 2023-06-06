using System.Windows.Forms;
using System;
using CarsDynamicLinkLibrary.Core;
using CarsDynamicLinkLibrary.ExceptionClass;

namespace CarsMain
{
    public partial class Garage : Form
    {
        private ICar _car;
        public Garage()
        {
            _car = new Car();
            InitializeComponent();
        }
        private void RepairClick(object sender, MouseEventArgs e)
        {
            try
            {
                var index = CarGarage.SelectedIndex;

                _car.Repair(index, Main.player.Cars, Main.player);
                DamageL.Text = Main.player.Cars[index].Damage.ToString() + " %";
                RepairPriceL.Text = Main.player.Cars[index].RepairPrice.ToString() + " $";
                SellPriceL.Text = Main.player.Cars[index].Price.ToString() + " $";
                Main.main.MoneyL.Text = Main.player.Money.ToString() + " $";
            }
            catch (NoMoneyException ex)
            {
                ex.NoEnoughMoney("No enough money to repair this car.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No cars to repair.", "Empty Garage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SellClick(object sender, MouseEventArgs e)
        {
            try
            {
                var index = CarGarage.SelectedIndex;

                _car.Sell(index, Main.player.Cars, Main.player);
                Main.main.MoneyL.Text = Main.player.Money.ToString() + " $";

                if (index > -1)
                {
                    CarGarage.Items.RemoveAt(index);
                  
                    if (CarGarage.TopIndex == index)
                    {
                        CarGarage.SetSelected(index, true);
                    }
                    else
                    {
                        CarGarage.SetSelected(index - 1, true);
                    }
                }
                else
                {
                    CarGarage.ClearSelected();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
               MessageBox.Show("No cars to sell.", "Empty Garage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CarGarage.SelectedIndex;

            if (index > -1)
            {
                DamageL.Text = Main.player.Cars[index].Damage.ToString() + " %";
                RepairPriceL.Text = Main.player.Cars[index].RepairPrice.ToString() + " $";
                SellPriceL.Text = Main.player.Cars[index].Price.ToString() + " $";
            }
            else
            {
                DamageL.Text = "0 %";
                RepairPriceL.Text = "0 $";
                SellPriceL.Text = "0 $";
            }
        }

        private void GarageLoad(object sender, EventArgs e)
        {
            CarGarage.Items.Clear();

            foreach (var car in Main.player.Cars)
            {
                CarGarage.Items.Add(car.Brand);
            }

            try
            {
                CarGarage.SetSelected(0, true);
            }
            catch (ArgumentOutOfRangeException)
            {
                CarGarage.ClearSelected();
            }
        }

        private void GarageClosed(object sender, FormClosedEventArgs e)
        {
            CarGarage.Items.Clear();
            DamageL.Text = "0 %";
            RepairPriceL.Text = "0 $";
            SellPriceL.Text = "0 $";
        }
    }
}
