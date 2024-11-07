namespace MagicDestroyers.Characters.Spellcasters
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters.Enumerations;  

    class Mage : Spellcaster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODYARMOR = new ClothRobe();

        /*private ClothRobe bodyArmor;
        private Staff weapon;


        
        public ClothRobe BodyArmor 
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Staff Weapon 
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }*/

        public Mage()
            : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {
        }
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.MANA_POINTS)

        {
        }
        public Mage(string name, int level,int manaPoints)
            :base(name,level,manaPoints)
        {
            base.HealthPoints = Consts.Mage.HEALTH_POINTS;
            base.Faction = Consts.Mage.FACTION;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;

        }



        public int ArcaneWrath()
        {
            throw new NotImplementedException();

        }
        public int Fireball()
        {
            return base.Weapon.Damage + 10;
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;

        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override int Defend()
        {
            return Meditation();
        }
    }
}

