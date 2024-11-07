using COMPLETE_OOP_CODE.Weapons.Sharp;

    public class Axe : Sharp
    {
    private const int DEFAULT_DAMAGE_POINTS = 10;

    public Axe()
        : this(DEFAULT_DAMAGE_POINTS)
    {
    }

    public Axe(int armorPoints)
    {
        this.Damage = armorPoints;
    }

    public void HackNSlash()
        {

        }
    }
