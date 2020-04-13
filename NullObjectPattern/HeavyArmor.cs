namespace NullObjectPattern
{
    internal class HeavyArmor : IArmor
    {
        private const int DefenseBonus = 2;

        public int GetArmorDefenseBonus()
        {
            return DefenseBonus;
        }
    }
}
