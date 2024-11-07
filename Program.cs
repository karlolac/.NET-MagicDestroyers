using COMPLETE_OOP_CODE.Characters;
using COMPLETE_OOP_CODE.Characters.Melee;
using MagicDestroyers.Characters.Melees;
using MagicDestroyers.Characters.Spellcasters;

public class Program
{
    static void Main()
    {
        bool gameOver=false;
        Random random=new Random();

        Melee currentMelee;
        Spellcaster currentSpellcaster;


        List<Melee> meleeTeam = new List<Melee>();
        List<Spellcaster> spellTeam = new List<Spellcaster>();

        List<Character> characters = new List<Character>()
        {
            new Warrior(),
            new Warrior(),
            new Warrior(),
            new Knight(),
            new Assasin(),
            new Mage(),
            new Mage(),
            new Mage(),
            new Necromancer(),
            new Druid()
        };

      

        foreach(var character in characters)
        {
            if (character is Melee)
            {
                meleeTeam.Add((Melee)character);
            }
            else if (character is Spellcaster) 
            {
                spellTeam.Add((Spellcaster)character);
            }
        }
       

        while (!gameOver)
        {
            currentMelee = meleeTeam[random.Next(0, meleeTeam.Count)];
            currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count)];

            currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name);

            if (!currentSpellcaster.IsAlive)
            {
                currentMelee.WonBattle();
                spellTeam.Remove(currentSpellcaster);

                if (spellTeam.Count == 0)
                {
                    Console.WriteLine("Melle team wins!");
                    break;
                }
                else
                {
                    currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count)];
                }
            }

            currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name);

            if (!currentMelee.IsAlive)
            {
                currentMelee.WonBattle();
                meleeTeam.Remove(currentMelee);

                if (meleeTeam.Count == 0)
                {
                    Console.WriteLine("Spell team wins!");
                    break;
                }
                else 
                {
                    currentMelee=meleeTeam[random.Next(0, meleeTeam.Count)];
                }
            }
        }
    }
}