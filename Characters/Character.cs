﻿using COMPLETE_OOP_CODE.Characters.Enumerations;
using COMPLETE_OOP_CODE.Characters.Interfaces;
using COMPLETE_OOP_CODE.Weapons;


namespace COMPLETE_OOP_CODE.Characters
{
     public abstract class Character : IAttack,IDefence
    {
        private Factions faction;
        private string name;
        private int healthPoints;
        private int level;
        private Armor bodyArmor;
        private Weapon weapon;
        private bool isAlive;
        private int scores;
        public Factions Faction
        {
            get
            {
                return faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Innapropriate value!");
                    this.name = "Unknown";
                }
            }
        }
        
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!");
                    this.healthPoints = 0;
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!");
                    this.level = 0;
                }
            }
        }

        public bool IsAlive {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value; 
            }
        }
        public int Scores
        {
            get
            {
                return this.scores;   
            }
            set
            {
                this.scores = value;
            }
        }
        public Armor BodyArmor
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
        public Weapon Weapon
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

        public Character()
        { 
        }

        public Character(string name, int level)
        { 
            this.name = name;
            this.level = level;
        }

        public abstract int Attack();


        public abstract int SpecialAttack();


        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("HaHa! Your Damage was not enough to harm me.");
            }

            if (!this.IsAlive)
            {
                Console.WriteLine($"{this.name} recived {damage} from {attackerName}, and he is dead now.");
            }
            else 
            {
                Console.WriteLine($"{this.name} recived {damage} damage, and now has {this.healthPoints} health points.");
            }
        }


        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }

  
}
