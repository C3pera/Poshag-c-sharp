namespace All_Classes
{
    public class CreaturesStats
    {
        public int hp;
        public int attack;
        public int strongAttack;
        public int weapon;
        public int fatigue;
    }

    public class Weapons
    {
        public string WeaponName = "";
        public int WeaponDmg;

        public void PrintWeaponList()
        {
            Console.WriteLine(WeaponName);
        }
    }
}