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
        Warrior warrior;
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
            main_label.Content = $"Name {mage.Name}, strength {mage.Strength}, dexternity {mage.Dexterity}, " +
                $"\nintelligence {mage.Intelligence}, constitution {mage.Constitution}, PAttack {mage.PhysicalAttack()}," +
                $"\nPAttack Crit {mage.CriticalAttack()}, PDef {mage.PhysicalDefence()}, MDef {mage.MagicalDefence()}," +
                $"\nCrit Chance {mage.CritChance()}, Bonus Crit Dmg {mage.CritDamage()}" +
                $"\nlvl {mage.Level}, health {mage.Health()}, mana {mage.Mana()}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            defaultMage.Strength++;
            UpdateDescriptionLabel(defaultMage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            defaultMage.Strength--;
            UpdateDescriptionLabel(defaultMage);
        }

        //private void plus_health_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string hp = Convert.ToString(health_label.Content);
        //    mage.Health = Convert.ToInt32(hp.Substring(8));
        //    mage.Health = mage.Health + 10;
        //    health_label.Content = $"Health: {mage.Health}";
        //    UpdateDescriptionLabel(mage);            
        //}

        //private void minus_health_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string hp = Convert.ToString(health_label.Content);
        //    mage.Health = Convert.ToInt32(hp.Substring(8));
        //    mage.Health = mage.Health - 10;
        //    health_label.Content = $"Health: {mage.Health}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void plus_damage_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string dmg = Convert.ToString(damage_label.Content);
        //    mage.Damage = Convert.ToInt32(dmg.Substring(8));
        //    mage.Damage = mage.Damage + 2;
        //    damage_label.Content = $"Damage: {mage.Damage}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void minus_damage1_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string dmg = Convert.ToString(damage_label.Content);
        //    mage.Damage = Convert.ToInt32(dmg.Substring(8));
        //    mage.Damage = mage.Damage - 2;
        //    damage_label.Content = $"Damage: {mage.Damage}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void plus_attackspeed_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string cast = Convert.ToString(casttime_label.Content);
        //    mage.CastTime = Convert.ToDouble(cast.Substring(11));
        //    mage.CastTime = mage.CastTime - 0.1;
        //    casttime_label.Content = $"Cast time: {mage.CastTime}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void minus_attackspeed_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string cast = Convert.ToString(casttime_label.Content);
        //    mage.CastTime = Convert.ToDouble(cast.Substring(11));
        //    mage.CastTime = mage.CastTime + 0.1;
        //    casttime_label.Content = $"Cast time: {mage.CastTime}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void plus_resource_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string mana = Convert.ToString(mana_label.Content);
        //    mage.Mana = Convert.ToInt32(mana.Substring(6));
        //    mage.Mana = mage.Mana + 5;
        //    mana_label.Content = $"Mana: {mage.Mana}";
        //    UpdateDescriptionLabel(mage);
        //}

        //private void minus_resource_Click(object sender, RoutedEventArgs e)
        //{
        //    Mage mage = new Mage();
        //    string mana = Convert.ToString(mana_label.Content);
        //    mage.Mana = Convert.ToInt32(mana.Substring(6));
        //    mage.Mana = mage.Mana - 5;
        //    mana_label.Content = $"Mana: {mage.Mana}";
        //    UpdateDescriptionLabel(mage);

        //    Mage mage2 = new Mage();

        //}
    }
}
