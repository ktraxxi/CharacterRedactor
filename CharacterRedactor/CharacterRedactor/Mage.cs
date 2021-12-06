using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterRedactor
{
    class Mage : ICharacter
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string Name { get; set; } = "New Mage";

        private int _talents = 0;
        public int Talents
        {
            get { return _talents; }
            set 
            {
                if (value < 0)
                {
                    _talents = 0;
                }
                else if (value > 245)
                {
                    _talents = 245;
                }
                else
                {
                    _talents = value;
                }
            }
        }

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

        private int _level = 1;
        public int Level
        {
            get { return _level; }
            set 
            {
                if (_level > 50)
                {
                    _level = 50;
                }
                else
                {
                    _level = value;
                }

            }
        }

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

        public Mage() {}

        //public Mage(string name)
        //{
        //    Name = name;
        //}
    }
}
