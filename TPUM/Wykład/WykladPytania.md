# Wykład pytania

- [Wykład pytania](#wykład-pytania)
  - [Wykład #1 Wprowadzenie](#wykład-1-wprowadzenie)
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
  - [Wykład #2 Architektura](#wykład-2-architektura)
    - [Kontekst bezpieczeństwa (tak/nie)](#kontekst-bezpieczeństwa-taknie)
    - [Kontekst semantyczny](#kontekst-semantyczny)
    - [Komunikacja klient/serwer](#komunikacja-klientserwer)
    - [Komunikacja publisher/subscriber](#komunikacja-publishersubscriber)
  - [Wykład #3 Protokoły](#wykład-3-protokoły)
    - [WebSocket bezpołączeniowy](#websocket-bezpołączeniowy)
    - [WebSocket a komunikacja reaktywna](#websocket-a-komunikacja-reaktywna)
    - [REST](#rest)
    - [REST - komunikacja reaktywna](#rest---komunikacja-reaktywna)
    - [HTTP](#http)
    - [HTTP Sesja](#http-sesja)
  - [Wykład #4 Semantyka danych - interoperacyjność](#wykład-4-semantyka-danych---interoperacyjność)
    - [Pytanie o zrozumienie treści zadania](#pytanie-o-zrozumienie-treści-zadania)
    - [Co to jest aplikacja rozproszona #1](#co-to-jest-aplikacja-rozproszona-1)
    - [Co to jest aplikacja rozproszona #2](#co-to-jest-aplikacja-rozproszona-2)
    - [Komunikacja M2M](#komunikacja-m2m)
    - [Serializacja/deserializacja](#serializacjadeserializacja)
    - [Wykorzystanie obiektów do komunikacji](#wykorzystanie-obiektów-do-komunikacji)
    - [REST to protokół](#rest-to-protokół)
    - [REST czym jest](#rest-czym-jest)
    - [Object Oriented Internet](#object-oriented-internet)
    - [Web Service (WS\*)](#web-service-ws)
    - [Aplikacja interaktywna/reaktywna](#aplikacja-interaktywnareaktywna)
    - [Metadane](#metadane)
  - [Wykład #5 Przetwarzanie w chmurze](#wykład-5-przetwarzanie-w-chmurze)
  - [Kontekst semantyczny (tak/nie)](#kontekst-semantyczny-taknie)
  - [Uzgodnienie kontekstu semantycznego (code first)](#uzgodnienie-kontekstu-semantycznego-code-first)
  - [Uzgodnienie kontekstu semantycznego (DSL)](#uzgodnienie-kontekstu-semantycznego-dsl)
    - [Przetwarzanie w chmurze (tak/nie)](#przetwarzanie-w-chmurze-taknie)
  - [Wykład #6 Bezpieczeństwo komunikacji](#wykład-6-bezpieczeństwo-komunikacji)
    - [Niewyrzekanie się](#niewyrzekanie-się)
    - [Szyfrowanie danych](#szyfrowanie-danych)
    - [Integralność danych](#integralność-danych)
    - [Składowe bezpieczeństwa](#składowe-bezpieczeństwa)
    - [Składanie bezpieczeństwa p2p](#składanie-bezpieczeństwa-p2p)
    - [Szyfrowanie symetryczne](#szyfrowanie-symetryczne)
    - [Podpis cyfrowy - klucz publiczny](#podpis-cyfrowy---klucz-publiczny)
    - [Podpis cyfrowy - definicja](#podpis-cyfrowy---definicja)
    - [Funkcja skrótu - kolizja](#funkcja-skrótu---kolizja)
    - [Funkcja skrótu - wartość](#funkcja-skrótu---wartość)
    - [Klucz sesji - procedura](#klucz-sesji---procedura)

## Wykład \#1 Wprowadzenie

### Dane składnia vs semantyka (tak/nie)

Dana to znakowa reprezentacja informacji. Aby ta reprezentacja była wzajemnie jednoznaczna musimy zdefiniować: alfabet, czyli zbiór dopuszczalnych znaków, (b) składnię, czyli zbiór reguł określających znaczenie poprawnych ciągów znaków, (c) semantykę, czyli zbiór reguł określających, jak budować poprawne ciągi znaków.

- fałsz

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

- określony zbiór typów odwołujących się wyłącznie do warstwy poniżej
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

### WebSocket bezpołączeniowy

Czy WebSocket to protokół komunikacyjny, który nie tworzy sesji?

### WebSocket a komunikacja reaktywna

Protokół WebSocket umożliwia reaktywną komunikację inicjowaną przez serwer.

### REST

REST to protokół komunikacyjny bezpołączeniowy.

### REST - komunikacja reaktywna

Komunikacja klient/serwer z wykorzystaniem REST to typowy przykład komunikacji interaktywnej synchronicznej.

### HTTP

HTTP to protokół komunikacyjny bezpołączeniowy

### HTTP Sesja

Protokół HTTP jest bezpołączeniowy i w związku z tym jego zastosowanie uniemożliwia utworzenie sesji

## Wykład \#4 Semantyka danych - interoperacyjność

### Pytanie o zrozumienie treści zadania

W treści zadania projektowego `projekt aplikacja mobilna` jest wymaganie:

```TXT
Opracować model danych z wykorzystaniem standardu OPC Unified Architecture i harmonizować używany model obiektowy z modelem wygenerowanym automatycznie przez wybrane narzędzie
```

Wybierz co oznaczają poszczególne frazy:

- Używany model obiektowy
  - zbiór typów reprezentujących używane dane
  - zbiór obiektów utworzonych przez instancję programu
  - kontekst przetwarzania danych
- Opracować model danych
  - zdefiniować ekwiwalentne typy
  - zdefiniować ekwiwalentny kontekst
- harmonizować używany model obiektowy z modelem wygenerowanym automatycznie
  - porównać wygenerowane definicje w C# z własnym kodem i umieć wyjaśnić różnice

### Co to jest aplikacja rozproszona #1

Aplikacja rozproszona to zbiór procesów wspólnie realizujących wybrane zadania, aby zrealizować wspólny cel.

### Co to jest aplikacja rozproszona #2

Aplikacja rozproszona to zbiór procesów komunikujących się wyłącznie poprzez sieć komputerową, które wspólnie realizują wybrane zadania, aby osiągnąć wspólny cel.

### Komunikacja M2M

Dla komunikacji typu maszyna - maszyna (ang. Machine to Machine communication (M2M)) cechą wyróżniającą jest

- brak interakcji z człowiekiem
- odpowiedni interfejs graficzny użytkownika

### Serializacja/deserializacja

Serializacja/deserializacja jest przydatna do budowy aplikacji rozproszonych, ale da się ją wyeliminować.

### Wykorzystanie obiektów do komunikacji

Aplikacja rozproszona wymaga wymiany danych pomiędzy poszczególnymi procesami ją tworzącymi.

### REST to protokół

REST jest protokołem komunikacyjnym.

### REST czym jest

REST - wybierz prawidłową odpowiedź

- To protokół komunikacyjny
- To technologia programowania
- To koncepcja wykorzystania protokołu HTTP do pozyskiwania danych z serwera
- To technologia bazująca na wykorzystaniu koncepcji sesji tworzonej przez klient/serwer
- To koncepcja komunikacji pozwalająca zdefiniować kontekst semantyczny dla aplikacji rozproszonych

### Object Oriented Internet

Object Oriented Internet to

- to protokół komunikacyjny
- to paradygmat tworzenia aplikacji rozproszonych

### Web Service (WS*)

Web Service (WS*) to technologia komunikacyjna znormalizowana przez konsorcjum W3C w które (dopasuj)

- XML - jest używany do zapisu danych
- WSDL - jest używany do definiowania usług zdalnych
- SOAP - jest protokołem komunikacyjnym pozwalającym na zdalne operowanie na obiektach
- UDDI - jest katalogiem pozwalającym na znajdowanie definicji usług

### Aplikacja interaktywna/reaktywna

- rozproszona aplikacja interaktywna - bazuje na współdziałaniu client/server i tworzonej przez nich sesji niezbędnej do późniejszej wymiany danych
- rozproszona aplikacja reaktywna - bazuje na współdziałaniu publisher/subscriber i wymianie danych bez potrzeby tworzenia jakichkolwiek związków pomiędzy tymi rolami
- bazuje na współdziałaniu systemów operacyjnych
- bazuje na współdziałaniu procesów z wykorzystaniem protokołu WebSocket

### Metadane

Pisząc program w C# do opisu danych używamy metadanych, którymi są typy/komentarze/dokumentacja

## Wykład \#5 Przetwarzanie w chmurze

## Kontekst semantyczny (tak/nie)

 Kontekst semantyczny to uzgodnienie pomiędzy komunikującymi się procesami alfabetu, składni i semantyki przesyłanych pomiędzy nimi danych.

## Uzgodnienie kontekstu semantycznego (code first)

Jedną z metod uzgodnienia kontekstu semantycznego jest współużytkowanie tych samych definicji typów pod warunkiem, że programy tworzące aplikację rozproszoną są napisane w tym samym języku.

## Uzgodnienie kontekstu semantycznego (DSL)

W przypadku, gdy programy tworzące aplikację rozproszoną są napisane w różnych językach programowania, kontekst semantyczny można utworzyć stosując Domain Specyfic Language do definicji typów wymienianych danych.

### Przetwarzanie w chmurze (tak/nie)

Przetwarzanie w chmurze to subskrypcja usług informatycznych.

## Wykład \#6 Bezpieczeństwo komunikacji

### Niewyrzekanie się

- ochrona danych przed modyfikacją
- ochrona danych przed niepowołanym dostępem
- zagwarantowanie niekwestionowanego autorstwa

### Szyfrowanie danych

Szyfrowanie danych polega na zastąpieniu strumienia bitów strumieniem ekwiwalentnym, w którym przestają obowiązywać pierwotne reguły składniowe. To powoduje, że, w konsekwencji do takiego strumienia nie można zastosować reguł semantycznym, a więc przypisania reprezentowanej informacji.

### Integralność danych

Zapewnienie integralności danych chroni reprezentowaną prze nie informację przed dostępem osób postronnych.

### Składowe bezpieczeństwa

Poprawa bezpieczeństwa polega na:

- zastosowaniu odpowiedniej procedury, która narzucają odpowiedni sposób prowadzenia działań
- zastosowaniu odpowiedniej technologii, która określa odpowiednie środki techniczne

### Składanie bezpieczeństwa p2p

Jeśli dane są retransmitowane przez wile węzłów sieci komputerowej, to bezpieczne połączenie pomiędzy poszczególnymi węzłami (zwane bezpieczeństwem p2p) jest wystarczające do zagwarantowania bezpieczeństwa pomiędzy ich źródłem a ostatecznym odbiorcą (zwane bezpieczeństwem end-to-end).

### Szyfrowanie symetryczne

W kryptografii symetrycznej do szyfrowania i deszyfrowania używa się identycznych kluczy, które muszą być w posiadaniu nadawcy i odbiorcy danych.

### Podpis cyfrowy - klucz publiczny

W kryptografii asymetrycznej wejście w posiadanie klucza, służącego do sprawdzania podpisu cyfrowego, przez osoby postronne należy uważać za naruszenie kontekstu bezpieczeństwa.

### Podpis cyfrowy - definicja

Podpis cyfrowy wybranego ciągu bitów to zaszyfrowana kluczem prywatnym wartość skrótu dla tego ciągu.

### Funkcja skrótu - kolizja

Funkcja skrótu generuje wartość, która powinna być różna dla różnych strumieni bitów. W przypadku, gdy generowana jest taka sam wartość mówimy o kolizji.

### Funkcja skrótu - wartość

Wartość wybranej funkcji skrótu jest ciągiem bitów o ścisłe określonej długości.

### Klucz sesji - procedura

Aby wykorzystać kryptografię asymetryczną do bezpiecznego uzgodnienia klucza sesji, partnerzy powinni:

- Zaszyfrować klucz symetryczny wybranym kluczem publicznym
- Przesłać szyfrogram do ostatecznego miejsca przeznaczenia
- Deszyfrować klucz symetryczny odpowiednim kluczem prywatnym
