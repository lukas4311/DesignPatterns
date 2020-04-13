namespace NullObjectPattern
{
    internal class Player
    {
        private readonly string Name;

        private int Health;

        private IArmor Armor;

        public Player(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Armor = new NoArmor();
        }

        public int GetHeath()
        {
            return this.Health;
        }

        public void TakeArmor(IArmor armor)
        {
            this.Armor = armor;
        }

        public void TakeDamage(int damage)
        {
            this.Health -= damage - damage / (this.Armor.GetArmorDefenseBonus());
        }

        public override string ToString()
        {
            return $"Player: {this.Name}, health: {this.Health}";
        }
    }
}
