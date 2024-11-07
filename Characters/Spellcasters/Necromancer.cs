namespace MagicDestroyers.Characters.Spellcasters
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters.Enumerations;

    class Necromancer : Spellcaster
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();

        /*private LeatherVest bodyArmor;
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
        }*/


        public Necromancer()
            :this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {
        }
        public Necromancer(string name, int level)
            :this(name,level, Consts.Necromancer.MANA_POINTS)
        {
        }
        public Necromancer(string name, int level, int manaPoints)
        :base (name,level,manaPoints)
        {

            base.HealthPoints = Consts.Necromancer.HEALTH_POINTS;
            base.Faction = Consts.Necromancer.FACTION;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
 


        public int ShadowRage()
        {
            return base.Weapon.Damage+ 10;
        }
        public int VampireTouch()
        {
            throw new NotImplementedException();

        }
        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();   
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }

}

