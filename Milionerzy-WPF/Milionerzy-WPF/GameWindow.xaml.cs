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
    /// Logika interakcji dla klasy GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {


        public static int intQuest = 0;
        public static int Score = 0;


        public GameWindow()
        {
            InitializeComponent();
            CurrentQuestion();
        }


        private void CurrentQuestion()
        {
            if (Score < 12)
            {
                Random rand = new Random();
                int randomQuestion = rand.Next(Questions.Quest.GetLength(0));
                string strQuestion;
                intQuest = randomQuestion;
                strQuestion = Questions.Quest[intQuest, 0];
                Question.Text = strQuestion;
                CurrentAnswers();
            }
            else
            {
                FinishGame();
            }
        }

        private void CurrentAnswers()
        {
            Answer1.Content = Questions.Quest[intQuest, 1];
            Answer2.Content = Questions.Quest[intQuest, 2];
            Answer3.Content = Questions.Quest[intQuest, 3];
            Answer4.Content = Questions.Quest[intQuest, 4];
        }

        private void A1(object sender, RoutedEventArgs e)
        {
            Questions.Quest[intQuest, 6] = "1";
            if (Questions.Quest[intQuest, 6] == Questions.Quest[intQuest, 5])
            {
                NextQuestion();
            }
            else
            {
                FinishGame();
            }
        }

        private void A2(object sender, RoutedEventArgs e)
        {
            Questions.Quest[intQuest, 6] = "2";
            if (Questions.Quest[intQuest, 6] == Questions.Quest[intQuest, 5])
            {
                NextQuestion();
            }
            else
            {
                FinishGame();
            }
        }

        private void A3(object sender, RoutedEventArgs e)
        {
            Questions.Quest[intQuest, 6] = "3";
            if (Questions.Quest[intQuest, 6] == Questions.Quest[intQuest, 5])
            {
                NextQuestion();
            }
            else
            {
                FinishGame();
            }
        }

        private void A4(object sender, RoutedEventArgs e)
        {
            Questions.Quest[intQuest, 6] = "4";
            if (Questions.Quest[intQuest, 6] == Questions.Quest[intQuest, 5])
            {
                NextQuestion();

            }
            else
            {
                FinishGame();
            }
        }

     

        private void Refresh(object sender, RoutedEventArgs e)
        {
            CurrentQuestion();
        }

        private void NextQuestion()
        {
           
            Score++;
            Questions.Quest[intQuest, 6] = string.Empty;
            CurrentQuestion();
            EnableButtons();
        }

        private void FinishGame()
        {
            
            EndWindow EWindow = new EndWindow();
            EWindow.Show();
            EWindow.EndGame();
            this.Close();
        }

        private void FinishEarly(object sender, RoutedEventArgs e)
        {
            EndWindow Ewindow = new EndWindow();

            Ewindow.Show();
            Ewindow.EndGameEarly();
            this.Close();
        }
        public void Answer1Remove()
        {
            Answer1.Content = "";
            Answer1.IsEnabled = false;
        }

        public void Answer2Remove()
        {
            Answer2.Content = "";
            Answer2.IsEnabled = false;
        }

        public void Answer3Remove()
        {
            Answer3.Content = "";
            Answer3.IsEnabled = false;
        }

        public void Answer4Remove()
        {
            Answer4.Content = "";
            Answer4.IsEnabled = false;
        }

    
        private void EnableButtons()
        {
            Answer1.IsEnabled = true;
            Answer2.IsEnabled = true;
            Answer3.IsEnabled = true;
            Answer4.IsEnabled = true;
        }


    }
}
