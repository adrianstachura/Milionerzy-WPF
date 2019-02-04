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
        List<int> mylist = new List<int>();






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
                int randomQuestion = 0;
                do {
                    randomQuestion = rand.Next(Questions.Quest.GetLength(0));
                }while(mylist.Contains(randomQuestion));
               
                string strQuestion;
                intQuest = randomQuestion;
                strQuestion = Questions.Quest[intQuest, 0];
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
            EnableAnswers();
            Score++;
            Questions.Quest[intQuest, 6] = string.Empty;
            CurrentQuestion();
        }

        private void FinishGame()
        {
       
            EndWindow EWindow = new EndWindow();
            EWindow.Show();
            EWindow.EndGame();
            this.Close();

        }

        private void button_EndEarly(object sender, RoutedEventArgs e)
        {
            EndWindow Ewindow = new EndWindow();

            Ewindow.Show();
            Ewindow.EndGameEarly();
            this.Close();
        }
        private void currentReward()
        {
            switch (Score)
            {
                case 0: creward.Text= "Aktualnie posiadasz: \r\n 0 pln";
                    break;
                case 1:
                    creward.Text = "Aktualnie posiadasz: \r\n 500 pln";
                    break;
                case 2:
                    creward.Text = "Aktualnie posiadasz: \r\n 1000 pln";
                    break;
                case 3:
                    creward.Text = "Aktualnie posiadasz: \r\n 2000 pln";
                    break;
                case 4:
                    creward.Text = "Aktualnie posiadasz: \r\n 5000 pln";
                    break;
                case 5:
                    creward.Text = "Aktualnie posiadasz: \r\n 10 000 pln";
                    break;
                case 6:
                    creward.Text = "Aktualnie posiadasz: \r\n 20 000 pln";
                    break;
                case 7:
                    creward.Text = "Aktualnie posiadasz: \r\n 40 000 pln";
                    break;
                case 8:
                    creward.Text = "Aktualnie posiadasz: \r\n 75 000 pln";
                    break;
                case 9:
                    creward.Text = "Aktualnie posiadasz: \r\n 125 000 pln";
                    break;
                case 10:
                    creward.Text = "Aktualnie posiadasz: \r\n 250 000 pln";
                    break;
                case 11:
                    creward.Text = "Aktualnie posiadasz: \r\n 500 000 pln";
                    break;
            }
        }

        private void nextReward()
        {
            switch (Score)
            {

                case 0:
                    nreward.Text = "Aktualnie grasza o: \r\n 500 pln";
                    break;
                case 1:
                    nreward.Text = "Aktualnie grasza o: \r\n 1000 pln";
                    break;
                case 2:
                    nreward.Text = "Aktualnie grasza o: \r\n 2000 pln";
                    break;
                case 3:
                    nreward.Text = "Aktualnie grasza o: \r\n 5000 pln";
                    break;
                case 4:
                    nreward.Text = "Aktualnie grasza o: \r\n 10 000 pln";
                    break;
                case 5:
                    nreward.Text = "Aktualnie grasza o: \r\n 20 000 pln";
                    break;
                case 6:
                    nreward.Text = "Aktualnie grasza o: \r\n 40 000 pln";
                    break;
                case 7:
                    nreward.Text = "Aktualnie grasza o: \r\n 75 000 pln";
                    break;
                case 8:
                    nreward.Text = "Aktualnie grasza o: \r\n 125 000 pln";
                    break;
                case 9:
                    nreward.Text = "Aktualnie grasza o: \r\n 250 000 pln";
                    break;
                case 10:
                    nreward.Text = "Aktualnie grasz o: \r\n 500 000 pln";
                    break;
                case 11:
                    nreward.Text = "Aktualnie grasz o: \r\n 1 000 000 pln";
                    break;
            }
        }

        private void phone(object sender, RoutedEventArgs e)
        {
            // PH.IsEnabled = false;
            Random ph = new Random();
            int ph1 = ph.Next(1, 101);
            int odp1 = Int32.Parse(Questions.Quest[intQuest, 5]);
            string odp2 = "1";
            string odp3 = "2";
            string odp4 = "3";
            string odp5 = "4";


            if (ph1 <= 35)
            {
                MessageBox.Show("Jestem pewien ze jest to odpowiedz " + Questions.Quest[intQuest, odp1]);
            }
            else if(ph1 >= 36 && ph1 <= 70)
            {
                MessageBox.Show("Wydaje mi sie ze jest to odpowiedz " + Questions.Quest[intQuest, odp1]);
            }
            else if(ph1 >= 71 && ph1 <=80)
            {
                MessageBox.Show("Wydaje mi sie, ze jest to odpowiedz " + Questions.Quest[intQuest, odp1] + ", ale reki sobie nie dam uciac.");
            }
            else if(ph1 >= 81 && ph1 <= 90)
            {
                MessageBox.Show("Na twoim miejscu zaznaczylbym odpowiedz " + Questions.Quest[intQuest, odp1] + ", ale zawsze bylem slaby w takich grach.");
            }
            else if(ph1 >= 91 && ph1 <= 99)
            {
                if (odp2 == odp1.ToString())
                {
                    MessageBox.Show("Slyszalem ostatnio o tym w telewizji, to jest odpowiedz " + Questions.Quest[intQuest, 2]);
                }
                else if(odp3 == odp1.ToString())
                {
                    MessageBox.Show("Slyszalem ostatnio o tym w telewizji, to jest odpowiedz: " + Questions.Quest[intQuest, 3]);
                }
                else if (odp4 == odp1.ToString())
                {
                    MessageBox.Show("Slyszalem ostatnio o tym w telewizji, to jest odpowiedz " + Questions.Quest[intQuest, 4]);
                }
                else if (odp5 == odp1.ToString())
                {
                    MessageBox.Show("Slyszalem ostatnio o tym w telewizji, to jest odpowiedz " + Questions.Quest[intQuest, 1]);
                }
            }
            else if(ph1 > 99)
            {
                MessageBox.Show("Przepraszamy, numer do ktorego probujesz sie dodzwonic nie istnieje...");
            }
        }
        private void fiftyfifty(object sender, RoutedEventArgs e)
        {
            FT.IsEnabled = false;
            int an = 0;
            int a1 = 0;
            int a2 = 0;
            Random wrong = new Random();
            switch (Questions.Quest[intQuest, 5])
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

        private void removeA1()
        {
            Answer1.Content = "";
            Answer1.IsEnabled = false;
        }
        private void removeA2()
        {
            Answer2.Content = "";
            Answer2.IsEnabled = false;
        }
        private void removeA3()
        {
            Answer3.Content = "";
            Answer3.IsEnabled = false;

        }
        private void removeA4()
        {
            Answer4.Content = "";
            Answer4.IsEnabled = false;
        }

        private void EnableAnswers()
        {
            Answer1.IsEnabled = true;
            Answer2.IsEnabled = true;
            Answer3.IsEnabled = true;
            Answer4.IsEnabled = true;
        }
        private void reroll(object sender, RoutedEventArgs e)
        {
           // RQ.IsEnabled = false;
            CurrentQuestion();
        }
    }

}
