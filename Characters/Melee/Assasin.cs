
namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;
   

    class Assasin : Melee
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();

        
        private LeatherVest bodyArmor;
        private Sword weapon;

       
        public LeatherVest BodyArmor
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
        public Sword Weapon
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
        

        public Assasin()
            : this(Consts.Assasin.NAME, Consts.Assasin.LEVEL)
        {
        }
        public Assasin(string name, int level)
            : this(name, level, Consts.Assasin.ABILITY_POINTS)

        {
        }

        public Assasin(string name, int level, int abilityPoints)
         :base(name,level,abilityPoints)
        {
            base.HealthPoints = Consts.Assasin.HEALTH_POINTS;
            base.Faction = Consts.Assasin.FACTION;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }



        public int Raze()
        {
            return base.Weapon.Damage + 10;
        }
        public int Bleed()
        {
            throw new NotImplementedException();

        }
        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.Bleed();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }

}

