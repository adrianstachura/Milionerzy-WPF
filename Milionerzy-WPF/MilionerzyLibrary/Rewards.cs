using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilionerzyLibrary
{
    /// <summary>
    /// Informacje o uzyskanej nagrodzie, wyswietlane na koniec gry
    /// </summary>

    public class Rewards 
    {
        
        public static string Reward0 = "Niestety, " +  User.Name + ", tym razem nic nie wygrałeś.";

        public static string Reward1 = "Gratulacje, " + User.Name + "! Wygrałeś 500zł!";

        public static string Reward2 = "Gratulacje, " + User.Name + "! Wygrałeś 1000zł!";

        public static string Reward3 = "Gratulacje, " + User.Name + "! Wygrałeś 2000zł!";

        public static string Reward4 = "Gratulacje, " + User.Name + "! Wygrałeś 5000zł!";

        public static string Reward5 = "Gratulacje, " + User.Name + "! Wygrałeś 10 000zł!";

        public static string Reward6 = "Gratulacje, " + User.Name + "! Wygrałeś 20 000zł!";

        public static string Reward7 = "Gratulacje, " + User.Name + "! Wygrałeś 40 000zł!";

        public static string Reward8 = "Gratulacje, " + User.Name + "! Wygrałeś 75 000zł!";

        public static string Reward9 = "Gratulacje, " + User.Name + "! Wygrałeś 125 000zł!";

        public static string Reward10 = "Gratulacje, " + User.Name + "! Wygrałeś 250 000zł!";

        public static string Reward11 = "Gratulacje, " + User.Name + "! Wygrałeś 500 000zł!";

        public static string Reward12 = "Gratulacje, " + User.Name + "! Wygrałeś 1 000 000zł!";

        public string showCurrent(int n,out string t)
        {
            if (n == 0)
            {
                t = "Aktualnie posiadasz: \r\n 0 pln";
                return t;
            }
            else if (n == 1)
            {
                t = "Aktualnie posiadasz: \r\n 500 pln";
                return t;
            }
            else if (n == 2)
            {
                t = "Aktualnie posiadasz: \r\n 1000 pln";
                return t;
            }
            else if (n == 3)
            {
                t = "Aktualnie posiadasz: \r\n 2000 pln";
                return t;
            }
            else if (n == 4)
            {
                t = "Aktualnie posiadasz: \r\n 5000 pln";
                return t;
            }
            else if (n == 5)
            {
                t = "Aktualnie posiadasz: \r\n 10 000 pln";
                return t;
            }
            else if (n == 6)
            {
                t = "Aktualnie posiadasz: \r\n 20 000 pln";
                return t;
            }
            else if (n == 7)
            {
                t = "Aktualnie posiadasz: \r\n 40 000 pln";
                return t;
            }
            else if (n == 8)
            {
                t = "Aktualnie posiadasz: \r\n 75 000 pln";
                return t;
            }
            else if (n == 9)
            {
                t = "Aktualnie posiadasz: \r\n 125 000 pln";
                return t;
            }
            else if (n == 10)
            {
                t = "Aktualnie posiadasz: \r\n 250 000 pln";
                return t;
            }
            else if (n == 11)
            {
                t = "Aktualnie posiadasz: \r\n 500 000 pln";
                return t;
            }
            return t = "";
        }

        public string showNext(int n, out string t)
        {
          
            if (n == 0)
            {
                t = "Aktualnie grasz o: \r\n 500 pln";
                return t;
            }
            else if (n == 1)
            {
                t = "Aktualnie grasz o: \r\n 1000 pln";
                return t;
            }
            else if (n == 2)
            {
                t = "Aktualnie grasz o: \r\n 2000 pln";
                return t;
            }
            else if (n == 3)
            {
                t = "Aktualnie grasz o: \r\n 5000 pln";
                return t;
            }
            else if (n == 4)
            {
                t = "Aktualnie grasz o: \r\n 10 000 pln";
                return t;
            }
            else if (n == 5)
            {
                t = "Aktualnie grasz o: \r\n 20 000 pln";
                return t;
            }
            else if (n == 6)
            {
                t = "Aktualnie grasz o: \r\n 40 000 pln";
                return t;
            }
            else if (n == 7)
            {
                t = "Aktualnie grasz o: \r\n 75 000 pln";
                return t;
            }
            else if (n == 8)
            {
                t = "Aktualnie grasz o: \r\n 125 000 pln";
                return t;
            }
            else if (n == 9)
            {
                t = "Aktualnie grasz o: \r\n 250 000 pln";
                return t;
            }
            else if (n == 10)
            {
                t = "Aktualnie grasz o: \r\n 500 000 pln";
                return t;
            }
            else if (n == 11)
            {
                t = "Aktualnie grasz o: \r\n 1 000 000pln";
                return t;
            }
            return t = "";
        }
    }
}
           


