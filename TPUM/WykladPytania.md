# Wykład pytania

- [Wykład pytania](#wykład-pytania)
  - [Wykład \#1 Wprowadzenie](#wykład-1-wprowadzenie)
    - [Dane składnia vs semantyka (tak/nie)](#dane-składnia-vs-semantyka-taknie)
    - [Informatyka](#informatyka)
    - [Warstwowa architektura aplikacji (wybór brakujących słów)](#warstwowa-architektura-aplikacji-wybór-brakujących-słów)
    - [Architektura aplikacji](#architektura-aplikacji)
    - [Warstwa Programu (wielokrotny wybór)](#warstwa-programu-wielokrotny-wybór)
    - [Rodzaje danych (brakujące słowa)](#rodzaje-danych-brakujące-słowa)
    - [Współdziałanie (dopasowanie)](#współdziałanie-dopasowanie)
    - [Dane mobilne (tak/nie)](#dane-mobilne-taknie)
    - [Urządzenia mobilne (tak/nie)](#urządzenia-mobilne-taknie)
    - [Eksploatacja urządzeń komputerowych w trudnych warunkach otoczenia](#eksploatacja-urządzeń-komputerowych-w-trudnych-warunkach-otoczenia)
    - [Service Oriented Architecture (SOA) (tak/nie)](#service-oriented-architecture-soa-taknie)
    - [Wykorzystanie GPS (tak/nie)](#wykorzystanie-gps-taknie)
    - [Aplikacja rozproszona](#aplikacja-rozproszona)
    - [M2M Communication](#m2m-communication)
  - [Wykład \#2 Architektura](#wykład-2-architektura)
    - [Kontekst bezpieczeństwa (tak/nie)](#kontekst-bezpieczeństwa-taknie)
    - [Kontekst semantyczny](#kontekst-semantyczny)
    - [Komunikacja klient/serwer](#komunikacja-klientserwer)
    - [Komunikacja publisher/subscriber](#komunikacja-publishersubscriber)
  - [Wykład \#3 Protokoły](#wykład-3-protokoły)
    - [WebSocket](#websocket)
    - [WebSocket a komunikacja reaktywna](#websocket-a-komunikacja-reaktywna)
    - [REST](#rest)
    - [REST - komunikacja reaktywna](#rest---komunikacja-reaktywna)
    - [HTTP](#http)
    - [HTTP Sesja](#http-sesja)
  - [Wykład \#4 Semantyka danych - interoperacyjność](#wykład-4-semantyka-danych---interoperacyjność)
  - [Wykład \#5 Przetwarzanie w chmurze](#wykład-5-przetwarzanie-w-chmurze)
  - [Wykład \#6 Bezpieczeństwo komunikacji](#wykład-6-bezpieczeństwo-komunikacji)
  - [Błędy w teście Sprawdzian #1](#błędy-w-teście-sprawdzian-1)

## Wykład \#1 Wprowadzenie

### Dane składnia vs semantyka (tak/nie)

Dana to znakowa reprezentacja informacji. Aby ta reprezentacja była wzajemnie jednoznaczna musimy zdefiniować: alfabet, czyli zbiór dopuszczalnych znaków, (b) składnię, czyli zbiór reguł określających znaczenie poprawnych ciągów znaków, (c) semantykę, czyli zbiór reguł określających, jak budować poprawne ciągi znaków.

- fałśz

### Informatyka

Informatyka to dziedzina zajmująca się automatyzacją procesów przetwarzania [[1]]. Aby opisać proces przetwarzania [[1]], niezbędny jest [[2]], który określa sekwencję operacji, jakie mają być wykonane w celu przetworzenia zbioru [[1]] wejściowej w zbiór [[1]] wynikowej. Problem w tym, że oba są pojęciami abstrakcyjnymi – to rodzaj wiedzy o tym, co i jak przetwarzać. W konsekwencji nie mogą być bezpośrednio wykorzystane przez współczesne materialne maszyny zbudowane z wykorzystaniem praw i zjawisk znanych w fizyce. Aby je zmaterializować (zaimplementować) wykorzystuje się [[4]] do ich reprezentowania. [[4]] pozwala na formalne opisanie informacji i algorytmu w postaci programu. Podstawą materializacji jest alfabet, który jest ciągiem znaków alfanumerycznych reprezentowanych w środowisku współczesnej maszyny przetwarzającej, jako skończony ciąg bitów. Po kompilacji program może być uruchomiony z wykorzystaniem wybranego środowiska wykonawczego, co oznacza utworzenie [[5]]. [[5]] to zbiór wątków, z których każdy odpowiada za realizację sekwencji instrukcji opisanych w programie z wykorzystaniem [[3]], które tworzone są w trakcie realizacji wątku. Warunkiem utworzenia [[5]] jest nadanie mu [[6]]  dziedziczon(ej)/(ego) po sesji, jeśli program uruchamiany jest przez użytkownika w ramach istniejącej sesji lub skonfigurowan(a)/(ny), jeśli program (usługa) uruchomiany jest przez system operacyjny lub w imieniu innego użytkownika. [[6]] [[5]] jest wykorzystywana do autoryzacji operacji, których wykonania [[5]] może żądać od otoczenia, przykładowo systemu operacyjnego. Autoryzacja to operacja sprawdzenia, czy [[7]] ma [[10]] do wykonania żądanej operacji.

1. Informacja
2. Algorytm
3. Dane
4. Język programowania
5. Proces
6. Tożsamość
7. Dokument
8. Plik
9. Wiedza
10. Uprawnienia
11. Podpis cyfrowy
12. Skrypt
13. Zadanie
14. Oczekiwane działanie
15. Nazwa
16. Tekst

### Warstwowa architektura aplikacji (wybór brakujących słów)

[[1]] jest rodzajem abstrakcji pozwalającym na projektowanie [[3]] programu reprezentującej hierarchię zależności elementów składowych programu należących do [[1]]. W tej [[3]] [[1]] łączą relacje zależności w taki sposób, że każda [[1]] z wyjątkiem najniższej jest zależna wyłącznie od [[1]] niższych. [[1]] najniższa nie jest uzależniona od istnienia żadnej innej [[1]]. Analogicznie od [[1]] najwyższej nie jest uzależniona żadna inna [[1]]. Zależność w kontekście programu oznacza wykorzystanie [[5]] eksponowanych przez inną [[1]]. Wszystkie [[5]] eksponowane przez [[1]] tworzą [[8]] dla [[1]]. [[7]] [[8]] [[10]] być abstrakcyjne by ukryć szczegóły implementacyjne [[1]].

1. Warstwa
2. Klasa
3. Architektura
4. Struktura
5. Definicja
6. Implementacja
7. Deklaracja
8. API
9. mogą
10. powinny

### Architektura aplikacji

W celu ułatwienia pracy zespołowej i testowania zwykle w architektura programu wyróżnia się możliwie niezależne warstwy o dedykowanych funkcjach zależnych od wybranego modelu. W trakcie zajęć odwoływaliśmy się do modeli:

- Prezentacja, logika, dane
- Widok, model widoku i model (MVVM)

Jakie koncepcje, konstrukcje językowe i technologie można wykorzystać w realizacji takiego podejścia:

| Odpowiedź                                                                                                                                                                | Ocena | Komentarz                                                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Abstrakcja (Interfejs, klasa abstrakcyjna), która pozwala ukryć nieistotne szczegóły warstwy                                                                             | 33.3  | To jest dobra odpowiedz, faktycznie abstrakcja ułatwia zastosowanie architektury warstwowej                                                                                                                      |
| Kompilacja rozłączna, która pozwala tworzyć osobne niezależnie opracowywane i testowane komponenty.                                                                      | 33.3  | To oczywiście poprawna odpowiedź, kompilacja rozłączna jest podstawowym narzędziem do implementacji warstw i zapewnienia niezależności warstwy od jej użytkownika.)                                              |
| Refleksja, która umożliwia dostęp do metadanych programu (warstwy) i używanie warstwy bez bezpośredniego dostępu do definicji oferowanej funkcjonalności na jej granicy. | -33.3 | O ile refleksja może się przydać w niektórych szczególnych przypadkach do implementacji warstw, to nie jest to technologia bazowa dla tej koncepcji. W związku z tym odpowiedzi tej nie można uznać za poprawną. |
| Polimorfizm, który pozwala zaimplementować wybraną funkcjonalność na kilka różnych sposobów w  warstwie.                                                                 | -33.3 | Jest to zła odpowiedź. Polimorfizm, jak zaznaczono w odpowiedzi, wpływa na realizację funkcjonalności, a nie na to, co jest oferowane w zakresie funkcjonalności.                                                |
| Zbiory typów, które możemy grupować w przestrzenie nazw i ograniczać ich uzależnienie od typów znajdujących się w warstwie poniżej.                                      | 33.3  | To poprawna odpowiedź.                                                                                                                                                                                           |

### Warstwa Programu (wielokrotny wybór)

Wybierz **poprawne i kompletne** sformułowania dotyczące tworzenia aplikacji warstwowej. Warstwa w programie to:

- określony zbiór typów odwołujących się wyłącznie do innej warstwy
- określony zbiór typów odwołujących się do kilku warstw
- zbiór typów nazwany z wykorzystaniem przestrzeni nazw
- określony zbiór funkcji
- określony zbiór obiektów

### Rodzaje danych (brakujące słowa)

Dane [[1]] to takie, w których nie możemy wyróżnić części składowych. W konsekwencji praktycznie wszystkie [[2]] na danych prostych dotyczą ich [[3]] jako pewnej całości. Natomiast, w danych [[4]] możemy wyróżnić ich składowe. Wyróżnienie to jest realizowane przez operację [[5]], która dla danych złożonych musi być zdefiniowana. Przykładami danych złożonych jest tablica, struktura, itp. Ich wewnętrzna struktura, więc wzajemne powiązanie elementów skłądowych jest narzucone i nie może być swobodnie zmieniane. Natomiast, dane [[8]] charakteryzują się tym, że relacje pomiędzy elementami mogą być swobodnie implementowane. W konsekwencji w miejsce operacji selektora mamy operację [[9]] wykorzystującą referencje pomiędzy obiektami.

1. proste
2. operacje
3. wartość
4. złożone
5. selektora
6. tablica
7. struktura
8. strukturalne
9. przeglądania (ang. browse)
10. drzewo
11. liczba zmiennopozycyjna
12. informacja
13. indeksowanie
14. graf

### Współdziałanie (dopasowanie)

Dopasuj terminy do odpowiednich opisów. Nie wszystkie terminy mają opis i mogą być wykorzystane w dopasowaniu.

- Programowanie asynchroniczne
  - Wykonywanie operacji jako efekt zdarzeń niedeterministycznych
  - Brak współdzielonych zasobów
- Programowanie współbieżne
  - Sekwencja operacji jest efektem zdarzeń niedeterministycznych
  - Współdzielone zasoby
- Programowanie równoległe
  - Jednoczesne wykonywanie różnych operacji programu
- Programowanie czasu rzeczywistego
  - Konieczność uwzględnienia czasu jako czynnika determinującego poprawność programu
- Programowanie sekwencyjne
- Programowanie dynamiczne
- Programowanie obiektowe
- Programowanie funkcyjne

### Dane mobilne (tak/nie)

Dane mobilne, to dane o charakterze zdarzenia, które pojawiają sie w nieprzedziwnych miejscach sieci komputerowej i nieprzewidzianych chwilach czasowych. Często kojarzone są z miejscem geograficznym i czasem wystąpienia przed przesłąniem ich do miejsca, gdzie mają yć dalej przetwarzane.

### Urządzenia mobilne (tak/nie)

Z punktu widzenia inżynierii programowania warunkiem wystarczającym, aby urządzenia można było nazwać mobilnym, jest to, że może swobodnie zmieniać swoje połowienie geograficzne.

### Eksploatacja urządzeń komputerowych w trudnych warunkach otoczenia

Urządzenia mobilne często są używane w trudnych warunkach środowiskowych, np. wibracje, przeciążenia, wilgotność, zadymienie, itd. W takich warunkach korzystanie z graficznego interfejsu użytkownika może być utrudnione. To typowe wyzwanie dla współczesnej inżynierii oprogramowania.

### Service Oriented Architecture (SOA) (tak/nie)

Service Oriented Architecture (SOA) - zaznacz wszystkie poprawne i wyczerpujące definicje

- paradygmat definiowania kontekstu semantycznego, pozwalającego na współdziałania programów stworzonych niezależnie
- standard komunikacyjny pozwalający zagwarantować współdziałanie programów stworzonych niezależnie
- protokół komunikacyjny w warstwie aplikacji, który pozwala zagwarantować współdziałanie programów stworzonych niezależnie
- zestaw norm zwanych WebService i oznaczanych WS*, który pozwala zagwarantować współdziałanie programów stworzonych niezależnie

### Wykorzystanie GPS (tak/nie)

- Czy wykorzystanie odbiornika GPS (ang. Global Positioning System), który służy do lokalizacji geograficznej, w urządzeniu komputerowym, czyni je urządzeniem mobilnym ?

### Aplikacja rozproszona

Jeśli program skonsolidowany (tzn. przeznaczony do realizacji jako jeden proces współczesnego systemu operacyjnego), chcemy podziwić na kilka części i wykonywać te części niezależnie, jako spójna aplikacja rozproszona, to architekturę każdego z programów składowych należy zaprojektować zgodnie z ogólnymi zasadami architektury warstwowej ponownie dokonując dystrybucji funkcjonalności do poszczególnych części aplikacji.

### M2M Communication

Komunikacja maszyn (ang. Machine to Machine (M2M)) to taka, która zapewnia, że maszyny współpracują ze sobą [bez możliwości | bez konieczności] ingerencji człowieka (użytkownika). Typowym przekładem takiej komunikacji jest [współdziałanie robotów | zdalna monitorowanie stanu zdrowia ].

## Wykład \#2 Architektura

### Kontekst bezpieczeństwa (tak/nie)

Kontekst bezpieczeństwa to wspólna definicja algorytmów bezpieczeństwa i ich parametrów.

### Kontekst semantyczny

Kontekst semantyczny to wspólne uzgodnienie [alfabetu | kodowania], [składni | protokołu komunikacyjnego  ] i [ semantyki | języka, np. XML, HTML ] obowiązujących przy wymienianie strumieni bitów.

### Komunikacja klient/serwer

Zaznacz wszystkie poprawne i wyczerpujące stwierdzenia opisujące komunikację klient/serwer

- tworzy ścisły związek pomiędzy parą programów realizowanych niezależnie
- tworzy luźny związek pomiędzy parą programów realizowanych niezależnie
- wymaga zastosowania protokołu połączeniowego to utworzenia połączenia
- tworzy sesję po połączeniu, która odpowiada za zarządzanie stanem współdziałania
- automatycznie tworzy kontekst semantyczny zapewniający współdziałanie

### Komunikacja publisher/subscriber

Zaznacz wszystkie poprawne i wyczerpujące stwierdzenia opisujące komunikację publisher/subscriber.

1. tworzy ścisły związek pomiędzy parą programów realizowanych niezależnie
2. tworzy luźny związek pomiędzy parą programów realizowanych niezależnie
3. wymaga zastosowania protokołu bezpołączeniowego do zapewnienia wymiany danych
4. subskrypcja tworzy kontekst zapewniający komunikację dwukierunkową
5. tworzy sesję po połączeniu, która odpowiada za zarządzanie stanem współdziałania
6. automatycznie tworzy kontekst semantyczny zapewniający współdziałanie
7. automatycznie tworzy kontekst bezpieczeństwa zapewniający ochronę danych przed wykorzystaniem w sposób nieupoważniany
8. subskryber nie może określić źródła pochodzenia otrzymywanych danych
9. publisher nie może swobodnie wybierać do kogo dane mają być wysłane

## Wykład \#3 Protokoły

### WebSocket

WebSocket to protokół komunikacyjny bezpołączeniowy.

### WebSocket a komunikacja reaktywna

Protokół WebSocket umożliwia reaktywną komunikację inicjowaną przez serwer.

### REST

REST to protokół komunikacyjny bezpołączeniowy

### REST - komunikacja reaktywna

Komunikacja klient/serwer z wykorzystaniem REST to typowy przykład komunikacji interaktywnej synchronicznej.

### HTTP

HTTP to protokół komunikacyjny bezpołączeniowy

### HTTP Sesja

Protokół HTTP jest bezpołączeniowy i w związku z tym jego zastosowanie uniemożliwia utworzenie sesji

## Wykład \#4 Semantyka danych - interoperacyjność

## Wykład \#5 Przetwarzanie w chmurze

## Wykład \#6 Bezpieczeństwo komunikacji

## Błędy w teście Sprawdzian #1

Wpłynęły do mnie cztery reklamacje dotyczące treści pytań w teście. Pomimo należytej staranności przy układnisiu pytań, muszę stwierdzić, że reklamacje są uzasadnione. Dotyczy to pytań:

| Tytuł                               | Pytanie                                             | Treść                         | Uwagi                                                       |
| ----------------------------------- | --------------------------------------------------- | ----------------------------- | ----------------------------------------------------------- |
| Service Oriented Architecture (SOA) | Zaznacz wszystkie poprawne i wyczerpujące definicje |                               | Nie widzicie tematu, test powinien być wielokrotnego wyboru |
| Informatyka                         | Brak                                                | Informatyka to dziedzina .... | Test powinien być innego rodzaju; uzupełnić a nie parować |

W związku z powyższym wszyscy niezadowoleni z wyniku testu mogą wystąpić do mnie o jego unieważnienie. Proszę o maila z prośbą o weryfikację wyniku. Oczywiście dotyczy to osób, dla których odpowiedzi na te pytania wpływały na wynik końcowy. Każdą prośbę będę analizował niezależnie.

Bardzo przepraszam za kłopot i niedogodności. Termin reklamacji upływa 31-05-2020.
