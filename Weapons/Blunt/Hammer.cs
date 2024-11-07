using COMPLETE_OOP_CODE.Weapons.Blunt;
    class Hammer : Blunt
    {

    private const int DEFAULT_DAMAGE_POINTS = 10;

    public Hammer()
        : this(DEFAULT_DAMAGE_POINTS)
    {
    }

    public Hammer(int armorPoints)
    {
        this.Damage = armorPoints;
    }
    public void Stun()
        {

        }
    }


