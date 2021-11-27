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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage("New Mage", 60, 10, 4.0, 100, 100);
            health_label.Content = $"Health: {mage.MinHealth}";
            damage_label.Content = $"Damage: {mage.MinDamage}";
            casttime_label.Content = $"Cast time: {mage.MaxCastTime}";
            mana_label.Content = $"Mana: {mage.MinMana}";
            talents_label.Content = $"Talents points: {mage.MaxTalentPoints}";

            UpdateDescriptionLabel(mage);
        }
        private void UpdateDescriptionLabel(Mage mage)
        {
            string cls = Convert.ToString(mage.GetType());
            
            description_label.Content = $" Character Stats.\n\n Class: {cls.Substring(18)}\n Name: {mage.DefaultName}\n " +
                $"Health: {mage.Health}\n " +
                $"Damage: {mage.Damage}\n Cast time: {mage.CastTime}\n Mana: {mage.Mana}";
        }

        private void plus_health_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string hp = Convert.ToString(health_label.Content);
            mage.Health = Convert.ToInt32(hp.Substring(8));
            mage.Health = mage.Health + 10;
            health_label.Content = $"Health: {mage.Health}";
            UpdateDescriptionLabel(mage);            
        }

        private void minus_health_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string hp = Convert.ToString(health_label.Content);
            mage.Health = Convert.ToInt32(hp.Substring(8));
            mage.Health = mage.Health - 10;
            health_label.Content = $"Health: {mage.Health}";
            UpdateDescriptionLabel(mage);
        }

        private void plus_damage_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string dmg = Convert.ToString(damage_label.Content);
            mage.Damage = Convert.ToInt32(dmg.Substring(8));
            mage.Damage = mage.Damage + 2;
            damage_label.Content = $"Damage: {mage.Damage}";
            UpdateDescriptionLabel(mage);
        }

        private void minus_damage1_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string dmg = Convert.ToString(damage_label.Content);
            mage.Damage = Convert.ToInt32(dmg.Substring(8));
            mage.Damage = mage.Damage - 2;
            damage_label.Content = $"Damage: {mage.Damage}";
            UpdateDescriptionLabel(mage);
        }

        private void plus_attackspeed_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string cast = Convert.ToString(casttime_label.Content);
            mage.CastTime = Convert.ToDouble(cast.Substring(11));
            mage.CastTime = mage.CastTime - 0.1;
            casttime_label.Content = $"Cast time: {mage.CastTime}";
            UpdateDescriptionLabel(mage);
        }

        private void minus_attackspeed_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string cast = Convert.ToString(casttime_label.Content);
            mage.CastTime = Convert.ToDouble(cast.Substring(11));
            mage.CastTime = mage.CastTime + 0.1;
            casttime_label.Content = $"Cast time: {mage.CastTime}";
            UpdateDescriptionLabel(mage);
        }

        private void plus_resource_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string mana = Convert.ToString(mana_label.Content);
            mage.Mana = Convert.ToInt32(mana.Substring(6));
            mage.Mana = mage.Mana + 5;
            mana_label.Content = $"Mana: {mage.Mana}";
            UpdateDescriptionLabel(mage);
        }

        private void minus_resource_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            string mana = Convert.ToString(mana_label.Content);
            mage.Mana = Convert.ToInt32(mana.Substring(6));
            mage.Mana = mage.Mana - 5;
            mana_label.Content = $"Mana: {mage.Mana}";
            UpdateDescriptionLabel(mage);
        }
    }
}
