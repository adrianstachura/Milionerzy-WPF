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
using System.Windows.Shapes;

namespace Milionerzy_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy EndWindow.xaml
    /// </summary>
    public partial class EndWindow : Window
    {
        public EndWindow()
        {
            InitializeComponent();
        }

        public void EndGame()
        {
            if (GameWindow.Score < 2)
            {
                Reward.Text = Rewards.Reward0;
            }

            else if (GameWindow.Score >= 2 && GameWindow.Score < 7)
            {
                Reward.Text = Rewards.Reward2;
            }
            else if (GameWindow.Score >= 7 && GameWindow.Score < 12)
            {
                ; Reward.Text = Rewards.Reward7;
            }
            else if (GameWindow.Score == 12)
            {
                Reward.Text = Rewards.Reward12;
            }
        }

        public void EndGameEarly()
        {
            if (GameWindow.Score == 0)
            {
                Reward_Copy.Text = Rewards.Reward0;
            }
            else if (GameWindow.Score == 1)
            {
                Reward_Copy.Text = Rewards.Reward1;
            }
            else if (GameWindow.Score == 2)
            {
                Reward_Copy.Text = Rewards.Reward2;
            }
            else if (GameWindow.Score == 3)
            {
                Reward_Copy.Text = Rewards.Reward3;
            }
            else if (GameWindow.Score == 4)
            {
                Reward_Copy.Text = Rewards.Reward4;
            }
            else if (GameWindow.Score == 5)
            {
                Reward_Copy.Text = Rewards.Reward5;
            }
            else if (GameWindow.Score == 6)
            {
                Reward_Copy.Text = Rewards.Reward6;
            }
            else if (GameWindow.Score == 7)
            {
                Reward_Copy.Text = Rewards.Reward7;
            }
            else if (GameWindow.Score == 8)
            {
                Reward_Copy.Text = Rewards.Reward8;
            }
            else if (GameWindow.Score == 9)
            {
                Reward_Copy.Text = Rewards.Reward9;
            }
            else if (GameWindow.Score == 10)
            {
                Reward_Copy.Text = Rewards.Reward10;
            }
            else if (GameWindow.Score == 11)
            {
                Reward_Copy.Text = Rewards.Reward11;
            }
            else if (GameWindow.Score == 12)
            {
                Reward_Copy.Text = Rewards.Reward12;
            }
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            Window MWindow = new MainWindow();
            GameWindow.Score = 0;
            MWindow.Show();
            this.Close();
        }




        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
