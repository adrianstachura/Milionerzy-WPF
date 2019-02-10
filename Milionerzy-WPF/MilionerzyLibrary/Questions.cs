using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilionerzyLibrary
{

    /// <summary>
    /// Baza pytań wykorzystywanych w grze
    /// </summary>
    public class Questions
    {
        public static string[,] Quest = { { "Carpaccio to danie kuchni:", "Włoskiej", "Polskiej", "Angielskiej", "Francuskiej", "1", String.Empty } ,
{"Jak nazywa się danie z mięsa mielonego, fasoli i chilli?", "Mielony", "Chilli con carne", "Burrito", "Pasta", "2",  String.Empty},
{"Który z wymienionych kolorów NIE widnieje na fladze Wielkiej Brytanii?", "Zielony", "Biały", "Niebieski", "Czerwony", "1",  String.Empty},
{"Stolicą jakiego kraju jest Damaszek?", "Polski", "Francji", "Afganistanu", "Syrii", "4",  String.Empty},
{"Nad jaką rzeką leży Opole", "Wisła", "Nil", "Odra", "Warta", "3",  String.Empty},
{"Włożyliśmy 100 zł do banku i dostaliśmy od razu 20 proc. odsetek. Rząd zabrał nam z całej kwoty w banku 20 proc. podatku. Zyskaliśmy, czy straciliśmy na tej operacji?", "Nie", "Tak", "Zyskaliśmy", "5", "2",  String.Empty},
{"W którym roku miał miejsce chrzest Polski?", "966", "669", "1000", "996", "4",  String.Empty},
{"Z którym krajem Polska nie graniczy od wschodu?", "Z Ukrainą", "Z Rosją", "Z Białorusią", "Z Litwą", "2",  String.Empty},
{"Kto jest autorem tych słów: 'Już tam ojciec do swej Basi mówi zapłakany – Słuchaj jeno, pono nasi biją w tarabany'?", "Adam Mickiewicz", "Henryk Dąbrowski", "Juliusz Słowacki", "Józef Wybicki", "4",  String.Empty},
{"Bohaterami której książki są Lasse, Bosse i Lisa?", "Sachem", "Dzieci z Bullerbyn", "Akademia Pana Kleksa", "Harry Potter", "2",  String.Empty},
{"Wynikiem dzielenia przez 0 jest zawsze:", "-1", "1", "0", "Nie dzieli się przez 0", "4",  String.Empty},
{"Jaka jest miara kątów przy podstawie w trójkącie równoramiennym?", "Mniejsza niż 90 stopni", "Większa niż 90 stopni", "Równa 90 stopniom", "dowolna", "1",  String.Empty},
{"Jak nazywa się uznanie cudzego dziecka za swoje?", "przysposobienie", "aborcja", "adopcja", "symbioza", "3",  String.Empty},
{"Co pływa po kanale Weneckim?", "ponton", "gondola", "galera", "żaglówka", "2",  String.Empty},
{"Jak nazywa się tradycyjny napój Anglików pity po południu?", "herbata", "kawa", "mleko", "sok", "1",  String.Empty},
{"Jak nazywa się rybi tłuszcz?", "olej", "smalec", "masło", "tran", "4",  String.Empty},
{"Kto rozśmiesza ludzi w cyrku?", "klaun", "komik", "satyryk", "pajac", "1",  String.Empty},
{"Jak nazywa się ptak w godle Polski?", "myszołów", "orzeł", "jastrzął", "sokół", "2",  String.Empty},
{"Który z napojów zawiera kofeinę?", "kawa", "inka", "herbata", "kako", "1",  String.Empty},
{"Ile dni ma lipiec?", "28", "30", "31", "29", "3",  String.Empty},
{"Który z oceanów jest największy?", "Arktyczny", "Spokojny", "Indyjski", "Atlantycki", "2",  String.Empty},
{"Jaka jest najbliższa gwiazda Ziemi?", "Syriusz", "Słońce", "Łabędzia", "Polarna", "2",  String.Empty},
{"Jak nazywa się zjawisko świetlne obserwowane tylko na biegunie?", "zorza polarna", "miraż", "tęcza", "łuna", "1",  String.Empty},
{"Jak nazywa się oficer marynarki?", "major", "komandor", "admirał", "bosman", "2",  String.Empty},
{"Jaki jest najstarszy uniwersytet w Polsce?", "Gdański", "Toruński", "Warszawski", "Jagielloński", "4",  String.Empty},
{"Jaka epoka trwała od V do XV wieku?", "barok", "średniowiecze", "romantyzm", "odrodzenie", "2",  String.Empty},
{"Jak nazywała się niewola tatarska lub turecka?", "branka", "zabór", "jasyr", "osaczenie", "2",  String.Empty},
{"Jak miał na imię założyciel firmy samochodowej Ford?", "Ronald", "George", "Herman", "Henry", "4",  String.Empty},
{"W którym wieku przed naszą erą żył Homer?", "5", "6", "7", "8", "4",  String.Empty},
{"Z iloma państwami graniczy Hiszpania?", "2", "3", "4", "5", "2",  String.Empty},
{"Z jakiego kraju pochodzą samochody marki Alfa Romeo", "Francja", "Hiszpania", "Włochy", "Luksemburg", "3",  String.Empty},
{"Z ilu graczy składa się drużyna polo?", "4", "6", "8", "10", "1",  String.Empty},
{"Do jakiej grupy zwierząt należą dziobaki?", "ssaków", "ptaków", "płazów", "gadów", "1",  String.Empty},
{"Jak nazywa się najgłębsze jezioro świata?", "Bajkał", "Czad", "Ontario", "Michigan", "1",  String.Empty},
{"Odrażający drab z Kabaretu Starszych Panów dubeltówkę weźmie, wyjdzie i...", "rach-ciach!", "buch, buch!", "z rur dwóch", "bum w brzuch", "2",  String.Empty},
{"Kto jest mistrzem tego samego oręża, w jakim specjalizowała się mitologiczna Artemida?", "Zorro", "Don Kichot", "Legolas", "Longinus Podbipięta", "3",  String.Empty},
{"Który aktor urodził się w roku opatentowania kinematografu braci Lumière?", "Rudolph Valentino", "Humphrey Bogart", "Charlie Chaplin", "Fred Astaire", "1",  String.Empty},
{"Skąd pochodzi Conan Barbarzyńca?", "z Rivii", "z Oz", "z Mordoru", "z Cimmerii", "4",  String.Empty},
{"Komiksowym 'dzieckiem' rysownika Boba Kane’a jest:", "Superman", "Batman", "Spider-Man", "Captain America", "2",  String.Empty},
{"Likier maraskino produkuje się z maraski, czyli odmiany:", "wiśni", "jabłoni", "figi", "gruszy", "1",  String.Empty},
{"Mowa w obronie poety Archiasza przeszła do historii jako jeden z najświetniejszych popisów retorycznych:", "Izokratesa", "Cycerona", "Demostenesa", "Kwintyliana", "2",  String.Empty},
{"Który utwór Juliusza Słowackiego napisany jest prozą?", "Godzina myśli", "W Szwajcarii", "Anhelli", "Arab", "3",  String.Empty},
{"Rybą nie jest:", "świnka", "rozpiór", "krasnopiórka", "kraska", "4",  String.Empty},
{"Ile liter to miejsce, w którym plecy tracą szlachetną nazwę?", "trzy", "cztery", "pięć", "sześć", "2",  String.Empty},
{"Akcja 'Chłopów' Reymonta zaczyna się jesienią. A kiedy się kończy?", "wiosną", "latem", "jesienią", "zimą", "2",  String.Empty},
{"Małgorzata Rozenek w programie 'Azja Express' przekonywała pasażerów wietnamskiego autobusu, że ona i jej narzeczony są polskimi:", "Hiltonami", "Beckhamami", "Kardashianami", "Trumpami", "2",  String.Empty},
{"Co Doda wytatuowała sobie na plecach? ", "Gitarę", "strzelbę", "koronę", "skrzydła", "4",  String.Empty},
{"Jakie elementy biżuterii stały się znakiem rozpoznawczym premier Beaty Szydło?", "diademy", "sygnety", "bransoletki", "broszki", "4",  String.Empty},
{"Z dyplomatami jakiego kraju miał spotkać się szef MSZ minister Witold Waszczykowski?", "El Chapo", "Nowego Corleone", "San Escobar", "Wysp Szakala", "3",  String.Empty},
{"Lider, którego ugrupowania powiedział: 'Jesteśmy ludzkimi panami, bo jesteśmy panami, w przeciwieństwie do niektórych'?", "PiS", "PO", "Kukiz '15", "Nowoczesnej", "1",  String.Empty},
{"Ryś polski, łabędź rostowski, saksoński bocian i wywrotek smoleński to:", "rasy gołębi", "rasy kur", "chrząszcze", "kwiaty", "1",  String.Empty},
{"Tytułowa pomidorowa z internetowej parodii piosenki Sarsy 'Naucz mnie' jest: ", "ze świeżego przecieru", "wczorajszego rosołu", "z torebki", "z baru w bramie", "2",  String.Empty},
{"Która pierwsza dama była porównywana ze względu na wizerunek do Claire Underwood - żony prezydenta USA z serialu 'House of Cards'?", "Agata Duda", "Anna Komorowska", "Maria Kaczyńska", "Danuta Wałęsa", "1",  String.Empty},
{"Pracownicy Biura Ochrony Rządu żartobliwie nazywa się", "bor-ciachami", "borsukami", "borowikami", "bormaszynami", "3",  String.Empty},
{"Co nie mówi o braku rozumu?", "zryta pacyna", "głupek", "kiełbie we łbie", "łeb jak sklep", "4",  String.Empty},
{"Do jakiego kraju należą wyspy Kuryle", "Rosji", "Szwecji", "Grecji", "Danii", "1",  String.Empty},
{"Jakie jest trzecie terytorialnie największe państwo świata (po Rosji i Kanadzie)", "USA", "Chiny", "Japonia", "Mongolia", "2",  String.Empty},
{"Przez który z tych krajów przechodzi równik?", "Kenia", "RPA", "Rosja", "Francja", "1",  String.Empty},
{"W jakim województwie położony jest Radom?", "Małopolskim", "Mazowieckim", "Podkarpackie", "Wielkopolskie", "2",  String.Empty},
{"Z którego kraju pochodziła Miss Universe i aktorka Anita Ekberg?", "Szwecji", "Norwegii", "Danii", "Holandii", "1",  String.Empty},
{"Która stacja telewizyjna emituje serial Trudne sprawy?", "TVN", "Polsat", "TVP1", "Puls", "2",  String.Empty},
{"Kto prowadził program Kłamczuch?", "H.Urbański", "A.Stachura", "O.Lubaszenko", "K.Ibisz", "4",  String.Empty},
{"Jak firma jest odpowiedzialna za karty graficzne z serii gtx", "AMD", "Nevada", "Intel", "Nvidia", "4",  String.Empty},
{"Jak ma na imię Żebrowski, polski aktor?", "Michał", "Olaf", "Adrian", "Krzysztof", "1",  String.Empty} };
    }
}




