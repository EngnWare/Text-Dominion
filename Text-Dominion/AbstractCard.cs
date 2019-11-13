using System;

namespace CrypDominion
{
    public abstract class AbstractCard
    {
        //Why shouldn't we take an abstract class and implement it for every card?
        public string Name;
        public string Type;
        public byte Cost;

        public abstract double Buy();
        public abstract bool Play();
    }

    public class BaseCard : AbstractCard
    {
        public BaseCard(string name, string type, byte cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
        }

        public override double Buy()
        {
            Console.WriteLine($"Subtract {Cost} from player.Treasure");
            return new double();
        }

        public override bool Play()
        {
            Console.WriteLine("Give player basic play.");
            return true;
        }
    }

    public class Copper : BaseCard
    {
        public Copper() : base("Copper", "Treasure", 0)
        {
        }

        private readonly byte _plusMoney = 1;
    }

    public class Engineer : BaseCard
    {
        public Engineer() : base("Engineer", "Action", 0)
        {
        }

        public override double Buy()
        {
            Console.WriteLine($"Give the player {_debt} debt.");
            return  new double();
        }

        private byte _debt = 4;
    }
}
