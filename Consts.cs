using COMPLETE_OOP_CODE.Characters.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_OOP_CODE
{
    public static class Consts
    {
        public static class Warrior 
        {
            public const string NAME = "Warrior";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 120;
            public const Factions FACTION = Factions.Melle;

        }

        public static class Mage
        {
            public const string NAME = "Mage";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;
        }

        public static class Necromancer
        { 
            public const string NAME = "Necromancer";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;
        }

        public static class Knight
        {
            public const string NAME = "Knight";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Melle;
        }

        public static class Druid 
        {
            public const string NAME = "Druid";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;

        }

        public static class Assasin
        {
            public const string NAME = "Assasin";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Melle;
        }

    }
}
