using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterRedactor
{
    class Mage : ICharacter
    {
        public string Name { get; set; } = "New Mage";

        private int _strength = 15;
        public int Strength     
        {
            get { return _strength; }
            set 
            {
                if (value < 15)
                {
                    _strength = 15;
                }
                else if (value > 45)
                {
                    _strength = 45;
                }
                else
                {
                    _strength = value;
                }
            }
        }
        private int _dexterity = 20;

        public int Dexterity
        {
            get { return _dexterity; }
            set 
            {
                if (value < 20)
                {
                    _dexterity = 20;
                }
                else if (value > 70)
                {
                    _dexterity = 70;
                }
                else
                {
                    _dexterity = value;
                }
            }
        }
        private int _intelligence = 35;

        public int Intelligence
        {
            get { return _intelligence; }
            set 
            {
                if (value < 35)
                {
                    _intelligence = 35;
                }
                else if (value > 250)
                {
                    _intelligence = 250;
                }
                else
                {
                    _intelligence = value;
                }
            }
        }
        private int _constitution = 15;

        public int Constitution
        {
            get { return _constitution; }
            set 
            {
                if (value < 15)
                {
                    _constitution = 15;
                }
                else if (value > 70)
                {
                    _constitution = 70;
                }
                else
                {
                    _constitution = value;
                }
            }
        }

        public int Level { get; set; } = 1;

        //private double _health;
        //public double Health
        //{
        //    get { return _health; }
        //    set 
        //    { 
        //        _health = Constitution * 2 + Strength * 0.5;
        //    }
        //}

        //private int _mana;
        //public int Mana
        //{
        //    get { return _mana; }
        //    set 
        //    {
        //        _mana = Intelligence * 2; 
        //    }
        //}

        public int Experience { get; set; } = 0;
        
        public double CritChance()
        {
            return Dexterity * 0.3 + 5;
        }

        public double CritDamage()
        {
            return Dexterity * 0.5 + 2;
        }

        public double CriticalAttack()
        {
            return PhysicalAttack() + CritDamage();
        }

        public double MagicalAttack()
        {
            return Intelligence * 0.3;
        }

        public double MagicalDefence()
        {
            return Intelligence * 0.1;
        }

        public double PhysicalAttack()
        {
            return Strength * 0.5 + Dexterity * 0.2;
        }

        public double PhysicalDefence()
        {
            return Dexterity * 0.2 + Constitution * 0.3;
        }

        public double Health()
        {
            return Constitution * 2 + Strength * 0.5;
        }

        public int Mana()
        {
            return Intelligence * 2;
        }

        public Mage(string name, int strength, int dexterity, int intelligence, int constitution)
        {
            Name = name;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
        }
        public Mage() 
        {

        }
    }
}
