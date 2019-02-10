# Milionerzy-WPF
**Wyższa Szkoła Ekonomii i Informatyki**
**Projekt semestralny z programowania obiektowego w C#.**

**Prosta gra na podstawie teleturnieju Milionerzy**
**Autorzy:** Olaf Szadkowski, Adrian Stachura

**Wykorzystane technologie oraz narzędzia:**

*WPF
*xaml
*C#
*Visual Studio Installer

# Wstęp

Gra Milionerzy jest prostym odwzorowaniem teleturnieju o tej samej nazwie.

# Opis działania

Warunkiem kończącym grę jest poprawne odpowiedzenie na 12 pytań, błędna odpowiedź na jedno z nich lub przedwczesne zakończenie gry za pomoć odpowiedniego przycisku. W grze jest dostępnych około 60 pytań, które losowane są na początku każdego z poziomów, nie mogą się one powtarzać podczas rozgrywki. Gracz do dyspozycji posiada 3 koła ratunkowe (każde koło może zostać użyte raz podczas rozgrywki, lecz można wykorzystać wszystkie 3 na danym poziomie):

**50/50** - odrzucane są 2 błędne odpowiedzi
**Telefon do przyjaciela** - wykonywany jest "telefon" do przyjaciela, który ma pomóc graczowi w udzieleniu poprawnej odpowiedzi w 90% przypadków wskazuje taką wskazuje w pozostałej części się myli.
**Wylosowaneie nowego pytania** - gracz losuje nowe pytanie na miejsce aktualnego

W oknie gry gracz ma dostęp do informacji o jakś sumę aktualnie gra oraz ile posiada "pieniędzy".

**Przycisk "zakończ grę"** - po wciśnięciu go gracz konczy grę z sumą wyświetlającą się w polu "Aktualnie posiadasz: XXX"

**Gwarantowane progi** - w przypadku błędnej odpowiedzi na pytanie gracz kończy grę z nagrodą gwarantowaną która przyznawana jest za poprawną odpowiedź na 2 oraz 7 pytanie kolejno jest to 1000zł oraz 40 000 zł.

# Podsumowanie

Aplikacja spełnia początkowe założenia projektu, działa ona szybko oraz stablinie.
W piwerwotnej wersji aplikacji koło "telefon do przyjaciela" nie brało pod uwagę użycia koła "50/50" co powodowało proponowanie graczowi odrzuconych odpowiedzi.
