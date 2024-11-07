namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;


    class Knight : Melee
    {
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly ChainLink DEFAULT_BODYARMOR = new ChainLink();


        /*
        private ChainLink bodyArmor;
        private Hammer weapon;

       
        public ChainLink BodyArmor
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
        public Hammer Weapon 
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
        public Knight()
            : this(Consts.Knight.NAME, Consts.Knight.LEVEL)
        {
        }

        public Knight(string name, int level)
             : this(name, level, Consts.Knight.ABILITY_POINTS)

        {
        }

        public Knight(string name, int level,int abilityPoints)
        :base(name,level,abilityPoints)
        {
            
            base.HealthPoints = Consts.Knight.HEALTH_POINTS;
            base.Faction = Consts.Knight.FACTION;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }



        public int HolyBlow()
        {
            return base.Weapon.Damage + 10;
        }
        public int PurifySoul()
        {
            throw new NotImplementedException();

        }
        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();  
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}

