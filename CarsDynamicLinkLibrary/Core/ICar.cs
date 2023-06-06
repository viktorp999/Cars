using System.Collections.Generic;

namespace CarsDynamicLinkLibrary.Core
{
    public interface ICar
    {
        string Brand { get; }
        double RepairPrice { get; }
        double Price { get; }
        int Damage { get; }
        bool IsStolen(double chance, Player player);
        void Sell(int index, List<Car> cars, Player player);
        void Repair(int index, List<Car> cars, Player player);
    }
}
