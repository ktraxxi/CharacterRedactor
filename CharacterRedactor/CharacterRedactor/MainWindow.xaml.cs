using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterRedactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mage defaultMage = new Mage();
        //Warrior warrior;
        //Archer archer;
       
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            UpdateDescriptionLabel(defaultMage);
        }
        private void UpdateDescriptionLabel(Mage mage)
        {
            main_label.Content = $"Character stats\n\nClass: {mage.ToString().Substring(18)} \nName: {mage.Name} " +
                $"\nLevel: {mage.Level} \nTalent Points: {mage.Talents} \nExperience: {mage.Experience} \nHealth: {mage.Health()}" +
                $"\nMana: {mage.Mana()}\n\nStrength: {mage.Strength} \nDexternity: {mage.Dexterity}" +
                $"\nIntelligence: {mage.Intelligence}\nConstitution: {mage.Constitution}" +
                $"\n\nMagic Attack: {mage.MagicalAttack()} \nPhys Attack: {mage.PhysicalAttack()}" +
                $"\nPhys Attack Critical: {mage.CriticalAttack()} \nCrit Chance: {mage.CritChance()}" +
                $"\nBonus Critical Damage: {mage.CritDamage()} " +
                $"\n\nPhys Defence: {mage.PhysicalDefence()}, \nMagic Defence: {mage.MagicalDefence()}";
        }
        private void plusstr_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 0 && defaultMage.Strength != 45)
            {                
                defaultMage.Strength++;
                defaultMage.Talents--;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void minusstr_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 245 && defaultMage.Strength != 15)
            {
                defaultMage.Strength--;
                defaultMage.Talents++;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void plusdex_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 0 && defaultMage.Dexterity != 70)
            {
                defaultMage.Dexterity++;
                defaultMage.Talents--;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void minusdex_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 245 && defaultMage.Dexterity != 20)
            {
                defaultMage.Dexterity--;
                defaultMage.Talents++;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void plusint_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 0 && defaultMage.Intelligence != 250)
            {
                defaultMage.Intelligence++;
                defaultMage.Talents--;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void minusint_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 245 && defaultMage.Intelligence != 35)
            {
                defaultMage.Intelligence--;
                defaultMage.Talents++;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void plusconst_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 0 && defaultMage.Constitution != 70)
            {
                defaultMage.Constitution++;
                defaultMage.Talents--;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void minusconst_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Talents != 0 && defaultMage.Constitution != 15)
            {
                defaultMage.Constitution--;
                defaultMage.Talents++;
            }
            UpdateDescriptionLabel(defaultMage);
        }

        int[] experienceValue = new int[51];
        private void xp1k_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Level < 50)
            {
                int tempXP = 0;
                for (int level = 0; level < experienceValue.Length; level++)
                {
                    int step = 1000;
                    experienceValue[level] = tempXP +  step * level;
                    tempXP += step * level;
                }
                defaultMage.Experience += 1000;
                
                for (int i = 0; i < experienceValue.Length; i++)
                {
                    if (defaultMage.Experience >= experienceValue[i] && defaultMage.Experience < experienceValue[i + 1])
                    {
                        int tempLvl = defaultMage.Level;
                        defaultMage.Level = i + 1;
                        defaultMage.Talents += (defaultMage.Level - tempLvl) * 5;
                    }
                }
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void xp5k_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Level < 50)
            {
                int tempXP = 0;
                for (int level = 0; level < experienceValue.Length; level++)
                {
                    int step = 1000;
                    experienceValue[level] = tempXP + step * level;
                    tempXP += step * level;
                }
                defaultMage.Experience += 5000;

                for (int i = 0; i < experienceValue.Length; i++)
                {
                    if (defaultMage.Experience >= experienceValue[i] && defaultMage.Experience < experienceValue[i + 1])
                    {
                        int tempLvl = defaultMage.Level;
                        defaultMage.Level = i + 1;
                        defaultMage.Talents += (defaultMage.Level - tempLvl) * 5;
                    }
                }
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void xp10k_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Level < 50)
            {
                int tempXP = 0;
                for (int level = 0; level < experienceValue.Length; level++)
                {
                    int step = 1000;
                    experienceValue[level] = tempXP + step * level;
                    tempXP += step * level;
                }
                defaultMage.Experience += 10000;

                for (int i = 0; i < experienceValue.Length; i++)
                {
                    if (defaultMage.Experience >= experienceValue[i] && defaultMage.Experience < experienceValue[i + 1])
                    {
                        int tempLvl = defaultMage.Level;
                        defaultMage.Level = i + 1;
                        defaultMage.Talents += (defaultMage.Level - tempLvl) * 5;
                    }
                }
            }
            UpdateDescriptionLabel(defaultMage);
        }

        private void XPfull_Click(object sender, RoutedEventArgs e)
        {
            if (defaultMage.Level < 50)
            {
                int tempXP = 0;
                for (int level = 0; level < experienceValue.Length; level++)
                {
                    int step = 1000;
                    experienceValue[level] = tempXP + step * level;
                    tempXP += step * level;
                }
                defaultMage.Experience += 1225000 - defaultMage.Experience;

                for (int i = 0; i < experienceValue.Length; i++)
                {
                    if (defaultMage.Experience >= experienceValue[i] && defaultMage.Experience < experienceValue[i + 1])
                    {
                        int tempLvl = defaultMage.Level;
                        defaultMage.Level = i + 1;
                        defaultMage.Talents += (defaultMage.Level - tempLvl) * 5;
                    }
                }
            }
            UpdateDescriptionLabel(defaultMage);
        }
        private void createCharBtn_Click(object sender, RoutedEventArgs e)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Characters");
            var collection = database.GetCollection<Mage>("Mages");

            defaultMage.Name = Name_textbox.Text;

            collection.InsertOne(defaultMage);
        }
    }
}
