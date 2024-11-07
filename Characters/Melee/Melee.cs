namespace COMPLETE_OOP_CODE.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!");
                    this.abilityPoints = 0;
                }
            }
        }


        public Melee(string name, int level, int abilityPoints)
            :base(name,level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }


    }
}
