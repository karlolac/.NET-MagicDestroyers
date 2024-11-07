namespace COMPLETE_OOP_CODE.Weapons
{
    public abstract class Weapon
    {
        public int damage;
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 1)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!");
                    this.damage = 1;
                }
            }
        }

        protected Weapon()
        { 
        }
    }
}
