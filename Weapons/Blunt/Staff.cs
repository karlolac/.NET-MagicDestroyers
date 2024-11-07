using COMPLETE_OOP_CODE.Weapons.Blunt;
    class Staff : Blunt
    {

    private const int DEFAULT_DAMAGE_POINTS = 10;

    public Staff()
        : this(DEFAULT_DAMAGE_POINTS)
    {
    }

    public Staff(int armorPoints)
    {
        this.Damage = armorPoints;
    }
    public void Empower()
        {

        }
    }
