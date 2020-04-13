namespace NullObjectPattern
{
    internal class NoArmor : IArmor
    {
        private const int DefenseBonus = 1;

        public int GetArmorDefenseBonus()
        {
            return DefenseBonus;
        }
    }
}