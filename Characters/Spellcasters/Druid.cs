namespace MagicDestroyers.Characters.Spellcasters
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters.Enumerations;
 
    class Druid : Spellcaster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();

      /*
        private LeatherVest bodyArmor;
        private Staff weapon;


      
        public LeatherVest BodyArmor 
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.BodyArmor = value;
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
        }
      */
        public Druid()
            : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {
        }
        public Druid(string name, int level)
            : this(name, level, Consts.Druid.MANA_POINTS)

        {
        }
        public Druid(string name, int level, int manaPoints)
        :base (name,level,manaPoints)
        {
           
            base.HealthPoints = Consts.Druid.HEALTH_POINTS;
            base.Faction = Consts.Druid.FACTION;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }


        public int Moonfire()
        {
            return base.Weapon.Damage + 10;
        }
        public int Starburst()
        {
            throw new NotImplementedException();
        }
        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}

