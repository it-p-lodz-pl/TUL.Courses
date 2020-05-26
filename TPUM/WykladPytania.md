# 1. Wykład pytania

- [1. Wykład pytania](#1-wykład-pytania)
  - [1.1. Sprawdzian 1](#11-sprawdzian-1)
    - [1.1.1. Dane składnia vs semantyka (tak/nie)](#111-dane-składnia-vs-semantyka-taknie)
    - [1.1.2. Dana vs Informacja (dopasowanie)](#112-dana-vs-informacja-dopasowanie)
    - [1.1.3. Informatyka (dopasowanie)](#113-informatyka-dopasowanie)
    - [1.1.4. Architektura aplikacji - hierarchia zależności](#114-architektura-aplikacji---hierarchia-zależności)
    - [1.1.5. Architektura aplikacji](#115-architektura-aplikacji)
    - [1.1.7. WarstwaProgramu](#117-warstwaprogramu)
    - [1.1.8. Dane - programowanie w praktyce - rodzaje danych](#118-dane---programowanie-w-praktyce---rodzaje-danych)
    - [1.1.9. Współdziałanie asynchroniczne](#119-współdziałanie-asynchroniczne)
  - [1.2. Sprawdzian 2](#12-sprawdzian-2)

## 1.1. Sprawdzian 1

### 1.1.1. Dane składnia vs semantyka (tak/nie)

Dana to znakowa reprezentacja informacji. Aby ta reprezentacja była wzajemnie jednoznaczna musimy zdefiniować: alfabet, czyli zbiór dopuszczalnych znaków, (b) składnię, czyli zbiór reguł określających znaczenie poprawnych ciągów znaków, (c) semantykę, czyli zbiór reguł określających, jak budować poprawne ciągi znaków.

- fałśz

### 1.1.2. Dana vs Informacja (dopasowanie)

Informatyka to dziedzina zajmująca się automatyzacją procesów przetwarzania [termin 1]. Aby opisać proces przetwarzania [termin 1], niezbędny jest [termin 2], który określa sekwencję operacji, jakie maja być wykonane w celu przetworzenia zbioru [termin 1] wejściowej w zbiór [termin 1] wynikowej. Problem w tym, że [termin 1] i [termin 2]są abstrakcyjne – to rodzaj wiedzy o tym, co i jak przetwarzać. W konsekwencji nie mogą być bezpośrednio wykorzystane przez współczesne materialne maszyny zbudowane wokół znanych praw fizycznych. Aby je zmaterializować wykorzystuje się [termin 4] do reprezentowania [termin 1] i [termin 2]. [termin 4] pozwala na formalne opisanie [termin 1] i [termin 2] w postaci programu. Podstawą materializacji jest alfabet, który jest ciągiem znaków alfanumerycznych reprezentowanych w środowisku współczesnej maszyny przetwarzającej, jako skończony ciąg bitów. Po kompilacji program może być uruchomiony z wykorzystaniem wybranego środowiska wykonawczego, co oznacza utworzenie [termin 5]. [termin 5] to zbiór wątków, z których każdy odpowiada za realizację sekwencji instrukcji opisanych w programie i [termin3], które tworzone są w trakcie realizacji wątku. Warunkiem utworzenia [termin 5] jest nadanie mu [termin 6], która dziedziczona jest po sesji, jeśli program uruchamiany jest przez użytkownika w ramach istniejącej sesji lub skonfigurowana, jeśli program (usługa) uruchomiany jest przez system operacyjny lub w imieniu innego użytkownika. [termin 6] [termin 5] jest wykorzystywana do autoryzacji operacji, których wykonania [termin 5] może żądać od otoczenia, przykładowo systemu operacyjnego. Brak możliwości wykonania takiej operacji powoje wystąpienie wyjątku, który musi być obsłużony, bo inaczej powoduje przerwanie działania wątku, co w konsekwencji może spowodować przerwanie zakończenie [termin 5].

1. informacja
2. algorytm
3. dane
4. język programowania
5. proces
6. tożsamość
7. dokument
8. plik
9. wiedza
10. uprawnienie
11. podpis cyfrowy
12. skrypt
13. zadanie
14. oczekiwane działanie
15. tekst

### 1.1.3. Informatyka (dopasowanie)

Informatyka to dziedzina zajmująca się automatyzacją procesów przetwarzania [[1]]. Aby opisać proces przetwarzania [[1]], niezbędny jest [[2]], który określa sekwencję operacji, jakie mają być wykonane w celu przetworzenia zbioru [[1]] wejściowej w zbiór [[1]] wynikowej. Problem w tym, że [[1]] i [[2]] są abstrakcyjne – to rodzaj wiedzy o tym, co i jak przetwarzać. W konsekwencji nie mogą być bezpośrednio wykorzystane przez współczesne materialne maszyny zbudowane z wykorzystaniem praw i zjawisk znanych w fizyce. Aby je zmaterializować (zaimplementować) wykorzystuje się [[4]] do reprezentowania [[1]] i [[2]]. [[4]] pozwala na formalne opisanie [[1]] i [[2]] w postaci programu. Podstawą materializacji jest alfabet, który jest ciągiem znaków alfanumerycznych reprezentowanych w środowisku współczesnej maszyny przetwarzającej, jako skończony ciąg bitów. Po kompilacji program może być uruchomiony z wykorzystaniem wybranego środowiska wykonawczego, co oznacza utworzenie [[5]]. [[5]] to zbiór wątków, z których każdy odpowiada za realizację sekwencji instrukcji opisanych w programie z wykorzystaniem [[3]], które tworzone są w trakcie realizacji wątku. Warunkiem utworzenia [[5]] jest nadanie mu [[6]], która dziedziczona jest po sesji, jeśli program uruchamiany jest przez użytkownika w ramach istniejącej sesji lub skonfigurowana, jeśli program (usługa) uruchomiany jest przez system operacyjny lub w imieniu innego użytkownika. [[6]] [[5]] jest wykorzystywana do autoryzacji operacji, których wykonania [[5]] może żądać od otoczenia, przykładowo systemu operacyjnego. Autoryzacja to operacja sprawdzenia, czy [[7]] ma [[10]] do wykonania żądanej operacji.

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

### 1.1.4. Architektura aplikacji - hierarchia zależności

[[1]] jest rodzajem abstrakcji pozwalającym na projektowanie [[3]] programu reprezentującej hierarchię zależności elementów składowych programu należących do [[1]]. W tej [[3]] [[1]] łączą relacje zależności w taki sposób, że każda [[1]] z wyjątkiem najniższej jest zależna wyłącznie od [[1]] niższych. [[1]] najniższa nie jest uzależniona od istnienia żadnej innej [[1]]. Analogicznie od [[1]] najwyższej nie jest uzależniona żadna inna [[1]].

Zależność w kontekście programu oznacza wykorzystanie [[5]] eksponowanych przez inną [[1]]. Wszystkie [[5]] eksponowane przez [[1]] tworzą [[8]] [[1]]. 

1. Warstwa
2. Klasa
3. Architektura
4. Struktura
5. Definicja
6. Implementacja
7. Deklaracja
8. API

### 1.1.5. Architektura aplikacji

W celu ułatwienia pracy zespołowej i testowania zwykle w architektura aplikacji wyróżnia się możliwie niezależne warstwy o dedykowanych funkcjach zależnych od wybranego modelu. W trakcie zajęć odwoływaliśmy się do modeli:

- Prezentacja, logika, dane
- Widok, model widoku i model (MVVM)

Jakie koncepcje, konstrukcje językowe i technologie można wykorzystać w realizacji takiego podejścia:

| Odpowiedź                                                                                                                                                                    | Ocena | Komentarz                                                                                                                                                                                                        |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Abstrakcja (Interfejs, klasa abstrakcyjna), która pozwala ukryć nieistotne szczegóły                                                                                         | 33.3  | To jest dobra odpowiedz, faktycznie abstrakcja ułatwia zastosowanie architektury warstwowej                                                                                                                      |
| Technologii LINQ (Language Integrated Query), która pozwala na standaryzację dostępu do danych z interfejsu warstwy.                                                         | -33.3 | To niepoprawna odpowiedź – LINQ umożliwia tworzenie wyrażeń, które mają na celu wybór podzbioru elementów ze zbioru źródłowego.  Za funkcjonalność odpowiedzialne są metody i właściwości w klasach.             |
| Żadne specjalistyczne koncepcje, konstrukcje i technologie nie są niezbędne, aby zastosować w praktyce wybraną architekturę warstwową.                                       | 33.3  | To jest również poprawna odpowiedź, jednak w praktyce trzeba jakoś istnienie warstw zasygnalizować, np. klasy częściowe, przestrzenie nazw, klasy, itp.                                                          |
| Kompilacja rozłączna, która pozwala tworzyć osobne niezależnie opracowywane i testowane komponenty.                                                                          | 33.3  | To oczywiście poprawna odpowiedź, kompilacja rozłączna jest podstawowym narzędziem do implementacji warstw i zapewnienia niezależności warstwy od jej użytkownika.)                                              |
| Refleksja, która umożliwia dostęp do metadanych programu (warstwy) i używanie warstwy bez bezpośredniego dostępu do definicji oferowanej funkcjonalności na jej granicy.</p> | -33.3 | O ile refleksja może się przydać w niektórych szczególnych przypadkach do implementacji warstw, to nie jest to technologia bazowa dla tej koncepcji. W związku z tym odpowiedzi tej nie można uznać za poprawną. |
| Polimorfizm, który pozwala warstwie użytkownika zaimplementować wybraną funkcjonalność na kilka różnych sposobów.                                                            | -33.3 | Jest to zła odpowiedź, Polimorfizm, jak zaznaczono w odpowiedzi, wpływa na realizację funkcjonalności, a nie na to, co jest oferowane w zakresie funkcjonalności.                                                |

### 1.1.7. WarstwaProgramu

Warstwa programu to:

- określony zbiór typów odwołujących się wyłącznie do innej warstwy
- nazwany zbiór typów
- określony zbiór funkcji
- określony zbiór obiektów

### 1.1.8. Dane - programowanie w praktyce - rodzaje danych

Dane [[1]] to takie, w których nie możemy wyróżnić części składowych. W konsekwencji praktycznie wszystkie [[2]] na danych prostych dotyczą ich [[3]] jako pewnej całości. Natomiast, w danych [[4]] możemy wyróżnić ich składowe. Wyróżnienie to jest realizowane przez operację [[5]], która dla danych złożonych musi być zdefiniowana. Przykładami danych złożonych jest [[6]], [[7]], itp. Struktura relacji, więc wzajemne powiązanie elementów jest narzucone i nie może być swobodnie zmieniane. Natomiast, dane [[8]] charakteryzują się tym, że relacje pomiędzy elementami mogą być swobodnie implementowane. W konsekwencji w miejsce operacji selektora mamy operację [[9]] wykorzystującą referencje pomiędzy obiektami.

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

### 1.1.9. Współdziałanie asynchroniczne

Dopasuj terminy do odpowidnich opisów. Nie wszystkie terminy mają opi i mogą być wykorzystane w dopasowaniu. 

- Programowanie asynchroniczne
  - Wykonywanie operacji jako efekt zdarzeń niedeterministycznych
  - Brak współdzielonych zasobów
- Programowanie współbieżne
  - Wykonywanie operacji jako efekt zdarzeń niedeterministycznych
  - Współdzielone zasoby
- Programowanie równoległe
  - Jednoczesne wykonywanie operacji programu
- Programowanie czasu rzeczywistego
  - Konieczność uwzględnienia czasu jako czynnika determinującego poprawność programu
- Programowanie sekwencyjne
- Programowanie dynamiczne
- Programowanie obiektowe
- Programowanie funkcyjne

## 1.2. Sprawdzian 2
