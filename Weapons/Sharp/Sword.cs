using COMPLETE_OOP_CODE.Weapons.Sharp;

    class Sword : Sharp
    {
    private const int DEFAULT_DAMAGE_POINTS = 10;

    public Sword()
        : this(DEFAULT_DAMAGE_POINTS)
    {
    }

    public Sword(int armorPoints)
    {
        this.Damage = armorPoints;
    }
     public void Bloodthirst()
     {

     }
    }


