public class Armor
{

    private int armorPoints;
    public int ArmorPoints
    {
        get
        {
            return this.armorPoints;
        }
        set
        {
            if (value >= 1)
            {
                this.armorPoints = value;
            }
            else
            {
                Console.WriteLine("Inappropriate value!");
                this.armorPoints = 1;
            }
        }
    }

}

