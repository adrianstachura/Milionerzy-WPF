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
using MilionerzyLibrary;

namespace Milionerzy_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public static int QuestionNumber = 0;
        public static int Score = 0;
        public static int fifty = 0;
        List<int> mylist = new List<int>();

        public GameWindow()
        {
            InitializeComponent();
            CurrentQuestion();
        }
        //losowanie aktualnego pytania z bazy pytań
        private void CurrentQuestion()
        {   
         if (Score < 12)
            {
                Random rand = new Random();
                int randomQuestion = 0;
                // losowanie pytania przy sprawdzeniu czy już nie wystąpiło
                do {
                    randomQuestion = rand.Next(Questions.Quest.GetLength(0));
                }while(mylist.Contains(randomQuestion));
               
                string strQuestion;
                QuestionNumber = randomQuestion;
                strQuestion = Questions.Quest[QuestionNumber, 0];
                Question.Text = strQuestion;
                mylist.Add(randomQuestion);
                CurrentAnswers();
                currentReward();
                nextReward();
            }
            else
            {
                FinishGame();
            }
        }   
        
        //Przypisanie przyciskom odpowiedzi do aktualnego pytania
        private void CurrentAnswers()
        {
            Answer1.Content = Questions.Quest[QuestionNumber, 1];
            Answer2.Content = Questions.Quest[QuestionNumber, 2];
            Answer3.Content = Questions.Quest[QuestionNumber, 3];
            Answer4.Content = Questions.Quest[QuestionNumber, 4];
        }

        //fukncje A1-4 przypisuje odpowiednią wartość do pustego stringa w tablicy, a następnie porównują z poprawną odpowiedzią
        private void A1(object sender, RoutedEventArgs e)
        {
            Questions.Quest[QuestionNumber, 6] = "1";
            if (Questions.Quest[QuestionNumber, 6] == Questions.Quest[QuestionNumber, 5])
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
            Questions.Quest[QuestionNumber, 6] = "2";
            if (Questions.Quest[QuestionNumber, 6] == Questions.Quest[QuestionNumber, 5])
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
            Questions.Quest[QuestionNumber, 6] = "3";
            if (Questions.Quest[QuestionNumber, 6] == Questions.Quest[QuestionNumber, 5])
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
            Questions.Quest[QuestionNumber, 6] = "4";
            if (Questions.Quest[QuestionNumber, 6] == Questions.Quest[QuestionNumber, 5])
            {
                NextQuestion();

            }
            else
            {
                FinishGame();
            }
        }

     
        //funkcja odpowidzialna za wyświetlenie kolejnego pytania
        private void NextQuestion()
        {
            EnableAnswers();
            Score++;
            Questions.Quest[QuestionNumber, 6] = string.Empty;
            CurrentQuestion();
            fifty = 0;
        }
        //funkcja odpowiedzialna za zakończenie gry, wyświetla okno z otrzymanym wynikiem
        private void FinishGame()
        {
       
            EndWindow EWindow = new EndWindow();
            EWindow.Show();
            EWindow.EndGame();
            this.Close();

        }
        //funkcja odpowiedzialna za wyjście z gry w wybranym momenice
        private void button_EndEarly(object sender, RoutedEventArgs e)
        {
            EndWindow Ewindow = new EndWindow();

            Ewindow.Show();
            Ewindow.EndGameEarly();
            this.Close();
        }
        // wyświetlanie aktualnie posiadanie kwoty
        private void currentReward()
        {
            string t = String.Empty;
            Rewards current = new Rewards();
            current.showCurrent(Score, out t);
            creward.Text = t;
        }
           
        //wyswietlanie kwoty, którą można zdobyć po dobrej odpowiedzi
        private void nextReward()
        {
            string t = String.Empty;
            Rewards next = new Rewards();
            next.showNext(Score, out t);
            nreward.Text = t;
        }
        //"telefon" do przyjaciela, oparty na losowości
        private void phone(object sender,RoutedEventArgs e)
        {
            PH.Opacity = 0.25;
            PH.IsEnabled = false;
            Random ph = new Random();
            int ph1 = ph.Next(1, 101);
            string tekst = String.Empty;
            kola phone1 = new kola();
            phone1.phone(QuestionNumber,fifty,ph1,out tekst);
            MessageBox.Show(tekst);
        }

          
         
        
        // odrzucenie dwóch błędnych odpowiedzi(losowych)
        private void fiftyfifty(object sender, RoutedEventArgs e)
        {
            FT.IsEnabled = false;
            FT.Opacity = 0.25;
            fifty++;
            int an = 0;
            int a1 = 0;
            int a2 = 0;
            Random wrong = new Random();
            switch (Questions.Quest[QuestionNumber, 5])
            {
                case "1":
                    int[] tab1 = new int[] { 2, 3, 4 };
                    do
                    {
                        a1 = wrong.Next(0, tab1.Length);
                        do { a2 = wrong.Next(0, tab1.Length); } while (a1 == a2);


                        if (tab1[a1] == 2 || tab1[a2] == 2)
                        {
                            removeA2();
                            an++;
                        }
                        if (tab1[a1] == 3 || tab1[a2] == 3)
                        {
                            removeA3();
                            an++;
                        }
                        if (tab1[a1] == 4 || tab1[a2] == 4)
                        {
                            removeA4();
                            an++;
                        }
                    } while (an < 2);
                    break;
                case "2":
                    int[] tab2 = new int[] { 1, 3, 4 };
                    do
                    {
                        a1 = wrong.Next(0, tab2.Length);
                        do { a2 = wrong.Next(0, tab2.Length); } while (a1 == a2);


                        if (tab2[a1] == 1 || tab2[a2] == 1)
                        {
                            removeA1();
                            an++;
                        }
                        if (tab2[a1] == 3 || tab2[a2] == 3)
                        {
                            removeA3();
                            an++;
                        }
                        if (tab2[a1] == 4 || tab2[a2] == 4)
                        {
                            removeA4();
                            an++;
                        }
                    } while (an < 2);
                    break;
                case "3":
                    int[] tab3 = new int[] { 1, 2, 4 };
                    do
                    {
                        a1 = wrong.Next(0, tab3.Length);
                        do { a2 = wrong.Next(0, tab3.Length); } while (a1 == a2);


                        if (tab3[a1] == 1 || tab3[a2] == 1)
                        {
                            removeA1();
                            an++;
                        }
                        if (tab3[a1] == 2 || tab3[a2] == 2)
                        {
                            removeA2();
                            an++;
                        }
                        if (tab3[a1] == 4 || tab3[a2] == 4)
                        {
                            removeA4();
                            an++;
                        }
                    } while (an < 2);
                    break;
                case "4":
                    int[] tab4 = new int[] { 1, 2, 3 };
                    do
                    {
                        a1 = wrong.Next(0, tab4.Length);
                        do { a2 = wrong.Next(0, tab4.Length); } while (a1 == a2);


                        if (tab4[a1] == 1 || tab4[a2] == 1)
                        {
                            removeA1();
                            an++;
                        }
                        if (tab4[a1] == 2 || tab4[a2] == 2)
                        {
                            removeA2();
                            an++;
                        }
                        if (tab4[a1] == 3 || tab4[a2] == 3)
                        {
                            removeA3();
                            an++;
                        }
                    } while (an < 2);
                    break;
            }
        }
        //funkcje removeA1-4() odpowiedzialne za wyłączenie przycisków oraz usunięcie zawartości.
        private void removeA1()
        {
            Questions.Quest[QuestionNumber, 1] = String.Empty;
            Answer1.Content = "";
            Answer1.IsEnabled = false;
        }
        private void removeA2()
        {
            Questions.Quest[QuestionNumber, 2] = String.Empty;
            Answer2.Content = "";
            Answer2.IsEnabled = false;
        }
        private void removeA3()
        {
            Questions.Quest[QuestionNumber, 3] = String.Empty;
            Answer3.Content = "";
            Answer3.IsEnabled = false;

        }
        private void removeA4()
        {
            Questions.Quest[QuestionNumber, 4] = String.Empty;
            Answer4.Content = "";
            Answer4.IsEnabled = false;
        }
        //ponowne uruchomienie przycisków
        private void EnableAnswers()
        {
            Answer1.IsEnabled = true;
            Answer2.IsEnabled = true;
            Answer3.IsEnabled = true;
            Answer4.IsEnabled = true;
        }
        //wylosowanie nowego pytania
        private void reroll(object sender, RoutedEventArgs e)
        {
            RQ.IsEnabled = false;
            RQ.Opacity = 0.25;
            CurrentQuestion();
            EnableAnswers();
        }
    }

}
