using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterRedactor
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        public int Level { get; set; }
        //public double Health { get; set; }
        //public int Mana { get; set; }
        public int Experience { get; set; }

        public double Health();
        public int Mana();

        public double PhysicalAttack();

        //return Strength * 0.5 + Dexterity * 0.2;

        public double MagicalAttack();

        //return Intelligence * 0.3;

        public double CriticalAttack();

        // return PhysicalAttack() + CritDamage();

        public double CritChance();

        //return Dexterity * 0.3 + 5;

        public double CritDamage();

        // return Dexterity * 0.5 + 2;

        public double PhysicalDefence();

        //return Dexterity * 0.2 + Constitution * 0.3;

        public double MagicalDefence();
        
            //return Intelligence * 0.1;
        
    }
}
