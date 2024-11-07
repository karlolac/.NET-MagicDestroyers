using COMPLETE_OOP_CODE.Characters;

public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.manaPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!");
                    this.manaPoints = 0;
                }
            }
        }
    
    public Spellcaster (string name, int level, int manaPoints)
    :base(name,level)
    {
        base.Name = name;
        base.Level = level;
        this.ManaPoints = manaPoints;

    }
}
