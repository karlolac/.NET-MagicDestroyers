namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE;
    using COMPLETE_OOP_CODE.Characters;
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;
 
    public class Warrior : Melee
    {
        private readonly Axe DEFAULT_WEAPON=new Axe();
        private readonly ChainLink DEFAULT_BODYARMOR=new ChainLink();

     
        public Warrior()
            :this(Consts.Warrior.NAME,Consts.Warrior.LEVEL)
        {
        }
        public Warrior(string name, int level)
            :this(name,level,Consts.Warrior.HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        : base(name, level, healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Warrior.FACTION;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.Damage + 10;
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int  SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }


        public override int Attack()
        {
           return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override  int Defend()
        {
            return this.SkinHarden();
        }
    }
}
