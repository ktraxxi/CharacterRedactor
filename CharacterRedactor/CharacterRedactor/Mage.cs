using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterRedactor
{
    class Mage 
    {
        public string DefaultName { get; set; } = "New Mage";
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _minTalentPoints = 0;
        public int MaxTalentPoints { get; set; } = 60;
        private int _talentPoints;
        public int TalentPoints
        {
            get { return _talentPoints; }
            set 
            {
                if (value < _minTalentPoints)
                {
                    _talentPoints = _minTalentPoints;
                }
                else if (value > MaxTalentPoints)
                {
                    _talentPoints = MaxTalentPoints;
                }
                else
                {
                    _talentPoints = value;
                }
            }
        }

       
        public int MinDamage { get; set; } = 10;
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set 
            {
                if (value < MinDamage)
                {
                    _damage = MinDamage;
                }
                else
                {
                    _damage = value;
                }
            }
        }

        private double _minCastTime = 1.0;
        public double MaxCastTime { get; set; } = 4.0;
        private double _castTime;
        public double CastTime
        {
            get { return _castTime; }
            set 
            {
                if (value < _minCastTime)
                {
                    _castTime = _minCastTime;
                }
                else if (value > MaxCastTime)
                {
                    _castTime = MaxCastTime;
                }
                else
                {
                    _castTime = value;
                }
            }
        }

        
        public int MinHealth { get; set; } = 100;
        private int _health;
        public int Health
        {
            get { return _health; }
            set 
            {
                if (value < MinHealth)
                {
                    _health = MinHealth;
                }
                else
                {
                    _health = value; 
                }
            }
        }

        private int MaxMana = 200;
        public int MinMana { get; set; } = 100;
        private int _mana;


        public int Mana
        {
            get { return _mana; }
            set 
            {
                if (value < MinMana)
                {
                    _mana = MinMana;
                }
                else if (value > MaxMana)
                {
                    _mana = MaxMana;
                }
                else
                {
                    _mana = value;
                }
            }
        }


        public Mage()
        {

        }
        public Mage(string DefaultName, int MaxTalentPoints, int MinDamage, double MaxCastTime, int MinHealth, int MinMana)
        {
            this.DefaultName = DefaultName;
            this.MaxTalentPoints = MaxTalentPoints;
            this.MinDamage = MinDamage;
            this.MaxCastTime = MaxCastTime;
            this.MinHealth = MinHealth;
            this.MinMana = MinMana;
        }
    }
}
