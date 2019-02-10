using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilionerzyLibrary
{
    public class kola
    {
        public string phone(int n,int fifty,int ph1,out string tekst)
        {
          
          
            int odp1 = Int32.Parse(Questions.Quest[n, 5]);
            string odp2 = "1";
            string odp3 = "2";
            string odp4 = "3";
            string odp5 = "4";


            if (ph1 <= 35)
            {
                tekst = "Jestem pewien, że jest to odpowiedź " + Questions.Quest[n, odp1];
                return tekst;
            }
            else if (ph1 >= 36 && ph1 <= 70)
            {
                tekst = ("Wydaje mi się, że jest to odpowiedź " + Questions.Quest[n, odp1]);
                return tekst;
            }
            else if (ph1 >= 71 && ph1 <= 80)
            {
                tekst = ("Wydaje mi się, że jest to odpowiedź " + Questions.Quest[n, odp1] + ", ale ręki sobie nie dam uciąć.");
                return tekst;
            }
            else if (ph1 >= 81 && ph1 <= 90)
            {
                tekst = ("Na twoim miejscu zaznaczyłbym odpowiedź " + Questions.Quest[n, odp1] + ", ale zawsze byłem słaby w takich grach.");
                return tekst;
            }
            else if (ph1 >= 91 && ph1 <= 99)
            {
                if (fifty == 0)
                {
                    if (odp2 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n, 2]);
                        return tekst;
                    }
                    else if (odp3 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest : " + Questions.Quest[n, 3]);
                        return tekst;
                    }
                    else if (odp4 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n, 4]);
                        return tekst;
                    }
                    else if (odp5 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n, 1]);
                        return tekst;
                    }
                }
                else
                {
                    if (odp2 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n,2] + Questions.Quest[n,3] + Questions.Quest[n,4]);
                        return tekst;
                    }
                    else if (odp3 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n,1] + Questions.Quest[n,3] + Questions.Quest[n,4]);
                        return tekst;
                    }
                    else if (odp4 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n,1] + Questions.Quest[n,2] + Questions.Quest[n,4]);
                        return tekst;
                    }
                    else if (odp5 == odp1.ToString())
                    {
                        tekst = ("Czytałem o tym ostatnio w internecie, jestem pewien, że poprawną odpowiedzią jest  " + Questions.Quest[n,1] + Questions.Quest[n,2] + Questions.Quest[n,3]);
                        return tekst;
                    }
                }
            }
            else if (ph1 > 99)
            {
                tekst = ("Przepraszamy, numer do ktorego probujesz sie dodzwonic nie istnieje...");
                return tekst;
            }
            return tekst =":)";
        }
    }
}
